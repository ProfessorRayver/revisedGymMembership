namespace GUIfinals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += btnRegister_Click;
            button2.Click += btnMembers_Click;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            
            viewMembers membersForm = new viewMembers();
            membersForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
    }
}