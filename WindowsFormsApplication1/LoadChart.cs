using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ClassModels;
using WindowsFormsApplication1.HelperClasses;
using WindowsFormsApplication1.Services;

namespace WindowsFormsApplication1
{
    public partial class LoadChart : Form
    {
        public LoadChart(GraphDataTemplate gdt)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            GettingServiceDetails gsd = new GettingServiceDetails();
            List<string> xAxis = Chart.getXAxisNames(
                GettingServiceDetails.incidentList, 
                gdt.incidentPropertyName);
            Dictionary<string, int> incData = Chart.getYAxisNumbers(
                GettingServiceDetails.incidentList, 
                xAxis, 
                gdt.incidentPropertyName);
            MainChart.Series.Add(gdt.seriesName);
            MainChart.Series[gdt.seriesName].Points.DataBindXY(incData.Keys, incData.Values);
            MainChart.Titles.Add(gdt.chartName);
            MainChart.ChartAreas[0].AxisX.Interval = 1;
            MainChart.Series[gdt.seriesName].IsValueShownAsLabel = true;
            MainChart.Series[gdt.seriesName].AxisLabel = gdt.xAxisLabelName;
            MainChart.ChartAreas[0].AxisX.Title = gdt.xAxisLabelName;
            MainChart.ChartAreas[0].AxisY.Title = "Number of incidents";            
        }
    }
}
