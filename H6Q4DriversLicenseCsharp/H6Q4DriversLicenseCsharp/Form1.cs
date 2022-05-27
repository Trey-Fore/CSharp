using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace H6Q4DriversLicenseCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                
                const int SIZE = 20;
                string[] gradekey = {"B","D","A","A","C",
                                     "A","B","A","C","D",
                                     "B","C","D","A","D",
                                     "C","C","B","D","A"};
                string[] studentscores = new string[SIZE];
                string[] incorrectscores = new string[SIZE];
                int incorrect = 0;
                int index = 0;
                int i = 0;
                bool arraysEqual = true;
                StreamReader inputFile;

                inputFile = File.OpenText("C:\\Users\\unloa\\OneDrive\\Desktop\\student_test.txt");
                while (index < studentscores.Length && !inputFile.EndOfStream)
                {
                    studentscores[index] = inputFile.ReadLine();
                index++;
                }
                inputFile.Close();

                if (studentscores.Length != gradekey.Length)
                {
                    arraysEqual = false;
                }
                while (arraysEqual && i < gradekey.Length)
                {
                  
                    if (gradekey[i] != studentscores[i])
                    {

                        incorrect++;
                        incorrectscores[i] = "False";

                }
                else { incorrectscores[i] = "True"; }
                    i++;
                }
                
                foreach (string value in studentscores)
                {
                    listBox1.Items.Add(value);
                }
                foreach (string value in gradekey)
                {
                    listBox2.Items.Add(value);
                }
                foreach (string value in incorrectscores)
                {
                    listBox3.Items.Add(value);
                }
            int correct = SIZE - incorrect;

            if (correct <= 14) label8.Text = "Test Failed";
            if (correct >= 15) label8.Text = "Test Passed!";

            label1.Text = incorrect.ToString();
            label2.Text = correct.ToString();
        }
    }
}
