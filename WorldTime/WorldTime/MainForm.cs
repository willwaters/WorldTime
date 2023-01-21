using WorldTime.Properties;

namespace WorldTime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadZones()
        {
            listPanel.Controls.Clear();
            foreach (var zone in Common.GetZones())
            {
                AddZone(zone);
            }
        }

        private void AddZone(Zone zone)
        {
            var pnl = new Panel
            {
                Width = this.Width,
                Height = 75,
                Dock = DockStyle.Top
            };

            var pic = new PictureBox
            {
                Location = new Point(19, 21),
                Size = new Size(28, 31),
                Image = Resources.moon
            };

            var nmlabel = new Label
            {
                Location = new Point(59, 14),
                ForeColor = Color.White,
                Size = new Size(193, 25),
                Text = zone.Name,
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold, GraphicsUnit.Point)
            };

            var subtext = new Label
            {
                Location = new Point(61, 40),
                ForeColor = Color.White,
                Size = new Size(191, 17),
                Text = zone.Subtext ?? zone.Timezone,
                Font = new Font("Segoe UI", (float)9.75, FontStyle.Regular, GraphicsUnit.Point)
            };

            var time = new Label
            {
                Location = new Point(222, 3),
                AutoSize = false,
                Size = new Size(135, 47),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", (float)26.25, FontStyle.Regular, GraphicsUnit.Point),
                Anchor = AnchorStyles.Right,
                TextAlign = ContentAlignment.MiddleRight,
                Text = "18:40"
            };

            var timeinf = new Label
            {
                Location = new Point(173, 44),
                AutoSize = false,
                Size = new Size(175, 21),
                ForeColor = Color.FromArgb(114, 121, 135),
                Font = new Font("Segoe UI", (float)9.75, FontStyle.Regular, GraphicsUnit.Point),
                Anchor = AnchorStyles.Right,
                TextAlign = ContentAlignment.MiddleRight,
                Text = "+0 Hours"
            };


            pnl.Controls.Add(pic);
            pnl.Controls.Add(time);
            pnl.Controls.Add(timeinf);
            pnl.Controls.Add(nmlabel);
            pnl.Controls.Add(subtext);
            listPanel.Controls.Add(pnl);
        }

        private void manageButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new SetupForm();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Common.LoadZoneSetup();
            Common.LoadSystemTimezones();
            LoadZones();
        }
    }
}