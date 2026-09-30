using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            try

            {
                
                string Food1, food2, full_data;
                int price1, price2, total;

                Food1=txtfood1.Text;
                food2 = txtfood2.Text;
                price1 = int.Parse(txtprice1.Text);
                price2=int.Parse(txtprice2.Text);
                total=price1 + price2;

                double TAX = total* 0.07;

                full_data= "Total:" + total+ "Tax:"+TAX;

                lblcalculate.Text = full_data;
                















       


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);


            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfood1.Text = "";
            txtfood2.Text = "";
            txtprice1.Text = "";
            txtprice2.Text = "";
            lblcalculate.Text = "";
        }
    }
}
