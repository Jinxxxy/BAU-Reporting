using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Services
{
    class GettingServiceDetails
    {
        public List<IncidentClass> serializeString(string _returnedString)
        {
            JToken obj = JObject.Parse(_returnedString)["result"];
            string newString = JsonConvert.SerializeObject(obj);

            try
            {
                var dataSource = JsonConvert.DeserializeObject<List<IncidentClass>>(newString);
                return dataSource;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Data.ToString());                
                MessageBox.Show(err.Message);
                throw err;
            }
        }

    }
}
