using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ShiftPlanner.Model
{
    public class DayData
    {
        public DayData()
        {
            AssignedWorkers = new List<WorkerData>();
        }

        public int Day { get; set; }

        public bool IsWeekend { get; set; }

        public bool IsHoliday { get; set; }

        [DefaultValue(1)]
        public int AvailablePlaces { get; set; }

        public List<WorkerData> AssignedWorkers { get; }

        public bool IsCompleted => AvailablePlaces == AssignedWorkers.Count;

        public bool AssignWorker(WorkerData worker)
        {
            if (IsCompleted)
                return false;

            if (AssignedWorkers.Any(a => a == worker))
                return false;

            AssignedWorkers.Add(worker);

            return true;
        }
    }
}
