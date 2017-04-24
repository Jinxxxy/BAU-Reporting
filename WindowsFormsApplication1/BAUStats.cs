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

namespace WindowsFormsApplication1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        public string GetUserName(TextBox _usernameInput)
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
                MessageBox.Show("This is blank");
                return rawUsername;
            }
        }

        private string getPassword(TextBox _passwordInput)
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

        public string MakeRequestToServiceNow()
        {
            //Testing
            string username = GetUserName(this.UsernameInput);
            string password = getPassword(this.PasswordInput);
            //Testing
                        
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password))
                );
            var response = client.GetAsync("https://stepchangeprod.service-now.com/api/now/table/incident?sysparm_limit=10&assignment_group=Dev%20-%20Advice%20%26%20Activations");
            string result;
            try
            {
                result = response.Result.Content.ReadAsStringAsync().Result;
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
                result = "{data:{name:none}}";
            }
            return result;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string value = MakeRequestToServiceNow();
            IncidentPage inc = new IncidentPage(value);
            inc.Show();
        }
    }
}
