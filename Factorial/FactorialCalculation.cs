using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    /*
     * Created by: Kok Wah
     * Date Created: 29 Aug 2017
     */
    public partial class FactorialCalculation : Form
    {
        public static int type = 0;
        public FactorialCalculation()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                if (type == 0)
                {
                    int value = Compute.Factorial(Convert.ToInt32(textBox1.Text));
                    Result.Text = Convert.ToString(value);
                }
                else
                {
                    int value = Compute.Fib(Convert.ToInt32(textBox1.Text));
                    Result.Text = Convert.ToString(value);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            type = 1;
            label1.Text = "Fibonacci using recursion";
            btnChange.Enabled = false;
            btnChange.BackColor = Color.White;
            btnchange2.Enabled = true;
            btnchange2.BackColor = Color.Black;
        }

        private void btnchange2_Click(object sender, EventArgs e)
        {
            type = 0;
            label1.Text = "Factorial using recursion";
            btnchange2.Enabled = false;
            btnchange2.BackColor = Color.White;
            btnChange.Enabled = true;
            btnChange.BackColor = Color.Black;
        }

        private void FactorialCalculation_Load(object sender, EventArgs e)
        {
            btnchange2.BackColor = Color.White;
        }
    }
}
