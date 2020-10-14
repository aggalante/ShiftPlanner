#region Copyright © 2014, Critical Health
// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================
#endregion

namespace ShiftPlanner.Model
{
    public class WorkerData
    {
        public WorkerData(int workerIndex, string name, int daysOfWork)
        {
            WorkerIndex = workerIndex;
            Name = name;
            DaysOfWork = daysOfWork;
        }

        public int WorkerIndex { get; set; }

        public string Name { get; set; }

        public int DaysOfWork { get; set; }
    }
}
