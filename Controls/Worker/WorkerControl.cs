using System.ComponentModel;
using System.Windows.Forms;

using ShiftPlanner.Model;

namespace ShiftPlanner.Controls.Worker
{
    [ToolboxItem(true)]
    public partial class WorkerControl : UserControl
    {
        public WorkerControl(int workerIndex)
        {
            InitializeComponent();
            WorkerIndex = workerIndex;
        }

        public int WorkerIndex { get; }

        public void ResetWorkerDays(int days)
        {
            daysComboBox.SelectedIndex = days;
        }

        public WorkerData GetWorkerData()
        {
            return new WorkerData(WorkerIndex, nameTextBox.Text, daysComboBox.SelectedIndex);
        }
    }
}
