using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using ShiftPlanner.Model;

namespace ShiftPlanner.Controls.Worker
{
    [ToolboxItem(true)]
    public partial class WorkersListControl : UserControl
    {
        private const int _minWorkers = 3;

        private const int _maxWorkers = 10;

        private readonly List<WorkerControl> _workers = new List<WorkerControl>();

        public WorkersListControl()
        {
            InitializeComponent();
            InitializeControl();
        }

        public void SetHeight()
        {
            int height = Padding.Vertical + topPanel.Height + bottomPanel.Height + _workers.Sum(s => s.Height);

            Height = height;
        }

        public void ResetWorkersDays(int days)
        {
            foreach (WorkerControl workerControl in _workers)
            {
                workerControl.ResetWorkerDays(days);
            }
        }

        public List<WorkerData> GetWorkers()
        {
            List<WorkerData> workers = new List<WorkerData>();

            foreach (WorkerControl workerControl in _workers)
            {
                WorkerData workerData = workerControl.GetWorkerData();

                for (int i = 0; i < workerData.DaysOfWork; i++)
                    workers.Add(workerData);
            }

            return workers;
        }

        private void InitializeControl()
        {
            for (int i = 1; i <= _minWorkers; i++)
                AddWorkerControl(i);
        }

        private void AddWorkerControl(int i)
        {
            WorkerControl workerControl = new WorkerControl(i)
            {
                Dock = DockStyle.Top
            };

            _workers.Add(workerControl);
            Controls.Add(workerControl);
            workerControl.BringToFront();

            addLinkLabel.Visible = _maxWorkers > _workers.Count;
        }

        private void AddLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddWorkerControl(_workers.Count + 1);
            SetHeight();
        }
    }
}
