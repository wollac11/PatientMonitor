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

        private void btnSet_Click(object sender, EventArgs e)
        {
          
            //call MinRate and MaxRate
            MinRate(tbrHRMin, heartRate);
            MaxRate(tbrHRMax, heartRate);

            //call MinRate and MaxRate
            MinRate(tbrBRMin, breathingRate);
            MaxRate(tbrBRMax, breathingRate);

            //call MinRate and MaxRate
            MinRate(tbrSysPressureMin, bloodPressure);
            MaxRate(tbrSysPressureMax, bloodPressure);

            //call MinRate and MaxRate
            MinRate(tbrDiaPressureMin, lblDiaPressure);
            MaxRate(tbrDiaPressureMax, lblDiaPressure);

            //call MinRate and MaxRate
            MinRate(tbrTempMin, temperature);
            MaxRate(tbrTempMax, temperature);
        }

        //limit alarms
        bool alarmLimit = false;

        //reset alarm
        public void AlarmLimit ()
        {
            alarmLimit = false;
        }


        /// <summary>
        /// The Minimum limit for the alarm
        /// </summary>
        /// <param name="tbrLimit">The limit that is the user inputs</param>
        /// <param name="lblRate">one of the 4 body rates</param>
        private void MinRate(TrackBar tbrLimit, Label lblRate)
        {
            //convert to int
            int limit = Convert.ToInt32(tbrLimit.Value);
            int rate = Convert.ToInt32(lblRate.Text);

            //when rate goes below min
            if (rate < limit)
            {
                //Limit alarm to 1
                if (alarmLimit == false)
                {
                    //PLACE ALARM
                    AlarmBelow m = new AlarmBelow();
                    m.Show();
                    alarmLimit = true;
                }
                //MessageBox.Show("Patient is BELOW limit");
            }
        }

        /// <summary>
        /// The Maximum limit for the alarm
        /// </summary>
        /// <param name="tbrLimit">The limit that is the user inputs</param>
        /// <param name="lblRate">one of the 4 body rates</param>
        private void MaxRate(TrackBar tbrLimit, Label lblRate)
        {
            //convert to int
            int limit = Convert.ToInt32(tbrLimit.Value);
            int rate = Convert.ToInt32(lblRate.Text);

            //when rate goes below min
            if (rate > limit)
            {
                //limit alarm to 1
                if (alarmLimit == false)
                {
                    //PLACE ALARM
                    AlarmAbove m = new AlarmAbove();
                    m.Show();
                    alarmLimit = true;
                }
                //MessageBox.Show("Patient is ABOVE limit");
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
    }
}
