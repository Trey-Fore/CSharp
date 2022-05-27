using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fcost = 0.00, days = 0.00, meds = 0.00, surg = 0.00, lab = 0.00, phys = 0.00, stay = 0.00, misc = 0.00;

            days = double.Parse(textBoxdays.Text);
            meds = double.Parse(textBoxmeds.Text);
            surg = double.Parse(textBoxsurg.Text);
            lab = double.Parse(textBoxlab.Text);
            phys = double.Parse(textBoxrehab.Text);

            stay = CalcStayCharges(days);
            misc = CalcMiscCharges(meds, surg, lab, phys);
            fcost = CalcTotalCharges(stay,misc);
           
            labelfinal.Text = "$" + fcost;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public double CalcStayCharges(double num)
        {
            num = num * 350.00;
            return num;
        }

        public double CalcMiscCharges(double num, double num1,double num2,double num3)
        {
            double total;
            total = num + num1 + num2 + num3;
            return total;
        }

        public double CalcTotalCharges(double num, double num1)
        {
            double total;
            total = num + num1;
            return total;
        }



    }
}
