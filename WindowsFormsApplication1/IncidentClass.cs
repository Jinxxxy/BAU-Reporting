using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    [DataContract]
    class IncidentClass
    {
        [JsonProperty("cmdb_ci.value")]
        string Application { get; set; }
        [JsonProperty("assigned_to.value")]
        string Owner { get; set; }
        [JsonProperty("closed_at")]
        DateTime ClosedDate { get; set; }
        [JsonProperty("sys_created_on")]
        DateTime OpenedDate { get; set; }
        [JsonProperty("u_closure_code")]
        string ClosureCode { get; set; }
        [JsonProperty("u_closure_sub_code")]
        string SubClosureCode { get; set; }
        [JsonProperty("assignment_group.value")]
        string Team { get; set; }
        [JsonProperty("description")]
        string LongDescription { get; set; }
        [JsonProperty("short_description")]
        string ShortDescription { get; set; }
        [JsonProperty("priority")]
        string Priority { get; set; }
        [JsonProperty("number")]
        string IncidentID { get; set; }
        //[JsonProperty("")]
        //string AssociatedChangeId { get; set; }
    }
}
