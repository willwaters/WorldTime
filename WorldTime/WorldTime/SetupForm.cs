using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTime
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void loadTimezones()
        {
            var zones = Common.GetZones();
            var local = zones.First(z => z.IsLocalTime == true);
            var others = zones.Where(z => z.IsLocalTime == false).ToList();

            var localRow = grid.Rows[grid.Rows.Add()];
            localRow.Cells[nameColumn.Index].Value = local.Name;
            localRow.Tag = local;

            foreach (var zn in others)
            {
                var row = grid.Rows[grid.Rows.Add()];
                row.Cells[nameColumn.Index].Value = zn.Name ?? zn.Timezone;
                row.Tag = zn;
            }

        }

        private void addTimezoneButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new AddTimezoneForm();
            frm.ShowDialog();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            loadTimezones();
            loadSidePanel();

            timezoneTextBox.AutoCompleteCustomSource = Common.Timezones;
            timezoneTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            timezoneTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            loadSidePanel();
        }

        private Zone SelectedZone {
            get { return (Zone)grid.SelectedRows[0].Tag; }
        }
        private DataGridViewRow SelectedRow
        {
            get { return grid.SelectedRows[0]; }
        }

        private void loadSidePanel()
        {
            if(SelectedZone != null)
            {
                nameTextBox.Text = SelectedZone.Name;
                subtextTextBox.Text = SelectedZone.Subtext;
                timezoneTextBox.Text = SelectedZone.Timezone;
                if(SelectedZone.IsLocalTime)
                {
                    removeButton.Visible = false;
                    localTimeLabel.Visible = true;
                    timezoneTextBoxSeperator.Visible = false;
                    timezoneTextBox.Visible = false;
                    timezoneLabel.Visible = false;

                    subtextTextBox.ReadOnly = true;
                    subtextTextBox.Text = TimeZoneInfo.Local.ToString();

                } else
                {
                    removeButton.Visible = true;
                    localTimeLabel.Visible = false;
                    timezoneTextBoxSeperator.Visible = true;
                    timezoneTextBox.Visible = true;
                    timezoneLabel.Visible = true;
                }
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedZone != null)
            {
                SelectedZone.Name = nameTextBox.Text;
                nameLabel.Text = nameTextBox.Text;
                removeButton.Text = $"Remove '{nameTextBox.Text}'";
                SelectedRow.Cells[nameColumn.Index].Value = nameTextBox.Text;
            }
        }

        private void removeButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedZone != null)
            {
                if(SelectedZone.IsLocalTime)
                {
                    MessageBox.Show("how did you even do this?? you cant remove your local timezone");
                } else
                {
                    if(MessageBox.Show($"Do you want to remove '{SelectedZone.Name}'?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        grid.Rows.RemoveAt(SelectedRow.Index);
                    }
                }
            }
        }

        private List<string> TimezoneNames { get; set; }

        private AutoCompleteStringCollection Timezones { get; set; }

        private void timezoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timezoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.StandardName.ToLower() == timezoneTextBox.Text.ToLower()) != null)
            {
                timezoneTextBox.Text = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.StandardName.ToLower() == timezoneTextBox.Text.ToLower()).StandardName;
            } else
            {
                MessageBox.Show("Please select a valid timezone!");
                e.Cancel = true;
            }
        }
    }
}
