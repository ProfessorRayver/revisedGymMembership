namespace GUIfinals
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Click += btnRegister_Click;
            button2.Click += btnMembers_Click;
            button3.Click += btnExit_Click;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {

            viewMembers membersForm = new viewMembers();
            membersForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm())
            {
                registerForm.ShowDialog(this);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}