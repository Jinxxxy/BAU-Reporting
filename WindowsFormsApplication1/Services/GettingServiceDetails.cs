using Library.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.ClassModels;

namespace WindowsFormsApplication1.Services
{
    class GettingServiceDetails
    {   
        public ResponseResultTemplate buildResponseTemplate(HttpResponseMessage resp) 
        {
            ResponseResultTemplate rrt = new ResponseResultTemplate();
            rrt.returnedReasonCode = resp.ReasonPhrase;
            rrt.error = checkResponseResult(resp);
            return rrt;
        }
        public bool checkResponseResult(HttpResponseMessage response)
        {
            
            switch (response.ReasonPhrase)
            {
                case "Unauthorized":
                    return true;
                case "OK":
                    return false;
                case "Faulted":
                    return true;
                default:
                    return true;
            }
        }
        public static Dictionary<string, string> loginDetails =  new Dictionary<string,string>();
        public static SortableBindingList<IncidentClass> incidentList = new SortableBindingList<IncidentClass>();
        public ResponseResultTemplate MakeRequestToServiceNow(string _url)
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
            Task<HttpResponseMessage> response = client.GetAsync(_url);
            string result;
            ResponseResultTemplate rrt;
            try
            {
                 rrt = buildResponseTemplate(response.Result);
            } catch (Exception err)
            {
                rrt = new ResponseResultTemplate();
                rrt.error = true;
                rrt.errorMessage = response.Exception.InnerException.InnerException.Message;
                return rrt;
            }
            
            if(!checkResponseResult(response.Result))
            {
                try
                {
                    rrt.returnedDataString = response.Result.Content.ReadAsStringAsync().Result;
                }
                catch (Exception err)
                {
                    rrt.error = true;
                    rrt.errorMessage = "Unable to parse JSON response";
                }
            } else
            {
                rrt.error = true;
                rrt.errorMessage = "Username / Password combination is incorrect";
            }       
            
            return rrt;
        }
        public SortableBindingList<IncidentClass> addDurationProperty(SortableBindingList<IncidentClass> incList)
        {
            foreach(IncidentClass inc in incList)
            {
                inc.Duration = (inc.ClosedDate - inc.OpenedDate).Value.Days;
            }
            return incList;
        }
        public SortableBindingList<IncidentClass> serializeString(string _returnedString)
        {
            JToken obj = JObject.Parse(_returnedString)["result"];
            string newString = JsonConvert.SerializeObject(obj);
            try
            {
                SortableBindingList<IncidentClass> dataSource = JsonConvert.DeserializeObject<SortableBindingList<IncidentClass>>(newString, new JsonSerializerSettings
                {
                    DateFormatString = "d/MMMM/yyyy"
                });
                incidentList = dataSource;            
                return dataSource;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Data.ToString());
                MessageBox.Show("Im here");       
                MessageBox.Show(err.Message);
                throw err;
            }
        }
        public object GetPropValue(IncidentClass src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src);
        }
        
    }
}
