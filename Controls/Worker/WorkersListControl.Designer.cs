namespace ShiftPlanner.Controls.Worker
{
    partial class WorkersListControl
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
            this.daysLabels = new System.Windows.Forms.Label();
            this.workerTitle = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.addLinkLabel = new System.Windows.Forms.LinkLabel();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // daysLabels
            // 
            this.daysLabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.daysLabels.Location = new System.Drawing.Point(145, 5);
            this.daysLabels.Name = "daysLabels";
            this.daysLabels.Size = new System.Drawing.Size(50, 20);
            this.daysLabels.TabIndex = 8;
            this.daysLabels.Text = "Days";
            this.daysLabels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workerTitle
            // 
            this.workerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.workerTitle.Location = new System.Drawing.Point(5, 5);
            this.workerTitle.Name = "workerTitle";
            this.workerTitle.Size = new System.Drawing.Size(140, 20);
            this.workerTitle.TabIndex = 7;
            this.workerTitle.Text = "Worker";
            this.workerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.daysLabels);
            this.topPanel.Controls.Add(this.workerTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(5);
            this.topPanel.Size = new System.Drawing.Size(200, 30);
            this.topPanel.TabIndex = 9;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.addLinkLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 170);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(5);
            this.bottomPanel.Size = new System.Drawing.Size(200, 30);
            this.bottomPanel.TabIndex = 10;
            // 
            // addLinkLabel
            // 
            this.addLinkLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addLinkLabel.Location = new System.Drawing.Point(148, 5);
            this.addLinkLabel.Name = "addLinkLabel";
            this.addLinkLabel.Size = new System.Drawing.Size(47, 20);
            this.addLinkLabel.TabIndex = 0;
            this.addLinkLabel.TabStop = true;
            this.addLinkLabel.Text = "Add...";
            this.addLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddLinkClicked);
            // 
            // WorkersListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "WorkersListControl";
            this.Size = new System.Drawing.Size(200, 200);
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label daysLabels;
        private System.Windows.Forms.Label workerTitle;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.LinkLabel addLinkLabel;
    }
}
