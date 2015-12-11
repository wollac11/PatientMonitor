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
    public partial class CentralStation : Form
    {
        public CentralStation()
        {
            InitializeComponent();

        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            // panel1.BackColor = Color.Crimson;
        }
    }
}
