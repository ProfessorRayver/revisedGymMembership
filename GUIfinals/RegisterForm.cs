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
            btnSubmit.Click += btnSubmit_Click;
            btnCancel.Click += btnCancel_Click_1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string status = txtStatus.Text.Trim();
                string date = dateTimePicker1.Value.ToString("MMMM");

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(status))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gymLogic.AddMember(name, status, date);

                MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Close RegisterForm to return to home page (Form1)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}