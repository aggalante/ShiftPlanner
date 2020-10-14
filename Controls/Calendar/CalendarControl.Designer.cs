namespace ShiftPlanner.Controls.Calendar
{
    partial class CalendarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.holydayPanel = new System.Windows.Forms.Panel();
            this.weekendPanel = new System.Windows.Forms.Panel();
            this.holydayLabel = new System.Windows.Forms.Label();
            this.workDayPanel = new System.Windows.Forms.Panel();
            this.weekendLabel = new System.Windows.Forms.Label();
            this.workDayLabel = new System.Windows.Forms.Label();
            this.places0button = new System.Windows.Forms.Button();
            this.places1button = new System.Windows.Forms.Button();
            this.places2button = new System.Windows.Forms.Button();
            this.daysTitle = new System.Windows.Forms.Panel();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.daysTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(740, 327);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(740, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.chooseLabel);
            this.topPanel.Controls.Add(this.yearComboBox);
            this.topPanel.Controls.Add(this.monthComboBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(740, 40);
            this.topPanel.TabIndex = 1;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(10, 19);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(156, 13);
            this.chooseLabel.TabIndex = 2;
            this.chooseLabel.Text = "Please choose calendar option:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(299, 16);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(78, 21);
            this.yearComboBox.TabIndex = 1;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBoxSelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(172, 16);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 0;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBoxSelectedIndexChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.holydayPanel);
            this.bottomPanel.Controls.Add(this.weekendPanel);
            this.bottomPanel.Controls.Add(this.holydayLabel);
            this.bottomPanel.Controls.Add(this.workDayPanel);
            this.bottomPanel.Controls.Add(this.weekendLabel);
            this.bottomPanel.Controls.Add(this.workDayLabel);
            this.bottomPanel.Controls.Add(this.places0button);
            this.bottomPanel.Controls.Add(this.places1button);
            this.bottomPanel.Controls.Add(this.places2button);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 427);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(740, 30);
            this.bottomPanel.TabIndex = 2;
            // 
            // holydayPanel
            // 
            this.holydayPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.holydayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holydayPanel.Location = new System.Drawing.Point(172, 6);
            this.holydayPanel.Name = "holydayPanel";
            this.holydayPanel.Size = new System.Drawing.Size(13, 13);
            this.holydayPanel.TabIndex = 8;
            // 
            // weekendPanel
            // 
            this.weekendPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.weekendPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekendPanel.Location = new System.Drawing.Point(91, 6);
            this.weekendPanel.Name = "weekendPanel";
            this.weekendPanel.Size = new System.Drawing.Size(13, 13);
            this.weekendPanel.TabIndex = 6;
            // 
            // holydayLabel
            // 
            this.holydayLabel.AutoSize = true;
            this.holydayLabel.Location = new System.Drawing.Point(191, 6);
            this.holydayLabel.Name = "holydayLabel";
            this.holydayLabel.Size = new System.Drawing.Size(43, 13);
            this.holydayLabel.TabIndex = 7;
            this.holydayLabel.Text = "holyday";
            // 
            // workDayPanel
            // 
            this.workDayPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.workDayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workDayPanel.Location = new System.Drawing.Point(13, 6);
            this.workDayPanel.Name = "workDayPanel";
            this.workDayPanel.Size = new System.Drawing.Size(13, 13);
            this.workDayPanel.TabIndex = 4;
            // 
            // weekendLabel
            // 
            this.weekendLabel.AutoSize = true;
            this.weekendLabel.Location = new System.Drawing.Point(110, 6);
            this.weekendLabel.Name = "weekendLabel";
            this.weekendLabel.Size = new System.Drawing.Size(51, 13);
            this.weekendLabel.TabIndex = 5;
            this.weekendLabel.Text = "weekend";
            // 
            // workDayLabel
            // 
            this.workDayLabel.AutoSize = true;
            this.workDayLabel.Location = new System.Drawing.Point(32, 6);
            this.workDayLabel.Name = "workDayLabel";
            this.workDayLabel.Size = new System.Drawing.Size(50, 13);
            this.workDayLabel.TabIndex = 3;
            this.workDayLabel.Text = "work day";
            // 
            // places0button
            // 
            this.places0button.Location = new System.Drawing.Point(365, 3);
            this.places0button.Name = "places0button";
            this.places0button.Size = new System.Drawing.Size(115, 23);
            this.places0button.TabIndex = 2;
            this.places0button.Text = "Set places to 0";
            this.places0button.UseVisualStyleBackColor = true;
            this.places0button.Click += new System.EventHandler(this.SetAllPlaces0ButtonClick);
            // 
            // places1button
            // 
            this.places1button.Location = new System.Drawing.Point(486, 3);
            this.places1button.Name = "places1button";
            this.places1button.Size = new System.Drawing.Size(115, 23);
            this.places1button.TabIndex = 1;
            this.places1button.Text = "Set places to 1";
            this.places1button.UseVisualStyleBackColor = true;
            this.places1button.Click += new System.EventHandler(this.SetAllPlaces1ButtonClick);
            // 
            // places2button
            // 
            this.places2button.Location = new System.Drawing.Point(607, 3);
            this.places2button.Name = "places2button";
            this.places2button.Size = new System.Drawing.Size(115, 23);
            this.places2button.TabIndex = 0;
            this.places2button.Text = "Set places to 2";
            this.places2button.UseVisualStyleBackColor = true;
            this.places2button.Click += new System.EventHandler(this.SetAllPlaces2ButtonClick);
            // 
            // daysTitle
            // 
            this.daysTitle.Controls.Add(this.sundayLabel);
            this.daysTitle.Controls.Add(this.saturdayLabel);
            this.daysTitle.Controls.Add(this.fridayLabel);
            this.daysTitle.Controls.Add(this.thursdayLabel);
            this.daysTitle.Controls.Add(this.wednesdayLabel);
            this.daysTitle.Controls.Add(this.tuesdayLabel);
            this.daysTitle.Controls.Add(this.mondayLabel);
            this.daysTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.daysTitle.Location = new System.Drawing.Point(0, 80);
            this.daysTitle.Name = "daysTitle";
            this.daysTitle.Size = new System.Drawing.Size(740, 20);
            this.daysTitle.TabIndex = 3;
            // 
            // mondayLabel
            // 
            this.mondayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mondayLabel.Location = new System.Drawing.Point(0, 0);
            this.mondayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.mondayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(106, 20);
            this.mondayLabel.TabIndex = 0;
            this.mondayLabel.Text = "Moday";
            this.mondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tuesdayLabel.Location = new System.Drawing.Point(106, 0);
            this.tuesdayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.tuesdayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(106, 20);
            this.tuesdayLabel.TabIndex = 1;
            this.tuesdayLabel.Text = "Tuesday";
            this.tuesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.wednesdayLabel.Location = new System.Drawing.Point(212, 0);
            this.wednesdayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.wednesdayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(106, 20);
            this.wednesdayLabel.TabIndex = 2;
            this.wednesdayLabel.Text = "Wednesday";
            this.wednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.thursdayLabel.Location = new System.Drawing.Point(318, 0);
            this.thursdayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.thursdayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(106, 20);
            this.thursdayLabel.TabIndex = 3;
            this.thursdayLabel.Text = "Thursday";
            this.thursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fridayLabel
            // 
            this.fridayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fridayLabel.Location = new System.Drawing.Point(424, 0);
            this.fridayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.fridayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(106, 20);
            this.fridayLabel.TabIndex = 4;
            this.fridayLabel.Text = "Friday";
            this.fridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.saturdayLabel.Location = new System.Drawing.Point(530, 0);
            this.saturdayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.saturdayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(106, 20);
            this.saturdayLabel.TabIndex = 5;
            this.saturdayLabel.Text = "Saturday";
            this.saturdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sundayLabel
            // 
            this.sundayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sundayLabel.Location = new System.Drawing.Point(636, 0);
            this.sundayLabel.MaximumSize = new System.Drawing.Size(106, 0);
            this.sundayLabel.MinimumSize = new System.Drawing.Size(106, 0);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(106, 20);
            this.sundayLabel.TabIndex = 6;
            this.sundayLabel.Text = "Sunday";
            this.sundayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.daysTitle);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "CalendarControl";
            this.Size = new System.Drawing.Size(740, 457);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.daysTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel holydayPanel;
        private System.Windows.Forms.Panel weekendPanel;
        private System.Windows.Forms.Label holydayLabel;
        private System.Windows.Forms.Panel workDayPanel;
        private System.Windows.Forms.Label weekendLabel;
        private System.Windows.Forms.Label workDayLabel;
        private System.Windows.Forms.Button places0button;
        private System.Windows.Forms.Button places1button;
        private System.Windows.Forms.Button places2button;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Panel daysTitle;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label mondayLabel;
    }
}
