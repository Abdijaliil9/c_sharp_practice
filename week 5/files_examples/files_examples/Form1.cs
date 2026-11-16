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

namespace files_examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating new file
            StreamWriter Outputfile;

            //open file 
            //create new file using create text function

            Outputfile=File.CreateText("Ca242.txt");

            //process the file
            //writting in the file  using write() or wrilteline()
            Outputfile.WriteLine("Best class in semester 5 is");
            Outputfile.WriteLine("jamhuuriya university ");
            Outputfile.WriteLine("subject C# ");

            //close file using close file 
            Outputfile.Close();

            //
            MessageBox.Show("the file is created successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //import clas
                StreamReader reads;
                //open file - reading the file
                reads=File.OpenText("Ca242.txt");


                string lines = reads.ReadLine();
                //string lines = reads.ReadToEnd();

                while (reads.EndOfStream==false) { 

                    lines = reads.ReadToEnd();
                    listBox1.Items.Add(lines);
                     
                
                }

                reads.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);    
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string lines;
            lines=File.ReadAllText("Ca242.txt");
            listBox1.Items.Add(lines);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try 
            {
                StreamWriter writes;

                writes=File.AppendText(@"Ca242.txt");

                writes.WriteLine("c#");
                writes.WriteLine("java");
                writes.WriteLine("html");
                writes.WriteLine("css");

                writes.Close();
            }
           
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
