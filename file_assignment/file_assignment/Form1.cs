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
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace file_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Haddii user-ku doorto file-ka
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Append ayan u isticmaleyna si aan wax ugu darno kii hore
                // xogti horana wano tale
                StreamWriter outputFile;
                outputFile= File.AppendText(saveFileDialog.FileName);

                // new data
                outputFile.WriteLine(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
               

                // Xir file-ka marka qoristu dhammaato
                outputFile.Close();
                textBox1.Text="";

                
            }




 

        }
    }
}
