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
            BindingSource bs = new BindingSource();
            dataGridView1.DataSource = bs;
            bs.DataSource = gsd.serializeString(jsonString);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Dock = DockStyle.Fill;
            
            //dataGridView1.Refresh();

        }

    }
}
