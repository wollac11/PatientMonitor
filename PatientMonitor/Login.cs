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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Bool to set desired form
        public bool management;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close login box
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkDetails();
        }

        private void checkDetails()
        {
            loginSuccess();
        }

        private void loginSuccess()
        {
            // Launch requested interface
            if (management == true)
            {
                Management m = new Management();
                m.Show();
            }
            else
            {
                Monitor.curNurse = txtUser.Text;
                Monitor m = new Monitor();
                m.Show();
            }

            // Close login box
            this.Close();
        }

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
