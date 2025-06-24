using System;
using System.Windows.Forms;

namespace GUIforms
{
    public partial class regMemForms : Form
    {
        public regMemForms()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Collect data
            string name = txtName.Text.Trim();
            string status = txtStatus.Text.Trim();
            string date = dateTimePicker1.Value.ToShortDateString();

            // Add to static list
            MemberDataStore.AddMember(name, status, date);

            // Show notification
            MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, go to listing form
            var listForm = new listingMemFroms();
            listForm.Show();
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var mainForm = new MaindashFroms();
            mainForm.Show();
            this.Dispose();
        }
    }

    // Simple static data store for demonstration
    public static class MemberDataStore
    {
        public static List<(string Name, string Status, string Date)> Members { get; } = new();

        public static void AddMember(string name, string status, string date)
        {
            Members.Add((name, status, date));
        }
    }
}