namespace ShiftPlanner.Controls.Calendar
{
    partial class DayControl
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
            this.dayLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.placesLabel = new System.Windows.Forms.Label();
            this.availablePlacesComboBox = new System.Windows.Forms.ComboBox();
            this.workersLabel = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(5, 5);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(52, 17);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "<day>";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.placesLabel);
            this.contentPanel.Controls.Add(this.availablePlacesComboBox);
            this.contentPanel.Controls.Add(this.dayLabel);
            this.contentPanel.Controls.Add(this.workersLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.contentPanel.Size = new System.Drawing.Size(100, 100);
            this.contentPanel.TabIndex = 1;
            // 
            // placesLabel
            // 
            this.placesLabel.AutoSize = true;
            this.placesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placesLabel.Location = new System.Drawing.Point(5, 27);
            this.placesLabel.Name = "placesLabel";
            this.placesLabel.Size = new System.Drawing.Size(41, 13);
            this.placesLabel.TabIndex = 3;
            this.placesLabel.Text = "places:";
            this.placesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availablePlacesComboBox
            // 
            this.availablePlacesComboBox.FormattingEnabled = true;
            this.availablePlacesComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.availablePlacesComboBox.Location = new System.Drawing.Point(47, 24);
            this.availablePlacesComboBox.Name = "availablePlacesComboBox";
            this.availablePlacesComboBox.Size = new System.Drawing.Size(45, 21);
            this.availablePlacesComboBox.TabIndex = 2;
            this.availablePlacesComboBox.SelectedIndexChanged += new System.EventHandler(this.AvailablePlacesSelectedIndexChanged);
            // 
            // workersLabel
            // 
            this.workersLabel.AutoSize = true;
            this.workersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.workersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workersLabel.Location = new System.Drawing.Point(5, 82);
            this.workersLabel.MaximumSize = new System.Drawing.Size(90, 0);
            this.workersLabel.MinimumSize = new System.Drawing.Size(90, 13);
            this.workersLabel.Name = "workersLabel";
            this.workersLabel.Size = new System.Drawing.Size(90, 13);
            this.workersLabel.TabIndex = 1;
            this.workersLabel.Text = "<worker>";
            this.workersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label workersLabel;
        private System.Windows.Forms.Label placesLabel;
        private System.Windows.Forms.ComboBox availablePlacesComboBox;
    }
}
