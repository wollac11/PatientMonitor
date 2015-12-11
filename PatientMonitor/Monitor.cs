﻿using System;
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
            applyInitialThresholds();
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

        int[][,] alarmThreshold = new int[10][,]
        {
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],

        };

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
                // Set alarm thresholds for currently selected bed
                setThresholds(_curBed);
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
                if (curHR < alarmThreshold[_curBed][0,0] || curHR > alarmThreshold[_curBed][0, 1]) placeAlarm();
            }

            if (_breathEnable == true)
            {
                // Check breathing rate
                int curBR = int.Parse(breathingRate.Text);
                // Place alarm if past min or max threshold
                if (curBR < alarmThreshold[_curBed][1, 0] || curBR > alarmThreshold[_curBed][1, 1]) placeAlarm();

            }

            if (_pressureEnable == true)
            {
                // Check systolic pressure
                int curSys = int.Parse(bloodPressure.Text);
                // Place alarm if past min or max threshold
                if (curSys < alarmThreshold[_curBed][2, 0] || curSys > alarmThreshold[_curBed][2, 1]) placeAlarm();


                // Check diastolic pressure
                int curDia = int.Parse(lblDiaPressure.Text);
                // Place alarm if past min or max threshold
                if (curDia < alarmThreshold[_curBed][3, 0] || curDia > alarmThreshold[_curBed][3, 1]) placeAlarm();

            }

            if (_tempEnable == true)
            {
                // Check temperature
                double curTemp = double.Parse(temperature.Text);
                // Place alarm if past min or max threshold
                if (curTemp < alarmThreshold[_curBed][4, 0] || curTemp > alarmThreshold[_curBed][4, 1]) placeAlarm();

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

        static int _curBed;
        public static int curBed
        {
            get { return _curBed; }
        }

        private void updateSelection()
        {
            _curBed = cbxBed.SelectedIndex;
            Sensor.initialize();
        }

        private void cbxBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBed.SelectedIndex > -1)
            {
                timerRefresh.Enabled = true;
                updateSelection();
            }
            else timerRefresh.Enabled = false;
        }

        private void applyInitialThresholds()
        {
            for (int i = 0; i <= 9; i++)
            {
                setThresholds(i);
            }
        }

        private void setThresholds(int bed)
        {
            // Set heart rate thresholds
            alarmThreshold[bed][0, 0] = tbrHRMin.Value;
            alarmThreshold[bed][0, 1] = tbrHRMax.Value;

            // Set breathing rate thresholds
            alarmThreshold[bed][1, 0] = tbrBRMin.Value;
            alarmThreshold[bed][1, 1] = tbrBRMax.Value;

            // Set Systolic pressure thresholds
            alarmThreshold[bed][2, 0] = tbrSysPressureMin.Value;
            alarmThreshold[bed][2, 1] = tbrSysPressureMax.Value;

            // Set Diastolic pressure thresholds
            alarmThreshold[bed][3, 0] = tbrDiaPressureMin.Value;
            alarmThreshold[bed][3, 1] = tbrDiaPressureMax.Value;

            // Set temperature thresholds
            alarmThreshold[bed][4, 0] = tbrTempMin.Value;
            alarmThreshold[bed][4, 1] = tbrTempMax.Value;
        }
    }
}
