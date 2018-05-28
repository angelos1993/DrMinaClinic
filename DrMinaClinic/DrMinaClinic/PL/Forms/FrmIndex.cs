using System;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Properties;
using DrMinaClinic.Utility;

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

        private BackgroundImageManager _backgroundImageManager;

        private BackgroundImageManager BackgroundImageManager =>
            _backgroundImageManager ?? (_backgroundImageManager = new BackgroundImageManager());

        #endregion

        #region Events

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetBackgroundImage();
            Cursor = Cursors.Default;
        }

        private void btnNewExamination_Click(object sender, EventArgs e)
        {
            new FrmReception().ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            new FrmStatistics().ShowDialog();
        }

        private void btnChangeBackgroundImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = Resources.OpenFileDialogTitleForImages,
                Filter = Resources.AllImageFiles,
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            BackgroundImageManager.SaveTheBackgroundImage(
                new BackgroundImage {Data = File.ReadAllBytes(openFileDialog.FileNames[0])});
            SetBackgroundImage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void SetBackgroundImage()
        {
            BackgroundImage = BackgroundImageManager.GetTheBackgroundImage()?.Data.ToImage();
        }

        #endregion
    }
}