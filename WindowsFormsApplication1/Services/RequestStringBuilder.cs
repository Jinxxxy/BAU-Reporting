using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.ClassModels;

namespace WindowsFormsApplication1.Services
{
    class RequestStringBuilder
    {

        private string baseString = "https://stepchangeprod.service-now.com/api/now/table/";
        private string incidentProjection = "sysparm_fields=cmdb_ci.name,assigned_to.name,closed_at,sys_created_on,u_closure_code,u_closure_sub_code,assignment_group.name,description,short_description,priority,number";
        private string incidentTableName = "incident?";
        private string separator = "&";
        private string teamSelector = "assignment_group=";
        private string queryOpener = "sysparm_query=";
        private string closedConditionString = "incident_state=7";
        private string teamTableName = "sys_user_group?";
        private string teamProjection = "sysparm_fields=name,sys_id";
        public static Dictionary<string, string> teamDictionary = new Dictionary<string, string>();
        private string startDateStringBuilder(string[] startDateArr)
        {
            string field = "closed_at>=";
            string vanityDate = startDateArr[2] + "-" + startDateArr[1] + "-" + startDateArr[0];
            string openScript = "@javascript:gs.dateGenerate('";
            string endScript = "','00:00:00')";


            return field + vanityDate + openScript + vanityDate + endScript;            
        }
        private string endDateStringBuilder(string[] endDateArr)
        {
            string field = "closed_at<=";
            string vanityDate = endDateArr[2] + "-" + endDateArr[1] + "-" + endDateArr[0];
            string openScript = "@javascript:gs.dateGenerate('";
            string endScript = "','23:59:59')";
            return field + vanityDate + openScript + vanityDate + endScript;
        }
        public string getIncidentRequestString(string[] _start, string[] _end, string teamName)
        {
            
            var startDate = startDateStringBuilder(_start);
            var endDate = endDateStringBuilder(_end);
            var _teamName = Uri.EscapeUriString(teamName).Replace("&", "%26");
            var queryString = queryOpener + startDate + separator + endDate + separator + closedConditionString + separator + teamSelector;
            
            var test2 = baseString  + teamProjection + separator + queryString + _teamName;
            return test2;
        }
        public string getTeamRequestString()
        {
            return baseString + teamTableName + teamProjection;
        }
    }
   

}
