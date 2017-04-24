using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class IncidentPage : Form
    {
        private DataTable serializeString(string _returnedString)
        {
            try
            {
                MessageBox.Show(_returnedString);
                DataTable table = (DataTable)JsonConvert.DeserializeObject(_returnedString, typeof(DataTable));
                return table;
            } catch(Exception err)
            {
                MessageBox.Show(err.Data.ToString());
                DataTable table = (DataTable)JsonConvert.DeserializeObject("[{\"No\":\"Data\", \"Has\":\"Been\", \"Received\":\"Ok\"}]", typeof(DataTable));
                return table;
            }
        }
        public IncidentPage(string jsonString)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = serializeString(jsonString);
            dataGridView1.Refresh();

        }

    }
}
