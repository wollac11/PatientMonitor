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
        public Options()
        {
            InitializeComponent();
            // Initialise checkbox states
            setCheckBoxes();
        }

        /// <summary>
        /// Sets module status properties and closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            applyOptions();
            this.Close();
        }

        /// <summary>
        /// Opens program about screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About m = new About();
            m.Show();
        }

        /// <summary>
        /// Sets checkbox values to their corresponding monitor properties
        /// </summary>
        private void setCheckBoxes()
        {
            ckbHeartRate.Checked = Monitor.hrEnable;
            cbxTemp.Checked = Monitor.tempEnable;
            cbxBreath.Checked = Monitor.breathEnable;
            cbxBloodPressure.Checked = Monitor.pressureEnable;
        }

        /// <summary>
        /// Sets monitor propertiees to their corresponding checkbox values
        /// </summary>
        private void applyOptions()
        {
            Monitor.hrEnable = ckbHeartRate.Checked;
            Monitor.tempEnable = cbxTemp.Checked;
            Monitor.breathEnable = cbxBreath.Checked;
            Monitor.pressureEnable = cbxBloodPressure.Checked;
        }
    }
}
