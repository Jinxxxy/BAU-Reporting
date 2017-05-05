using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ClassModels
{
    class TeamItem
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("sys_id")]
        public string id { get; set; }
    }
}
