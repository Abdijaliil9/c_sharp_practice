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

namespace Employee_attendence
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // RECORD ATTENDANCE
        private void btnattendence_Click(object sender, EventArgs e)
        {
            string name, department;
            int id;

            string presentt = "Present";
            string absentt = "Absent";

            name = txtemponame.Text;
            department = txtDepartment.Text;

            if (name == "" || department == "")
            {
                MessageBox.Show("Please fill all information");
            }

            else if (int.TryParse(txtmpoId.Text, out id))
            {
                if (radiobtnpresent.Checked)
                {
                    StreamWriter present;

                    present = File.AppendText("attndence.txt");

                    present.WriteLine("Employee Name: " + name);
                    present.WriteLine("Employee ID: " + id);
                    present.WriteLine("Department: " + department);
                    present.WriteLine("Attendance: " + presentt);
                    present.WriteLine("--------------------------");

                    present.Close();

                    MessageBox.Show("Employee marked as Present");
                }

                else if (radioBtnabsent.Checked)
                {
                    StreamWriter absent;

                    absent = File.AppendText("attndence.txt");

                    absent.WriteLine("Employee Name: " + name);
                    absent.WriteLine("Employee ID: " + id);
                    absent.WriteLine("Department: " + department);
                    absent.WriteLine("Attendance: " + absentt);
                    absent.WriteLine("--------------------------");

                    absent.Close();

                    MessageBox.Show("Employee marked as Absent");
                }

                else
                {
                    MessageBox.Show("Choose Present or Absent");
                }
            }

            else
            {
                MessageBox.Show("ID must be an integer");
            }
        }


        // VIEW ATTENDANCE
        private void btnview_Click(object sender, EventArgs e)
        {
            StreamReader reades;

            reades = File.OpenText("attndence.txt");

            listBox1.Items.Clear();

            string lines;
            string record = "";

            while (reades.EndOfStream == false)
            {
                lines = reades.ReadLine();

                if (lines == "--------------------------")
                {
                    listBox1.Items.Add(record);
                    record = "";
                }

                else
                {
                    record = record + lines + " | ";
                }
            }

            reades.Close();
        }


        // REMOVE SELECTED
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                List<string> records = new List<string>();

                StreamReader reads;

                reads = File.OpenText("attndence.txt");

                string lines;
                string record = "";

                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();

                    if (lines == "--------------------------")
                    {
                        records.Add(record);
                        record = "";
                    }

                    else
                    {
                        record = record + lines + Environment.NewLine;
                    }
                }

                reads.Close();

                int selected = listBox1.SelectedIndex;

                records.RemoveAt(selected);

                StreamWriter writes;

                writes = File.CreateText("attndence.txt");

                for (int i = 0; i < records.Count; i++)
                {
                    writes.Write(records[i]);
                    writes.WriteLine("--------------------------");
                }

                writes.Close();

                MessageBox.Show("Employee removed successfully");

                btnview_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Please select employee first");
            }
        }


        // COUNT ATTENDANCE
        private void btncount_Click(object sender, EventArgs e)
        {
            int present = 0;
            int absent = 0;

            StreamReader reads;

            reads = File.OpenText("attndence.txt");

            string lines;

            while (reads.EndOfStream == false)
            {
                lines = reads.ReadLine();

                if (lines.Contains("Attendance: Present"))
                {
                    present++;
                }

                else if (lines.Contains("Attendance: Absent"))
                {
                    absent++;
                }
            }

            reads.Close();

            MessageBox.Show(
                "Present: " + present +
                "\nAbsent: " + absent +
                "\nTotal: " + (present + absent)
            );
        }


        // CLEAR
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmpoId.Clear();
            txtemponame.Clear();
            txtDepartment.Clear();

            radiobtnpresent.Checked = false;
            radioBtnabsent.Checked = false;

            txtmpoId.Focus();
        }


        // EXIT
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
