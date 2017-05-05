using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using WindowsFormsApplication1.Services;
using WindowsFormsApplication1.ClassModels;
using WindowsFormsApplication1.HelperClasses;

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
            //RequestStringBuilder.teamDictionary.Add("Dev - Advice & Activations", "4e877bbf0f25e200afcf38b362050eb7");
            //RequestStringBuilder.teamDictionary.Add("Dev - Finance", "818a77b30f65e200afcf38b362050ea7");
            //RequestStringBuilder.teamDictionary.Add("Dev - Client Maintenance", "0dc937b30f65e200afcf38b362050e08");
            //These will be placed in a more appropriate file, and the list 
            //Extended to include all relevant chart properties
            GraphDataTemplate gdt1 = new GraphDataTemplate();
            gdt1.chartName = "By Application";
            gdt1.incidentPropertyName = "Application";
            gdt1.seriesName = "By Application";
            gdt1.xAxisLabelName = "Application";  
            GraphDataTemplate gdt2 = new GraphDataTemplate();
            gdt2.chartName = "By Solution";
            gdt2.incidentPropertyName = "ClosureCode";
            gdt2.seriesName = "By Solution";
            gdt2.xAxisLabelName = "Solutions";
            GraphDataTemplate gdt3 = new GraphDataTemplate();
            gdt3.chartName = "By Duration";
            gdt3.incidentPropertyName = "DurationName";
            gdt3.seriesName = "By Duration";
            gdt3.xAxisLabelName = "Incidents";
            GraphDataTemplate gdt4 = new GraphDataTemplate();
            gdt4.chartName = "By Priority";
            gdt4.incidentPropertyName = "Priority";
            gdt4.seriesName = "By Priority";
            gdt4.xAxisLabelName = "Priority";
            GraphDataTemplate gdt5 = new GraphDataTemplate();
            gdt5.chartName = "By Closed Date";
            gdt5.incidentPropertyName = "ClosedDate";
            gdt5.seriesName = "By Closed Date";
            gdt5.xAxisLabelName = "Per Day";
            GraphDataTemplate gdt6 = new GraphDataTemplate();
            gdt6.chartName = "By Owner";
            gdt6.incidentPropertyName = "Owner";
            gdt6.seriesName = "By Owner";
            gdt6.xAxisLabelName = "Owner";
            Chart.gdtList.Add(gdt1);
            Chart.gdtList.Add(gdt2);
            Chart.gdtList.Add(gdt3);
            Chart.gdtList.Add(gdt4);
            Chart.gdtList.Add(gdt5);
            Chart.gdtList.Add(gdt6);

            DurationInterval di1 = new DurationInterval();
            di1.intervalName = "Less than a day";
            di1.minValue = 0;
            di1.maxValue = 1;
            DurationInterval di2= new DurationInterval();
            di2.intervalName = "1-2 Days";
            di2.minValue = 1;
            di2.maxValue = 2;
            DurationInterval di3 = new DurationInterval();
            di3.intervalName = "2-3 Days";
            di3.minValue = 2;
            di3.maxValue = 3;
            DurationInterval di4 = new DurationInterval();
            di4.intervalName = "Up to a week";
            di4.minValue = 4;
            di4.maxValue = 7;
            DurationInterval di5 = new DurationInterval();
            di5.intervalName = "Up to a month";
            di5.minValue = 8;
            di5.maxValue = 30;
            DurationInterval di6 = new DurationInterval();
            di6.intervalName = "Over a month";
            di6.minValue = 31;
            di6.maxValue = 100000000;
            Chart.intervalList.Add(di1);
            Chart.intervalList.Add(di2);
            Chart.intervalList.Add(di3);
            Chart.intervalList.Add(di4);
            Chart.intervalList.Add(di5);
            Chart.intervalList.Add(di6);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
    }
}


