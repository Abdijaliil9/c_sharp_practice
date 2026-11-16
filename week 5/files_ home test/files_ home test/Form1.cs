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

namespace files__home_test
{
    public partial class Form1 : Form
    {
        public object OpenFile { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            //StreamWriter Outputfile;
            //Outputfile = File.CreateText("Homde.txt");

            //creating new file
            //File.Create("Home.txt");
            //MessageBox.Show("the file is created successfully");

            // creating files
            StreamWriter Outputfile;
            Outputfile= File.CreateText("data.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //writing in the file  using write() or wrilteline()
            //File.WriteAllText("Home.txt", "jamhuuriya university");
            //File.WriteAllText("Home.txt", "Best class in semester 5 is");
            //File.WriteAllText("Home.txt", "CA242");
            //File.WriteAllText("Home.txt", "so");

            StreamWriter Outputfile;
            Outputfile= File.CreateText("data.txt");
            Outputfile.WriteLine("full name is: abdibaari mohamed ali ");
            Outputfile.WriteLine("age is: 22 ");
            Outputfile.WriteLine("gender is: male ");
            Outputfile.WriteLine("university is: jamhuriya ");
            Outputfile.WriteLine("semester is: 5 ");
            Outputfile.WriteLine("class is: CA242 ");

            MessageBox.Show(Path.GetFullPath("data.txt"));
            //MessageBox.Show("its been written successfully"); 

            //

            Outputfile.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            DialogResult result;
            result =openFileDialog1.ShowDialog();
            //checking
            if (result==DialogResult.OK)
            {
                //open file to read its elements
                reads=File.OpenText(openFileDialog1.FileName);
                string lines;
                //string lines = reads.ReadLine();
                //string lines = reads.ReadToEnd();

                while (reads.EndOfStream==false)
                {

                    lines = reads.ReadLine();
                    listBox1.Items.Add(lines);
                   


                }

                //string lines;
                //lines = File.ReadAllText("data.txt");
                //listBox1.Items.Add(lines);
                reads.Close();
            }
            else if (result==DialogResult.Cancel)
            {
                MessageBox.Show("file not opened");
            }
            //reader=File.ReadAllText("data.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            string lines;
            StreamWriter writes;
            DialogResult result;
            result= saveFileDialog1.ShowDialog();

            if (result==DialogResult.OK)
            {
                writes= File.CreateText(saveFileDialog1.FileName);

                //proces
                writes.WriteLine("Hello");
                writes.Close();
                //listBox1.Items.Add(writes);
                reads=File.OpenText(openFileDialog1.FileName);
                lines=reads.ReadLine();
                listBox1.Items.Add(lines);
            }
            else if(result==DialogResult.Cancel)
            {

            }
        }
    }
}
