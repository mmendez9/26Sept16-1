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
                MessageBox.Show("Got valid input", "Average", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isInputValid()
        {
            double exam1, exam2;
            if (double.TryParse(tbxExam1.Text, out exam1) && double.TryParse(tbxExam2.Text, out exam2))
            {
                if ((exam1 >= 0 && exam1 <= 100) && (exam2 >= 0 && exam2 <= 100))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Exams out of range", "Average", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } 
            else
            {
                MessageBox.Show("Exams missing or not numeric", "Average", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
