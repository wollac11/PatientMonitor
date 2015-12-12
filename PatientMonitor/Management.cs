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

        // Instantiate  Staff table adapter
        MonitorDBTableAdapters.StaffTableAdapter staffTableAdapter = new MonitorDBTableAdapters.StaffTableAdapter();

        // Instantiate  Shifts table adapter
        MonitorDBTableAdapters.ShiftsTableAdapter shiftsTableAdapter = new MonitorDBTableAdapters.ShiftsTableAdapter();

        // Instantiate  Response times table adapter
        MonitorDBTableAdapters.ResponseTimesTableAdapter responseTableAdapter = new MonitorDBTableAdapters.ResponseTimesTableAdapter();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Options m = new Options();
            m.Show();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            this.responseTimesTableAdapter.Fill(this.monitorDB.ResponseTimes);
            this.shiftsTableAdapter1.Fill(this.monitorDB.Shifts);

        }
    }
}
