
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Reasearch_other_methods_using_files
{
    public partial class Form1 : Form
    {
        // File path
        private string filePath = Path.Combine(
            Application.StartupPath, "home.txt");

        public Form1()
        {
            InitializeComponent();
        }

        // Create file and write text inside it
        private void btncreating_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("Welcome to C# File Handling");
                writer.WriteLine("This is the first line in the file.");
                writer.WriteLine("This is the second line in the file.");
                writer.WriteLine("We are using WriteLine() method.");
            }

            MessageBox.Show("File created and text written successfully!");
        }

        // Read file using StreamReader
        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                listBox_items_from_thefile.Items.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox_items_from_thefile.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found. Please create the file first.");
            }
        }

        // Read file using ReadAllLines()
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                listBox_items_from_thefile.Items.Clear();

                string[] lines = File.ReadAllLines(filePath);

                listBox_items_from_thefile.Items.AddRange(lines);
            }
            else
            {
                MessageBox.Show("File not found. Please create the file first.");
            }
        }

        // Read file using ReadLines()
        private void btn_readlines_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                listBox_items_from_thefile.Items.Clear();

                foreach (string line in File.ReadLines(filePath))
                {
                    listBox_items_from_thefile.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found. Please create the file first.");
            }
        }

        // Delete selected item from file
        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            if (listBox_items_from_thefile.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            string selectedItem =
                listBox_items_from_thefile.SelectedItem.ToString();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            if (lines.Remove(selectedItem))
            {
                File.WriteAllLines(filePath, lines);

                listBox_items_from_thefile.Items.Remove(
                    listBox_items_from_thefile.SelectedItem);

                MessageBox.Show("Item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Item not found in the file.");
            }
        }

        // Delete the entire file
        private void btn_deletefile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the entire file?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                File.Delete(filePath);

                listBox_items_from_thefile.Items.Clear();

                MessageBox.Show("File deleted successfully.");
            }
        }
    }
}