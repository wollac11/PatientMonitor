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
        public void csvWriter(string timer)
        {
            //path to where the file will save
            //got help from:
            //http://stackoverflow.com/questions/20997716/how-to-edit-text-file-in-resources-folder-of-window-form-c-sharp
            string fileAddress = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimerRecords.csv");

            //delimiter to space the time apart
            string delimiter = ",";

            string file = "Timer Records.csv";
            //create an array to store time
            string[] timeData = new string[] { "Time taken to disable alarm:", timer };

            //create a string builder to use for the array
            StringBuilder stringbuild = new StringBuilder();

            //write to file
            using (StreamWriter sw = new StreamWriter("TimerRecords.csv"))
            {
                stringbuild.AppendLine(string.Join(delimiter, timer));
                File.AppendAllText(file, stringbuild.ToString());

            }


            /*
            //create an array to collect both alarms that go above and below limits
            string[][] alarmTimes = new string[][]
            {
                new string [] {"Alarm times gone above limits", above},
                new string [] {"Alarm times gone below limits", _below}
            };

            int arrayLength = alarmTimes.GetLength(0);
            StringBuilder stringbuild = new StringBuilder();
            for (int i = 0; i < arrayLength; i++)
            {
                stringbuild.AppendLine(string.Join(delimiter, alarmTimes[i]));
            }

            File.AppendAllText(fileAddress, stringbuild.ToString());
            */

        }
    }
}