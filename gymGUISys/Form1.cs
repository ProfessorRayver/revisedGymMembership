namespace gymGUISys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Add Member
        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string membershipType = txtMembershipType.Text.Trim();
            string month = txtMonth.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(membershipType) || string.IsNullOrWhiteSpace(month))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Member newMember = new Member
            {
                Name = name,
                MembershipType = membershipType,
                Month = month,
                PaymentStatus = "Unpaid"
            };

            gymLogic.AddMember(newMember);
            MessageBox.Show("Member added!");
            txtName.Clear();
            txtMembershipType.Clear();
            txtMonth.Clear();
            ShowAllMembers();
        }

        // Show All Members
        private void buttonShowMembers_Click(object sender, EventArgs e)
        {
            ShowAllMembers();
        }

        private void ShowAllMembers()
        {
            lstMembers.Items.Clear();
            var members = gymLogic.GetMembers();
            foreach (var member in members)
            {
                lstMembers.Items.Add($"{member.Name} | {member.MembershipType} | {member.Month} | {member.PaymentStatus}");
            }
        }

        // Remove Member
        private void buttonRemoveMember_Click(object sender, EventArgs e)
        {
            if (lstMembers.SelectedItem == null)
            {
                MessageBox.Show("Select a member to remove.");
                return;
            }
            string selected = lstMembers.SelectedItem.ToString();
            string[] parts = selected.Split('|');
            if (parts.Length < 1)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }
            string name = parts[0].Trim();
            gymLogic.RemoveMember(name);
            MessageBox.Show("Member removed (if existed).");
            ShowAllMembers();
        }

        // Update Payment Status
        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            if (lstMembers.SelectedItem == null)
            {
                MessageBox.Show("Select a member from the list.");
                return;
            }
            string selected = lstMembers.SelectedItem.ToString();
            string[] parts = selected.Split('|');
            if (parts.Length < 1)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }
            string name = parts[0].Trim();
            string newStatus = txtPaymentStatus.Text.Trim();
            if (string.IsNullOrWhiteSpace(newStatus))
            {
                MessageBox.Show("Enter new payment status.");
                return;
            }
            gymLogic.UpdatePaymentStatus(name, newStatus);
            MessageBox.Show("Payment status updated.");
            ShowAllMembers();
        }

        // Search Member
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim();
            lstMembers.Items.Clear();
            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Enter a name to search.");
                return;
            }
            var members = gymLogic.GetMembers();
            var found = members
                .Where(m => m.Name != null && m.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (found.Count == 0)
            {
                MessageBox.Show("No member found.");
            }
            else
            {
                foreach (var member in found)
                {
                    lstMembers.Items.Add($"{member.Name} | {member.MembershipType} | {member.Month} | {member.PaymentStatus}");
                }
            }
        }
    }
}
