using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - Aug 10, 2017
 * Description - BMR Calculator 
 * Version: 0.2 - Added Spalash screen before load the BMR calculator app
 */
namespace Assignment05_BMR_Calcualtor_App
{
    public partial class BMRCalculatorForm : Form
    {
        public BMRCalculatorForm()
        {
            Thread t = new Thread(new ThreadStart(ProgressStart));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        public void ProgressStart()
        {
            Application.Run(new HomePage());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
