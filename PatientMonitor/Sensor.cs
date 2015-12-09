using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitor
{
    class Sensor
    {
        static Random r = new Random();

        public static double bodyTemp
        {
            get { return gen_sensor_data(r, 35, 40, true); }
        }

        public static double heartRate
        {
            get { return gen_sensor_data(r, 70, 85, false); }
        }

        public static double sysPressure
        {
            get { return gen_sensor_data(r, 80, 130, false); }
        }

        public static double diaPressure
        {
            get { return gen_sensor_data(r, 50, 80, false); }
        }

        public static double breathRate
        {
            get { return gen_sensor_data(r, 14, 20, false); }
        }

        private static double gen_sensor_data(Random rand, int min, int max, bool dec)
        {
            int integralPart = rand.Next(min, max);

            if (dec == true)
            {
                int decimalPart = rand.Next(0, 9);
                return double.Parse(integralPart.ToString() + "." + decimalPart.ToString());
            }
            else
            {
                return integralPart;
            }

        }

    }
}
