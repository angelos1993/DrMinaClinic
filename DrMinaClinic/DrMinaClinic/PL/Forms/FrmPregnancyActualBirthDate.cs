using System;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Model;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmPregnancyActualBirthDate : FrmMaster
    {
        #region Constructor

        public FrmPregnancyActualBirthDate(Pregnancy pregnancy)
        {
            InitializeComponent();
            Pregnancy = pregnancy;
        }

        #endregion

        #region Properties

        private Pregnancy Pregnancy { get; }
        private PregnancyManager _pregnancyManager;
        private PregnancyManager PregnancyManager => _pregnancyManager ?? (_pregnancyManager = new PregnancyManager());

        #endregion

        #region Events

        private void FrmPregnancyActualBirthDate_Load(object sender, EventArgs e)
        {
            dtActualDate.Value = DateTime.Now;
        }

        private void chkCloseWithoutDate_CheckedChanged(object sender, EventArgs e)
        {
            dtActualDate.Enabled = !chkCloseWithoutDate.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetPregnancyActualBirthdate();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void SetPregnancyActualBirthdate()
        {
            Pregnancy.ActualBirthdate = chkCloseWithoutDate.Checked ? (DateTime?) null : dtActualDate.Value;
            Pregnancy.IsCurrent = false;
            PregnancyManager.UpdatePregnancy(Pregnancy);
        }

        #endregion
    }
}