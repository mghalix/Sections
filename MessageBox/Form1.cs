using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Section
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            DialogResult msgBox = MessageBox.Show("Are you sure?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (msgBox == DialogResult.No)
            {
                return;
            }
            else if (msgBox == DialogResult.Cancel)
            {
                return;
            }

            string display = $"Name: {name}\r\nAge: {age}";
            if (radioButton1.Checked)
                display += $"\r\nGender: {radioButton1.Text}";
            else if (radioButton2.Checked)
                display += $"\r\nGender: {radioButton2.Text}";
            else
            {
                MessageBox.Show($"Please select your {groupBox1.Text}", "Incomplete", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                return;
            }

            if (ABp.Checked)
                display += $"\r\nBlood Type: {ABp.Text}";
            else if (ABn.Checked)
                display += $"\r\nBlood Type: {ABn.Text}";
            else if (Ap.Checked)
                display += $"\r\nBlood Type: {Ap.Text}";
            else if (An.Checked)
                display += $"\r\nBlood Type: {An.Text}";
            else if (Bp.Checked)
                display += $"\r\nBlood Type: {Bp.Text}";
            else if (Bn.Checked)
                display += $"\r\nBlood Type: {Bn.Text}";
            else if (Op.Checked)
                display += $"\r\nBlood Type: {Op.Text}";
            else if(On.Checked)
                display += $"\r\nBlood Type: {On.Text}";
            else
            {
                MessageBox.Show($"Please Select Your {groupBox2.Text}", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }


            textBox3.Text = display;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                e.Cancel = !true;
            }
            else
                e.Cancel = true;
        }
       
    }
}
