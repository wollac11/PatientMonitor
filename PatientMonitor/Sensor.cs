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

        private static int prevDia = 0;
        private static int prevSys = 0;
        private static int prevHR = 0;
        private static int prevBr = 0;
        private static double prevTemp = 0;

        public static double bodyTemp
        {
            get { return _bodyTemp(); }
        }

        public static double heartRate
        {
            get { return _heartRate(); }
        }

        public static int sysPressure
        {
            get { return _sysPressure(); }
        }

        public static int diaPressure
        {
            get { return _diaPressure(); }
        }

        public static int breathRate
        {
            get { return _breathRate(); }
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

        private static int _diaPressure() 
        {
            if (prevDia == 0)
            {
                prevDia = Convert.ToInt16(gen_sensor_data(r, 50, 80, false));
            }
            else
            {
                prevDia = Convert.ToInt16(gen_sensor_data(r, prevDia - 2, prevDia + 3, false));
            }

            return prevDia;
        }

        private static int _sysPressure()
        {
            if (prevSys == 0)
            {
                prevSys = Convert.ToInt16(gen_sensor_data(r, 80, 130, false));
            }
            else
            {
                prevSys = Convert.ToInt16(gen_sensor_data(r, prevSys - 2, prevSys + 3, false));
            }

            return prevSys;
        }

        private static int _heartRate()
        {
            if (prevHR == 0)
            {
                prevHR = Convert.ToInt16(gen_sensor_data(r, 70, 85, false));
            }
            else
            {
                int rand = Convert.ToInt16(gen_sensor_data(r, 0, 2, false));

                switch (rand)
                {
                    case 0:
                        prevHR = prevHR + Convert.ToInt16(gen_sensor_data(r, 0, 2, false));
                        break;
                    case 1:
                        prevHR = prevHR - Convert.ToInt16(gen_sensor_data(r, 0, 2, false));
                        break;
                }
            }

            return prevHR;
        }

        private static int _breathRate()
        {
            if (prevBr == 0)
            {
                prevBr = Convert.ToInt16(gen_sensor_data(r, 14, 20, false));
            }
            else
            {
                int rand = Convert.ToInt16(gen_sensor_data(r, 0, 2, false));
                switch (rand)
                {
                    case 0:
                        prevBr = Convert.ToInt16(Math.Round(prevBr + (gen_sensor_data(r, 0, 10, false) / 10)));
                        break;

                    case 1:
                        prevBr = Convert.ToInt16(Math.Round(prevBr - (gen_sensor_data(r, 0, 10, false) / 10)));
                        break;
                }
            }

            return prevBr;
        }

        private static double _bodyTemp()
        {
            if (prevTemp == 0)
            {
                prevTemp = gen_sensor_data(r, 35, 39, true);
            }
            else
            {
                int rand = Convert.ToInt16(gen_sensor_data(r, 0, 2, false));
                int integralPart = 0;
                int decimalPart = Convert.ToInt16(gen_sensor_data(r, 0, 9, false));
                switch (rand)
                {
                    case 0:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp) + (gen_sensor_data(r, 0, 2, false)));
                        break;
                    case 1:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp) - (gen_sensor_data(r, 0, 2, false)));
                        break;
                }
                prevTemp = double.Parse(integralPart.ToString() + "." + decimalPart.ToString()); 
            }

            return prevTemp;
        }

    }
}
