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
        public IncidentClass()
        {
            
        }
        [JsonProperty("cmdb_ci.name")]
        public string Application { get; set; }
        [JsonProperty("assigned_to.name")]
        public string Owner { get; set; }        
        [JsonProperty("closed_at")]
        public DateTime? ClosedDate { get; set; }
        public DateTime ShortClosedDate { get; set; }
        [JsonProperty("sys_created_on")]
        public DateTime? OpenedDate { get; set; }
        public DateTime ShortOpenedDate { get; set; }
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
        public int Duration { get; set; }
    }
    
}
