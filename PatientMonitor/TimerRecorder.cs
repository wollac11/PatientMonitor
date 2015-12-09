using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;

namespace PatientMonitor
{
    class TimerRecorder
    {

        public TimerRecorder()
        {

        }

        /// <summary>
        /// Write timers to CSV
        /// </summary>
        public void csvWriter(string timer)
        {
            // Path to save file
            string fileAddress = "Timer Records.csv";

            // Time record delimiter
            string delimiter = ",";

            // Build CSV string for response times
            StringBuilder stringbuild = new StringBuilder();
            stringbuild.AppendLine(string.Join(delimiter, timer));

            // Append string to file
            File.AppendAllText(fileAddress, stringbuild.ToString());
        }
    }
}