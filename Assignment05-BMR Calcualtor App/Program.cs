using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - Aug 04, 2017
 * Description - BMR Calculator
 * Version: 0.1 - Created project
 */
namespace Assignment05_BMR_Calcualtor_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
