using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using ShiftPlanner.Model;

namespace ShiftPlanner.Controls.Calendar
{
    public partial class DayControl : UserControl
    {
        private DayData _data;

        public DayControl(DayData data)
        {
            InitializeComponent();
            Reset();

            Data = data;

            SetColor();
        }

        public DayData Data
        {
            get => _data;
            set
            {
                _data = value;
                dayLabel.Text = value.Day.ToString();
                availablePlacesComboBox.SelectedIndex = value.AvailablePlaces;
                workersLabel.Text = string.Join(Environment.NewLine, value.AssignedWorkers.Select(s => s.Name));
            }
        }

        public bool AssignWorker(WorkerData worker)
        {
            if (Data.IsCompleted)
                return false;

            if (Data.AssignedWorkers.Any(a => a == worker))
                return false;

            Data.AssignedWorkers.Add(worker);
            workersLabel.Text = string.Join(Environment.NewLine, Data.AssignedWorkers.Select(s => s.Name));

            return true;
        }

        public void ClearData()
        {
            Data.AssignedWorkers.Clear();
            workersLabel.Text = string.Empty;
        }

        public void SetAvailablePlaces(int value)
        {
            availablePlacesComboBox.SelectedIndex = value;
        }

        private void Reset()
        {
            Data = new DayData();

            contentPanel.BackColor = Color.AliceBlue;
            dayLabel.Text = string.Empty;
            workersLabel.Text = string.Empty;
        }

        private void SetColor()
        {
            if (Data.IsHoliday)
                contentPanel.BackColor = Color.BurlyWood;
            else if (Data.IsWeekend)
                contentPanel.BackColor = Color.MediumAquamarine;
            else
                contentPanel.BackColor = Color.AliceBlue;
        }

        private void AvailablePlacesSelectedIndexChanged(object sender, EventArgs e)
        {
            Data.AvailablePlaces = availablePlacesComboBox.SelectedIndex;
        }
    }
}
