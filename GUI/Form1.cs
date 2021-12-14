using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numberOne = int.Parse(textBox1.Text);
            int numberTwo = int.Parse(textBox2.Text);
            int sum = numberOne + numberTwo;
            label3.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOne = int.Parse(textBox1.Text);
            int numberTwo = int.Parse(textBox2.Text);
            int sub = numberOne - numberTwo;
            label3.Text = sub.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numberOne = int.Parse(textBox1.Text);
            int numberTwo = int.Parse(textBox2.Text);
            int multi = numberOne * numberTwo;
            label3.Text = multi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numberOne = int.Parse(textBox1.Text);
            int numberTwo = int.Parse(textBox2.Text);
            int divide = numberOne / numberTwo;
            label3.Text = divide.ToString();
        }
    }
}
