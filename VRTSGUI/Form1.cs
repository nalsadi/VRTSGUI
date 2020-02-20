using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRTSGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddTrial_Click(object sender, EventArgs e)
        {
            Form trialForm = new Form2();
            this.Hide();
            trialForm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
            int feet;
            try
            {
                feet = int.Parse(textBox6.Text);
            }
            catch (Exception eq)
            {
                feet = 0;
            }

            int inches = 0;
            int totalInches;
            try
            {
                inches = int.Parse(textBox4.Text);
                totalInches = feet * 12 + inches;
            }
            catch (Exception eq)
            {
                totalInches = feet * 12;
            }
           
            textBox5.Text = System.Convert.ToString(totalInches/ 3.281);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
