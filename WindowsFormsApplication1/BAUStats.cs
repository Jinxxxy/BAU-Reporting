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

namespace WindowsFormsApplication1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
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
                MessageBox.Show("This is blank");
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

        

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            GettingServiceDetails gsd = new GettingServiceDetails();
            if(GettingServiceDetails.loginDetails.Count < 2)
            {
                GettingServiceDetails.loginDetails.Add("userName", getUserName(UsernameInput));
                GettingServiceDetails.loginDetails.Add("password", getPassword(PasswordInput));
            }            
            string value = gsd.MakeRequestToServiceNow("https://stepchangeprod.service-now.com/api/now/table/incident?sysparm_fields=subcategory%2Cassigned_to.name%2Cclosed_at%2Csys_created_on%2Cu_closure_code%2Cu_closure_sub_code%2Cassignment_group.name%2Cdescription%2Cshort_description%2Cpriority%2Cnumber&assignment_group=Dev%20-%20Advice%20%26%20Activations");
            IncidentPage inc = new IncidentPage(value);
            inc.Show();
        }
    }
}
