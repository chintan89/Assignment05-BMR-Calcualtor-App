using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - Aug 10, 2017
 * Description - BMR Calculator 
 * Version: 0.1 - Added Spalash screen before load the BMR calculator app
 */
namespace Assignment05_BMR_Calcualtor_App
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SplashBar.Increment(1);
            if (SplashBar.Value == 100)
                timer1.Stop();
                      
        }
    }
}
