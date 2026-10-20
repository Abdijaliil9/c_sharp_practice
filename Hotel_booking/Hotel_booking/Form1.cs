using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_booking
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                int age, number_nights, number_guest;

                double roomRate = 0;
                double totalCost = 0;
                double discount = 0;
                double breakfastCost = 0;
                double serviceCharge = 0;
                double seniorDiscount = 0;

                bool boolaproved = false;
                string roomtype = "";

                if (int.TryParse(txtage.Text, out age) &&
                    int.TryParse(txtnights.Text, out number_nights) &&
                    int.TryParse(txtguest.Text, out number_guest))
                {
                    if (name != "")
                    {
                        if (age >= 18 && age <= 90)
                        {
                            if (number_nights >= 1 && number_nights <= 30)
                            {
                                if (number_guest >= 1 && number_guest <= 6)
                                {
                                    if (radiohight.Checked)
                                    {
                                        roomtype = "high";
                                    }
                                    else if (radionormal.Checked)
                                    {
                                        roomtype = "normal";
                                    }
                                    else if (radiostandard.Checked)
                                    {
                                        roomtype = "standard";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please choose a room type");
                                    }

                                    switch (roomtype)
                                    {
                                        case "standard":
                                            if (number_guest <= 2)
                                            {
                                                roomRate = 50;
                                                boolaproved = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Standard room allows maximum 2 guests");
                                            }
                                            break;

                                        case "normal":
                                            if (number_guest <= 4)
                                            {
                                                roomRate = 80;
                                                boolaproved = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Normal room allows maximum 4 guests");
                                            }
                                            break;

                                        case "high":
                                            if (number_guest <= 6)
                                            {
                                                roomRate = 130;
                                                boolaproved = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("High room allows maximum 6 guests");
                                            }
                                            break;

                                        default:
                                            break;
                                    }

                                    if (boolaproved == true)
                                    {
                                        totalCost = roomRate * number_nights;

                                        if (number_nights >= 1 && number_nights <= 4)
                                        {
                                            discount = 0;
                                        }
                                        else if (number_nights >= 5 && number_nights <= 9)
                                        {
                                            discount = totalCost * 0.05;
                                        }
                                        else if (number_nights >= 10)
                                        {
                                            discount = totalCost * 0.12;
                                        }

                                        totalCost = totalCost - discount;

                                        if (checkBox1.Checked)
                                        {
                                            breakfastCost = number_guest * number_nights * 10;
                                            totalCost = totalCost + breakfastCost;
                                        }

                                        if (number_guest > 4)
                                        {
                                            serviceCharge = totalCost * 0.05;
                                            totalCost = totalCost + serviceCharge;
                                        }

                                        if (age >= 60)
                                        {
                                            seniorDiscount = totalCost * 0.05;
                                            totalCost = totalCost - seniorDiscount;
                                        }

                                        listBox1.Items.Add("===== BOOKING DETAILS =====");
                                        listBox1.Items.Add("Guest Name: " + name);
                                        listBox1.Items.Add("Guest Age: " + age);
                                        listBox1.Items.Add("Room Type: " + roomtype);
                                        listBox1.Items.Add("Room Rate: $" + roomRate);
                                        listBox1.Items.Add("Number of Guests: " + number_guest);
                                        listBox1.Items.Add("Number of Nights: " + number_nights);
                                        listBox1.Items.Add("Room Cost: $" + (roomRate * number_nights));
                                        listBox1.Items.Add("Night Discount: $" + discount);
                                        listBox1.Items.Add("Breakfast Cost: $" + breakfastCost);
                                        listBox1.Items.Add("Service Charge: $" + serviceCharge);
                                        listBox1.Items.Add("Senior Discount: $" + seniorDiscount);
                                        listBox1.Items.Add("TOTAL COST: $" + totalCost);
                                        listBox1.Items.Add("Booking Approved: " + boolaproved);
                                        listBox1.Items.Add("==============================");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Number of guests must be between 1 and 6");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Number of nights must be between 1 and 30");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Guest age must be between 18 and 90");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the guest name");
                    }
                }
                else
                {
                    MessageBox.Show("Age, nights and guests must contain numeric values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
