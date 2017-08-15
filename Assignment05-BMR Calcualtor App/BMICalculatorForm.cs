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
 * Version: 0.4 - Part 2 - Added functionality to the BMI calculator app
 * https://www.youtube.com/watch?v=EcZQghn88vE
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

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }
        //A Reset button that reset’s the screen to its original state
        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear all
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            // enable all the textbox
            txtHeight.Enabled = true;
            txtWeight.Enabled = true;
        }
        //Q-2. BMICalculator Functionality
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //adding require local variables

            double bmi, Height, Weight;

            try
            {
                //2- D & F - local variables - convert to numbers
                Height = Convert.ToDouble(txtHeight.Text);
                Weight = Convert.ToDouble(txtWeight.Text);


                //2- D & F - Text box of Height and Weigh can't be empty
                if (txtHeight.Text == "" || txtWeight.Text == "")
                {
                    MessageBox.Show("Text box of Height and Weigh can't be empty!");
                }

                //2- D & F - Input of Height and Weight can't be minus or zero
                else if (Height <= 0 || Weight <= 0)
                {
                    MessageBox.Show("Input of Height and Weight can't be minus or zero!");
                    txtHeight.Focus();
                    txtHeight.SelectAll();
                }
                else if (Height > 0 || Weight > 0)
                {

                    //2-G. disabled inputed textboxes
                    txtHeight.Enabled = false;
                    txtHeight.Enabled = false;

                    //BMI Metric
                    if (lblMetric.Checked == true)
                    {

                        //The Formula for BMI Metric is as follows
                        bmi = Weight / ((Height) * (Height));
                       txtResult.Text = Convert.ToString(bmi);       
                    }

                    //BMI Imperial
                    else if (lblImperial.Checked == true)
                    {
                        //The Formula for BMI Imperial is as follows
                        bmi = (Weight * 703) / ((Height) * (Height));
                        txtResult.Text = Convert.ToString(bmi);

                        //List of BMI scale 

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill up form properly");
                txtHeight.Focus();
                txtHeight.SelectAll();
            }
        }
        /* This code implemented to limit the user's entry to improve input validation
        https://www.youtube.com/watch?v=EcZQghn88vE */
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
