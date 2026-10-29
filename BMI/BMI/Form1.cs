using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclaculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, height, BMI;
                if(double.TryParse(txtweight.Text, out weight) && double.TryParse(textBox2.Text, out height))
                    
                    
                {
                    weight=double.Parse(txtweight.Text);
                    height=double.Parse(textBox2.Text);
                    BMI = weight/ (height * height);
           
                    if (BMI < 18.5)
                    {
                    
                    
                        listBox1.Items.Add("your bmi is :" + BMI);
                        listBox1.Items.Add("Underweight");
                    
                    
                    }
                    else if (BMI > 18.5 && BMI < 25)
                    {
                        listBox1.Items.Add("your bmi is :" + BMI);
                        listBox1.Items.Add("optimal weight");


                    }
                    else
                    {
                        listBox1.Items.Add("your bmi is :" + BMI);
                        listBox1.Items.Add("overweight");
                    }
                }
                         
                else
                {
                    MessageBox.Show("enter valid weight");
                }



            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            
            }

        }
    }
}
