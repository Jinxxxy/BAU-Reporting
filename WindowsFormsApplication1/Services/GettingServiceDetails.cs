using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1.Services
{
    class GettingServiceDetails
    {
        public static Dictionary<string, string> loginDetails =  new Dictionary<string,string>();
        public static List<IncidentClass> incidentList = new List<IncidentClass>();
        public string MakeRequestToServiceNow(string _url)
        {
            string username = GettingServiceDetails.loginDetails["userName"];
            string password = GettingServiceDetails.loginDetails["password"];
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password))
                );
            var response = client.GetAsync(_url);
            string result;
            try
            {
                result = response.Result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                IncidentClass tic = new IncidentClass();
                //tic.Application = "DCS";
                tic.ClosedDate = DateTime.Now;
                tic.OpenedDate = DateTime.Now;
                tic.ClosureCode = "Closed";
                tic.IncidentID = "INC148908";
                tic.LongDescription = "This is the long description";
                // tic.Owner = "Craig Berry";
                tic.Priority = "High";
                tic.ShortDescription = "This is the short description";
                tic.SubClosureCode = "No Fault Founded";
                // tic.Team = "Dev - Advice & Activations";
                string ff = "[" + JsonConvert.SerializeObject(tic) + "]";
                result = ff;
                MessageBox.Show(result);
            }
            return result;
        }
        public List<IncidentClass> serializeString(string _returnedString)
        {
            JToken obj = JObject.Parse(_returnedString)["result"];
            string newString = JsonConvert.SerializeObject(obj);
            try
            {
                List<IncidentClass> dataSource = JsonConvert.DeserializeObject<List<IncidentClass>>(newString);
                GettingServiceDetails.incidentList = dataSource;            
                return dataSource;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Data.ToString());                
                MessageBox.Show(err.Message);
                throw err;
            }
        }
        public List<string> getApplicationNames(List<IncidentClass> incList)
        {
            List<string> nameList = new List<string>();
            foreach(IncidentClass i in incList)
            {
                if (nameList.IndexOf(i.Application) < 0)
                {
                    nameList.Add(i.Application);
                }
            }
            return nameList;
        } 
        public Dictionary<string,int> getApplicationNumbers(List<IncidentClass> incList, List<string> appNames)
        {
            Dictionary<string, int> appNumbers = new Dictionary<string, int>();
            foreach(string app in appNames)
            {
                var name = app;
                int appCount = 0;
                foreach(IncidentClass inc in incList)
                {
                    if(inc.Application == name)
                    {
                        appCount++;
                    }
                }
                appNumbers.Add(name, appCount);
            }
            return appNumbers;
            
        }
    }
}
