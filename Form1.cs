using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taking_App
{
    public partial class Note : Form
    {
        DataTable table;
        public Note()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Notes", typeof(String));

            dataGridView1.DataSource = table;
            
            dataGridView1.Columns["Notes"].Visible = false;
            dataGridView1.Columns["Title"].Width = 244;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtNote.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtNote.Text);

            txtTitle.Clear();
            txtNote.Clear();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if(index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtNote.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete this note?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            int index = dataGridView1.CurrentCell.RowIndex;
            if (result == DialogResult.Yes)
                table.Rows[index].Delete();
            else
                return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                e.Cancel = !true;
            else
                e.Cancel = true;
        }
    }
}
