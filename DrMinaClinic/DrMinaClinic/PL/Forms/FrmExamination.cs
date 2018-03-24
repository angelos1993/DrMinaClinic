using System;
using DrMinaClinic.DAL.Enums;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmExamination : FrmMaster
    {
        #region Constructor

        public FrmExamination()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void FrmExamination_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            EnableOrDisableControls(ExaminationFormMode.New);
        }

        private void EnableOrDisableControls(ExaminationFormMode mode)
        {
            
        }

        #endregion
    }
}