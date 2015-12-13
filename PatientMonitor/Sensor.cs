using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitor
{
    // A virtual sensor which generates readings for a range of patient vitals
    class Sensor
    {
        /* -------- Variable Declaration & Assignment -------- */

        // Generate new random instance
        static Random r = new Random();

        // Arrays for retaining previous readings
        static int[] prevDia = new int[8];
        static int[] prevSys = new int[8];
        static int[] prevHR = new int[8];
        static int[] prevBr = new int[8];
        static double[] prevTemp = new double[8];

        /* -------- Main Methods -------- */

        /// <summary>
        /// Clears all previous readings and starts afresh
        /// </summary>
        public static void initialize()
        {
            for (int i = 0; i <= 7; i++)
            {
                prevDia[i] = 0;
                prevSys[i] = 0;
                prevHR[i] = 0;
                prevBr[i] = 0;
                prevTemp[i] = 0;
            }
        }

        /// <summary>
        /// Generates a diastolic pressure reading
        /// </summary>
        /// <param name="i">Bed number</param>
        public static int getDiaPressure(int i) 
        {
            if (prevDia[i] == 0)
            {
                prevDia[i] = r.Next(50, 80);
            }
            else
            {
                prevDia[i] = r.Next(prevDia[i] - 2, prevDia[i] + 3);
            }

            return prevDia[i];
        }

        /// <summary>
        /// Generates a systolic pressure reading
        /// </summary>
        /// <param name="i">Bed number</param>
        public static int getSysPressure(int i)
        {
            if (prevSys[i] == 0)
            {
                prevSys[i] = r.Next(80, 130);
            }
            else
            {
                prevSys[i] = r.Next(prevSys[i] - 2, prevSys[i] + 3);
            }

            return prevSys[i];
        }

        /// <summary>
        /// Generates a pulse rate reading
        /// </summary>
        /// <param name="i">Bed number</param>
        public static int getHeartRate(int i)
        {
            if (prevHR[i] == 0)
            {
                prevHR[i] = r.Next(70, 85);
            }
            else
            {
                int rand = r.Next(0, 2);
                switch (rand)
                {
                    case 0:
                        prevHR[i] = prevHR[i] + r.Next(0, 2); break;
                    case 1:
                        prevHR[i] = prevHR[i] - r.Next(0, 2);  break;
                }
            }

            return prevHR[i];
        }

        /// <summary>
        /// Generates a breathing rate reading
        /// </summary>
        /// <param name="i">Bed number</param>
        public static int getBreathRate(int i)
        {
            if (prevBr[i] == 0)
            {
                prevBr[i] = r.Next(14, 20);
            }
            else
            {
                int rand = r.Next(0, 2);
                double dec = r.Next(0, 10);
                switch (rand)
                {
                    case 0:
                        prevBr[i] = Convert.ToInt16(Math.Round(prevBr[i] + (dec / 10))); break;
                    case 1:
                        prevBr[i] = Convert.ToInt16(Math.Round(prevBr[i] - (dec / 10))); break;
                }
            }

            return prevBr[i];
        }

        /// <summary>
        /// Generates a body temperature reading
        /// </summary>
        /// <param name="i">Bed number</param>
        public static double getBodyTemp(int i)
        {
            int integralPart = 0;
            int decimalPart = r.Next(0, 10);

            if (prevTemp[i] == 0)
            {
                integralPart = r.Next(35, 38);
            }
            else
            {
                int rand = r.Next(0, 3);
                switch (rand)
                {
                    case 0:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp[i]) + (r.Next(0, 2))); break;
                    case 1:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp[i]) - (r.Next(0, 2))); break;
                    case 2:
                        integralPart = Convert.ToInt16(Math.Truncate(prevTemp[i])); break;
                }
            }

            prevTemp[i] = double.Parse(integralPart.ToString() + "." + decimalPart.ToString());
            return prevTemp[i];
        }

    }
}
