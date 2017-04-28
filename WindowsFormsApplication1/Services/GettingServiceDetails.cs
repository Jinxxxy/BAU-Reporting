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

namespace Library.Forms
{
    /// <summary>
    /// Provides a generic collection that supports data binding and additionally supports sorting.
    /// See http://msdn.microsoft.com/en-us/library/ms993236.aspx
    /// If the elements are IComparable it uses that; otherwise compares the ToString()
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public class SortableBindingList<T> : BindingList<T> where T : class
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        public SortableBindingList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        /// <param name="list">An <see cref="T:System.Collections.Generic.IList`1" /> of items to be contained in the <see cref="T:System.ComponentModel.BindingList`1" />.</param>
        public SortableBindingList(IList<T> list)
            : base(list)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the list supports sorting.
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether the list is sorted.
        /// </summary>
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        /// <summary>
        /// Gets the direction the list is sorted.
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        /// <summary>
        /// Gets the property descriptor that is used for sorting the list if sorting is implemented in a derived class; otherwise, returns null
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }

        /// <summary>
        /// Removes any sort applied with ApplySortCore if sorting is implemented
        /// </summary>
        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
            _isSorted = false; //thanks Luca
        }

        /// <summary>
        /// Sorts the items if overridden in a derived class
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="direction"></param>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            List<T> list = Items as List<T>;
            if (list == null) return;

            list.Sort(Compare);

            _isSorted = true;
            //fire an event that the list has been changed.
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }


        private int Compare(T lhs, T rhs)
        {
            var result = OnComparison(lhs, rhs);
            //invert if descending
            if (_sortDirection == ListSortDirection.Descending)
                result = -result;
            return result;
        }

        private int OnComparison(T lhs, T rhs)
        {
            object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
            object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
            if (lhsValue == null)
            {
                return (rhsValue == null) ? 0 : -1; //nulls are equal
            }
            if (rhsValue == null)
            {
                return 1; //first has value, second doesn't
            }
            if (lhsValue is IComparable)
            {
                return ((IComparable)lhsValue).CompareTo(rhsValue);
            }
            if (lhsValue.Equals(rhsValue))
            {
                return 0; //both are the same
            }
            //not comparable, compare ToString
            return lhsValue.ToString().CompareTo(rhsValue.ToString());
        }
    }
}

namespace WindowsFormsApplication1.Services
{
    class GettingServiceDetails
    {
        public static Dictionary<string, string> loginDetails =  new Dictionary<string,string>();
        public static SortableBindingList<IncidentClass> incidentList = new SortableBindingList<IncidentClass>();
        public string MakeRequestToServiceNow(string _url)
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
            var response = client.GetAsync(_url);
            string result;
            try
            {
                result = response.Result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                IncidentClass tic = new IncidentClass();
                //tic.Application = "DCS";
                tic.ClosedDate = DateTime.Now;
                tic.OpenedDate = DateTime.Now;
                tic.ClosureCode = "Closed";
                tic.IncidentID = "INC148908";
                tic.LongDescription = "This is the long description";
                // tic.Owner = "Craig Berry";
                tic.Priority = "High";
                tic.ShortDescription = "This is the short description";
                tic.SubClosureCode = "No Fault Founded";
                // tic.Team = "Dev - Advice & Activations";
                string ff = "[" + JsonConvert.SerializeObject(tic) + "]";
                result = ff;
                MessageBox.Show(result);
            }
            return result;
        }
        public SortableBindingList<IncidentClass> serializeString(string _returnedString)
        {
            JToken obj = JObject.Parse(_returnedString)["result"];
            string newString = JsonConvert.SerializeObject(obj);
            try
            {
                SortableBindingList<IncidentClass> dataSource = JsonConvert.DeserializeObject<SortableBindingList<IncidentClass>>(newString);
                GettingServiceDetails.incidentList = dataSource;            
                return dataSource;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Data.ToString());                
                MessageBox.Show(err.Message);
                throw err;
            }
        }
        public object GetPropValue(IncidentClass src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src);
        }
        public List<string> getXAxisNames(SortableBindingList<IncidentClass> incList, string labelName)
        {
            List<string> nameList = new List<string>();
            foreach(IncidentClass i in incList)
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
        public Dictionary<string,int> getYAxisNumbers(SortableBindingList<IncidentClass> incList, List<string> appNames, string propName)
        {
            Dictionary<string, int> appNumbers = new Dictionary<string, int>();
            foreach(string app in appNames)
            {
                var name = app;
                int appCount = 0;
                foreach(IncidentClass inc in incList)
                {
                    var incPropName = GetPropValue(inc, propName).ToString();
                    if(incPropName == name)
                    {
                        appCount++;
                    }
                }
                appNumbers.Add(name, appCount);
            }
            return appNumbers;
            
        }
    }
}
