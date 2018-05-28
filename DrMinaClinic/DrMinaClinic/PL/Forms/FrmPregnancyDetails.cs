using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrMinaClinic.BLL;
using DrMinaClinic.DAL.Model;
using DrMinaClinic.Utility;

namespace DrMinaClinic.PL.Forms
{
    public partial class FrmPregnancyDetails : FrmMaster
    {
        #region Constructor

        public FrmPregnancyDetails(FrmExamination owner, Pregnancy pregnancy, int no)
        {
            Owner = owner;
            Pregnancy = pregnancy;
            No = no;
            InitializeComponent();
            if (Pregnancy.PregnancyDetails.Any())
            {
                PregnancyDetailsList = Pregnancy.PregnancyDetails.ToList();
                if (no > Pregnancy.PregnancyDetails.Count)
                {
                    var difference = no - Pregnancy.PregnancyDetails.Count;
                    for (var i = 0; i < difference; i++)
                        PregnancyDetailsList.Add(new PregnancyDetail());
                }
            }
            else
            {
                PregnancyDetailsList = new List<PregnancyDetail>();
                for (var i = 0; i < No; i++)
                    PregnancyDetailsList.Add(new PregnancyDetail());
            }
            PregnancyDetailManager.DeletePregnancyDetailsForPregnancy(pregnancy.Id);
            pregnancy.PregnancyDetails.Clear();
        }

        #endregion

        #region Properties

        public Pregnancy Pregnancy { get; set; }
        public int No { get; set; }
        private List<PregnancyDetail> PregnancyDetailsList { get; }
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private PregnancyDetailManager _pregnancyDetailManager;

        private PregnancyDetailManager PregnancyDetailManager =>
            _pregnancyDetailManager ?? (_pregnancyDetailManager = new PregnancyDetailManager());

        #endregion

        #region Events

        private void FrmPregnancyDetails_Load(object sender, EventArgs e)
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
            DisplayPregnancyDetail(selectedNodeIndex);
            lblHeader.Text = selectedNode.Text;
        }

        private void DisplayPregnancyDetail(int selectedNodeIndex)
        {
            if (!PregnancyDetailsList.Any())
                return;
            var pregnancyDetail = PregnancyDetailsList[selectedNodeIndex];
            swBtnLiving.Value = pregnancyDetail.Living;
            txtAf.Text = pregnancyDetail.AF ?? string.Empty;
            swBtnSex.Value = pregnancyDetail.Sex;
            txtPlacenta.Text = pregnancyDetail.Placenta ?? string.Empty;
            dblInWeight.Value = pregnancyDetail.Weight ?? default(double);
            txtPresentation.Text = pregnancyDetail.Presentation ?? string.Empty;
            txtOther.Text = pregnancyDetail.Other ?? string.Empty;
        }

        private void Save()
        {
            LoadDataFromForm(treeChildren.SelectedNode.Index);
            OwnerForm.SetPregnancyDetails(PregnancyDetailsList);
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
            PregnancyDetailsList[selectedNodeIndex] = new PregnancyDetail
            {
                PregnancyId = Pregnancy.Id,
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