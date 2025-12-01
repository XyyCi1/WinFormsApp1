namespace WinFormsApp1
{
    public partial class LogInMenu : Form
    {
        public LogInMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Enter text here";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
