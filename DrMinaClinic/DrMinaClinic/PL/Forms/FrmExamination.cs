using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Enums;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.DAL.VMs;
using DrMinaClinic.Properties;
using DrMinaClinic.Utility;
using static DrMinaClinic.Utility.MessageBoxUtility;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmExamination : FrmMaster
    {
        #region Constructor

        public FrmExamination(Patient patient)
        {
            InitializeComponent();
            Patient = patient;
        }

        #endregion

        #region Properties

        private PregnancyManager _pregnancyManager;
        private PregnancyManager PregnancyManager => _pregnancyManager ?? (_pregnancyManager = new PregnancyManager());
        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager =>
            _examinationManager ?? (_examinationManager = new ExaminationManager());

        public Patient Patient { get; set; }
        private List<Pregnancy> AllPatientPregnancies { get; set; }
        private Pregnancy Pregnancy { get; set; }
        private Examination Examination { get; set; }
        private static DateTime Today => DateTime.Now.Date;
        private ExaminationFormMode Mode { get; set; }
        private PregnancyDetailManager _pregnancyDetailManager;

        private PregnancyDetailManager PregnancyDetailManager =>
            _pregnancyDetailManager ?? (_pregnancyDetailManager = new PregnancyDetailManager());

        #endregion

        #region Events

        private void FrmExamination_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void treePregnancies_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DisplaySelectedExamination(e.Node);
            Cursor = Cursors.Default;
        }

        private void intInNo_ValueChanged(object sender, EventArgs e)
        {
            intInNo.Value = Math.Max(dgvPregnancyDetails.Rows.Count, intInNo.Value);
        }

        private void btnAddEditDetails_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            if (intInNo.Value == 0)
            {
                ShowErrorMsg(Resources.EnterChildrenCountText);
                ErrorProvider.SetError(intInNo, Resources.EnterChildrenCountText);
                return;
            }
            if (Pregnancy == null)
                Pregnancy = new Pregnancy();
            new FrmPregnancyDetails(this, Pregnancy, intInNo.Value).ShowDialog();
        }

        private void btnNewPregnancy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            NewPregnancy();
            Cursor = Cursors.Default;
        }

        private void btnEditPregnancy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditPregnancy();
            Cursor = Cursors.Default;
        }

        private void btnCloseCurrentPregnancy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            CloseCurrentPregnancy();
            Cursor = Cursors.Default;
        }

        private void btnSaveExamination_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveExamination();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            lblPatientData.Text = $@"ID: {Patient.Id} - Name: {Patient.Name}";
            LoadPatientPregnancies();
            FillTree();
        }

        private void LoadPatientPregnancies()
        {
            AllPatientPregnancies = PregnancyManager.GetAllPregnanciesForPatient(Patient.Id);
            Pregnancy = GetCurrentPregnancy();
            Examination = GetCurrentExamination(Pregnancy);
        }

        private void DisplayExamination(Examination examination)
        {
            intInWeeks.Value = examination.Weeks ?? default(int);
            dblInWeight.Value = examination.Weight ?? default(double);
            intInFundalHeight.Value = examination.FundalHeight ?? default(int);
            swBtnOedema.Value = examination.Oedema ?? default(bool);
            intInHb.Value = examination.Hb ?? default(int);
            intInUlterineSize.Value = examination.UterineSize ?? default(int);
            cmbEngagement.SelectedIndex = ExaminationManager.GetEngagementValueFromText(examination.Engagement);
            cmbAlb.SelectedIndex = ExaminationManager.GetAlbValueFromText(examination.UrineAlb);
            swBtnSugar.Value = examination.UrineSuger ?? default(bool);
            var bp = examination.BP.Split(new[] {" / "}, StringSplitOptions.None);
            intInBP1.Value = int.Parse(bp[0]);
            intInBP2.Value = int.Parse(bp[1]);
            txtUltraSoungNotes.Text = examination.UltraSoundNotes;
        }

        private void DisplayPregnancy(Pregnancy pregnancy)
        {
            intInG.Value = pregnancy.G ?? default(int);
            intInP1.Value = pregnancy.P1 ?? default(int);
            intInP2.Value = pregnancy.P2 ?? default(int);
            intInNo.Value = pregnancy.No;
            dtEDD.Value = pregnancy.EDD ?? default(DateTime);
            dtLMP.Value = pregnancy.LMP ?? default(DateTime);
            intInCS.Value = pregnancy.CS ?? default(int);
            intInVag.Value = pregnancy.Vag ?? default(int);
            FillGrid(pregnancy);
        }

        private void SetFormForAddExamination(Pregnancy pregnancy)
        {
            DisplayPregnancy(pregnancy);
            EnableOrDisableControls(ExaminationFormMode.AddEditExamination);
            ToggleNewPregnancyButton(true);
        }

        private void SetFormForAddPregnancy()
        {
            EnableOrDisableControls(ExaminationFormMode.AddPregnancy);
            ToggleNewPregnancyButton(false);
        }

        private void ToggleNewPregnancyButton(bool isNew)
        {
            btnNewPregnancy.Text = isNew ? @"New Pregnancy" : @"Save Pregnancy";
            btnNewPregnancy.Image = isNew ? Resources.Add : Resources.Save;
        }

        private void ToggleEditPregnancyButton(bool isEdit)
        {
            btnEditPregnancy.Text = isEdit ? @"Edit Pregnancy" : @"Save Pregnancy";
            btnEditPregnancy.Image = isEdit ? Resources.Edit : Resources.Save;
        }

        private void EnableOrDisableControls(ExaminationFormMode mode)
        {
            Mode = mode;
            treePregnancies.Enabled = mode != ExaminationFormMode.EditPregnancy;
            pnlPregnancyData.Enabled = mode == ExaminationFormMode.AddPregnancy ||
                                       mode == ExaminationFormMode.EditPregnancy;
            btnNewPregnancy.Enabled = mode == ExaminationFormMode.AddPregnancy ||
                                      mode == ExaminationFormMode.AddEditExamination;
            btnEditPregnancy.Enabled = mode == ExaminationFormMode.AddEditExamination ||
                                       mode == ExaminationFormMode.EditPregnancy;
            btnCloseCurrentPregnancy.Enabled = mode == ExaminationFormMode.AddEditExamination;
            pnlExaminationData.Enabled = mode == ExaminationFormMode.AddEditExamination;
            btnSaveExamination.Enabled = mode == ExaminationFormMode.AddEditExamination;

            #region Buttons' Text & Image

            var isNew = mode != ExaminationFormMode.AddPregnancy;
            var isEdit = mode != ExaminationFormMode.EditPregnancy;
            ToggleNewPregnancyButton(isNew);
            ToggleEditPregnancyButton(isEdit);

            #endregion
        }

        private void DisplaySelectedExamination(TreeNode selectedNode)
        {
            if (selectedNode.Parent == null)
            {
                treePregnancies.SelectedNode = selectedNode.Nodes[0];
            }
            else
            {
                var pregnancyId = int.Parse(selectedNode.Parent.Name);
                var examinationId = int.Parse(selectedNode.Name);
                if (pregnancyId == 0 && examinationId == 0)
                {
                    ResetFormData();
                    SetFormForAddPregnancy();
                }
                else if (pregnancyId != 0 && examinationId == 0)
                {
                    ResetFormData();
                    Examination = new Examination();
                    SetFormForAddExamination(Pregnancy);
                }
                else
                {
                    if (selectedNode.Text != Today.ToCustomFormattedShortDateString() &&
                        Mode != ExaminationFormMode.AddPregnancy && Mode != ExaminationFormMode.OldExamination)
                    {
                        LoadPregnancyFromForm();
                        if (!IsExistPregnancyExaminationForToday())
                            Examination = new Examination();
                        LoadExaminationFromForm();
                    }
                    ResetFormData();
                    var selectedPregnancy =
                        AllPatientPregnancies.FirstOrDefault(pregnancy => pregnancy.Id == pregnancyId);
                    DisplayPregnancy(selectedPregnancy);
                    DisplayExamination(AllPatientPregnancies.FirstOrDefault(pregnancy => pregnancy.Id == pregnancyId)
                        ?.Examinations.FirstOrDefault(examination => examination.Id == examinationId));
                    EnableOrDisableControls(selectedPregnancy != null && selectedPregnancy.IsCurrent &&
                                            selectedNode.Text == Today.ToCustomFormattedShortDateString()
                        ? ExaminationFormMode.AddEditExamination
                        : ExaminationFormMode.OldExamination);
                }
            }
        }

        private void NewPregnancy()
        {
            if (btnNewPregnancy.Text == @"New Pregnancy")
            {
                CloseCurrentPregnancy();
            }
            else
            {
                AllPatientPregnancies.ForEach(pregnancy =>
                {
                    if (pregnancy.IsCurrent)
                    {
                        pregnancy.IsCurrent = false;
                        PregnancyManager.UpdatePregnancy(pregnancy);
                    }
                });
                if (Pregnancy == null)
                    Pregnancy = new Pregnancy();
                LoadPregnancyFromForm();
                Pregnancy.IsCurrent = true;
                PregnancyManager.AddPregnancy(Pregnancy);
                LoadPatientPregnancies();
                SetFormForAddExamination(Pregnancy);
                DisplayPregnancy(Pregnancy);
            }
        }

        private void EditPregnancy()
        {
            if (btnEditPregnancy.Text == @"Edit Pregnancy")
            {
                EnableOrDisableControls(ExaminationFormMode.EditPregnancy);
            }
            else
            {
                Pregnancy = GetCurrentPregnancy();
                LoadPregnancyFromForm();
                PregnancyManager.UpdatePregnancy(Pregnancy);
                EnableOrDisableControls(ExaminationFormMode.AddEditExamination);
            }
        }

        private void CloseCurrentPregnancy()
        {
            if (Pregnancy.Examinations.Any())
            {
                new FrmPregnancyActualBirthDate(Pregnancy).ShowDialog();
                if (Pregnancy.ActualBirthdate != null)
                    ResetForm();
            }
            else
            {
                if (ShowConfirmationDialog(Resources.DeletePregnancyConfirmationText) == DialogResult.No)
                    return;
                PregnancyManager.DeletePregnancy(Pregnancy);
                ResetForm();
            }
        }

        private void SaveExamination()
        {
            if (!IsExistPregnancyExaminationForToday() && Examination == null)
                Examination = new Examination();
            LoadExaminationFromForm();
            if (!IsExistPregnancyExaminationForToday())
                ExaminationManager.AddExamination(Examination);
            else
                ExaminationManager.UpdateExamination(Examination);
            ShowInfoMsg(Resources.ExaminationSavedSuccessfullyText);
            Hide();
            new FrmReception().ShowDialog();
        }

        private void LoadPregnancyFromForm()
        {
            Pregnancy.PatientId = Patient.Id;
            Pregnancy.G = intInG.Value;
            Pregnancy.P1 = intInP1.Value;
            Pregnancy.P2 = intInP2.Value;
            Pregnancy.No = intInNo.Value;
            Pregnancy.EDD = dtEDD.Value != default(DateTime) ? dtEDD.Value : (DateTime?) null;
            Pregnancy.LMP = dtLMP.Value;
            Pregnancy.CS = intInCS.Value;
            Pregnancy.Vag = intInVag.Value;
        }

        private void LoadExaminationFromForm()
        {
            Examination.Date = Today;
            Examination.PregnancyId = Pregnancy.Id;
            Examination.Weeks = intInWeeks.Value;
            Examination.Weight = dblInWeight.Value;
            Examination.FundalHeight = intInFundalHeight.Value;
            Examination.Oedema = swBtnOedema.Value;
            Examination.Hb = intInHb.Value;
            Examination.Fhs = intInFHS.Value;
            Examination.UterineSize = intInUlterineSize.Value;
            Examination.Engagement = cmbEngagement.SelectedIndex != 0
                ? int.Parse(cmbEngagement.SelectedItem.ToString())
                : (int?) null;
            Examination.UrineAlb = cmbEngagement.SelectedIndex != 0 ? cmbAlb.SelectedItem?.ToString() : null;
            Examination.UrineSuger = swBtnSugar.Value;
            Examination.BP = $"{intInBP1.Value} / {intInBP2.Value}";
            Examination.UltraSoundNotes = txtUltraSoungNotes.Text;
        }

        private Pregnancy GetCurrentPregnancy()
        {
            return AllPatientPregnancies.OrderByDescending(pregnancy => pregnancy.Id)
                .FirstOrDefault(pregnancy => pregnancy.IsCurrent);
        }

        private Examination GetCurrentExamination(Pregnancy pregnancy)
        {
            return pregnancy?.Examinations.AsQueryable()
                .FirstOrDefault(examination => examination.Date.Date == Today);
        }

        private void ResetExaminationData()
        {
            intInWeeks.Value = default(int);
            dblInWeight.Value = default(int);
            intInFundalHeight.Value = default(int);
            swBtnOedema.Value = default(bool);
            intInHb.Value = default(int);
            intInFHS.Value = default(int);
            intInUlterineSize.Value = default(int);
            cmbEngagement.SelectedIndex = default(int);
            cmbAlb.SelectedIndex = default(int);
            swBtnSugar.Value = default(bool);
            intInBP1.Value = default(int);
            intInBP2.Value = default(int);
            txtUltraSoungNotes.Clear();
        }

        private void ResetPregnancyData()
        {
            intInG.Value = default(int);
            intInP1.Value = default(int);
            intInP2.Value = default(int);
            intInNo.Value = default(int);
            dtEDD.Value = default(DateTime);
            dtLMP.Value = default(DateTime);
            intInCS.Value = default(int);
            intInVag.Value = default(int);
            dgvPregnancyDetails.DataSource = null;
        }

        private void ResetFormData()
        {
            ResetPregnancyData();
            ResetExaminationData();
        }

        private void FillTree()
        {
            treePregnancies.Nodes.Clear();
            AllPatientPregnancies = AllPatientPregnancies.OrderByDescending(pregnancy => pregnancy.Id).ToList();
            for (var i = 0; i < AllPatientPregnancies.Count; i++)
            {
                var pregnancyNode = new TreeNode
                {
                    Name = AllPatientPregnancies[i].Id.ToString(),
                    Text = $@"{(AllPatientPregnancies.Count - i).ToOrdinal()} Pregnancy"
                };
                AllPatientPregnancies[i].Examinations.OrderByDescending(examination => examination.Date).ToList()
                    .ForEach(examination => pregnancyNode.Nodes.Add(examination.Id.ToString(),
                        examination.Date.ToCustomFormattedShortDateString()));
                treePregnancies.Nodes.Add(pregnancyNode);
            }
            if (AllPatientPregnancies.Any() && AllPatientPregnancies.Any(pregnancy => pregnancy.IsCurrent))
            {
                var firstNode = treePregnancies.Nodes[0];
                firstNode.Text = Resources.CurrentPregnancyText;
                if (!IsExistPregnancyExaminationForToday())
                    firstNode.Nodes.Insert(0,
                        new TreeNode {Name = 0.ToString(), Text = Today.ToCustomFormattedShortDateString()});
                if (firstNode.Nodes.Count == 0)
                    firstNode.Nodes.Add(0.ToString(), Today.ToCustomFormattedShortDateString());
            }
            else
            {
                treePregnancies.Nodes.Insert(0, new TreeNode
                {
                    Name = 0.ToString(),
                    Text = Resources.CurrentPregnancyText,
                    Nodes =
                    {
                        new TreeNode {Name = 0.ToString(), Text = Today.ToCustomFormattedShortDateString()}
                    }
                });
            }
            treePregnancies.Nodes[0].Expand();
            treePregnancies.SelectedNode = treePregnancies.Nodes[0];
        }

        private bool IsExistPregnancyExaminationForToday()
        {
            var pregnancy = GetCurrentPregnancy();
            return pregnancy != null && pregnancy.Examinations.Any(examination => examination.Date.Date == Today.Date);
        }

        private void FillGrid(Pregnancy pregnancy)
        {
            dgvPregnancyDetails.DataSource = pregnancy.PregnancyDetails.Select(pregnancyDetail => new PregnancyDetailVm
            {
                Living = pregnancyDetail.Living,
                Af = pregnancyDetail.AF,
                Sex = pregnancyDetail.Sex,
                Placenta = pregnancyDetail.Placenta,
                Weight = pregnancyDetail.Weight ?? default(double),
                Presentation = pregnancyDetail.Presentation,
                Other = pregnancyDetail.Other
            }).ToList();
        }

        #region Call-Back(s)

        public void SetPregnancyDetails(List<PregnancyDetail> pregnancyDetailsList)
        {
            PregnancyDetailManager.DeletePregnancyDetailsList(Pregnancy.PregnancyDetails.ToList());
            Pregnancy.PregnancyDetails = pregnancyDetailsList;
            FillGrid(Pregnancy);
        }

        #endregion

        #endregion
    }
}