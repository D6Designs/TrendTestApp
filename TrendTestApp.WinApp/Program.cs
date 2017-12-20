using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrendTestApp.ModelServices;
using TrendTestApp.BusinessServices;
using TrendTestApp.Repository;
using TrendTestApp.Repository.Interfaces;
using TrendTestApp.Common;
using TrendTestApp.ModelServices.Interfaces;
using Autofac;

namespace TrendTestApp.WinApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IoCInit.InitialiseIoC();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(IoCInit.GetScope().Resolve<ICompanyModelService>()));

         
        }
    }
}
