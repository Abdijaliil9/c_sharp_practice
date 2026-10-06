using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Validate the data types of the input values

            double check;

            if (double.TryParse(txthours.Text, out check) && double.TryParse(txtpayrate.Text, out check))
            {
                try
                {
                    //declare variables
                    double hours, payRate, gross_pay;

                    //initialize variables

                    hours = double.Parse(txthours.Text);
                    payRate = double.Parse(txtpayrate.Text);

                    //ckecking 
                    if (hours>0) {
                        if (payRate>0)
                        {
                            //calculate gross pay

                            gross_pay=hours * payRate;

                            //display gross pay
                            lblshow.Text = "Gross Pay: $" + gross_pay.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Pay rate must be greater than zero.");
                        }
                        

                }
                    else
                    {
                        MessageBox.Show("Hours worked must be greater than zero.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }




            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthours.Text = "";
            txtpayrate.Text = "";
            lblshow.Text = "";
        }
    }
}
