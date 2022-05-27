using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpTreecontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip tooltip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.InitialDelay = 1000;
            toolTip1.UseFading = true;
            tooltip1.SetToolTip(button1, "Click me to get help");

            ComboBox combobox1 = new ComboBox();
            combobox1.Name = "combobox1";
            combobox1.Size = new System.Drawing.Size(245, 25);
            combobox1.BackColor = System.Drawing.Color.Black;
            combobox1.ForeColor = System.Drawing.Color.Orange;

            Controls.Add(combobox1);
            combobox1.Items.Add("C++");
            combobox1.Items.Add("C#");
            combobox1.Items.Add("Java");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string name in comboBox1.Items)
            {
                sb.Append(name);
                sb.Append(" ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            MessageBox.Show(selectedItem);
        }
    }
}
