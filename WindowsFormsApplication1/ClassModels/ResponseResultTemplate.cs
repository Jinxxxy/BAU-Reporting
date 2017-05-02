using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ClassModels
{
    class ResponseResultTemplate
    {
        public bool error { get; set; }
        public string returnedReasonCode { get; set; }
        public string returnedDataString { get; set; }
        public string errorMessage { get; set; }
    }
}
