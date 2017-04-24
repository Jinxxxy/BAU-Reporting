using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class IncidentClass
    {
        string Application { get; set; }
        string Owner { get; set; }
        DateTime ClosedDate { get; set; }
        DateTime OpenedDate { get; set; }
        string ClosureCode { get; set; }
        string SubClosureCode { get; set; }
        string Team { get; set; }
        string LongDescription { get; set; }
        string ShortDescription { get; set; }
        string Priority { get; set; }
        string IncidentID { get; set; }
        string AssociatedChangeId { get; set; }
    }
}
