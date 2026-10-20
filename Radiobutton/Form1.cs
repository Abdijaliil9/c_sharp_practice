using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {


                string name, gender;
                string Foculty = "";
                int age, validation;
                if (int.TryParse(txtage.Text, out validation))

                {
                    age = int.Parse(txtage.Text);
                    name = txtname.Text;
                    if (age >= 18)
                    {
                        listBox1.Items.Add("magacaga :"+name);
                        listBox1.Items.Add("da,da :"+age);
                    }
                    else
                    {
                        MessageBox.Show("you are under age");
                    }

                    if (radioButton1.Checked)
                    {
                        gender = "male";
                        listBox1.Items.Add("your gender is :" + gender);
                    }

                    else if (radioButton2.Checked)
                    {
                        gender = "female";
                        listBox1.Items.Add("your gender is :" + gender);
                    }

                    else
                    {
                        MessageBox.Show("are male or female");
                    }

                    if (checkBox1.Checked && checkBox2.Checked)
                        
                    {
                        MessageBox.Show("choose only one foculty");

                    }
                    else if (checkBox2.Checked)
                    {
                        Foculty = "IT";
                        listBox1.Items.Add("your foculty is: " + Foculty);
                    }

                    else if(checkBox1.Checked)
                    {

                        Foculty = "computer";
                        listBox1.Items.Add("your foculty is: " + Foculty);
                        
                        
                    }

                    else
                    {
                        MessageBox.Show("choose foculty");
                    }


                    

                }

            }
            catch (Exception ex) {


                MessageBox.Show(ex.Message);
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtage.Text = "";
            txtname.Text = "";
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            checkBox2.Checked=false;
            checkBox1 .Checked=false;
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selections;
            selections=listBox1.SelectedItem.ToString();
            MessageBox.Show(selections);

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
