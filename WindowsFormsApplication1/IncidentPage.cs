using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class IncidentPage : Form
    {
       public IncidentPage(string jsonString)
        {
            GettingServiceDetails gsd = new GettingServiceDetails();
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = gsd.serializeString(jsonString);
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void ByApplication_Click(object sender, EventArgs e)
        {
            ChartArea ca = new ChartArea();
            ca.Show();
        }
    }
}
