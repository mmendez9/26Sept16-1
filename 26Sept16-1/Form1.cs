using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26Sept16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCalculate_Click(object sender, EventArgs e)
        {
            if (isInputValid() == true)
            {
                calAverage();
                //MessageBox.Show("Got valid input", "Average", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isInputValid()
        {
            double exam1, exam2;
            exam2 = 0;
            exam1 = 0;
            if (isFieldValid(Exam1, exam1) && isFieldValid(Exam2, exam2))
                return true;
            else
                return false;
        }

        private bool isFieldValid(TextBox name, double exm)
        {
            if (double.TryParse(name.Text,out exm))
            {
                if (exm >= 0 && exm <= 100)
                    return true;
                else
                {
                    MessageBox.Show(name.Name + " out of range", "Average", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(name.Name + " missing or not numeric", "Average", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void calAverage()
        {
            double average, ex1, ex2;

            ex1 = double.Parse(Exam1.Text);
            ex2 = double.Parse(Exam2.Text);

            average = (ex1 + ex2) / 2;
            tbxAverage.Text = average.ToString() + "%";
        }
    }
}
