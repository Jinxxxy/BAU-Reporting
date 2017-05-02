using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApplication1.Services;
using WindowsFormsApplication1.ClassModels;

namespace WindowsFormsApplication1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            TeamPicker.DataSource = new BindingSource(RequestStringBuilder.teamDictionary, null);
            TeamPicker.DisplayMember = "Key";
            TeamPicker.ValueMember = "Value";
            
        }
        public string getUserName(TextBox _usernameInput)
        {
            string rawUsername = _usernameInput.Text;
            Boolean blank = isStringNotBlank(rawUsername);
            MessageBox.Show(rawUsername);
            MessageBox.Show(this.isStringNotBlank(rawUsername).ToString());
            if (blank)
            {
                MessageBox.Show("This is not blank");
                return rawUsername;
            } else
            {                
                return rawUsername;
            }
        }

        public string getPassword(TextBox _passwordInput)
        {
            string rawPassword = _passwordInput.Text;
            bool isPasswordNotBlank = isStringNotBlank(rawPassword);
            if(isPasswordNotBlank)
            {
                return rawPassword;
            } else
            {
                return rawPassword;
            }
        }
        private Boolean isStringNotBlank(string item)
        {
            if(item.Length <= 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
        public string getDate(DateTimePicker dtp)
        {
            DateTime dateTime = dtp.Value;
            return dateTime.ToShortDateString();
        }
        

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            
            string[] startDateString = getDate(StartDateInput).Split('/');
            string[] endDateString = getDate(EndDateInput).Split('/');
            string teamName = ((KeyValuePair<string, string>) TeamPicker.SelectedItem).Value;
            RequestStringBuilder rsb = new RequestStringBuilder();
            GettingServiceDetails gsd = new GettingServiceDetails();
            if(GettingServiceDetails.loginDetails.Count < 2)
            {
                GettingServiceDetails.loginDetails.Add("userName", getUserName(UsernameInput));
                GettingServiceDetails.loginDetails.Add("password", getPassword(PasswordInput));
            }            
            ResponseResultTemplate value = gsd.MakeRequestToServiceNow(rsb.getRequestString(startDateString,endDateString, teamName));
            if(value.error)
            {
                MessageBox.Show(value.errorMessage);
            } else
            {
                IncidentPage inc = new IncidentPage(value.returnedDataString);
                inc.Show();
            }            
        }
    }
}
