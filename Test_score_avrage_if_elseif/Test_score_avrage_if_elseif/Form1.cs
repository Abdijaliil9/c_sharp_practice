using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_score_avrage_if_elseif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create variables to store the three scores
                double score1;
                double score2;
                double score3;

                // Create a variable to store the average
                double avrage;


                // Try to convert the text from all three TextBoxes into double numbers
                // TryParse returns true if the text is a valid number
                if (double.TryParse(txtscore1.Text, out score1) && double.TryParse(txtscore2.Text, out score2)
                    && double.TryParse(txtscore3.Text, out score3))
                {
                    // Check if score1 is less than 0 or greater than 100
                    if (score1 < 0 || score1 > 100)
                    {
                        // Show an error message if score1 is not between 0 and 100
                        MessageBox.Show("score1 must be between 0 and 100");


                    }
                    // If score1 is correct, check if score2 is less than 0 or greater than 100
                    else if (score2 < 0 || score2 > 100)
                    {
                        // Show an error message if score2 is not between 0 and 100
                        MessageBox.Show("score2 must be between 0 and 100");
                    }
                    // If score1 and score2 are correct, check score3
                    else if (score3 < 0 || score3 > 100)
                    {
                        // Show an error message if score3 is not between 0 and 100
                        MessageBox.Show("score3 must be between 0 and 100");
                    }
                    // If all three scores are valid
                    else
                    {
                        // Calculate the average of the three scores
                        avrage = (score1 + score2 + score3) / 3;

                        // Convert the average to text and display it in the label
                        lblresult.Text = avrage.ToString();
                    }
                }

                // If TryParse fails, one or more TextBoxes do not contain a valid number
                else
                {
                    // Show an error message to the user
                    MessageBox.Show("this textBox only accept Double dataType ");

                }
            }

            
            catch (Exception ex)
            {
                // Display the error message
                MessageBox.Show(ex.Message);
            }

        }

        
        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear the first score TextBox
            txtscore1.Text = "";

            // Clear the second score TextBox
            txtscore2.Text = "";

            // Clear the third score TextBox
            txtscore3.Text = "";

            // Clear the result label
            lblresult.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}
