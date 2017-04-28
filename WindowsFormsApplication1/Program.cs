using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using WindowsFormsApplication1.Services;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RequestStringBuilder.teamDictionary.Add("Dev - Advice & Activations", "4e877bbf0f25e200afcf38b362050eb7");
            RequestStringBuilder.teamDictionary.Add("Dev - Finance", "818a77b30f65e200afcf38b362050ea7");
            RequestStringBuilder.teamDictionary.Add("Dev - Client Maintenance", "0dc937b30f65e200afcf38b362050e08");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
    }
}


