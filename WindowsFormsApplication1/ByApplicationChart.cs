using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Services;

namespace WindowsFormsApplication1
{
    public partial class ByApplicationChart : Form
    {
        public ByApplicationChart()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            GettingServiceDetails gsd = new GettingServiceDetails();
            Dictionary<string, int> incData = gsd.getYAxisNumbers(GettingServiceDetails.incidentList, gsd.getXAxisNames(GettingServiceDetails.incidentList, "Application"),"Application");
            chart1.Series.Add("Series 1");
            chart1.Series["Series 1"].Points.DataBindXY(incData.Keys, incData.Values);
            chart1.Titles.Add("By Application");
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series["Series 1"].IsValueShownAsLabel = true;
            //foreach (var x in incData)
            //{
                
            //}
        }
    }
}
