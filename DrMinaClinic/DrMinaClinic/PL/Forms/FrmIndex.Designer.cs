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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndex));
            this.btnStatistics = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnNewExamination = new DevComponents.DotNetBar.ButtonX();
            this.btnChangeBackgroundImage = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnStatistics
            // 
            this.btnStatistics.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Maroon;
            this.btnStatistics.Image = global::DrMinaClinic.Properties.Resources.Statistics;
            this.btnStatistics.ImageFixedSize = new System.Drawing.Size(100, 100);
            this.btnStatistics.Location = new System.Drawing.Point(508, 182);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5, 50, 50, 5);
            this.btnStatistics.Size = new System.Drawing.Size(375, 100);
            this.btnStatistics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.TabStop = false;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DrMinaClinic.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(75, 75);
            this.btnClose.Location = new System.Drawing.Point(11, 393);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnClose.Size = new System.Drawing.Size(120, 120);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.Tooltip = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.Class = "";
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(535, 363);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(375, 150);
            this.reflectionLabel1.TabIndex = 28;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Dr.</i><font color=\"#B02B2C\"><i>Mina Clinic</i></font></fon" +
    "t></b>";
            // 
            // btnNewExamination
            // 
            this.btnNewExamination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewExamination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewExamination.BackColor = System.Drawing.Color.Transparent;
            this.btnNewExamination.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnNewExamination.CustomColorName = "255,255,255";
            this.btnNewExamination.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExamination.ForeColor = System.Drawing.Color.Maroon;
            this.btnNewExamination.Image = global::DrMinaClinic.Properties.Resources.Sma3a;
            this.btnNewExamination.ImageFixedSize = new System.Drawing.Size(100, 100);
            this.btnNewExamination.Location = new System.Drawing.Point(508, 76);
            this.btnNewExamination.Name = "btnNewExamination";
            this.btnNewExamination.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5, 50, 50, 5);
            this.btnNewExamination.Size = new System.Drawing.Size(375, 100);
            this.btnNewExamination.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnNewExamination.TabIndex = 29;
            this.btnNewExamination.TabStop = false;
            this.btnNewExamination.Text = "New Examination";
            this.btnNewExamination.Click += new System.EventHandler(this.btnNewExamination_Click);
            // 
            // btnChangeBackgroundImage
            // 
            this.btnChangeBackgroundImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeBackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeBackgroundImage.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnChangeBackgroundImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBackgroundImage.Location = new System.Drawing.Point(12, 12);
            this.btnChangeBackgroundImage.Name = "btnChangeBackgroundImage";
            this.btnChangeBackgroundImage.Size = new System.Drawing.Size(222, 40);
            this.btnChangeBackgroundImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeBackgroundImage.TabIndex = 30;
            this.btnChangeBackgroundImage.Text = "Change Background Image";
            this.btnChangeBackgroundImage.Click += new System.EventHandler(this.btnChangeBackgroundImage_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 525);
            this.Controls.Add(this.btnChangeBackgroundImage);
            this.Controls.Add(this.btnNewExamination);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStatistics);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIndex";
            this.Text = "Dr. Mina Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnStatistics;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnNewExamination;
        private DevComponents.DotNetBar.ButtonX btnChangeBackgroundImage;
    }
}