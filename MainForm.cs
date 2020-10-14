using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ShiftPlanner.Controls;
using ShiftPlanner.Model;

namespace ShiftPlanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ControlExtensions.SetDoubleBuffered(calendarControl);
            workersList.Focus();
            ClearData();
        }

        private void ClearData()
        {
            messageLabel.Text = string.Empty;
            calendarControl.ClearData();
        }
        private void WorkersDaysSelectedChanged(object sender, EventArgs e)
        {
            workersList.ResetWorkersDays(workersDaysComboBox.SelectedIndex + 1);
        }

        private void GenerateButtonClick(object sender, EventArgs e)
        {
            List<WorkerData> workers = workersList.GetWorkers();
            messageLabel.Text = calendarControl.GenerateWorkersSchedule(workers);
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            ClearData();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            workersList.SetHeight();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
    }
}
