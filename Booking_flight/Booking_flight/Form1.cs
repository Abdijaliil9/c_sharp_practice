using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Booking_flight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnclaculate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                string travel_class;

                int age, num_Tickets, Baggage_weight, validation;

                double Discount = 0, Ticket_discount = 0;
                int Ticket_price = 0;
                int Ticket_cost = 0;

                double Child_discount = 0;
                double Senior_discount = 0;
                double Insurance_cost = 0;
                double Final_cost = 0;


                if (int.TryParse(txtage.Text, out validation) &&
                    int.TryParse(txtTickets.Text, out validation) &&
                    int.TryParse(txtweight.Text, out validation))
                {
                    age = int.Parse(txtage.Text);
                    num_Tickets = int.Parse(txtTickets.Text);
                    Baggage_weight = int.Parse(txtweight.Text);


                    if (age >= 1 && age <= 100)
                    {
                        if (num_Tickets >= 1 && num_Tickets <= 5)
                        {
                            if (Baggage_weight >= 0 && Baggage_weight <= 50)
                            {
                                listBox1.Items.Clear();


                                // Travel Class

                                if (age <= 12 && radiofirstclass.Checked)
                                {
                                    travel_class = "Rejected";
                                    Ticket_price = 150;
                                }
                                else if (radiofirstclass.Checked)
                                {
                                    travel_class = "First class";
                                    Ticket_price = 150;
                                }
                                else if (radioBussnesclass.Checked)
                                {
                                    travel_class = "Business class";
                                    Ticket_price = 500;
                                }
                                else if (radionormalclass.Checked)
                                {
                                    travel_class = "Normal class";
                                    Ticket_price = 300;
                                }
                                else
                                {
                                    MessageBox.Show("Choose Travel class");
                                    return;
                                }


                                // Ticket Cost

                                Ticket_cost = Ticket_price * num_Tickets;


                                // Ticket Discount

                                if (num_Tickets >= 3 && num_Tickets <= 4)
                                {
                                    Ticket_discount = Ticket_cost * 0.05;
                                }
                                else if (num_Tickets == 5)
                                {
                                    Ticket_discount = Ticket_cost * 0.10;
                                }
                                else
                                {
                                    Ticket_discount = 0;
                                }


                                // Child Discount

                                if (age < 12)
                                {
                                    Child_discount = Ticket_cost * 0.20;
                                }
                                else
                                {
                                    Child_discount = 0;
                                }


                                // Senior Discount

                                if (age >= 60)
                                {
                                    Senior_discount = Ticket_cost * 0.10;
                                }
                                else
                                {
                                    Senior_discount = 0;
                                }


                                // Total Discount

                                Discount = Ticket_discount +
                                           Child_discount +
                                           Senior_discount;


                                // Insurance Cost

                                if (checkbox1.Checked)
                                {
                                    Insurance_cost = 25 * num_Tickets;
                                }
                                else
                                {
                                    Insurance_cost = 0;
                                }


                                // Final Cost

                                Final_cost = Ticket_cost -
                                             Discount +
                                             Insurance_cost;


                                // Display Passenger Information

                                listBox1.Items.Add("AIRLINE TICKET BOOKING");
                                listBox1.Items.Add("------------------------------");

                                listBox1.Items.Add("Passenger Name: " + name);
                                listBox1.Items.Add("Passenger Age: " + age);
                                listBox1.Items.Add("Number of Tickets: " + num_Tickets);

                                listBox1.Items.Add("Travel Class: " + travel_class);

                                // Reason for First Class Rejection

                                if (age < 12 && radiofirstclass.Checked)
                                {
                                    listBox1.Items.Add(
                                        "Reason: Passengers under 12 years cannot travel First Class."
                                    );
                                }


                                listBox1.Items.Add(
                                    "Baggage Weight: " + Baggage_weight + " KG"
                                );

                                listBox1.Items.Add("------------------------------");


                                // Ticket and Discount Information

                                listBox1.Items.Add("Ticket Price: $" + Ticket_price);

                                listBox1.Items.Add(
                                    "Basic Ticket Cost: $" + Ticket_cost
                                );

                                listBox1.Items.Add(
                                    "Ticket Discount: $" + Ticket_discount
                                );

                                listBox1.Items.Add(
                                    "Child Discount: $" + Child_discount
                                );

                                listBox1.Items.Add(
                                    "Senior Discount: $" + Senior_discount
                                );

                                listBox1.Items.Add(
                                    "Total Discount: $" + Discount
                                );

                                listBox1.Items.Add(
                                    "Insurance Cost: $" + Insurance_cost
                                );


                                // Baggage Information

                                if (Baggage_weight <= 20)
                                {
                                    listBox1.Items.Add("Baggage: Free");
                                }
                                else
                                {
                                    listBox1.Items.Add(
                                        "Baggage: Above free allowance"
                                    );
                                }


                                // Final Booking Information

                                listBox1.Items.Add("------------------------------");

                                listBox1.Items.Add(
                                    "Final Cost: $" + Final_cost
                                );

                                listBox1.Items.Add("Booking Status: Approved");
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Baggage weight must be between 0 and 50 KG"
                                );
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Number of tickets must be between 1 and 5"
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid age. Age must be between 1 and 100"
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Age, Tickets and Baggage weight must be numbers"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtage.Text = "";
            txtTickets.Text = "";
            txtweight.Text = "";
            listBox1.Items.Clear();
            radioBussnesclass.Checked = false;
            radiofirstclass.Checked = false;
            radionormalclass.Checked = false;
            checkbox1.Checked = false;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
