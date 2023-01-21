namespace WorldTime
{
    partial class AddTimezoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimezoneForm));
            this.label6 = new System.Windows.Forms.Label();
            this.timezoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.abortButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(16, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 1);
            this.label6.TabIndex = 17;
            // 
            // timezoneTextBox
            // 
            this.timezoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timezoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.timezoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timezoneTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timezoneTextBox.ForeColor = System.Drawing.Color.White;
            this.timezoneTextBox.Location = new System.Drawing.Point(16, 56);
            this.timezoneTextBox.Name = "timezoneTextBox";
            this.timezoneTextBox.Size = new System.Drawing.Size(436, 20);
            this.timezoneTextBox.TabIndex = 16;
            this.timezoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.timezoneTextBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Timezone";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 1);
            this.label4.TabIndex = 14;
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.displayNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayNameTextBox.ForeColor = System.Drawing.Color.White;
            this.displayNameTextBox.Location = new System.Drawing.Point(16, 107);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(436, 20);
            this.displayNameTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Display as";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Zone";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.abortButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 51);
            this.panel1.TabIndex = 19;
            // 
            // abortButton
            // 
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.ForeColor = System.Drawing.Color.White;
            this.abortButton.Location = new System.Drawing.Point(242, 11);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(104, 29);
            this.abortButton.TabIndex = 1;
            this.abortButton.Text = "Cancel";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(352, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 29);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddTimezoneForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.CancelButton = this.abortButton;
            this.ClientSize = new System.Drawing.Size(469, 202);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timezoneTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayNameTextBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTimezoneForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Zone";
            this.Load += new System.EventHandler(this.AddTimezoneForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox timezoneTextBox;
        private Label label7;
        private Label label4;
        private TextBox displayNameTextBox;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button abortButton;
        private Button addButton;
    }
}