using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Utility;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmExaminationDetails : FrmMaster
    {
        #region Constructor

        public FrmExaminationDetails(Form owner, Examination examination, int no)
        {
            Owner = owner;
            Examination = examination;
            No = no;
            InitializeComponent();
            if (Examination.ExaminationDetails.Any())
            {
                ExaminationDetailsList = Examination.ExaminationDetails.ToList();
                if (no > Examination.ExaminationDetails.Count)
                {
                    var difference = no - Examination.ExaminationDetails.Count;
                    for (var i = 0; i < difference; i++)
                        ExaminationDetailsList.Add(new ExaminationDetail());
                }
            }
            else
            {
                ExaminationDetailsList = new List<ExaminationDetail>();
                for (var i = 0; i < No; i++)
                    ExaminationDetailsList.Add(new ExaminationDetail());
            }
            ExaminationDetailManager.DeleteExaminationDetailsForPregnancy(examination.Id);
            examination.ExaminationDetails.Clear();
        }

        #endregion

        #region Properties

        public Examination Examination { get; set; }
        public int No { get; set; }
        private List<ExaminationDetail> ExaminationDetailsList { get; }
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private ExaminationDetailManager _examinationDetailManager;

        private ExaminationDetailManager ExaminationDetailManager =>
            _examinationDetailManager ?? (_examinationDetailManager = new ExaminationDetailManager());

        #endregion

        #region Events

        private void FrmExaminationDetails_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void treeChildren_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HandleBeforeNodeSelection(treeChildren.SelectedNode);
            Cursor = Cursors.Default;
        }

        private void treeChildren_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HandleAfterNodeSelection(e.Node);
            Cursor = Cursors.Default;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HandleNextClick();
            Cursor = Cursors.Default;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            HandleBackClick();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Save();
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
            for (var i = 1; i <= No; i++)
                treeChildren.Nodes.Add(new TreeNode
                {
                    Name = i.ToString(),
                    Text = $@"{i.ToOrdinal()} Child"
                });
            treeChildren.SelectedNode = treeChildren.Nodes[0];
        }

        private void HandleBeforeNodeSelection(TreeNode selectedNode)
        {
            LoadDataFromForm(selectedNode.Index);
        }

        private void HandleAfterNodeSelection(TreeNode selectedNode)
        {
            var selectedNodeIndex = selectedNode.Index;
            DisplayExaminationDetail(selectedNodeIndex);
            lblHeader.Text = selectedNode.Text;
        }

        private void DisplayExaminationDetail(int selectedNodeIndex)
        {
            if (!ExaminationDetailsList.Any())
                return;
            var examinationDetail = ExaminationDetailsList[selectedNodeIndex];
            swBtnLiving.Value = examinationDetail.Living;
            txtAf.Text = examinationDetail.AF ?? string.Empty;
            swBtnSex.Value = examinationDetail.Sex;
            txtPlacenta.Text = examinationDetail.Placenta ?? string.Empty;
            dblInWeight.Value = examinationDetail.Weight ?? default(double);
            txtPresentation.Text = examinationDetail.Presentation ?? string.Empty;
            txtOther.Text = examinationDetail.Other ?? string.Empty;
        }

        private void Save()
        {
            LoadDataFromForm(treeChildren.SelectedNode.Index);
            OwnerForm.SetExaminationDetails(ExaminationDetailsList);
            Close();
        }

        private void HandleNextClick()
        {
            LoadDataFromForm(treeChildren.SelectedNode.Index);
            treeChildren.SelectedNode = treeChildren.SelectedNode.NextNode ?? treeChildren.Nodes[0];
            treeChildren.Select();
        }

        private void HandleBackClick()
        {
            LoadDataFromForm(treeChildren.SelectedNode.Index);
            treeChildren.SelectedNode = treeChildren.SelectedNode.PrevNode ??
                                        treeChildren.Nodes[treeChildren.Nodes.Count - 1];
            treeChildren.Select();
        }

        private void LoadDataFromForm(int selectedNodeIndex)
        {
            ExaminationDetailsList[selectedNodeIndex] = new ExaminationDetail
            {
                ExaminationId = Examination.Id,
                Living = swBtnLiving.Value,
                AF = txtAf.Text,
                Sex = swBtnSex.Value,
                Placenta = txtPlacenta.Text,
                Weight = dblInWeight.Value,
                Presentation = txtPresentation.Text,
                Other = txtOther.Text
            };
        }

        #endregion
    }
}