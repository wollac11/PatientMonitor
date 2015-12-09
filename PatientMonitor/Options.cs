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
    public partial class Options : Form
    {
        //public static bool heartRate;
        public Options()
        {
            InitializeComponent();
            setCheckBoxes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            applyOptions();
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About m = new About();
            m.Show();
        }

        // Sets checkbox values to their corresponding monitor properties
        private void setCheckBoxes()
        {
            ckbHeartRate.Checked = Monitor.hrEnable;
            cbxTemp.Checked = Monitor.tempEnable;
            cbxBreath.Checked = Monitor.breathEnable;
            cbxBloodPressure.Checked = Monitor.pressureEnable;
        }

        // Sets monitor propertiees to their corresponding checkbox values
        private void applyOptions()
        {
            Monitor.hrEnable = ckbHeartRate.Checked;
            Monitor.tempEnable = cbxTemp.Checked;
            Monitor.breathEnable = cbxBreath.Checked;
            Monitor.pressureEnable = cbxBloodPressure.Checked;
        }
    }
}
