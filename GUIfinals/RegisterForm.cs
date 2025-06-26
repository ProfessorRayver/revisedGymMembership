using System;
using System.Windows.Forms;
using GymBL; 

namespace GUIfinals
{
    public partial class RegisterForm : Form
    {
        private GymBAL gymLogic = new GymBAL();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string status = txtStatus.Text.Trim();
            string date = dateTimePicker1.Value.ToString("MMMM");

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to database via business logic (SQLDB)
            gymLogic.AddMember(name, status, date);

            // Show success notification to users 
            MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            txtStatus.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
        }
    }
}