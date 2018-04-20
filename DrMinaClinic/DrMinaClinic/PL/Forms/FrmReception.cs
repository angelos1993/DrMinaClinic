using System;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.Properties;
using DrMinaClinic.DAL.Enums;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Utility;

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

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddNewPatient();
            Cursor = Cursors.Default;
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
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
            ResetPatientData();
            EnableOrDisableControls(ReceptionFormMode.New);
        }

        private void FindPatient()
        {

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
                    var patient = new Patient
                    {
                        #region Patient's Basic Data

                        Id = PatientManager.GetNextPatientId(PatientManager.GetLastPatientId()),
                        Name = txtName.Text.FullTrim(),
                        //TODO: check if the value is the default
                        BirthDate = dtBirthdate.Value,
                        Address = txtAddress.Text.FullTrim(),
                        Phone = txtPhone.Text.FullTrim(),
                        CreatedOn = DateTime.Now,

                        #endregion

                        #region First Examination

                        Heart = txtHeart.Text.FullTrim(),
                        Lungs = txtLungs.Text.FullTrim(),
                        VaricoseVenis = txtVaricoseVeins.Text.FullTrim(),
                        Pelvis = txtPelvis.Text.FullTrim(),
                        LowerLimbs = txtLowerLimbs.Text.FullTrim(),
                        PV = txtPV.Text.FullTrim(),

                        #endregion

                        #region Relevant Family History

                        Twins = intInTwins.Value,
                        Diabetes = swBtnDiabetes.Value,
                        Hypertension = swBtnHypertension.Value,
                        PastIllness = txtPastIllness.Text.FullTrim(),
                        Operations = txtOperations.Text.FullTrim(),
                        Allergies = txtAllergies.Text.FullTrim(),
                        Drugs = txtDrugs.Text.FullTrim(),

                        #endregion

                        #region Investigations

                        //TODO: need to make sure of this line
                        AboGroup = cmbAboGroup.Text,
                        RhesusGroup = swBtnRhesusGroup.Value ? "+" : "-",
                        CytomegaioVirus = swBtnCytomegaloVirus.Value,
                        HbsAg = swBtnHBSAg.Value,
                        HbcAb = swBtnHBCAb.Value,
                        Bhcg = intInBHCG.Value,
                        EstriolE3 = intInEstriolE3.Value,
                        Fbs = intInFBS.Value,
                        Cbc = intInCBC.Value,
                        Platelets = intInPlatelets.Value,
                        GeneralRemarks = txtGeneralRemarks.Text.FullTrim()

                        #endregion
                    };
                    PatientManager.AddNewPatient(patient);
                    EnableOrDisableControls(ReceptionFormMode.HasPatient);
                    ToggleNewPatientButton(true);
                }
                else
                {
                    ErrorProvider.SetError(txtName, Resources.RequiredValidationMsg);
                    //TODO: need to complete (validate) the required fields
                    //I think the name is the only required field
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

            #region New / Save button

            ToggleNewPatientButton(true);

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

        #endregion
    }
}