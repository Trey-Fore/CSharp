using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharparrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[5] { 2,1,3,5,4};
            foreach (int i in array)
            {
                listBox1.Items.Add(i);
            }
            Array.Sort(array);
            listBox1.Items.Add("After Sort");
            foreach (int i in array)
            {
                listBox1.Items.Add(i);
            }
            Array.Reverse(array);
            listBox1.Items.Add("After Reverse");
            foreach (int i in array)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
