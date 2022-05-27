using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);            
            MessageBox.Show("The sum is: " + AddUp(num1, num2).ToString());
        }
        private int AddUp(int firstnum, int secnum)
        {                    
            return firstnum + secnum;
        }
    }
}
