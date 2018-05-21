namespace DrMinaClinic.PL.Forms
{
    partial class FrmPregnancyDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeChildren = new System.Windows.Forms.TreeView();
            this.swBtnLiving = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.swBtnSex = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtAf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOther = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPresentation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dblInWeight = new DevComponents.Editors.DoubleInput();
            this.txtPlacento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.lblHeader = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // treeChildren
            // 
            this.treeChildren.HideSelection = false;
            this.treeChildren.Location = new System.Drawing.Point(12, 12);
            this.treeChildren.Name = "treeChildren";
            this.treeChildren.Size = new System.Drawing.Size(141, 237);
            this.treeChildren.TabIndex = 0;
            this.treeChildren.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeChildren_AfterSelect);
            this.treeChildren.Click += new System.EventHandler(this.treeChildren_Click);
            // 
            // swBtnLiving
            // 
            // 
            // 
            // 
            this.swBtnLiving.BackgroundStyle.Class = "";
            this.swBtnLiving.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swBtnLiving.Location = new System.Drawing.Point(286, 39);
            this.swBtnLiving.Name = "swBtnLiving";
            this.swBtnLiving.OffText = "✘";
            this.swBtnLiving.OnBackColor = System.Drawing.Color.Transparent;
            this.swBtnLiving.OnText = "✔";
            this.swBtnLiving.Size = new System.Drawing.Size(75, 22);
            this.swBtnLiving.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swBtnLiving.TabIndex = 23;
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(159, 39);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(121, 23);
            this.labelX14.TabIndex = 22;
            this.labelX14.Text = "Living";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(159, 162);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "Weight Kg.";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(159, 127);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "Placento";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(159, 99);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(121, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "Sex";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(159, 67);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(121, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "AF";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(159, 191);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(121, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "Presentation";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(159, 223);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(121, 23);
            this.labelX6.TabIndex = 29;
            this.labelX6.Text = "Other";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // swBtnSex
            // 
            // 
            // 
            // 
            this.swBtnSex.BackgroundStyle.Class = "";
            this.swBtnSex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swBtnSex.Location = new System.Drawing.Point(286, 99);
            this.swBtnSex.Name = "swBtnSex";
            this.swBtnSex.OffText = "Female";
            this.swBtnSex.OnBackColor = System.Drawing.Color.Transparent;
            this.swBtnSex.OnText = "Male";
            this.swBtnSex.Size = new System.Drawing.Size(123, 22);
            this.swBtnSex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swBtnSex.TabIndex = 30;
            // 
            // txtAf
            // 
            // 
            // 
            // 
            this.txtAf.Border.Class = "TextBoxBorder";
            this.txtAf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAf.Location = new System.Drawing.Point(286, 67);
            this.txtAf.Name = "txtAf";
            this.txtAf.Size = new System.Drawing.Size(238, 26);
            this.txtAf.TabIndex = 31;
            // 
            // txtOther
            // 
            // 
            // 
            // 
            this.txtOther.Border.Class = "TextBoxBorder";
            this.txtOther.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOther.Location = new System.Drawing.Point(286, 223);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(238, 26);
            this.txtOther.TabIndex = 32;
            // 
            // txtPresentation
            // 
            // 
            // 
            // 
            this.txtPresentation.Border.Class = "TextBoxBorder";
            this.txtPresentation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPresentation.Location = new System.Drawing.Point(286, 191);
            this.txtPresentation.Name = "txtPresentation";
            this.txtPresentation.Size = new System.Drawing.Size(238, 26);
            this.txtPresentation.TabIndex = 33;
            // 
            // dblInWeight
            // 
            // 
            // 
            // 
            this.dblInWeight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInWeight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInWeight.Increment = 1D;
            this.dblInWeight.Location = new System.Drawing.Point(286, 159);
            this.dblInWeight.Name = "dblInWeight";
            this.dblInWeight.ShowUpDown = true;
            this.dblInWeight.Size = new System.Drawing.Size(123, 26);
            this.dblInWeight.TabIndex = 34;
            // 
            // txtPlacento
            // 
            // 
            // 
            // 
            this.txtPlacento.Border.Class = "TextBoxBorder";
            this.txtPlacento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlacento.Location = new System.Drawing.Point(286, 127);
            this.txtPlacento.Name = "txtPlacento";
            this.txtPlacento.Size = new System.Drawing.Size(238, 26);
            this.txtPlacento.TabIndex = 35;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::DrMinaClinic.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(46, 267);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Image = global::DrMinaClinic.Properties.Resources.Next;
            this.btnNext.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnNext.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNext.Location = new System.Drawing.Point(284, 267);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 40);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 36;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Image = global::DrMinaClinic.Properties.Resources.Back;
            this.btnBack.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(165, 267);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 40);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblHeader.BackgroundStyle.Class = "";
            this.lblHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(175, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(349, 23);
            this.lblHeader.TabIndex = 39;
            this.lblHeader.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrMinaClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(403, 267);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmPregnancyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 318);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPlacento);
            this.Controls.Add(this.dblInWeight);
            this.Controls.Add(this.txtPresentation);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtAf);
            this.Controls.Add(this.swBtnSex);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.swBtnLiving);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.treeChildren);
            this.DoubleBuffered = true;
            this.Name = "FrmPregnancyDetails";
            this.Text = "Pregnancy Details";
            this.Load += new System.EventHandler(this.FrmPregnancyDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeChildren;
        private DevComponents.DotNetBar.Controls.SwitchButton swBtnLiving;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.SwitchButton swBtnSex;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAf;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOther;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPresentation;
        private DevComponents.Editors.DoubleInput dblInWeight;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlacento;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnBack;
        private DevComponents.DotNetBar.LabelX lblHeader;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}