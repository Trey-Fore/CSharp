using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalcodeproblemcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Open";
            label2.Text = "Open";
            label3.Text = "Open";
            label4.Text = "Open";
            label5.Text = "Open";
            label6.Text = "Open";
            label7.Text = "Open";
            label8.Text = "Open";
            label9.Text = "Open";
            label10.Text = "Open";
        }
        bool[] seats = { false, false, false, false, false, false, false, false, false, false };
        int i = 0;
        int n = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {

                if (i < 5 & i >= 0)
                {
                    if (seats[i] == false)
                    {
                        seats[i] = true;
                        
                    }

                }
                i++;
                if (i > 5)
                {
                    DialogResult dialogResult = MessageBox.Show("We apologize, our First Class seats are all booked. Would you like to downgrade your ticket to Coach?", "First Class at Full Capacity", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int j = 9;
                        if (seats[j] == true) j--;
                        if (j > 4 & seats[j] == false) seats[j] = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Next flight leaves in 3 hours.");
                    }
                }

            }

            if (radioButton1.Checked)
            {
                if (n < 10)
                {
                    if (seats[n] == false)
                    {
                        seats[n] = true;
                        
                    }
                    
                }
                n++;
                if (n>10)
                {
                        DialogResult dialogResult = MessageBox.Show("We apologize, our coach seats are all booked. Would you like to upgrade your ticket to First Class?", "Coach at Full Capacity", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int j = 5;
                        if (seats[j] == true) j--;
                        if (j <= 5 & seats[j] == false) seats[j] = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Next flight leaves in 3 hours.");
                    }
                }


                

            }
            if (seats[0] == false) label1.Text = "Open";
            else label1.Text = "Booked";
            if (seats[1] == false) label2.Text = "Open";
            else label2.Text = "Booked";
            if (seats[2] == false) label3.Text = "Open";
            else label3.Text = "Booked";
            if (seats[3] == false) label4.Text = "Open";
            else label4.Text = "Booked";
            if (seats[4] == false) label5.Text = "Open";
            else label5.Text = "Booked";
            if (seats[5] == false) label6.Text = "Open";
            else label6.Text = "Booked";
            if (seats[6] == false) label7.Text = "Open";
            else label7.Text = "Booked";
            if (seats[7] == false) label8.Text = "Open";
            else label8.Text = "Booked";
            if (seats[8] == false) label9.Text = "Open";
            else label9.Text = "Booked";
            if (seats[9] == false) label10.Text = "Open";
            else label10.Text = "Booked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
