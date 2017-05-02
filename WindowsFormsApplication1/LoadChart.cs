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
            List<string> xAxis = gsd.getXAxisNames(
                GettingServiceDetails.incidentList, 
                gdt.incidentPropertyName);
            Dictionary<string, int> incData = gsd.getYAxisNumbers(
                GettingServiceDetails.incidentList, 
                xAxis, 
                gdt.incidentPropertyName);
            chart1.Series.Add(gdt.seriesName);
            chart1.Series[gdt.seriesName].Points.DataBindXY(incData.Keys, incData.Values);
            chart1.Titles.Add(gdt.chartName);
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series["Series 1"].IsValueShownAsLabel = true;
        }
    }
}
