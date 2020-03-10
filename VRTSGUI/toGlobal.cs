using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace VRTSGUI
{
    public class toGlobal
    {
        public void ee()
        {
            Form1 mainForm = new Form1();
            SQLfx Data = new SQLfx();

            int counter = 0;
            string line;
            string[] array = new String[100];



           ///////// -------- Begin Reading Globals File, Line By Line, Stored In Array ----------------------
            
            //  Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\User\source\repos\nalsadi\VRTSGUI\VRTSGUI\Globals.py");
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                array[counter] = line;
                counter++;
            }
            System.Console.WriteLine("\n\nHERE: {0} ", array[26]);
            file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            //System.Console.ReadLine();

            ///////// -------- Get Values From SQL Database, Stored As Local Variables ----------------------

            String DCP = Data.printString("properties", "DCP");
            String NMD = Data.printString("properties", "NMD");
            String RSD = Data.printString("properties", "RSD");
            String RND = Data.printString("properties", "RND");
            String FCA = Data.printString("properties", "FCA");
            String PCA = Data.printString("properties", "PCA");
            String MPA = Data.printString("properties", "MPA");

            String CSR = Data.printCS("trialList", "CarSpaceRight");
            
            ///////// -------- Line By Line Parse and Modify Values From Array ----------------------

            char[] spearator = {'='};
            Int32 count = 2;
            String final = "";
            String[] strlist = new String[2];
            String[] cS = new String[2];

            //strlist = array[26].Split('  ');
            cS = CSR.Split(':');
            Console.WriteLine("CSR: " + cS.Length);


            // DCP is Array 27
            strlist = array[26].Split(spearator, count, StringSplitOptions.None);
            array[26] = strlist[0] + " = " + DCP;

            // NMD is Array 28
            strlist = array[27].Split(spearator, count, StringSplitOptions.None);
            array[27] = strlist[0] + " = " + NMD;

            // RSD is Array 33
            strlist = array[32].Split(spearator, count, StringSplitOptions.None);
            array[32] = strlist[0] + " = " + RSD;

            // RND is Array 34
            strlist = array[33].Split(spearator, count, StringSplitOptions.None);
            array[33] = strlist[0] + " = " + RND;

            // FCA is Array 45
            strlist = array[44].Split(spearator, count, StringSplitOptions.None);
            array[44] = strlist[0] + " = " + FCA;
           
            // PCA is Array 46
            strlist = array[45].Split(spearator, count, StringSplitOptions.None);
            array[45] = strlist[0] + " = " + PCA;

            // MPA is Array 48
            strlist = array[47].Split(spearator, count, StringSplitOptions.None);
            array[47] = strlist[0] + " = " + MPA;


            string[] newArray = new String[array.Length + cS.Length];
            for(int i = 0; i< 53; i++)
            {
                newArray[i] = array[i];
            }
            // Needs defensive programming -- What if no entires in DataTable??
           

            SqlConnection con = Data.openSQLConnection(); // Open SQL Connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM trialList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StringBuilder output = new StringBuilder();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    output.AppendFormat("{0},", dr[col]);
                }

                output.AppendLine();
            }
            Console.WriteLine("KO --");
            Console.WriteLine(output);
            Console.WriteLine("--\n\n");
            String[] strlist1 = new String[200];
            Int32 count1 = 200;
            char[] spearator1 = { ',', '\0', '\n','\t'};
            string newoutput = output.ToString();

            // DCP is Array 27
            strlist1 = newoutput.Split(spearator1, count1, StringSplitOptions.None);
            Console.WriteLine(strlist1[2]);
            String TrialType = strlist1[1];
            String TrialBehav = strlist1[2];
            String CSR1 = strlist1[3];
            String CSL1 = strlist1[4];
            String replace = Regex.Replace(CSL1, @"\t|\n|\r|,", "");
            string[] CSR12 = Regex.Split(CSR1, @"\D+");

            //  Once all values are in array, respective to their lines, then write array element by element to file line by line
            string finalCSR = string.Join(",", CSR12, 1, CSR12.Length - 1);
            Console.WriteLine("\n\n" + string.Join(",",CSR12,1, CSR12.Length-1));
            if(finalCSR[finalCSR.Length-1] == ',')
            {
                finalCSR = finalCSR.Substring(0, finalCSR.Length - 1);
            }
            Console.WriteLine("\n\n" + finalCSR + "\n\n\n");
            Console.WriteLine(string.Format("TrialType." + TrialType + ", " + "None" + ", " + "CarBehaviour." + TrialBehav + ", " + "[" + finalCSR + "]" + ", " + "[" + replace + "]" + "\n"));

            // Write the string array to a new file named "WriteLines.txt".--- Will need to be chnaged to Globals.py
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("WriteLines.txt")))
            {
                for (int i = 0; i < counter; i++)
                {
                    outputFile.WriteLine(array[i]);
                }
            }
            //  Now run the python scipt to start main simulation




            //  Clean out database when all values have been put into file


        }

    }
   

}
