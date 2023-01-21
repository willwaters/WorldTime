namespace WorldTime
{
    partial class SetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.editPanel = new System.Windows.Forms.Panel();
            this.localTimeLabel = new System.Windows.Forms.Label();
            this.timezoneTextBoxSeperator = new System.Windows.Forms.Label();
            this.timezoneTextBox = new System.Windows.Forms.TextBox();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.subtextTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timezoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTimezoneButton = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.editPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.editPanel.Controls.Add(this.localTimeLabel);
            this.editPanel.Controls.Add(this.timezoneTextBoxSeperator);
            this.editPanel.Controls.Add(this.timezoneTextBox);
            this.editPanel.Controls.Add(this.timezoneLabel);
            this.editPanel.Controls.Add(this.removeButton);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.subtextTextBox);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.nameTextBox);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.nameLabel);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(230, 428);
            this.editPanel.TabIndex = 0;
            // 
            // localTimeLabel
            // 
            this.localTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.localTimeLabel.AutoSize = true;
            this.localTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.localTimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.localTimeLabel.Location = new System.Drawing.Point(16, 378);
            this.localTimeLabel.Name = "localTimeLabel";
            this.localTimeLabel.Size = new System.Drawing.Size(186, 30);
            this.localTimeLabel.TabIndex = 12;
            this.localTimeLabel.Text = "This is your local timezone. It is not\r\npossible to remove it.";
            this.localTimeLabel.Visible = false;
            // 
            // timezoneTextBoxSeperator
            // 
            this.timezoneTextBoxSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.timezoneTextBoxSeperator.Location = new System.Drawing.Point(17, 198);
            this.timezoneTextBoxSeperator.Name = "timezoneTextBoxSeperator";
            this.timezoneTextBoxSeperator.Size = new System.Drawing.Size(193, 1);
            this.timezoneTextBoxSeperator.TabIndex = 11;
            // 
            // timezoneTextBox
            // 
            this.timezoneTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.timezoneTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.timezoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.timezoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timezoneTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timezoneTextBox.ForeColor = System.Drawing.Color.White;
            this.timezoneTextBox.Location = new System.Drawing.Point(17, 175);
            this.timezoneTextBox.Name = "timezoneTextBox";
            this.timezoneTextBox.Size = new System.Drawing.Size(193, 20);
            this.timezoneTextBox.TabIndex = 10;
            this.timezoneTextBox.Text = "Zurich";
            this.timezoneTextBox.TextChanged += new System.EventHandler(this.timezoneTextBox_TextChanged);
            this.timezoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.timezoneTextBox_Validating);
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.AutoSize = true;
            this.timezoneLabel.ForeColor = System.Drawing.Color.White;
            this.timezoneLabel.Location = new System.Drawing.Point(13, 157);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.Size = new System.Drawing.Size(58, 15);
            this.timezoneLabel.TabIndex = 9;
            this.timezoneLabel.Text = "Timezone";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.AutoSize = true;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.removeButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.removeButton.Location = new System.Drawing.Point(14, 389);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 20);
            this.removeButton.TabIndex = 8;
            this.removeButton.TabStop = true;
            this.removeButton.Text = "Remove \'Zurich\'";
            this.removeButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removeButton_LinkClicked);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 1);
            this.label5.TabIndex = 7;
            // 
            // subtextTextBox
            // 
            this.subtextTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.subtextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtextTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtextTextBox.ForeColor = System.Drawing.Color.White;
            this.subtextTextBox.Location = new System.Drawing.Point(16, 120);
            this.subtextTextBox.Name = "subtextTextBox";
            this.subtextTextBox.Size = new System.Drawing.Size(193, 16);
            this.subtextTextBox.TabIndex = 6;
            this.subtextTextBox.Text = "Switzerland";
            this.subtextTextBox.TextChanged += new System.EventHandler(this.subtextTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 1);
            this.label4.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(17, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Zurich";
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display as";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(10, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Zurich";
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.gridPanel.Controls.Add(this.grid);
            this.gridPanel.Controls.Add(this.addTimezoneButton);
            this.gridPanel.Controls.Add(this.label2);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(230, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(463, 428);
            this.gridPanel.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.timezoneColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(87)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(14, 67);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 25;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(437, 344);
            this.grid.TabIndex = 13;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // timezoneColumn
            // 
            this.timezoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timezoneColumn.HeaderText = "Time-zone";
            this.timezoneColumn.Name = "timezoneColumn";
            this.timezoneColumn.ReadOnly = true;
            // 
            // addTimezoneButton
            // 
            this.addTimezoneButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(197)))));
            this.addTimezoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTimezoneButton.AutoSize = true;
            this.addTimezoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTimezoneButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.addTimezoneButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(144)))), ((int)(((byte)(159)))));
            this.addTimezoneButton.Location = new System.Drawing.Point(409, 31);
            this.addTimezoneButton.Name = "addTimezoneButton";
            this.addTimezoneButton.Size = new System.Drawing.Size(37, 20);
            this.addTimezoneButton.TabIndex = 12;
            this.addTimezoneButton.TabStop = true;
            this.addTimezoneButton.Text = "Add";
            this.addTimezoneButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addTimezoneButton_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Zones";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 428);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.editPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupForm";
            this.Text = "Setup Timezones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupForm_FormClosing);
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            this.gridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel editPanel;
        private Panel gridPanel;
        private Label nameLabel;
        private Label label2;
        private Label timezoneTextBoxSeperator;
        private TextBox timezoneTextBox;
        private Label timezoneLabel;
        private LinkLabel removeButton;
        private Label label5;
        private TextBox subtextTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private Label label3;
        private LinkLabel addTimezoneButton;
        private DataGridView grid;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn timezoneColumn;
        private Label localTimeLabel;
    }
}