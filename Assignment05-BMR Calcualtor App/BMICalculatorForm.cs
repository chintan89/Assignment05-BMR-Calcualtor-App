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
 * Date - Aug 14, 2017
 * Description - BMI Calculator 
 * Version: 0.3 - Part 1 - Modified the property of the BMI calculator app
 */
namespace Assignment05_BMR_Calcualtor_App
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
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

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear all
            txtAge.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";

            textBox1.Text = "";


            // enable all the textbox
            txtAge.Enabled = true;
            txtHeight.Enabled = true;
            txtWeight.Enabled = true;
        }
//BMI Calculator (Q2)
        private void btnCalculate_Click(object sender, EventArgs e)
        {


        }
    }
}
