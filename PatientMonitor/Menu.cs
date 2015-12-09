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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Confirm if user really wants to exit the application
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Exit the application
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Options m = new Options();
            m.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Management m = new Management();
            m.Show();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            Monitor m = new Monitor();
            m.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About m = new About();
            m.Show();
        }
    }
}
