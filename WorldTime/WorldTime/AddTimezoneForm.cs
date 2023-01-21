using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTime
{
    public partial class AddTimezoneForm : Form
    {
        public AddTimezoneForm()
        {
            InitializeComponent();
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string DisplayName
        {
            get { return displayNameTextBox.Text; }
        }

        public string TimezoneName
        {
            get { return timezoneTextBox.Text; }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(timezoneTextBox.Text) || string.IsNullOrEmpty(displayNameTextBox.Text))
            {
                MessageBox.Show("Please enter both a timezone and a display name.");
            } else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddTimezoneForm_Load(object sender, EventArgs e)
        {

            timezoneTextBox.AutoCompleteCustomSource = Common.Timezones;
            timezoneTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            timezoneTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void timezoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.DisplayName.ToLower().EndsWith(timezoneTextBox.Text.ToLower())) != null)
            {
                timezoneTextBox.Text = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.DisplayName.ToLower().EndsWith(timezoneTextBox.Text.ToLower())).DisplayName;
            }
            else
            {
                MessageBox.Show("Please select a valid timezone!");
                e.Cancel = true;
            }
        }
    }
}
