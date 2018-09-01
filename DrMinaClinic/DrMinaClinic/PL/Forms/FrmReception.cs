using System;
using System.Linq;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Enums;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Properties;
using DrMinaClinic.Utility;
using static DrMinaClinic.Utility.MessageBoxUtility;
using static DrMinaClinic.Utility.Utility;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmReception : FrmMaster
    {
        #region Constructor

        public FrmReception()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private PatientManager _patientManager;
        private PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        private Patient Patient { get; set; }

        #endregion

        #region Events

        private void FrmReception_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FindPatient();
            Cursor = Cursors.Default;
        }

        private void txtPatientIdOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindPatient();
        }

        private void cmbAboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            swBtnRhesusGroup.Enabled = cmbAboGroup.SelectedIndex != 0;
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddNewPatient();
            Cursor = Cursors.Default;
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditPatient();
            Cursor = Cursors.Default;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnNewExamination_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmExamination(Patient).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            ResetPatientData();
            EnableOrDisableControls(ReceptionFormMode.New);
            SetAutoCompletionForTextBoxes();
        }

        private void FindPatient()
        {
            ErrorProvider.Clear();
            var patientId = txtId.Text.FullTrim();
            var patientName = txtName.Text.FullTrim();
            if (patientId.IsNullOrEmptyOrWhiteSpace() && patientName.IsNullOrEmptyOrWhiteSpace())
            {
                ShowErrorMsg(Resources.RequiredPatientIdAndNameMsg);
                return;
            }
            Patient = !patientId.IsNullOrEmptyOrWhiteSpace()
                ? PatientManager.GetPatientById(patientId)
                : PatientManager.GetPatientByName(patientName);
            if (Patient != null)
            {
                DisplayPatient();
                EnableOrDisableControls(ReceptionFormMode.HasPatient);
            }
            else
            {
                ShowErrorMsg(Resources.ErrorPatientIdAndNameMsg);
            }
        }

        private void EnableOrDisableControls(ReceptionFormMode mode)
        {
            #region Patient Data

            txtId.Enabled = mode == ReceptionFormMode.New;
            txtName.Enabled = mode == ReceptionFormMode.New || mode == ReceptionFormMode.AddPatient ||
                              mode == ReceptionFormMode.Edit;
            dtBirthdate.Enabled = mode == ReceptionFormMode.AddPatient || mode == ReceptionFormMode.Edit;
            txtAddress.Enabled = mode == ReceptionFormMode.AddPatient || mode == ReceptionFormMode.Edit;
            txtPhone.Enabled = mode == ReceptionFormMode.AddPatient || mode == ReceptionFormMode.Edit;
            btnFindPatient.Enabled = mode == ReceptionFormMode.New;

            #endregion

            #region Relevant Family History

            pnlRelevantFamilyHistory.Enabled = mode == ReceptionFormMode.AddPatient || mode == ReceptionFormMode.Edit;

            #endregion

            #region First Examination

            pnlFirstExamination.Enabled = mode == ReceptionFormMode.AddPatient || mode == ReceptionFormMode.Edit;

            #endregion

            #region Investigations

            pnlInvestigations.Enabled = mode == ReceptionFormMode.AddPatient || mode == ReceptionFormMode.Edit;

            #endregion

            #region Lower Buttons

            btnNewPatient.Enabled = mode == ReceptionFormMode.New || mode == ReceptionFormMode.AddPatient;
            btnEditPatient.Enabled = mode == ReceptionFormMode.HasPatient || mode == ReceptionFormMode.Edit;
            btnNewExamination.Enabled = mode == ReceptionFormMode.HasPatient;

            #endregion
        }

        private void AddNewPatient()
        {
            ErrorProvider.Clear();
            if (btnNewPatient.Text == @"New")
            {
                ResetPatientData();
                EnableOrDisableControls(ReceptionFormMode.AddPatient);
                ToggleNewPatientButton(false);
            }
            else
            {
                if (!txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
                {
                    Patient = new Patient();
                    LoadPatientFromForm();
                    Patient.Id = PatientManager.GetNextPatientId(PatientManager.GetLastPatientId());
                    Patient.CreatedOn = DateTime.Now;
                    PatientManager.AddNewPatient(Patient);
                    DisplayPatient();
                    EnableOrDisableControls(ReceptionFormMode.HasPatient);
                    ToggleNewPatientButton(true);
                }
                else
                {
                    ErrorProvider.SetError(txtName, Resources.RequiredValidationMsg);
                }
            }
        }

        private void ResetPatientData()
        {
            #region Patient's Basic Data

            txtId.Clear();
            txtName.Clear();
            dtBirthdate.Value = default(DateTime);
            txtAddress.Clear();
            txtPhone.Clear();

            #endregion

            #region First Examination

            txtHeart.Clear();
            txtLungs.Clear();
            txtVaricoseVeins.Clear();
            txtPelvis.Clear();
            txtLowerLimbs.Clear();
            txtPV.Clear();

            #endregion

            #region Relevant Family History

            intInTwins.Value = default(int);
            swBtnDiabetes.Value = false;
            swBtnHypertension.Value = false;
            txtPastIllness.Clear();
            txtOperations.Clear();
            txtAllergies.Clear();
            txtDrugs.Clear();

            #endregion

            #region Investigations

            cmbAboGroup.SelectedIndex = default(int);
            swBtnRhesusGroup.Value = false;
            swBtnCytomegaloVirus.Value = false;
            swBtnHBSAg.Value = false;
            swBtnHBCAb.Value = false;
            intInBHCG.Value = default(int);
            intInEstriolE3.Value = default(int);
            intInFBS.Value = default(int);
            intInCBC.Value = default(int);
            intInPlatelets.Value = default(int);
            txtGeneralRemarks.Clear();

            #endregion

            #region New / Save & Edit / Save buttons

            ToggleNewPatientButton(true);
            ToggleEditPatientButton(true);

            #endregion

            #region Error Provider

            ErrorProvider.Clear();

            #endregion
        }

        private void ToggleNewPatientButton(bool isNew)
        {
            btnNewPatient.Text = isNew ? @"New" : @"Save";
            btnNewPatient.Image = isNew ? Resources.Add : Resources.Save;
        }

        private void ToggleEditPatientButton(bool isEdit)
        {
            btnEditPatient.Text = isEdit ? @"Edit" : @"Save";
            btnEditPatient.Image = isEdit ? Resources.Edit : Resources.Save;
        }

        private void DisplayPatient()
        {
            #region Patient's Basic Data

            txtId.Text = Patient.Id;
            txtName.Text = Patient.Name;
            dtBirthdate.Value = Patient.BirthDate ?? default(DateTime);
            txtAddress.Text = Patient.Address;
            txtPhone.Text = Patient.Phone;

            #endregion

            #region First Examination

            txtHeart.Text = Patient.Heart;
            txtLungs.Text = Patient.Lungs;
            txtVaricoseVeins.Text = Patient.VaricoseVenis;
            txtPelvis.Text = Patient.Pelvis;
            txtLowerLimbs.Text = Patient.LowerLimbs;
            txtPV.Text = Patient.PV;

            #endregion

            #region Relevant Family History

            intInTwins.Value = Patient.Twins ?? 0;
            swBtnDiabetes.Value = Patient.Diabetes ?? false;
            swBtnHypertension.Value = Patient.Hypertension ?? false;
            txtPastIllness.Text = Patient.PastIllness;
            txtOperations.Text = Patient.Operations;
            txtAllergies.Text = Patient.Allergies;
            txtDrugs.Text = Patient.Drugs;

            #endregion

            #region Investigations

            cmbAboGroup.SelectedIndex = PatientManager.GetAboGroupValueFromText(Patient.AboGroup);
            swBtnRhesusGroup.Value = Patient.RhesusGroup != null && Patient.RhesusGroup == "+";
            swBtnCytomegaloVirus.Value = Patient.CytomegaioVirus ?? false;
            swBtnHBSAg.Value = Patient.HbsAg ?? false;
            swBtnHBCAb.Value = Patient.HbcAb ?? false;
            intInBHCG.Value = Patient.Bhcg ?? 0;
            intInEstriolE3.Value = Patient.EstriolE3 ?? 0;
            intInFBS.Value = Patient.Fbs ?? 0;
            intInCBC.Value = Patient.Cbc ?? 0;
            intInPlatelets.Value = Patient.Platelets ?? 0;
            txtGeneralRemarks.Text = Patient.GeneralRemarks;

            #endregion
        }

        private void EditPatient()
        {
            if (btnEditPatient.Text == @"Edit")
            {
                ToggleEditPatientButton(false);
                EnableOrDisableControls(ReceptionFormMode.Edit);
            }
            else
            {
                if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
                {
                    ErrorProvider.SetError(txtName, Resources.RequiredValidationMsg);
                    return;
                }
                LoadPatientFromForm();
                PatientManager.UpdatePatient(Patient);
                ToggleEditPatientButton(true);
                EnableOrDisableControls(ReceptionFormMode.HasPatient);
            }
        }

        private void LoadPatientFromForm()
        {
            #region Patient's Basic Data

            Patient.Name = txtName.Text.FullTrim();
            Patient.BirthDate = dtBirthdate.Value;
            Patient.Address = txtAddress.Text.FullTrim();
            Patient.Phone = txtPhone.Text.FullTrim();

            #endregion

            #region First Examination

            Patient.Heart = txtHeart.Text.FullTrim();
            Patient.Lungs = txtLungs.Text.FullTrim();
            Patient.VaricoseVenis = txtVaricoseVeins.Text.FullTrim();
            Patient.Pelvis = txtPelvis.Text.FullTrim();
            Patient.LowerLimbs = txtLowerLimbs.Text.FullTrim();
            Patient.PV = txtPV.Text.FullTrim();

            #endregion

            #region Relevant Family History

            Patient.Twins = intInTwins.Value;
            Patient.Diabetes = swBtnDiabetes.Value;
            Patient.Hypertension = swBtnHypertension.Value;
            Patient.PastIllness = txtPastIllness.Text.FullTrim();
            Patient.Operations = txtOperations.Text.FullTrim();
            Patient.Allergies = txtAllergies.Text.FullTrim();
            Patient.Drugs = txtDrugs.Text.FullTrim();

            #endregion

            #region Investigations

            Patient.AboGroup = cmbAboGroup.SelectedIndex != 0 ? cmbAboGroup.SelectedItem.ToString() : null;
            Patient.RhesusGroup = cmbAboGroup.SelectedIndex != 0 ? swBtnRhesusGroup.Value ? "+" : "-" : null;
            Patient.CytomegaioVirus = swBtnCytomegaloVirus.Value;
            Patient.HbsAg = swBtnHBSAg.Value;
            Patient.HbcAb = swBtnHBCAb.Value;
            Patient.Bhcg = intInBHCG.Value;
            Patient.EstriolE3 = intInEstriolE3.Value;
            Patient.Fbs = intInFBS.Value;
            Patient.Cbc = intInCBC.Value;
            Patient.Platelets = intInPlatelets.Value;
            Patient.GeneralRemarks = txtGeneralRemarks.Text.FullTrim();

            #endregion
        }

        private void SetAutoCompletionForTextBoxes()
        {
            SetAutoCompletionForPatientIds();
            SetAutoCompletionForPatientNames();
        }

        private void SetAutoCompletionForPatientIds()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(PatientManager.GetAllPatients().Select(patient => patient.Id).ToArray());
            SetAutoCompleteSourceForTextBox(txtId, collection);
        }

        private void SetAutoCompletionForPatientNames()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(PatientManager.GetAllPatients().Select(patient => patient.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtName, collection);
        }

        #endregion
    }
}