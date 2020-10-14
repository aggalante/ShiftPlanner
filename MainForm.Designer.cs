using ShiftPlanner.Controls.Calendar;

namespace ShiftPlanner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.workersActionsPanel = new System.Windows.Forms.Panel();
            this.workerActionsLabel = new System.Windows.Forms.Label();
            this.workersDaysComboBox = new System.Windows.Forms.ComboBox();
            this.buttonsBorderPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calendarControl = new ShiftPlanner.Controls.Calendar.CalendarControl();
            this.workersList = new ShiftPlanner.Controls.Worker.WorkersListControl();
            this.leftPanel.SuspendLayout();
            this.workersActionsPanel.SuspendLayout();
            this.buttonsBorderPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.workersActionsPanel);
            this.leftPanel.Controls.Add(this.workersList);
            this.leftPanel.Controls.Add(this.buttonsBorderPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(220, 781);
            this.leftPanel.TabIndex = 4;
            // 
            // workersActionsPanel
            // 
            this.workersActionsPanel.Controls.Add(this.workerActionsLabel);
            this.workersActionsPanel.Controls.Add(this.workersDaysComboBox);
            this.workersActionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.workersActionsPanel.Location = new System.Drawing.Point(10, 158);
            this.workersActionsPanel.Name = "workersActionsPanel";
            this.workersActionsPanel.Padding = new System.Windows.Forms.Padding(0, 2, 10, 2);
            this.workersActionsPanel.Size = new System.Drawing.Size(200, 25);
            this.workersActionsPanel.TabIndex = 12;
            // 
            // workerActionsLabel
            // 
            this.workerActionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerActionsLabel.Location = new System.Drawing.Point(0, 2);
            this.workerActionsLabel.Name = "workerActionsLabel";
            this.workerActionsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.workerActionsLabel.Size = new System.Drawing.Size(145, 21);
            this.workerActionsLabel.TabIndex = 0;
            this.workerActionsLabel.Text = "Set workers days to";
            this.workerActionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // workersDaysComboBox
            // 
            this.workersDaysComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.workersDaysComboBox.FormattingEnabled = true;
            this.workersDaysComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.workersDaysComboBox.Location = new System.Drawing.Point(145, 2);
            this.workersDaysComboBox.Name = "workersDaysComboBox";
            this.workersDaysComboBox.Size = new System.Drawing.Size(45, 21);
            this.workersDaysComboBox.TabIndex = 2;
            this.workersDaysComboBox.SelectedIndexChanged += new System.EventHandler(this.WorkersDaysSelectedChanged);
            // 
            // buttonsBorderPanel
            // 
            this.buttonsBorderPanel.BackColor = System.Drawing.Color.White;
            this.buttonsBorderPanel.Controls.Add(this.buttonsPanel);
            this.buttonsBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsBorderPanel.Location = new System.Drawing.Point(10, 651);
            this.buttonsBorderPanel.Name = "buttonsBorderPanel";
            this.buttonsBorderPanel.Padding = new System.Windows.Forms.Padding(2);
            this.buttonsBorderPanel.Size = new System.Drawing.Size(200, 120);
            this.buttonsBorderPanel.TabIndex = 11;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonsPanel.Controls.Add(this.messageLabel);
            this.buttonsPanel.Controls.Add(this.generateButton);
            this.buttonsPanel.Controls.Add(this.clearButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(2, 2);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonsPanel.Size = new System.Drawing.Size(196, 116);
            this.buttonsPanel.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.messageLabel.Location = new System.Drawing.Point(0, 86);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(196, 20);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "<message>";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(63, 10);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(63, 40);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // calendarControl
            // 
            this.calendarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarControl.Location = new System.Drawing.Point(220, 0);
            this.calendarControl.MaximumSize = new System.Drawing.Size(744, 781);
            this.calendarControl.MinimumSize = new System.Drawing.Size(744, 781);
            this.calendarControl.Name = "calendarControl";
            this.calendarControl.Size = new System.Drawing.Size(744, 781);
            this.calendarControl.TabIndex = 2;
            // 
            // workersList
            // 
            this.workersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.workersList.Location = new System.Drawing.Point(10, 10);
            this.workersList.Name = "workersList";
            this.workersList.Size = new System.Drawing.Size(200, 148);
            this.workersList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(964, 781);
            this.Controls.Add(this.calendarControl);
            this.Controls.Add(this.leftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 820);
            this.Name = "MainForm";
            this.Text = "ShiftPlanner";
            this.leftPanel.ResumeLayout(false);
            this.workersActionsPanel.ResumeLayout(false);
            this.buttonsBorderPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CalendarControl calendarControl;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private Controls.Worker.WorkersListControl workersList;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel buttonsBorderPanel;
        private System.Windows.Forms.Panel workersActionsPanel;
        private System.Windows.Forms.Label workerActionsLabel;
        private System.Windows.Forms.ComboBox workersDaysComboBox;
    }
}

