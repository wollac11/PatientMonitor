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
            Panel[] panel = { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8 };

            for (int i = 0; i <= 7; i++)
            {
                if (Monitor.pastThreshold[i] == true) panel[i].BackColor = Color.Red;
                else panel[i].BackColor = Color.Green;
            }
        }
    }
}
