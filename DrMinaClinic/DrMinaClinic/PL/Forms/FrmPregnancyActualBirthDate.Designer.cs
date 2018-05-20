namespace DrMinaClinic.PL.Forms
{
    partial class FrmPregnancyActualBirthDate
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtActualDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.chkCloseWithoutDate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(516, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Please select a birthdate to this pregnancy (if you want).";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtActualDate
            // 
            this.dtActualDate.Location = new System.Drawing.Point(50, 41);
            this.dtActualDate.Name = "dtActualDate";
            this.dtActualDate.Size = new System.Drawing.Size(238, 26);
            this.dtActualDate.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnOK.Location = new System.Drawing.Point(68, 72);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(200, 40);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK, Close Pregnancy";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(272, 72);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkCloseWithoutDate
            // 
            // 
            // 
            // 
            this.chkCloseWithoutDate.BackgroundStyle.Class = "";
            this.chkCloseWithoutDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkCloseWithoutDate.Location = new System.Drawing.Point(294, 41);
            this.chkCloseWithoutDate.Name = "chkCloseWithoutDate";
            this.chkCloseWithoutDate.Size = new System.Drawing.Size(197, 23);
            this.chkCloseWithoutDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkCloseWithoutDate.TabIndex = 26;
            this.chkCloseWithoutDate.Text = "Close without date";
            this.chkCloseWithoutDate.CheckedChanged += new System.EventHandler(this.chkCloseWithoutDate_CheckedChanged);
            // 
            // FrmPregnancyActualBirthDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 119);
            this.Controls.Add(this.chkCloseWithoutDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtActualDate);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmPregnancyActualBirthDate";
            this.Text = "Close Pregnancy";
            this.Load += new System.EventHandler(this.FrmPregnancyActualBirthDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dtActualDate;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkCloseWithoutDate;
    }
}