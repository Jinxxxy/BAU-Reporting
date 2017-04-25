using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using WindowsFormsApplication1.Services;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication1
{
    [DataContract]
    class IncidentClass
    {
        [JsonProperty("subcategory")]
        public string Application { get; set; }
        [JsonProperty("assigned_to.name")]
        public string Owner { get; set; }        
        [JsonProperty("closed_at")]
        public DateTime? ClosedDate { get; set; }
        [JsonProperty("sys_created_on")]
        public DateTime? OpenedDate { get; set; }
        [JsonProperty("u_closure_code")]
        public string ClosureCode { get; set; }
        [JsonProperty("u_closure_sub_code")]
        public string SubClosureCode { get; set; }
        [JsonProperty("assignment_group.name")]
        public string Team { get; set; }
        [JsonProperty("description")]
        public string LongDescription { get; set; }
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
        [JsonProperty("priority")]
        public string Priority { get; set; }
        [JsonProperty("number")]
        public string IncidentID { get; set; }
        /*public void getOwner()
        {
            if (this._Owner != null)
            {
                GettingServiceDetails gsd = new GettingServiceDetails();
                string results = gsd.MakeRequestToServiceNow("https://stepchangeprod.service-now.com/api/now/table/sys_user?sysparm_fields=first_name%2C%20last_name&sysparm_limit=10&sysparm_view=&sys_id=" + this._Owner.Value);

                JToken obj = JObject.Parse(results)["result"][0];
                string newString = JsonConvert.SerializeObject(obj);
                Dictionary<string, string> resultObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(newString);

                this.Owner = resultObject["first_name"] + " " + resultObject["last_name"];
            }           
        
            return;
            
        }*/
    }
    public class AssignedTo
    {
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
    public class AssignmentGroup
    {
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
    public class ConfigurationItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
