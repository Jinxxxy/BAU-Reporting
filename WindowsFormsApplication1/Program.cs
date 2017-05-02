using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using WindowsFormsApplication1.Services;
using WindowsFormsApplication1.ClassModels;

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
            //This are being added solely for Dev purposes
            //These will be replaced by a call to get this information and will include all teams.
            RequestStringBuilder.teamDictionary.Add("Dev - Advice & Activations", "4e877bbf0f25e200afcf38b362050eb7");
            RequestStringBuilder.teamDictionary.Add("Dev - Finance", "818a77b30f65e200afcf38b362050ea7");
            RequestStringBuilder.teamDictionary.Add("Dev - Client Maintenance", "0dc937b30f65e200afcf38b362050e08");
            //These will be placed in a more appropriate file, and the list 
            //Extended to include all relevant chart properties
            GraphDataTemplate gdt1 = new GraphDataTemplate();
            gdt1.chartName = "By Application";
            gdt1.incidentPropertyName = "Application";
            gdt1.seriesName = "By Application";
            
            GraphDataTemplate gdt2 = new GraphDataTemplate();
            gdt2.chartName = "By Solution";
            gdt2.incidentPropertyName = "ClosureCode";
            gdt2.seriesName = "By Solution";
            GraphDataTemplate gdt3 = new GraphDataTemplate();
            gdt3.chartName = "By Duration";
            gdt3.incidentPropertyName = "Duration";
            gdt3.seriesName = "By Duration";
            RequestStringBuilder.gdtList.Add(gdt1);
            RequestStringBuilder.gdtList.Add(gdt2);
            RequestStringBuilder.gdtList.Add(gdt3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
    }
}


