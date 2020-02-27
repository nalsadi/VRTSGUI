using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            textBox2.Text = textBox5.Text;
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
            double feet;
            double meters = 0;
            try
            {
                feet = double.Parse(textBox6.Text);
                meters = feet / 3.2808 + meters;
            }
            catch (Exception eq)
            {
                feet = 0;
                meters = 0;
            }

            double inches = 0;
            try
            {
                inches = double.Parse(textBox4.Text);
                meters = meters + ((inches / 12) / 3.2808);
            }
            catch (Exception eq)
            {
                meters = meters; //Dont do anything 
            }

            textBox5.Text = System.Convert.ToString(meters);
        }

        private void btnAddTrial_Click(object sender, EventArgs e)
        {
            Form trialForm = new Form2();
            //this.Hide();
            trialForm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            double feet;
            double meters = 0;
            try
            {
                feet = double.Parse(textBox6.Text);
                meters = feet / 3.2808 + meters;
            }
            catch (Exception eq)
            {
                feet = 0;
                meters = 0;
            }

            double inches = 0;
            try
            {
                inches = double.Parse(textBox4.Text);
                meters = meters + ((inches/12)/3.2808);
            }
            catch (Exception eq)
            {
                meters = meters; //Dont do anything 
            }
            meters = Math.Round(meters, 2);
            textBox5.Text = System.Convert.ToString(meters);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double ms, km = 0;
            try
            {
                km = double.Parse(textBox10.Text);
                ms = km / 3.6;
            }
            catch (Exception eq)
            {
                ms = 0;
            }
            ms = Math.Round(ms, 2);
            textBox9.Text = System.Convert.ToString(ms);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataCollectionPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO properties (DCP, NMD, RSD, RND, FCA, PCA, MPA) VALUES (@DCP, @NMD, @RSD, @RND, @FCA, @PCA, @MPA);";
            cmd.Parameters.AddWithValue("@DCP", txtDataCollectionPeriod.Text);
            cmd.Parameters.AddWithValue("@NMD", txtNearMissDistance.Text);
            cmd.Parameters.AddWithValue("@RSD", txtRespawnStartDistance.Text);
            cmd.Parameters.AddWithValue("@RND", txtRespawnEndDistance.Text);
            cmd.Parameters.AddWithValue("@FCA", txtFullCheckAngle.Text);
            cmd.Parameters.AddWithValue("@PCA", txtPartialCheckAngle.Text);
            cmd.Parameters.AddWithValue("@MPA", txtMaxPitchAngle.Text);
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            //textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            //textBox1.Text = "";
        }

        private void txtNearMissDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVisualTest_Click(object sender, EventArgs e)
        {
            toGlobal fileStuff = new toGlobal();
            fileStuff.ee();

            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();
           // cmd.Connection = con;

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM trialList",con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
