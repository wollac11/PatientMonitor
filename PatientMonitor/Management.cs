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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            this.responseTimesTableAdapter.Fill(this.monitorDB.ResponseTimes);
            this.shiftsTableAdapter1.Fill(this.monitorDB.Shifts);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            NewUser m = new NewUser();
            m.Show();
        }
    }
}
