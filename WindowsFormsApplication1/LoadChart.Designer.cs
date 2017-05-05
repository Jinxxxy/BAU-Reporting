namespace WindowsFormsApplication1
{
    partial class LoadChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(-1, 1);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(1595, 698);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "MainChart";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsFormsApplication1.Program);
            // 
            // LoadChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 697);
            this.Controls.Add(this.MainChart);
            this.Name = "LoadChart";
            this.Text = "ChartArea";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
    }
}