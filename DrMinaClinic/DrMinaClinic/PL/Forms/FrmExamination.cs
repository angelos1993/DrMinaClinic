using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Enums;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Properties;

namespace DrMinaClinic.PL.Forms
{
    //TODO: delete all comments after finishing all the implementation
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
            DisplaySelectedExamination();
            Cursor = Cursors.Default;
        }

        private void btnNewPregnancy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //TODO: rename this method NewPregnancy() -_-
            NewPregnancy();
            Cursor = Cursors.Default;
        }

        private void btnEditPregnancy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditPregnancy();
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
            InitializeTheFormForExamination();
        }

        private void LoadPatientPregnancies()
        {
            AllPatientPregnancies = PregnancyManager.GetAllPregnanciesForPatient(Patient.Id);
        }

        private void InitializeTheFormForExamination()
        {
            if (AllPatientPregnancies.Any())
            {
                var currentPregnancy = AllPatientPregnancies.FirstOrDefault(pregnancy => pregnancy.IsCurrent);
                if (currentPregnancy == null)
                {
                    currentPregnancy = AllPatientPregnancies.OrderByDescending(pregnancy => pregnancy.Id).First();
                    currentPregnancy.IsCurrent = true;
                    PregnancyManager.UpdatePregnancy(currentPregnancy);
                }
                if (currentPregnancy.Examinations.Any())
                {
                    var currentExamination = currentPregnancy.Examinations.FirstOrDefault(
                        examination => SqlFunctions.DateDiff("DAY", DateTime.Now, examination.Date) == 0);
                    if (currentExamination != null)
                    {
                        //display the current examination (in case of the patient has an axamination today)
                        DisplayPregnancy(currentPregnancy);
                        DisplayExamination(currentExamination);
                    }
                    else
                    {
                        //create a new examination
                        //display the current pregnancy
                        //create a new examination for today
                        SetFormForAddExamination(currentPregnancy);
                    }
                }
                else
                {
                    //create a new examination
                    //display the current pregnancy
                    //create a new examination for today
                    SetFormForAddExamination(currentPregnancy);
                }
            }
            else
            {
                //new patient
                //create a new pregnancy
                SetFormForAddPregnancy();
            }
        }

        private void DisplayExamination(Examination examination)
        {
            throw new NotImplementedException();
        }

        private void DisplayPregnancy(Pregnancy pregnancy)
        {
            throw new NotImplementedException();
        }

        private void SetFormForAddExamination(Pregnancy pregnancy)
        {
            DisplayPregnancy(pregnancy);
            EnableOrDisableControls(ExaminationFormMode.AddExamination);
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
            return;
            //todo: need to be tested well
            //treePregnancies.Enabled = 
            pnlPregnancyData.Enabled = mode == ExaminationFormMode.AddPregnancy ||
                                       mode == ExaminationFormMode.EditPregnancy;
            btnNewPregnancy.Enabled = mode == ExaminationFormMode.New || mode == ExaminationFormMode.AddPregnancy ||
                                      mode == ExaminationFormMode.AddExamination;
            btnEditPregnancy.Enabled = mode == ExaminationFormMode.AddExamination;
            pnlExaminationData.Enabled = mode == ExaminationFormMode.New || mode == ExaminationFormMode.AddExamination;
            btnSaveExamination.Enabled = mode == ExaminationFormMode.AddExamination;
        }

        private void DisplaySelectedExamination()
        {
        }

        private void NewPregnancy()
        {
            if (btnNewPregnancy.Text == @"New Pregnancy")
            {
                SetFormForAddPregnancy();
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
                Pregnancy = new Pregnancy();
                LoadPregnancyFromForm();
                Pregnancy.IsCurrent = true;
                PregnancyManager.AddPregnancy(Pregnancy);
                SetFormForAddExamination(Pregnancy);
            }
        }

        private void EditPregnancy()
        {
        }

        private void SaveExamination()
        {
        }

        private void LoadPregnancyFromForm()
        {
            //TODO: consider the 'ActualDate' and when should it be set
            Pregnancy.PatientId = Patient.Id;
            Pregnancy.G = intInG.Value;
            Pregnancy.P1 = intInP1.Value;
            Pregnancy.P2 = intInP2.Value;
            Pregnancy.No = intInNo.Value;
            Pregnancy.EDD = dtEDD.Value;
            Pregnancy.LMP = dtLMP.Value;
            Pregnancy.CS = intInCS.Value;
            Pregnancy.Vag = intInVag.Value;
            //set the pregnancy details from the grid
        }

        private void LoadExaminationFromForm()
        {
            Examination.Date = DateTime.Now;
            Examination.PregnancyId = Pregnancy.Id;
            Examination.Weeks = intInWeeks.Value;
            Examination.Weight = dblInWeight.Value;
            Examination.FundalHeight = intInFundalHeight.Value;
            Examination.Oedema = swBtnOedema.Value;
            Examination.Hb = intInHb.Value;
            Examination.Fhs = intInFHS.Value;
            Examination.UterineSize = intInUlterineSize.Value;
            Examination.Engagement = int.Parse(cmbEngagement.SelectedItem.ToString());
            //Examination.UrineAlb = cmbAlb.SelectedItem;
            Examination.UrineSuger = swBtnSugar.Value;
            //TODO: check if the value is NULL
            Examination.BP = $"{intInBP1.Value} / {intInBP2.Value}";
            Examination.UltraSoundNotes = txtUltraSoungNotes.Text;
        }

        #endregion
    }
}