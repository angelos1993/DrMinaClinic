using System;
using System.Windows.Forms;

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
            
        }

        private void FindPatient()
        {
            
        }

        #endregion
    }
}