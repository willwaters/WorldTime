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
            localRow.Cells[timezoneColumn.Index].Value = TimeZoneInfo.Local.ToString();
            localRow.Tag = local;

            foreach (var zn in others)
            {
                var row = grid.Rows[grid.Rows.Add()];
                row.Cells[nameColumn.Index].Value = zn.Name ?? zn.Timezone;
                row.Cells[timezoneColumn.Index].Value = zn.Timezone;
                row.Tag = zn;
            }

        }

        private void addTimezoneButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new AddTimezoneForm();
            
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var tz = new Zone
                {
                    Name = frm.DisplayName,
                    IsLocalTime = false,
                    Timezone = frm.TimezoneName,
                    Subtext = frm.TimezoneName
                };
                var newRow = grid.Rows[grid.Rows.Add()];
                newRow.Cells[nameColumn.Index].Value = tz.Name;
                newRow.Cells[timezoneColumn.Index].Value = tz.Timezone;
                newRow.Tag = tz;
                newRow.Selected = true;
            }



        }

        private void Save()
        {
            var newData = new ZoneSetup();

            newData.zones = new List<Zone>();

            foreach (DataGridViewRow row  in grid.Rows)
            {
                var zone = (Zone)row.Tag;
                if(zone != null)
                {
                    if(zone.IsLocalTime)
                    {
                        newData.zones.Add(new Zone
                        {
                            Name = zone.Name,
                            Subtext = zone.Subtext,
                            IsLocalTime = true
                        });
                    } else
                    {
                        newData.zones.Add(zone);
                    }
                }
            }

            Common.SaveZoneSetup(newData);
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
                    subtextTextBox.ReadOnly = false;
                    subtextTextBox.Text = SelectedZone.Timezone;
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

        private void subtextTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedZone != null && SelectedZone.IsLocalTime == false)
            {
                SelectedZone.Subtext = nameTextBox.Text;
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
            if(SelectedZone.IsLocalTime == false)
            {
                if (TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.DisplayName.ToLower().EndsWith(timezoneTextBox.Text.ToLower())) != null)
                {
                    var name = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.DisplayName.ToLower().EndsWith(timezoneTextBox.Text.ToLower())).DisplayName;
                    timezoneTextBox.Text = name;
                    SelectedRow.Cells[timezoneColumn.Index].Value = name;
                }
                else
                {
                    MessageBox.Show("Please select a valid timezone!");
                    e.Cancel = true;
                }
            }
        }

        private void SetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
    }
}
