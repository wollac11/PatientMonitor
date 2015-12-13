using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PatientMonitor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Instantiate  Staff table adapter
        MonitorDBTableAdapters.StaffTableAdapter staffTableAdapter = new MonitorDBTableAdapters.StaffTableAdapter();

        // Instantiate  Shifts table adapter
        MonitorDBTableAdapters.ShiftsTableAdapter shiftsTableAdapter = new MonitorDBTableAdapters.ShiftsTableAdapter();

        // Bool to set desired form
        public bool management;

        /* -------- Event Handlers -------- */

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close login box
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check user inputs are valid
            checkDetails();
        }

        /* -------- Main Methods -------- */

        /// <summary>
        /// Validates username and password
        /// </summary>
        private void checkDetails()
        {
            string password = staffTableAdapter.PasswordQuery(txtUser.Text);
            {
                if (Password.verify(txtPass.Text, password))
                {
                    loginSuccess();
                }
                else
                {
                    loginFail();
                }
            }

        }

        /// <summary>
        /// Logs user into the requested interface
        /// </summary>
        private void loginSuccess()
        {
            // Get staffID
            int staffID = Convert.ToInt32(staffTableAdapter.StaffIDQuery(txtUser.Text));
            // Launch requested interface
            if (management == true)
            {
                // Verify user is a manager
                if (staffTableAdapter.PositionQuery(staffID) == "Manager")
                {
                    // Launch management interface
                    Management m = new Management();
                    m.Show();
                }
                // Deny user access
                else MessageBox.Show("Sorry you are not authorised to access the management interface.","Access Denined");
            }
            else
            {
                // Get time
                DateTime time = DateTime.Now;
                // Record login
                shiftsTableAdapter.Insert(time, null, staffID);
                // Set attending staff
                Monitor.curStaff = txtUser.Text;
                // Create new monitor
                Monitor m = new Monitor();
                // Set monitor attending staff shift details
                m.startTime = time;
                m.staffID = staffID;
                m.shiftID = Convert.ToInt32(shiftsTableAdapter.LatestShiftID());
                // Launch monitor
                m.Show();
            }

            // Close login box
            this.Close();
        }

        /// <summary>
        /// Refuses login for and resets input fields
        /// </summary>
        private void loginFail()
        {
            // Alert of failure
            MessageBox.Show("Sorry, username/password combination is incorrect! Please try again.", "Login Failure");

            // Clear input
            txtUser.Text = "";
            txtPass.Text = "";
        }

    }
}
