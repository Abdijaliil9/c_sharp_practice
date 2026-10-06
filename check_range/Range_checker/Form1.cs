using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //check if the input is a valid number

            double validation; 
            if (double.TryParse(txtinputuser.Text, out validation))
            {
                //execption handling
                try
                {
                    //declare variables

                    double number, decision;

                    //initialize variables
                    number=double.Parse(txtinputuser.Text);

                    //check if the number is in range
                    if (number >= 1 && number <= 10)
                    {
                        //if the number is in range, assign it to decision variable
                        decision = number ;

                        //display the result in the label

                        lblshowdecision.Text =  " Number " + decision.ToString()+" is in range: " ;

                    }
                    else
                    {
                        lblshowdecision.Text = " Number " + number.ToString() + " is out of range: ";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtinputuser.Clear();
            lblshowdecision.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
