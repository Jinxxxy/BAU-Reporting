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
            GettingServiceDetails gsd = new GettingServiceDetails();
            RequestStringBuilder rsb = new RequestStringBuilder();
            
            TeamPicker.DisplayMember = "name";
            TeamPicker.ValueMember = "id";
            
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Size size = TextRenderer.MeasureText(StatusBox.Text, StatusBox.Font);
            StatusBox.Width = size.Width;
            StatusBox.Height = size.Height;

        }
        public string getUserName(TextBox _usernameInput)
        {
            string rawUsername = _usernameInput.Text;
            Boolean blank = isStringNotBlank(rawUsername);
            if (blank)
            {
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
        private List<TeamItem> sortTeamList(List<TeamItem> unsortedList)
        {
            List<TeamItem> returnList = unsortedList.OrderBy(o => o.name).ToList();

            return returnList;
        }
        
        private List<TeamItem> serializeTeams(ResponseResultTemplate rrt)
        {
            List<TeamItem> _returnDict = new List<TeamItem>();
            if (rrt.error)
            {
                MessageBox.Show(rrt.errorMessage);
            } else
            {
                GettingServiceDetails gsd = new GettingServiceDetails();
                _returnDict = gsd.serializeTeamString(rrt.returnedDataString);
            }
            return _returnDict;
        }

        private void loadIncidentScreen()
        {
            string[] startDateString = getDate(StartDateInput).Split('/');
            string[] endDateString = getDate(EndDateInput).Split('/');
            string teamName = ((TeamItem)TeamPicker.SelectedItem).id;
            RequestStringBuilder rsb = new RequestStringBuilder();
            GettingServiceDetails gsd = new GettingServiceDetails();
            //if (GettingServiceDetails.loginDetails.Count < 2)
            //{
            //    GettingServiceDetails.loginDetails.Add("userName", getUserName(UsernameInput));
            //    GettingServiceDetails.loginDetails.Add("password", getPassword(PasswordInput));
            //}
            ResponseResultTemplate value = gsd.MakeRequestToServiceNow(rsb.getIncidentRequestString(startDateString, endDateString, teamName));
            if (value.error)
            {
                StatusBox.Text = value.errorMessage;
            }
            else
            {
                IncidentPage inc = new IncidentPage(value.returnedDataString);
                inc.Show();
            }
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            StatusBox.Text = "Loading Team Data...";
            GettingServiceDetails gsd = new GettingServiceDetails();
            RequestStringBuilder rsb = new RequestStringBuilder();
            if (GettingServiceDetails.loginDetails.Count < 2)
            {
                GettingServiceDetails.loginDetails.Add("userName", getUserName(UsernameInput));
                GettingServiceDetails.loginDetails.Add("password", getPassword(PasswordInput));
            }
            ResponseResultTemplate teamData = gsd.MakeRequestToServiceNow(rsb.getTeamRequestString());
            if (teamData.error)
            {
                StatusBox.Text = teamData.errorMessage;
                
            }
            else
            {
                TeamPicker.DataSource = sortTeamList(serializeTeams(gsd.MakeRequestToServiceNow(rsb.getTeamRequestString())));
                DetailsPanel.Visible = true;
                LoginButton.Visible = false;
                StatusBox.Text = "Teams Loaded. ";
            }
        }

        private void GetIncidents_Click(object sender, EventArgs e)
        {
            loadIncidentScreen();
        }
    }
}
