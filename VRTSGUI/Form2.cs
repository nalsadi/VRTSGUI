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
using System.Text.RegularExpressions;

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

            textBox2.Text = Data.printString("CarListSpaceRight", "CarListSpaceRight");
            textBox1.Text = "";
        }
        string previousInput = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* Regex r = new Regex("^-{0,1}\d+\.{0,1}\d*$"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(textBox1.Text);
            if (m.Success)
            {
                previousInput = textBox1.Text;
            }
            else
            {
                textBox1.Text = previousInput;
            }*/

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("NEW KEYYY");
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
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
            /*bool Flag = false;
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
            }*/
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("NEW KEYYY");
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
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
            String farLaneSpace = Data.printString("CarListSpaceLeft", "CarListSpaceLeft") ;
            String closeLaneSpace = Data.printString("CarListSpaceRight", "CarListSpaceRight");

            Int32 count = 210;
            String final = "";
            String[] strlist = new String[210];
            String[] strlist1 = new String[210];
            char[] spearator = { ' ' };

            
            // DCP is Array 27
            strlist = farLaneSpace.Split(spearator, count, StringSplitOptions.None);
            strlist1 = closeLaneSpace.Split(spearator, count, StringSplitOptions.None);
            if (textBox7.Text != "None") {
                Console.WriteLine("HERE");
                if (Math.Abs(float.Parse(strlist[1]) - float.Parse(strlist1[1])) != float.Parse(textBox7.Text)) {
                    strlist[1] = (float.Parse(strlist1[1]) + float.Parse(textBox7.Text)).ToString();
                }
            }
            //Console.WriteLine("Hello " + int.Parse(strlist[1]) + int.Parse(strlist1[1]) + "Between");
            Console.WriteLine(string.Join(" ", strlist));
            Console.WriteLine("HJK" + strlist1.Length);
            for (int i =0; i < strlist1.Length; i++)
            {
               // Console.WriteLine(i + " : " + strlist[i] + "\n");
            }

             
            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO trialList (trialType, trialBehav,CarSpaceRight,CarSpaceLeft) VALUES (@trialType, @trialBehav,@CarSpaceRight,@CarSpaceLeft);";
            cmd.Parameters.AddWithValue("@trialType", cbTrialType.Text);
            cmd.Parameters.AddWithValue("@trialBehav", cbCarBehaviour.Text);
            cmd.Parameters.AddWithValue("@CarSpaceRight", Data.printString("CarListSpaceRight", "CarListSpaceRight"));
            cmd.Parameters.AddWithValue("@CarSpaceLeft", string.Join(" ", strlist));
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
