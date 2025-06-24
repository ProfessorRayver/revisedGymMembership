namespace GUIforms
{
    public partial class MaindashFroms : Form
    {
        public MaindashFroms()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
        }

        // Register button
        private void button1_Click(object sender, EventArgs e)
        {
            var regForm = new regMemForms();
            regForm.Show();
        }

        // Members button
        private void button2_Click(object sender, EventArgs e)
        {
            var listForm = new listingMemFroms();
            listForm.Show();
            // Optionally: this.Dispose(); if you want to close the main menu
        }

        // Exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}