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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close new user form
            this.Close();
        }

        // Instantiate  Staff table adapter
        MonitorDBTableAdapters.StaffTableAdapter staffTableAdapter = new MonitorDBTableAdapters.StaffTableAdapter();

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Verify user input and add user if valid
            if (verifyInput() == true) addUser();
        }

        private bool verifyInput()
        {
            // Set validation flag to false
            bool result = false;
            // Validate input fields
            if (txtName.Text.Length < 3) MessageBox.Show("Name must be at least 3 letters!", "Input Error");
            else if (cmbPosition.SelectedIndex < 0) MessageBox.Show("Please choose a position", "Input Error");
            else if (txtPass1.Text.Length < 3) MessageBox.Show("Passwords must be at least 3 chracters!", "Input Error");
            else if (txtPass1.Text != txtPass2.Text) MessageBox.Show("Passwords do not match!", "Input Error");
            // If all validation passed, set flag to true
            else result = true;
            // Return validation result
            return result;
        }

        private void addUser()
        {
            // Add new user as new row in staff table
            staffTableAdapter.Insert(txtName.Text, cmbPosition.Text, Password.encrypt(txtPass1.Text));
            // Confirm success
            MessageBox.Show("User added successfully!", "Success");
            // Close new user form
            this.Close();
        }
    }
}
