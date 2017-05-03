using Library.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.HelperClasses
{
    class Chart
    {
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
