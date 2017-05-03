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
            this.LoadChart = new System.Windows.Forms.Button();
            this.CommonIssues = new System.Windows.Forms.Button();
            this.IncidentListLabel = new System.Windows.Forms.Label();
            this.graphTypeList = new System.Windows.Forms.ListBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(861, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // LoadChart
            // 
            this.LoadChart.Location = new System.Drawing.Point(12, 454);
            this.LoadChart.Name = "LoadChart";
            this.LoadChart.Size = new System.Drawing.Size(156, 56);
            this.LoadChart.TabIndex = 11;
            this.LoadChart.Text = "Load Chart";
            this.LoadChart.UseVisualStyleBackColor = true;
            this.LoadChart.Click += new System.EventHandler(this.ByApplication_Click);
            // 
            // CommonIssues
            // 
            this.CommonIssues.Location = new System.Drawing.Point(718, 454);
            this.CommonIssues.Name = "CommonIssues";
            this.CommonIssues.Size = new System.Drawing.Size(155, 56);
            this.CommonIssues.TabIndex = 14;
            this.CommonIssues.Text = "Common Issues";
            this.CommonIssues.UseVisualStyleBackColor = true;
            // 
            // IncidentListLabel
            // 
            this.IncidentListLabel.AutoSize = true;
            this.IncidentListLabel.Font = new System.Drawing.Font("Corbel", 24F);
            this.IncidentListLabel.Location = new System.Drawing.Point(337, 9);
            this.IncidentListLabel.Name = "IncidentListLabel";
            this.IncidentListLabel.Size = new System.Drawing.Size(178, 39);
            this.IncidentListLabel.TabIndex = 15;
            this.IncidentListLabel.Text = "Incident List";
            // 
            // graphTypeList
            // 
            this.graphTypeList.FormattingEnabled = true;
            this.graphTypeList.Location = new System.Drawing.Point(308, 454);
            this.graphTypeList.Name = "graphTypeList";
            this.graphTypeList.Size = new System.Drawing.Size(268, 56);
            this.graphTypeList.TabIndex = 16;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsFormsApplication1.Program);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chart Type";
            // 
            // IncidentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphTypeList);
            this.Controls.Add(this.IncidentListLabel);
            this.Controls.Add(this.CommonIssues);
            this.Controls.Add(this.LoadChart);
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
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button LoadChart;
        private System.Windows.Forms.Button CommonIssues;
        private System.Windows.Forms.Label IncidentListLabel;
        private System.Windows.Forms.ListBox graphTypeList;
        private System.Windows.Forms.Label label1;
    }
}