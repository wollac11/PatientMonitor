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

        /* -------- Event Handlers -------- */

        /// <summary>
        /// Exits the application (pending user confirmation)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Confirm that user really wants to exit the application
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Exit the application
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// Opens the management interface with login request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManage_Click(object sender, EventArgs e)
        {
            // Procceed of no login prompt is currently open
            if (!Application.OpenForms.OfType<Login>().Any())
            {
                Login m = new Login();
                m.management = true;
                m.Show();
            }
        }

        /// <summary>
        /// Opens the monitor interface with login request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            // Procceed of no login prompt is currently open
            if (!Application.OpenForms.OfType<Login>().Any())
            {
                Login m = new Login();
                m.management = false;
                m.Show();
            }
        }

        /// <summary>
        /// Opens the program about screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About m = new About();
            m.Show();
        }
    }
}
