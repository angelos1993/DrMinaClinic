using System;
using System.Linq;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.VMs;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmStatistics : FrmMaster
    {
        #region Constructor

        public FrmStatistics()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager
            => _examinationManager ?? (_examinationManager = new ExaminationManager());

        #endregion

        #region Events

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Find();
            Cursor = Cursors.Default;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Find();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            dt.Value = DateTime.Now;
        }

        private void Find()
        {
            var patientExaminationVms = ExaminationManager.GetExaminationsByDate(dt.Value)
                .Select(examination => new PatientExaminationVm
                {
                    PatientId = examination.Pregnancy.PatientId,
                    PatientName = examination.Pregnancy.Patient.Name,
                    Address = examination.Pregnancy.Patient.Address,
                    Phone = examination.Pregnancy.Patient.Phone
                }).OrderBy(vm => vm.PatientName).ToList();
            dgv.DataSource = patientExaminationVms;
            lblCount.Text = patientExaminationVms.Count != 0 ? $"Count: {patientExaminationVms.Count}" : string.Empty;
        }

        #endregion
    }
}