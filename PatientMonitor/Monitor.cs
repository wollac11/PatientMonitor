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

        /// <summary>
        /// send all the patient details and custom limits through MinRate and MaxRate method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            // Apply threshold values only if a bed is selected 
            if (cbxBed.SelectedIndex > -1)
            {
                if (_hrEnable == true)
                {
                    //call MinRate and MaxRate
                    MinRate(tbrHRMin, heartRate);
                    MaxRate(tbrHRMax, heartRate);
                }

                if (_breathEnable == true)
                {
                    //call MinRate and MaxRate
                    MinRate(tbrBRMin, breathingRate);
                    MaxRate(tbrBRMax, breathingRate);
                }
                    
                if (_pressureEnable == true)
                {
                    //call MinRate and MaxRate
                    MinRate(tbrSysPressureMin, bloodPressure);
                    MaxRate(tbrSysPressureMax, bloodPressure);

                    //call MinRate and MaxRate
                    MinRate(tbrDiaPressureMin, lblDiaPressure);
                    MaxRate(tbrDiaPressureMax, lblDiaPressure);
                }

                if (_tempEnable == true)
                {
                    //call MinRate and MaxRate
                    MinRate(tbrTempMin, temperature);
                    MaxRate(tbrTempMax, temperature);
                }
                
            }
            else
            {
                MessageBox.Show("Error: You must select a bed first.", "No bed selected!");
            }

           
        }
        /// <summary>
        /// The Minimum limit for the alarm
        /// </summary>
        /// <param name="tbrLimit">The limit that is the user inputs</param>
        /// <param name="lblRate">one of the 4 body rates</param>
        private void MinRate(TrackBar tbrLimit, Label lblRate)
        {
            // Convert to double
            Double limit = Convert.ToDouble(tbrLimit.Value);
            Double rate = Convert.ToDouble(lblRate.Text);

            //when rate goes below min
            if (rate < limit)
            {
                //if there isnt already an alarm
                //help from http://stackoverflow.com/questions/13445155/how-to-check-if-form-is-open-if-open-close-form
                if (!Application.OpenForms.OfType<AlarmBelow>().Any())
                {
                    //PLACE ALARM
                    AlarmBelow m = new AlarmBelow();
                    m.Show();
                }
            }
        }

        /// <summary>
        /// The Maximum limit for the alarm
        /// </summary>
        /// <param name="tbrLimit">The limit that is the user inputs</param>
        /// <param name="lblRate">one of the 4 body rates</param>
        private void MaxRate(TrackBar tbrLimit, Label lblRate)
        {
            // Convert to double
            Double limit = Convert.ToDouble(tbrLimit.Value);
            Double rate = Convert.ToDouble(lblRate.Text);

            //when rate goes below min
            if (rate > limit)
            {
                //if there isnt already an alarm
                if (!Application.OpenForms.OfType<AlarmAbove>().Any())
                {
                    //PLACE ALARM
                    AlarmAbove m = new AlarmAbove();
                    m.Show();
                }
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
        }

        private void updateDisplay()
        {
            // Updates display with enabled sensor values only if a bed is selected 
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

    }
}
