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
            // Initialize Monitor
            InitializeComponent();
            applyInitialThresholds();
            // Initialize Sensor
            Sensor.initialize();
            // Set attending staff display to current user
            lblStaffName.Text = _curStaff;
        }

        /* -------- Variable Declaration & Assignment -------- */

        // Intialise jagged array of multidimensional arrays holding min and max alarm
        // thresholds for each of the patient vitals
        int[][,] alarmThreshold = new int[8][,]
        {
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
            new int[5,2],
        };

        // Vital stats for currently proccessing bed
        double[] curStat = new double[5];
        // Boolean alarm limit flags for each bed
        public static bool[] pastThreshold = new bool[8];

        // Shift details
        public DateTime startTime;
        public int staffID;
        public int shiftID;

        // Instantiate Shifts table adapter
        MonitorDBTableAdapters.ShiftsTableAdapter shiftsTableAdapter = new MonitorDBTableAdapters.ShiftsTableAdapter();

        /* -------- Event Handlers -------- */

        // Update alarm threshold labels when sliders moved
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
        /// Opens options form to toggle modules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Options>().Any())
            {
                Options m = new Options();
                m.Show();
            }
            else Application.OpenForms.OfType<Options>().FirstOrDefault().Focus();
        }

        /// <summary>
        /// Polls sensors (once a second)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            checkVitals();
        }

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

        /// <summary>
        /// Stops monitor and logs out current attenting staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Confirm that user really wants to close the monitor
            DialogResult dialogResult = MessageBox.Show("Patient monitoring will be stopped. Are you sure?", "Close Monitor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // If central monitoring station is open
                if (Application.OpenForms.OfType<CentralStation>().Any())
                {
                    // Close central station
                    Application.OpenForms.OfType<CentralStation>().FirstOrDefault().Close();
                }

                // Save shift end time
                shiftsTableAdapter.Update(startTime, DateTime.Now, staffID, shiftID, startTime, null, staffID);

                // Close the monitor
                this.Close();
            }
        }

        /// <summary>
        /// Opens central overview station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStation_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<CentralStation>().Any())
            {
                CentralStation m = new CentralStation();
                m.Show();
            }
            else Application.OpenForms.OfType<CentralStation>().FirstOrDefault().Focus();
        }

        /// <summary>
        /// Switches monitor to selected patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBed.SelectedIndex > -1)
            {
                // Poll sensors
                timerRefresh.Enabled = true;
                // Update bed selection
                updateSelection();
                // Update slider values
                updateSliders();
            }
            // Stop polling sensors
            else timerRefresh.Enabled = false;
        }

        /* -------- Main Methods -------- */

        /// <summary>
        /// Updates display with sensor values for enabled modules
        /// </summary>
        private void updateDisplay()
        {
            // Only procceed if a bed is selected 
            if (cbxBed.SelectedIndex > -1)
            {
                if (_hrEnable == true) heartRate.Text = curStat[0].ToString();
                else heartRate.Text = "---";
                if (_breathEnable == true) breathingRate.Text = curStat[1].ToString();
                else breathingRate.Text = "---";
                if (_pressureEnable == true)
                {
                    bloodPressure.Text = curStat[2].ToString();
                    lblDiaPressure.Text = curStat[3].ToString();
                }
                else
                {
                    bloodPressure.Text = "---";
                    lblDiaPressure.Text = "---";
                }
                if (_tempEnable == true) temperature.Text = curStat[4].ToString();
                else temperature.Text = "---";
            }
            
        }

        /// <summary>
        /// Compares all threshold values with sensor values and sets
        /// their status. Also calls alarm trigger if currently monitored
        /// bed is one of those past its thresholds.
        /// </summary>
        private void checkVitals()
        {
            for (int i = 0; i <= 7; i++)
            {
                pastThreshold[i] = false;

                if (_hrEnable == true)
                {
                    // Check heart rate
                    curStat[0] = Sensor.getHeartRate(i);
                    // Mark as past threshold if current value above or below min/max
                    if (curStat[0] < alarmThreshold[i][0, 0] || curStat[0] > alarmThreshold[i][0, 1]) pastThreshold[i] = true;
                }

                if (_breathEnable == true)
                {
                    // Check breathing rate
                    curStat[1] = Sensor.getBreathRate(i);
                    // Place alarm if past min or max threshold
                    if (curStat[1] < alarmThreshold[i][1, 0] || curStat[1] > alarmThreshold[i][1, 1]) pastThreshold[i] = true;
                }

                if (_pressureEnable == true)
                {
                    // Check systolic pressure
                    curStat[2] = Sensor.getSysPressure(i);
                    // Place alarm if past min or max threshold
                    if (curStat[2] < alarmThreshold[i][2, 0] || curStat[2] > alarmThreshold[i][2, 1]) pastThreshold[i] = true;

                    // Check diastolic pressure
                    curStat[3] = Sensor.getDiaPressure(i);
                    // Place alarm if past min or max threshold
                    if (curStat[3] < alarmThreshold[i][3, 0] || curStat[3] > alarmThreshold[i][3, 1]) pastThreshold[i] = true;
                }

                if (_tempEnable == true)
                {
                    // Check temperature
                    curStat[4] = Sensor.getBodyTemp(i);
                    // Place alarm if past min or max threshold
                    if (curStat[4] < alarmThreshold[i][4, 0] || curStat[4] > alarmThreshold[i][4, 1]) pastThreshold[i] = true;
                }

                if (i == _curBed)
                {
                    updateDisplay();
                }
            }

            // If the currently monitored bed has excceed thresholds place an alarm
            if (pastThreshold[_curBed] == true) placeAlarm();
        }

        /// <summary>
        /// Places new alarm (if there isn't one already)
        /// </summary>
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

        /// <summary>
        /// Sets all beds to default alarm thresholds
        /// </summary>
        private void applyInitialThresholds()
        {
            for (int i = 0; i <= 7; i++)
            {
                setThresholds(i);
            }
        }

        /// <summary>
        /// Applies alarm thresholds
        /// </summary>
        /// <param name="bed">Chosen bed</param>
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

        /// <summary>
        /// Updates bed selection for monitoring
        /// </summary>
        private void updateSelection()
        {
            _curBed = cbxBed.SelectedIndex;
        }

        /// <summary>
        /// Updates slider settings to saved alarm thresholds
        /// for current bed
        /// </summary>
        private void updateSliders()
        {
            // Set heart rate sliders to thresholds
            tbrHRMin.Value = alarmThreshold[_curBed][0, 0];
            tbrHRMax.Value = alarmThreshold[_curBed][0, 1];

            // Set breathing rate sliders to thresholds
            tbrBRMin.Value = alarmThreshold[_curBed][1, 0];
            tbrBRMax.Value = alarmThreshold[_curBed][1, 1];

            // Set Systolic pressure sliders to thresholds
            tbrSysPressureMin.Value = alarmThreshold[_curBed][2, 0];
            tbrSysPressureMax.Value = alarmThreshold[_curBed][2, 1];

            // Set Diastolic pressure sliders to thresholds
            tbrDiaPressureMin.Value = alarmThreshold[_curBed][3, 0];
            tbrDiaPressureMax.Value = alarmThreshold[_curBed][3, 1];

            // Set temperature sliders to thresholds
            tbrTempMin.Value = alarmThreshold[_curBed][4, 0];
            tbrTempMax.Value = alarmThreshold[_curBed][4, 1];
        }

        /* -------- Class Properties -------- */

        // Pulse rate module status
        static bool _hrEnable = true;
        public static bool hrEnable
        {
            get { return _hrEnable; }
            set { _hrEnable = value;}
        }

        // Blood pressure module status
        static bool _pressureEnable = true;
        public static bool pressureEnable
        {
            get { return _pressureEnable; }
            set { _pressureEnable = value; }
        }

        // Breathing rate module status
        static bool _breathEnable = true;
        public static bool breathEnable
        {
            get { return _breathEnable; }
            set { _breathEnable = value; }
        }

        // Body temp module status
        static bool _tempEnable = true;
        public static bool tempEnable
        {
            get { return _tempEnable; }
            set { _tempEnable = value; }
        }

        // Curent bed being monitored
        static int _curBed;
        public static int curBed
        {
            get { return _curBed; }
        }

        // Current attending staff member
        static string _curStaff;
        public static string curStaff
        {
            get { return _curStaff; }
            set { _curStaff = value; }
        }

    }
}
