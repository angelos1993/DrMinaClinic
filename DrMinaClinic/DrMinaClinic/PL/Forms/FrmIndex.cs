using System;
using DevComponents.DotNetBar;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmIndex : Office2007Form
    {
        #region Constructor

        public FrmIndex()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void btnNewExamination_Click(object sender, EventArgs e)
        {
            new FrmReception().ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        #endregion
    }
}