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

        // Vars for retaining previous readings
        private static int prevDia = 0;
        private static int prevSys = 0;
        private static int prevHR = 0;
        private static int prevBr = 0;
        private static double prevTemp = 0;

        public static double bodyTemp
        {
            get { return _bodyTemp(); }
        }

        public static int heartRate
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

        public static void initialize()
        {
            prevDia = 0;
            prevSys = 0;
            prevHR = 0;
            prevTemp = 0;
            prevBr = 0;
        }

        private static int _diaPressure() 
        {
            if (prevDia == 0)
            {
                prevDia = r.Next(50, 80);
            }
            else
            {
                prevDia = r.Next(prevDia - 2, prevDia + 3);
            }

            return prevDia;
        }

        private static int _sysPressure()
        {
            if (prevSys == 0)
            {
                prevSys = r.Next(80, 130);
            }
            else
            {
                prevSys = r.Next(prevSys - 2, prevSys + 3);
            }

            return prevSys;
        }

        private static int _heartRate()
        {
            if (prevHR == 0)
            {
                prevHR = r.Next(70, 85);
            }
            else
            {
                int rand = r.Next(0, 2);
                switch (rand)
                {
                    case 0:
                        prevHR = prevHR + r.Next(0, 2); break;
                    case 1:
                        prevHR = prevHR - r.Next(0, 2);  break;
                }
            }

            return prevHR;
        }

        private static int _breathRate()
        {
            if (prevBr == 0)
            {
                prevBr = r.Next(14, 20);
            }
            else
            {
                int rand = r.Next(0, 2);
                double dec = r.Next(0, 10);
                switch (rand)
                {
                    case 0:
                        prevBr = Convert.ToInt16(Math.Round(prevBr + (dec / 10))); break;
                    case 1:
                        prevBr = Convert.ToInt16(Math.Round(prevBr - (dec / 10))); break;
                }
            }

            return prevBr;
        }

        private static double _bodyTemp()
        {
            int integralPart = 0;
            int decimalPart = r.Next(0, 10);

            if (prevTemp == 0)
            {
                integralPart = r.Next(35, 38);
            }
            else
            {
                int rand = r.Next(0, 3);
                switch (rand)
                {
                    case 0:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp) + (r.Next(0, 2))); break;
                    case 1:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp) - (r.Next(0, 2))); break;
                    case 2:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp)); break;
                }
            }

            prevTemp = double.Parse(integralPart.ToString() + "." + decimalPart.ToString());
            return prevTemp;
        }

    }
}
