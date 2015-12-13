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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        /* -------- Event Handlers -------- */

        /// <summary>
        /// Closes management interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fiils data grid views with database tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Management_Load(object sender, EventArgs e)
        {
            this.responseTimesTableAdapter.Fill(this.monitorDB.ResponseTimes);
            this.shiftsTableAdapter1.Fill(this.monitorDB.Shifts);
        }

        /// <summary>
        /// Opens new instance of staff creator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            NewUser m = new NewUser();
            m.Show();
        }
    }
}
