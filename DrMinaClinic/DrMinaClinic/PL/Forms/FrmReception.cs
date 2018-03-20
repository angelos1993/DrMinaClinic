using System;
using System.Windows.Forms;
using DrMinaClinic.DAL.Enums;

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
            EnableOrDisableControls(ReceptionFormMode.New);
        }

        private void FindPatient()
        {
            
        }

        private void EnableOrDisableControls(ReceptionFormMode mode)
        {
            #region Patient Data

            txtId.Enabled = mode == ReceptionFormMode.New || mode == ReceptionFormMode.AddPatient;
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

            btnNewPatient.Enabled = mode == ReceptionFormMode.New;
            btnEditPatient.Enabled = mode == ReceptionFormMode.HasPatient || mode == ReceptionFormMode.Edit;
            btnNewExamination.Enabled = mode == ReceptionFormMode.HasPatient;

            #endregion
        }

        #endregion
    }
}