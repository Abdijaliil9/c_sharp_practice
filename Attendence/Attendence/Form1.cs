
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text="";
            txtname.Text="";
            txtdepart.Text = "";
            radioButtonabsent.Checked = false;
            radioButtonpresent.Enabled = false;
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            int count;
            count = listBox1.Items.Count;
            lblcount.Text = "total records are: " + count.ToString();
        }

        private void record_Click(object sender, EventArgs e)
        {
            int id, valdiate;
            string name, department;

            if (!int.TryParse(txtdepart.Text, out valdiate))
            {
                id = int.Parse(txtid.Text);
                name = txtname.Text;
                department = txtdepart.Text;

                if (!radioButtonpresent.Checked && !radioButtonabsent.Checked)
                {
                    MessageBox.Show("pleas select present or absent");
                    return;
                }

                StreamReader reads;
                string lines;
                StreamWriter writes;
                DialogResult result;

                result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    writes = File.AppendText(saveFileDialog1.FileName);

                    if (radioButtonpresent.Checked)
                    {
                        writes.WriteLine("id :" + txtid.Text);
                        writes.WriteLine("name" + txtname.Text);
                        writes.WriteLine("department" + txtdepart.Text);
                        writes.WriteLine("attendence: present");
                    }
                    else if (radioButtonabsent.Checked)
                    {
                        writes.WriteLine("id :" + txtid.Text);
                        writes.WriteLine("name" + txtname.Text);
                        writes.WriteLine("department" + txtdepart.Text);
                        writes.WriteLine("attendence: absent");
                    }

                    writes.Close();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MessageBox.Show("please inte numeric id");
            }
        }

        private void btnfreadile_Click(object sender, EventArgs e)
        {
            StreamReader reads;

            DialogResult result;
            result = openFileDialog1.ShowDialog();

            //checking
            if (result == DialogResult.OK)
            {
                //open file to read its elements
                reads = File.OpenText(openFileDialog1.FileName);
                string lines;

                //string lines = reads.ReadLine();
                //string lines = reads.ReadToEnd();

                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();
                    listBox1.Items.Add(lines);
                }

                reads.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("file not opened");
            }

            //reader=File.ReadAllText("data.txt");
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                String selectedItem = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("please select item to remove");
            }
        }
    }
}

