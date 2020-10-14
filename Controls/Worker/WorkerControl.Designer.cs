namespace ShiftPlanner.Controls.Worker
{
    partial class WorkerControl
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.separator = new System.Windows.Forms.Panel();
            this.daysComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameTextBox.Location = new System.Drawing.Point(5, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Left;
            this.separator.Location = new System.Drawing.Point(135, 5);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(10, 20);
            this.separator.TabIndex = 5;
            // 
            // daysComboBox
            // 
            this.daysComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.daysComboBox.FormattingEnabled = true;
            this.daysComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.daysComboBox.Location = new System.Drawing.Point(145, 5);
            this.daysComboBox.Name = "daysComboBox";
            this.daysComboBox.Size = new System.Drawing.Size(45, 21);
            this.daysComboBox.TabIndex = 1;
            // 
            // WorkerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.daysComboBox);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.nameTextBox);
            this.Name = "WorkerControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(200, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.ComboBox daysComboBox;
    }
}
