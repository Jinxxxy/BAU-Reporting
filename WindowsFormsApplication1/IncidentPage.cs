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
            for(var i  = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }           
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

        }

        private void ByApplication_Click(object sender, EventArgs e)
        {
            ChartArea ca = new ChartArea();
            ca.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
