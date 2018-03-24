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

        private void treePregnancies_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {

        }

        private void btnNewPregnancy_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPregnancy_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveExamination_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            EnableOrDisableControls(ExaminationFormMode.New);
        }

        private void EnableOrDisableControls(ExaminationFormMode mode)
        {
            //treePregnancies.Enabled = 
            pnlPregnancyData.Enabled = mode == ExaminationFormMode.AddPregnance ||
                                       mode == ExaminationFormMode.EditPregnance;
            btnNewPregnancy.Enabled = mode == ExaminationFormMode.New || mode == ExaminationFormMode.HasPregnance;
            btnEditPregnancy.Enabled = mode == ExaminationFormMode.HasPregnance;
            pnlExaminationData.Enabled = mode == ExaminationFormMode.New || mode == ExaminationFormMode.HasPregnance;
            btnSaveExamination.Enabled = mode == ExaminationFormMode.HasPregnance;
        }

        #endregion
    }
}