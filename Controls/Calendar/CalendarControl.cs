using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Nager.Date;

using ShiftPlanner.Model;

namespace ShiftPlanner.Controls.Calendar
{
    [ToolboxItem(true)]
    public partial class CalendarControl : UserControl
    {
        private List<DayControl> _daysControls;

        private bool _isInitializing;

        public CalendarControl()
        {
            InitializeComponent();
            InitializeControls();

            SetData(DateTime.Today.Year, DateTime.Today.Month + 1);
        }
        
        public string GenerateWorkersSchedule(List<WorkerData> workers)
        {
            SuspendLayout();

            try
            {
                ClearData();

                Random rnd = new Random();
                List<DayData> daysList = _daysControls.Where(w => w.Data.IsCompleted == false).Select(s => s.Data).ToList();

                if (daysList.Count == 0)
                {
                    MessageBox.Show("There's no days available!"
                                    + Environment.NewLine + Environment.NewLine
                                    + "Please check places availability");

                    return string.Empty;
                }

                workers.Shuffle();
                Stack<WorkerData> workersList = new Stack<WorkerData>();
                foreach (WorkerData worker in workers)
                    workersList.Push(worker);

                foreach (DayData dayData in daysList)
                {
                    if (AllDaysFilled())
                        break;

                    if (workersList.Count == 0)
                        break;

                    WorkerData worker = workersList.Peek();

                    if (AssignedDaysCheck(daysList, dayData, worker))
                    {
                        bool success = dayData.AssignWorker(worker);
                        if (success)
                            workersList.Pop();
                    }
                }

                //do
                //{
                //    int rw = rnd.Next(workers.Count);
                //    WorkerData rndWorker = workers[rw];

                //    int rd = rnd.Next(daysList.Count);
                //    DayData rndDay = daysList[rd];

                //    if (rndDay != null)
                //    {
                //        if (AssignedDaysCheck(daysList, rndDay, rndWorker) == false)
                //            continue;

                //        bool success = rndDay.AssignWorker(rndWorker);
                //        if (success)
                //            workers.Remove(rndWorker);
                //    }

                //    if (AllDaysFilled())
                //        break;

                //    if (workers.Count == 0)
                //        break;
                //}
                //while (true);

                UpdateCalendarWorkerData(daysList);

                return workers.Count == 0 || AllDaysFilled()
                    ? "Generation successful!"
                    : "Sorry, generation went wrong... Please try again...";
            }
            finally
            {
                ResumeLayout();
            }

        }

        private static bool AssignedDaysCheck(List<DayData> daysList, DayData day, WorkerData worker)
        {
            int authorizedInterval = 2;

            int currentDayIndex = daysList.IndexOf(day);

            for (int i = 1; i <= authorizedInterval; i++)
            {
                if (!PreviousDaysCheck(daysList, worker, currentDayIndex, i))
                    return false;

                if (!NextDaysCheck(daysList, worker, currentDayIndex, i))
                    return false;
            }

            return true;
        }

        private static bool PreviousDaysCheck(List<DayData> daysList, WorkerData worker, int currentDayIndex, int interval)
        {
            int index = currentDayIndex - interval;
            if (index >= 0)
            {
                DayData auxDay = daysList[index];
                if (auxDay.AssignedWorkers.Any(s => s == worker))
                    return false;
            }

            return true;
        }

        private static bool NextDaysCheck(List<DayData> daysList, WorkerData worker, int currentDayIndex, int interval)
        {
            int index = currentDayIndex + interval;
            if (index < daysList.Count)
            {
                DayData auxDay = daysList[index];
                if (auxDay.AssignedWorkers.Any(s => s == worker))
                    return false;
            }

            return true;
        }

