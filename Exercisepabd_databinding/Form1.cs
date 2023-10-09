using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercisepabd_databinding
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textfBox_nama.Text == "Ridwan" && textBox_pass.Text == "1234")
            {
                new Form2().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Please check your Username and Password");
                textfBox_nama.Clear();
                textBox_pass.Clear();
                textfBox_nama.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
