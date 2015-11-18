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

        private void btn_Set_Click(object sender, EventArgs e)
        {
            //Pulse Rate Null Check
            if (string.IsNullOrWhiteSpace(pulseRate_Min.Text))
            {
                pulseRate_Min.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(pulseRate_Max.Text))
            {
                pulseRate_Max.Text = "0";
            }
            //call MinRate and MaxRate
            MinRate(pulseRate_Min, pulseRate);
            MaxRate(pulseRate_Max, pulseRate);

            //Breathing Rate Null Check
            if (string.IsNullOrWhiteSpace(breathingRate_Min.Text))
            {
                breathingRate_Min.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(breathingRate_Max.Text))
            {
                breathingRate_Max.Text = "0";
            }
            //call MinRate and MaxRate
            MinRate(breathingRate_Min, breathingRate);
            MaxRate(breathingRate_Max, breathingRate);

            //Blood Pressure Null Check
            if (string.IsNullOrWhiteSpace(bloodPressure_Min.Text))
            {
                bloodPressure_Min.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(bloodPressure_Max.Text))
            {
                bloodPressure_Max.Text = "0";
            }
            //call MinRate and MaxRate
            MinRate(bloodPressure_Min, bloodPressure);
            MaxRate(bloodPressure_Max, bloodPressure);

            //Temperature Null Check
            if (string.IsNullOrWhiteSpace(temperature_Min.Text))
            {
                temperature_Min.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(temperature_Max.Text))
            {
                temperature_Max.Text = "0";
            }
            //call MinRate and MaxRate
            MinRate(temperature_Min, temperature);
            MaxRate(temperature_Max, temperature);
        }

        /// <summary>
        /// The Minimum limit for the alarm
        /// </summary>
        /// <param name="tbLimit">The limit that is the user inputs</param>
        /// <param name="lbRate">one of the 4 body rates</param>
        private void MinRate(TextBox tbLimit, Label lbRate)
        {
            //convert to int
            int limit = Convert.ToInt32(tbLimit.Text);
            int rate = Convert.ToInt32(lbRate.Text);
            //when rate goes below min
            if (rate < limit)
            {
                //PLACE ALARM
                MessageBox.Show("Patient is BELOW limit");
            }
        }

        /// <summary>
        /// The Maximum limit for the alarm
        /// </summary>
        /// <param name="tbLimit">The limit that is the user inputs</param>
        /// <param name="lbRate">one of the 4 body rates</param>
        private void MaxRate(TextBox tbLimit, Label lbRate)
        {
            //convert to int
            int limit = Convert.ToInt32(tbLimit.Text);
            int rate = Convert.ToInt32(lbRate.Text);
            //when rate goes below min
            if (rate > limit)
            {
                //PLACE ALARM
                MessageBox.Show("Patient is ABOVE limit");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
