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
 * Date - Aug 15, 2017
 * Description - BMI Calculator 
 * Version: 0.6 - Modified splash screen function that displays beging of the disply BMI app
 * https://www.youtube.com/watch?v=EcZQghn88vE
 */
namespace Assignment05_BMR_Calcualtor_App
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {//splash screen
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            InitializeComponent();
            string str = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                str += ToString();
            }
            t.Abort();
        }
        void splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "BMI Calculator App";
            frm.Icon = Properties.Resources.bmi2;
            frm.ShowIcon = true;
            frm.ShowInTaskbar = true;
            frm.BackgroundImage = Properties.Resources.bmi4;
            Application.Run(frm);
        }
     

        //A Reset button that reset’s the screen to its original state
        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear all
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";
            txtBMIScale.Text = "";
            rbtnImperial.Checked = false;
            rbtnMetric.Checked = false;
            txtBMIScale.BackColor = Color.White;
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
                    if (rbtnMetric.Checked == true)
                    {
                        //The Formula for BMI Metric is as follows
                        bmi = Weight / ((Height) * (Height));
                        txtResult.Text = Convert.ToString(bmi);

                    }

                    //BMI Imperial
                    else if (rbtnImperial.Checked == true)
                    {
                        //The Formula for BMI Imperial is as follows
                        bmi = (Weight * 703) / ((Height) * (Height));
                        txtResult.Text = Convert.ToString(bmi);

                    }
                    //List of BMI scale with change of appropriate background color
                    if (Convert.ToDouble(txtResult.Text) <= 18.5)
                    {
                        txtBMIScale.Text = "Under Weight";
                        txtBMIScale.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToDouble(txtResult.Text) > 18.5 && Convert.ToDouble(txtResult.Text) <= 24.9)
                    {
                        txtBMIScale.Text = "Normal Weight";
                        txtBMIScale.BackColor = Color.Green;
                    }
                    else if (Convert.ToDouble(txtResult.Text) >= 25 && Convert.ToDouble(txtResult.Text) <= 29.9)
                    {
                        txtBMIScale.Text = "Over Weight";
                        txtBMIScale.BackColor = Color.Maroon;
                    }
                    else if (Convert.ToDouble(txtResult.Text) >= 30)
                    {
                        txtBMIScale.Text = "Obese";
                        txtBMIScale.BackColor = Color.Red;
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
