namespace WindowsFormsApplication1
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.TeamPickerLabel = new System.Windows.Forms.Label();
            this.TeamPicker = new System.Windows.Forms.ListBox();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateInput = new System.Windows.Forms.DateTimePicker();
            this.StartDateInput = new System.Windows.Forms.DateTimePicker();
            this.LoginButton = new System.Windows.Forms.Button();
            this.GetIncidents = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 123);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(109, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "ServiceNow Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(69, 153);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(50, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(134, 151);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(258, 21);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(134, 119);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(258, 21);
            this.UsernameInput.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.White;
            this.HeaderLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(70, 81);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(257, 26);
            this.HeaderLabel.TabIndex = 5;
            this.HeaderLabel.Text = "BAU Monthly Reporting Tool";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 62);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Controls.Add(this.GetIncidents);
            this.DetailsPanel.Controls.Add(this.TeamPickerLabel);
            this.DetailsPanel.Controls.Add(this.TeamPicker);
            this.DetailsPanel.Controls.Add(this.EndDateLabel);
            this.DetailsPanel.Controls.Add(this.StartDateLabel);
            this.DetailsPanel.Controls.Add(this.EndDateInput);
            this.DetailsPanel.Controls.Add(this.StartDateInput);
            this.DetailsPanel.Location = new System.Drawing.Point(15, 175);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(377, 151);
            this.DetailsPanel.TabIndex = 13;
            this.DetailsPanel.Visible = false;
            // 
            // TeamPickerLabel
            // 
            this.TeamPickerLabel.AutoSize = true;
            this.TeamPickerLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TeamPickerLabel.Location = new System.Drawing.Point(57, 71);
            this.TeamPickerLabel.Name = "TeamPickerLabel";
            this.TeamPickerLabel.Size = new System.Drawing.Size(31, 13);
            this.TeamPickerLabel.TabIndex = 19;
            this.TeamPickerLabel.Text = "Team";
            // 
            // TeamPicker
            // 
            this.TeamPicker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TeamPicker.FormattingEnabled = true;
            this.TeamPicker.Location = new System.Drawing.Point(119, 71);
            this.TeamPicker.Name = "TeamPicker";
            this.TeamPicker.Size = new System.Drawing.Size(200, 43);
            this.TeamPicker.TabIndex = 18;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EndDateLabel.Location = new System.Drawing.Point(57, 49);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(48, 13);
            this.EndDateLabel.TabIndex = 17;
            this.EndDateLabel.Text = "End Date";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StartDateLabel.Location = new System.Drawing.Point(53, 14);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.StartDateLabel.TabIndex = 16;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDateInput
            // 
            this.EndDateInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EndDateInput.Location = new System.Drawing.Point(119, 41);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.Size = new System.Drawing.Size(200, 21);
            this.EndDateInput.TabIndex = 15;
            // 
            // StartDateInput
            // 
            this.StartDateInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StartDateInput.Location = new System.Drawing.Point(119, 8);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.Size = new System.Drawing.Size(200, 21);
            this.StartDateInput.TabIndex = 14;
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoginButton.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(134, 332);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // GetIncidents
            // 
            this.GetIncidents.Location = new System.Drawing.Point(119, 120);
            this.GetIncidents.Name = "GetIncidents";
            this.GetIncidents.Size = new System.Drawing.Size(75, 23);
            this.GetIncidents.TabIndex = 20;
            this.GetIncidents.Text = "Get Incidents";
            this.GetIncidents.UseVisualStyleBackColor = true;
            this.GetIncidents.Click += new System.EventHandler(this.GetIncidents_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.StatusBox);
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Location = new System.Drawing.Point(15, 361);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(377, 82);
            this.StatusPanel.TabIndex = 14;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(38, 5);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 27);
            this.StatusLabel.TabIndex = 0;
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.Color.Red;
            this.StatusBox.Location = new System.Drawing.Point(5, 8);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(367, 37);
            this.StatusBox.TabIndex = 1;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 455);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginScreen";
            this.Text = "BAU Monthly Reporting Tool ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        public System.Windows.Forms.TextBox PasswordInput;
        public System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label TeamPickerLabel;
        private System.Windows.Forms.ListBox TeamPicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker EndDateInput;
        private System.Windows.Forms.DateTimePicker StartDateInput;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button GetIncidents;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusBox;
    }
}

