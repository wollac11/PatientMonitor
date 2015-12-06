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
        //collect timer data from Alarm Above
        AlarmAbove alarmAbove = new AlarmAbove();

        //Collect timer data from Alarm Below
        AlarmBelow alarmBelow = new AlarmBelow();

        /// <summary>
        /// write timers to csv
        /// </summary>
        public void csvWriter()
        {
            //path to where the file will save
            string fileAddress = "c:\\TimerRecords.csv";
            //delimiter to space the time apart
            string delimiter = ",";

            //collect time
            int above = alarmAbove.saveTimer;
            int below = alarmBelow.saveTimer;

            //parse ints to string
            string _above = above.ToString();
            string _below = below.ToString();


            string[][] alarmTimes = new string[][]
            {
                new string [] {"Alarm times gone above limits", _above},
                new string [] {"Alarm times gone below limits", _below}
            };

            int arrayLength = alarmTimes.GetLength(0);
            StringBuilder stringbuild = new StringBuilder();
            for(int i = 0; i < arrayLength; i++)
            {
                stringbuild.AppendLine(string.Join(delimiter, alarmTimes[i]));
            }

            File.WriteAllText(fileAddress, stringbuild.ToString());

        }
    }
}