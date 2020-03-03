using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRTSGUI
{ 

    public partial class Form2 : Form
    {
        private readonly Form1 frm1; //readonly is optional (For safety purposes)

        public Form2(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
    }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "INSERT INTO dbo.CarListSpaceRight (CarListSpaceRight) VALUES (@CarListSpaceRight)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CarListSpaceRight", textBox1.Text);
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool Flag = false;
            int i = 0;
            foreach (char c in textBox1.Text)
            {
                if (c < '0' || c > '9' || i>3)
                {
                    Flag = true;
                    break;
                }
                i++;
            }
            if(Flag == true)
            {
                textBox1.Text = textBox1.Text.Substring(0, i);
                textBox1.SelectionStart = i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
           
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "DELETE FROM CarListSpaceRight WHERE ID=(SELECT MAX(Id) FROM CarListSpaceRight)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@CarListSpaceRight", textBox1.Text);
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            bool Flag = false;
            int i = 0;
            foreach (char c in textBox6.Text)
            {
                if (c < '0' || c > '9' || i > 3)
                {
                    Flag = true;
                    break;
                }
                i++;
            }
            if (Flag == true)
            {
                textBox6.Text = textBox6.Text.Substring(0, i);
                textBox6.SelectionStart = i;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "INSERT INTO dbo.CarListSpaceLeft (CarListSpaceLeft) VALUES (@CarListSpaceLeft)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CarListSpaceLeft", textBox6.Text);
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            textBox5.Text = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");
            textBox6.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLfx Data = new SQLfx();
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection

            String query = "DELETE FROM CarListSpaceLeft WHERE ID=(SELECT MAX(Id) FROM CarListSpaceLeft)";
            //WIPE TABLE ---- String query = "DELETE FROM dbo.CarListSpaceDIRECTION";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@CarListSpaceLeft", textBox1.Text);
            cmd.ExecuteNonQuery();
            //Data.closeSQLConnection(con);
            textBox5.Text = Data.printString("CarListSpaceLeft", "CarListSpaceLeft");
            textBox6.Text = "";
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            

            SQLfx Data = new SQLfx();

            Console.WriteLine("HELLO " + Data.printString("CarListSpaceLeft", "CarListSpaceLeft"));

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO trialList (trialType, trialBehav,CarSpaceRight,CarSpaceLeft) VALUES (@trialType, @trialBehav,@CarSpaceRight,@CarSpaceLeft);";
            cmd.Parameters.AddWithValue("@trialType", cbTrialType.Text);
            cmd.Parameters.AddWithValue("@trialBehav", cbCarBehaviour.Text);
            cmd.Parameters.AddWithValue("@CarSpaceRight", Data.printString("CarListSpaceRight", "CarListSpaceRight"));
            cmd.Parameters.AddWithValue("@CarSpaceLeft", Data.printString("CarListSpaceLeft", "CarListSpaceLeft"));
            cmd.ExecuteNonQuery();

            frm1.updateDataTable();
            this.Close();

            String query = "DELETE FROM dbo.CarListSpaceRight";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM dbo.CarListSpaceLeft";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            // cmd.Connection = con;
            //this.Hide();


        }

        private void cbTrialType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCarBehaviour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
