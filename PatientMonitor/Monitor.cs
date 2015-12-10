using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMonitor
{
    public partial class Monitor : Form
    {

        public Monitor()
        {
            InitializeComponent();
        }

        private void tbrHRMin_OnValueChanged(object sender, EventArgs e)
        {
            lblHRMin.Text = tbrHRMin.Value.ToString();
        }

        private void tbrHRMax_OnValueChanged(object sender, EventArgs e)
        {
            lblHRMax.Text = tbrHRMax.Value.ToString();
        }

        private void tbrBRMin_OnValueChanged(object sender, EventArgs e)
        {
            lblBRMin.Text = tbrBRMin.Value.ToString();
        }

        private void tbrBRMax_OnValueChanged(object sender, EventArgs e)
        {
            lblBRMax.Text = tbrBRMax.Value.ToString();
        }

        private void tbrTempMin_OnValueChanged(object sender, EventArgs e)
        {
            lblTempMin.Text = tbrTempMin.Value.ToString();
        }

        private void tbrTempMax_OnValueChanged(object sender, EventArgs e)
        {
            lblTempMax.Text = tbrTempMax.Value.ToString();
        }

        private void tbrSysPressureMin_OnValueChanged(object sender, EventArgs e)
        {
            lblSysPressureMin.Text = tbrSysPressureMin.Value.ToString();
        }

        private void tbrSysPressureMax_OnValueChanged(object sender, EventArgs e)
        {
            lblSysPressureMax.Text = tbrSysPressureMax.Value.ToString();
        }

        private void tbrDiaPressureMin_OnValueChanged(object sender, EventArgs e)
        {
            lblDiaPressureMin.Text = tbrDiaPressureMin.Value.ToString();
        }
        private void tbrDiaPressureMax_OnValueChanged(object sender, EventArgs e)
        {
            lblDiaPressureMax.Text = tbrDiaPressureMax.Value.ToString();
        }

        int[] minThreshold = new int[5];
        int[] maxThreshold = new int[5];

        /// <summary>
        /// Applies min and max alarm thresholds for current patient vitals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            // Apply threshold values only if a bed is selected 
            if (cbxBed.SelectedIndex > -1)
            {
                // Set heart rate thresholds
                minThreshold[0] = tbrHRMin.Value;
                maxThreshold[0] = tbrHRMax.Value;

                // Set breathing rate thresholds
                minThreshold[1] = tbrBRMin.Value;
                maxThreshold[1] = tbrBRMax.Value;

                // Set Systolic pressure thresholds
                minThreshold[2] = tbrSysPressureMin.Value;
                maxThreshold[2] = tbrSysPressureMax.Value;

                // Set Diastolic pressure thresholds
                minThreshold[3] = tbrDiaPressureMin.Value;
                maxThreshold[3] = tbrDiaPressureMax.Value;

                // Set temperature thresholds
                minThreshold[4] = tbrTempMin.Value;
                maxThreshold[4] = tbrTempMax.Value;
            }
            else
            {
                MessageBox.Show("Error: You must select a bed first.", "No bed selected!");
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options m = new Options();
            m.Show();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            updateDisplay();
            checkAlarm();
        }

        // Updates display with sensor values for enabled modules
        private void updateDisplay()
        {
            // Only procceed if a bed is selected 
            if (cbxBed.SelectedIndex > -1)
            {
                if (_hrEnable == true) heartRate.Text = Sensor.heartRate.ToString();
                else heartRate.Text = "---";
                if (_tempEnable == true) temperature.Text = Sensor.bodyTemp.ToString();
                else temperature.Text = "---";
                if (_breathEnable == true) breathingRate.Text = Sensor.breathRate.ToString();
                else breathingRate.Text = "---";
                if (_pressureEnable == true)
                {
                    bloodPressure.Text = Sensor.sysPressure.ToString();
                    lblDiaPressure.Text = Sensor.diaPressure.ToString();
                }
                else
                {
                    bloodPressure.Text = "---";
                    lblDiaPressure.Text = "---";
                }
            }
            
        }

        private void checkAlarm()
        {
            if (_hrEnable == true)
            {
                // Check heart rate
                int curHR = int.Parse(heartRate.Text);
                // Place alarm if past min or max threshold
                if (curHR < minThreshold[0] || curHR > maxThreshold[0]) placeAlarm();
            }

            if (_breathEnable == true)
            {
                // Check breathing rate
                int curBR = int.Parse(breathingRate.Text);
                // Place alarm if past min or max threshold
                if (curBR < minThreshold[1] || curBR > maxThreshold[1]) placeAlarm();
            }

            if (_pressureEnable == true)
            {
                // Check systolic pressure
                int curSys = int.Parse(bloodPressure.Text);
                // Place alarm if past min or max threshold
                if (curSys< minThreshold[2] || curSys > maxThreshold[2]) placeAlarm();

                // Check diastolic pressure
                int curDia = int.Parse(lblDiaPressure.Text);
                // Place alarm if past min or max threshold
                if (curDia < minThreshold[3] || curDia > maxThreshold[3]) placeAlarm();
            }

            if (_tempEnable == true)
            {
                // Check temperature
                double curTemp = (double.Parse(temperature.Text));
                // Place alarm if past min or max threshold
                if (curTemp < minThreshold[4] || curTemp > maxThreshold[4]) placeAlarm();
            }
        }

        private void placeAlarm()
        {
            // If there isnt already an alarm
            if (!Application.OpenForms.OfType<Alarm>().Any())
            {
                //PLACE ALARM
                Alarm m = new Alarm();
                m.Show();
            }
        }

        static bool _hrEnable = true;
        public static bool hrEnable
        {
            get { return _hrEnable; }
            set { _hrEnable = value;}
        }

        static bool _pressureEnable = true;
        public static bool pressureEnable
        {
            get { return _pressureEnable; }
            set { _pressureEnable = value; }
        }

        static bool _breathEnable = true;
        public static bool breathEnable
        {
            get { return _breathEnable; }
            set { _breathEnable = value; }
        }

        static bool _tempEnable = true;
        public static bool tempEnable
        {
            get { return _tempEnable; }
            set { _tempEnable = value; }
        }

        static int _curbed;
        public static int curBed
        {
            get { return _curbed; }
        }

        private void updateSelection()
        {
            _curbed = cbxBed.SelectedIndex + 1;
        }

        private void cbxBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBed.SelectedIndex > -1)
            {
                Sensor.initialize();
                timerRefresh.Enabled = true;
                updateSelection();
            }
            else timerRefresh.Enabled = false;
        }
    }
}