        private void InitializeControls()
        {
            _isInitializing = true;

            try
            {
                _daysControls = new List<DayControl>();

                monthComboBox.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                    .MonthNames.Take(12).ToList();
                monthComboBox.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                    .MonthNames[DateTime.Now.Month];

                yearComboBox.DataSource = Enumerable.Range(2017, DateTime.Now.Year - 2017 + 1).ToList();
                yearComboBox.SelectedItem = DateTime.Now.Year;
            }
            finally
            {
                _isInitializing = false;
            }
        }

        private void SetData(int year, int month)
        {
            titleLabel.Text = $"{new DateTime(year, month, 1).ToString("MMMM", CultureInfo.InvariantCulture)} {year}";
            SetCalendarDays(month, year);
        }

        private void ClearCalendarDays()
        {
            foreach (DayControl control in _daysControls)
                control.Dispose();

            _daysControls.Clear();
            flowLayoutPanel.Controls.Clear();
        }

        private void SetCalendarDays(int month, int year)
        {
            SuspendLayout();

            try
            {
                ClearCalendarDays();

                AddOffsetDays(year, month);

                int daysInCurrentMonth = DateTime.DaysInMonth(year, month);

                for (int i = 1; i <= daysInCurrentMonth; i++)
                {
                    DateTime date = new DateTime(year, month, i);

                    DayData dayData = new DayData
                    {
                        Day = i,
                        IsWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday,
                        IsHoliday = DateSystem.IsPublicHoliday(date, CountryCode.ES)
                    };

                    DayControl dayControl = new DayControl(dayData);
                    _daysControls.Add(dayControl);
                    flowLayoutPanel.Controls.Add(dayControl);
                }
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void AddOffsetDays(int year, int month)
        {
            DateTime firstDay = new DateTime(year, month, 1);

            int offsetDays;

            switch (firstDay.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    offsetDays = 0;
                    break;
                case DayOfWeek.Tuesday:
                    offsetDays = 1;
                    break;
                case DayOfWeek.Wednesday:
                    offsetDays = 2;
                    break;
                case DayOfWeek.Thursday:
                    offsetDays = 3;
                    break;
                case DayOfWeek.Friday:
                    offsetDays = 4;
                    break;
                case DayOfWeek.Saturday:
                    offsetDays = 5;
                    break;
                case DayOfWeek.Sunday:
                    offsetDays = 6;
                    break;
                default:
                    offsetDays = 0;
                    break;
            }

            if (offsetDays == 0)
                return;

            for (int i = 1; i <= offsetDays; i++)
            {
                Panel control = new Panel
                {
                    Width = 100,
                    Height = 100
                };
                flowLayoutPanel.Controls.Add(control);
            }

        }

        private void UpdateCalendarWorkerData(List<DayData> daysList)
        {
            foreach (DayData dayData in daysList)
            {
                DayControl dayControl = _daysControls.FirstOrDefault(s => s.Data.Day == dayData.Day);
                if (dayControl != null)
                    dayControl.Data = dayData;
            }
        }

        private bool AllDaysFilled()
        {
            bool isFilled = true;

            foreach (DayControl day in _daysControls)
                isFilled &= day.Data.IsCompleted;

            return isFilled;
        }

        public void ClearData()
        {
            foreach (DayControl day in _daysControls)
                day.ClearData();
        }

        private void SetAllPlaces0ButtonClick(object sender, EventArgs e)
        {
            ResetAllPlaces(0);
        }

        private void SetAllPlaces1ButtonClick(object sender, EventArgs e)
        {
            ResetAllPlaces(1);
        }

        private void SetAllPlaces2ButtonClick(object sender, EventArgs e)
        {
            ResetAllPlaces(2);
        }

        private void ResetAllPlaces(int value)
        {
            foreach (DayControl dayControl in _daysControls)
                dayControl.SetAvailablePlaces(value);
        }

        private void MonthComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing)
                return;

            SetData((int)yearComboBox.SelectedValue, monthComboBox.SelectedIndex + 1);
        }

        private void YearComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing)
                return;

            SetData((int)yearComboBox.SelectedValue, monthComboBox.SelectedIndex + 1);
        }
    }
}
