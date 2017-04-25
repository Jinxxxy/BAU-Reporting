namespace WindowsFormsApplication1
{
    partial class IncidentPage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ByApplication = new System.Windows.Forms.Button();
            this.BySolution = new System.Windows.Forms.Button();
            this.ByDuration = new System.Windows.Forms.Button();
            this.CommonIssues = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncidentListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(591, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(482, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Group By";
            // 
            // ByApplication
            // 
            this.ByApplication.Location = new System.Drawing.Point(12, 415);
            this.ByApplication.Name = "ByApplication";
            this.ByApplication.Size = new System.Drawing.Size(137, 47);
            this.ByApplication.TabIndex = 11;
            this.ByApplication.Text = "By Application";
            this.ByApplication.UseVisualStyleBackColor = true;
            this.ByApplication.Click += new System.EventHandler(this.ByApplication_Click);
            // 
            // BySolution
            // 
            this.BySolution.Location = new System.Drawing.Point(155, 415);
            this.BySolution.Name = "BySolution";
            this.BySolution.Size = new System.Drawing.Size(137, 47);
            this.BySolution.TabIndex = 12;
            this.BySolution.Text = "By Solution";
            this.BySolution.UseVisualStyleBackColor = true;
            // 
            // ByDuration
            // 
            this.ByDuration.Location = new System.Drawing.Point(298, 415);
            this.ByDuration.Name = "ByDuration";
            this.ByDuration.Size = new System.Drawing.Size(137, 47);
            this.ByDuration.TabIndex = 13;
            this.ByDuration.Text = "By Duration";
            this.ByDuration.UseVisualStyleBackColor = true;
            // 
            // CommonIssues
            // 
            this.CommonIssues.Location = new System.Drawing.Point(466, 415);
            this.CommonIssues.Name = "CommonIssues";
            this.CommonIssues.Size = new System.Drawing.Size(137, 47);
            this.CommonIssues.TabIndex = 14;
            this.CommonIssues.Text = "Common Issues";
            this.CommonIssues.UseVisualStyleBackColor = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsFormsApplication1.Program);
            // 
            // IncidentListLabel
            // 
            this.IncidentListLabel.AutoSize = true;
            this.IncidentListLabel.Font = new System.Drawing.Font("Corbel", 24F);
            this.IncidentListLabel.Location = new System.Drawing.Point(208, 13);
            this.IncidentListLabel.Name = "IncidentListLabel";
            this.IncidentListLabel.Size = new System.Drawing.Size(178, 39);
            this.IncidentListLabel.TabIndex = 15;
            this.IncidentListLabel.Text = "Incident List";
            // 
            // IncidentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 474);
            this.Controls.Add(this.IncidentListLabel);
            this.Controls.Add(this.CommonIssues);
            this.Controls.Add(this.ByDuration);
            this.Controls.Add(this.BySolution);
            this.Controls.Add(this.ByApplication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IncidentPage";
            this.Text = "IncidentPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button ByApplication;
        private System.Windows.Forms.Button BySolution;
        private System.Windows.Forms.Button ByDuration;
        private System.Windows.Forms.Button CommonIssues;
        private System.Windows.Forms.Label IncidentListLabel;
    }
}