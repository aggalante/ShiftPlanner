#region Copyright © 2014, Critical Health
// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ShiftPlanner.Controls
{
    public static class ControlExtensions
    {
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            if (aProp != null)
                aProp.SetValue(c, true, null);
        }

        /// <summary>
        /// Shuffles the element order of the specified list.
        /// </summary>
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
