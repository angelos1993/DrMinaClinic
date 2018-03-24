namespace DrMinaClinic.PL.Forms
{
    partial class FrmIndex
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
            this.btnNewExamination = new DevComponents.DotNetBar.ButtonX();
            this.btnStatistics = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnNewExamination
            // 
            this.btnNewExamination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewExamination.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewExamination.Location = new System.Drawing.Point(252, 172);
            this.btnNewExamination.Name = "btnNewExamination";
            this.btnNewExamination.Size = new System.Drawing.Size(253, 100);
            this.btnNewExamination.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewExamination.TabIndex = 1;
            this.btnNewExamination.Text = "New Examination";
            this.btnNewExamination.Click += new System.EventHandler(this.btnNewExamination_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStatistics.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStatistics.Location = new System.Drawing.Point(511, 172);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(253, 100);
            this.btnStatistics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 477);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnNewExamination);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "FrmIndex";
            this.Text = "Dr. Mina Clinic";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnNewExamination;
        private DevComponents.DotNetBar.ButtonX btnStatistics;
    }
}