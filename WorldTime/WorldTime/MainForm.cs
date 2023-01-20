namespace WorldTime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void manageButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new SetupForm();
            frm.ShowDialog();
        }
    }
}