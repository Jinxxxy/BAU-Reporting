using Library.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.ClassModels;

namespace WindowsFormsApplication1.HelperClasses
{
    class Chart

    {
        public static List<GraphDataTemplate> gdtList = new List<GraphDataTemplate>();
        public static List<DurationInterval> intervalList = new List<DurationInterval>();
        public static bool checkMinMax(int toCheck, DurationInterval di)
        {
            if(toCheck <= di.maxValue && toCheck >= di.minValue)
            {
                return true;
            } else
            {
                return false;
            }

        }
        public static Dictionary<string, int> getYAxisNamesForDuration(SortableBindingList<IncidentClass> incList)
        {
            Dictionary<string, int> returnList = new Dictionary<string, int>();
            foreach (DurationInterval di in intervalList)
            {
                int count = 0;
                
                foreach (IncidentClass i in incList)
                {
                    if(checkMinMax(i.Duration, di))
                    {
                        count++;
                    }
                }
                returnList.Add(di.intervalName, count);
            }
            return returnList;
        }
        
        public static List<string> getXAxisNames(SortableBindingList<IncidentClass> incList, string labelName)
        {
            List<string> nameList = new List<string>();
            foreach (IncidentClass i in incList)
            {
                PropertyInfo prop = typeof(IncidentClass).GetProperty(labelName);
                object value = prop.GetValue(i, null);

                if (nameList.IndexOf(value.ToString()) < 0)
                {
                    nameList.Add(value.ToString());
                }
            }
            return nameList;
        }
        public static Dictionary<string, int> getYAxisNumbers(SortableBindingList<IncidentClass> incList, List<string> appNames, string propName)
        {
            Dictionary<string, int> appNumbers = new Dictionary<string, int>();
            foreach (string app in appNames)
            {
                var name = app;
                int appCount = 0;
                foreach (IncidentClass inc in incList)
                {
                    var incPropName = GetPropValue(inc, propName).ToString();
                    if (incPropName == name)
                    {
                        appCount++;
                    }
                }
                appNumbers.Add(name, appCount);
            }
            return appNumbers;

        }
        public static object GetPropValue(IncidentClass src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src);
        }

    }
}
