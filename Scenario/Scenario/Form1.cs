using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scenario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            try
            {
                string name = txtname.Text;
                string id = txtid.Text;
                string year = txtyear.Text;
                

                int courses;
                double courseAmount;
                double discount = 0;
                double finalAmount;

                // Check courses
                if (!int.TryParse(txtcourses.Text, out courses) || courses < 1 || courses > 8)
                {
                    MessageBox.Show("Courses must be an integer between 1 and 8.");
                    
                }

                // Calculate course amount according to year
                if (year == "year1")
                {
                    courseAmount = courses * 40;
                }
                else if (year == "year2")
                {
                    courseAmount = courses * 45;
                }
                else if (year == "year3")
                {
                    courseAmount = courses * 50;
                }
                else if (year == "year4")
                {
                    courseAmount = courses * 55;
                }
                else
                {
                    MessageBox.Show("Enter a valid year.");
                    return;
                }

                // 10% discount if courses are 6 or more
                if (courses >= 6)
                {
                    discount = courseAmount * 10 / 100;
                }
                else
                {
                    discount = 0;
                }

                // Final amount after discount
                double transport =double.Parse( txtTrans.Text);
                finalAmount = (courseAmount - discount)+transport;

                // Display result
                string Full_data =
                    "Name: " + name +
                    "Study Level: " + year +
                    "Courses: " + courses +
                    "Transport: " + transport +
                    "Course Fee: $" + courseAmount +
                    "Discount: $" + discount +
                    "Final Registration Fee: $" + finalAmount;

                lblresult.Text = Full_data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
