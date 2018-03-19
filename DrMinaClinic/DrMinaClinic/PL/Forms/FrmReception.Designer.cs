namespace DrMinaClinic.PL.Forms
{
    partial class FrmReception
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
            this.pnlPatientData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtBirthdate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.pnlRelevantFamilyHistory = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnFindPatient = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlPatientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPatientData
            // 
            this.pnlPatientData.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlPatientData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlPatientData.Controls.Add(this.btnFindPatient);
            this.pnlPatientData.Controls.Add(this.txtPhone);
            this.pnlPatientData.Controls.Add(this.labelX5);
            this.pnlPatientData.Controls.Add(this.txtAddress);
            this.pnlPatientData.Controls.Add(this.labelX4);
            this.pnlPatientData.Controls.Add(this.dtBirthdate);
            this.pnlPatientData.Controls.Add(this.labelX3);
            this.pnlPatientData.Controls.Add(this.txtName);
            this.pnlPatientData.Controls.Add(this.txtId);
            this.pnlPatientData.Controls.Add(this.labelX2);
            this.pnlPatientData.Controls.Add(this.labelX1);
            this.pnlPatientData.Location = new System.Drawing.Point(12, 12);
            this.pnlPatientData.Name = "pnlPatientData";
            this.pnlPatientData.Size = new System.Drawing.Size(955, 224);
            // 
            // 
            // 
            this.pnlPatientData.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlPatientData.Style.BackColorGradientAngle = 90;
            this.pnlPatientData.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlPatientData.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderBottomWidth = 1;
            this.pnlPatientData.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlPatientData.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderLeftWidth = 1;
            this.pnlPatientData.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderRightWidth = 1;
            this.pnlPatientData.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlPatientData.Style.BorderTopWidth = 1;
            this.pnlPatientData.Style.Class = "";
            this.pnlPatientData.Style.CornerDiameter = 4;
            this.pnlPatientData.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlPatientData.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlPatientData.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlPatientData.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlPatientData.StyleMouseDown.Class = "";
            this.pnlPatientData.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlPatientData.StyleMouseOver.Class = "";
            this.pnlPatientData.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlPatientData.TabIndex = 0;
            this.pnlPatientData.Text = "Patient Data";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ID";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 38);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Name";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.Border.Class = "TextBoxBorder";
            this.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtId.Location = new System.Drawing.Point(84, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(266, 26);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(84, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 26);
            this.txtName.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Birthdate";
            // 
            // dtBirthdate
            // 
            // 
            // 
            // 
            this.dtBirthdate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBirthdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBirthdate.ButtonDropDown.Visible = true;
            this.dtBirthdate.Location = new System.Drawing.Point(84, 67);
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBirthdate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBirthdate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBirthdate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dtBirthdate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBirthdate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBirthdate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBirthdate.MonthCalendar.TodayButtonVisible = true;
            this.dtBirthdate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(200, 26);
            this.dtBirthdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBirthdate.TabIndex = 5;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(446, 6);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Address";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(527, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(266, 26);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.Location = new System.Drawing.Point(527, 38);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(266, 26);
            this.txtPhone.TabIndex = 9;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(446, 41);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Phone";
            // 
            // pnlRelevantFamilyHistory
            // 
            this.pnlRelevantFamilyHistory.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlRelevantFamilyHistory.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlRelevantFamilyHistory.Location = new System.Drawing.Point(12, 288);
            this.pnlRelevantFamilyHistory.Name = "pnlRelevantFamilyHistory";
            this.pnlRelevantFamilyHistory.Size = new System.Drawing.Size(742, 100);
            // 
            // 
            // 
            this.pnlRelevantFamilyHistory.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlRelevantFamilyHistory.Style.BackColorGradientAngle = 90;
            this.pnlRelevantFamilyHistory.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlRelevantFamilyHistory.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlRelevantFamilyHistory.Style.BorderBottomWidth = 1;
            this.pnlRelevantFamilyHistory.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlRelevantFamilyHistory.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlRelevantFamilyHistory.Style.BorderLeftWidth = 1;
            this.pnlRelevantFamilyHistory.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlRelevantFamilyHistory.Style.BorderRightWidth = 1;
            this.pnlRelevantFamilyHistory.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlRelevantFamilyHistory.Style.BorderTopWidth = 1;
            this.pnlRelevantFamilyHistory.Style.Class = "";
            this.pnlRelevantFamilyHistory.Style.CornerDiameter = 4;
            this.pnlRelevantFamilyHistory.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlRelevantFamilyHistory.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlRelevantFamilyHistory.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlRelevantFamilyHistory.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlRelevantFamilyHistory.StyleMouseDown.Class = "";
            this.pnlRelevantFamilyHistory.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlRelevantFamilyHistory.StyleMouseOver.Class = "";
            this.pnlRelevantFamilyHistory.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlRelevantFamilyHistory.TabIndex = 1;
            this.pnlRelevantFamilyHistory.Text = "Relevant Family History";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindPatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindPatient.Location = new System.Drawing.Point(356, 3);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(75, 58);
            this.btnFindPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindPatient.TabIndex = 10;
            this.btnFindPatient.Text = "Find";
            // 
            // FrmReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 402);
            this.Controls.Add(this.pnlRelevantFamilyHistory);
            this.Controls.Add(this.pnlPatientData);
            this.DoubleBuffered = true;
            this.Name = "FrmReception";
            this.Text = "Reception";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlPatientData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel pnlPatientData;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBirthdate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlRelevantFamilyHistory;
        private DevComponents.DotNetBar.ButtonX btnFindPatient;
    }
}