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


            ///////// -------- Line By Line Parse and Modify Values From Array ----------------------

            char[] spearator = {'='};
            Int32 count = 2;
            String final = "";
            String[] strlist = new String[2];



            // DCP is Array 26
            strlist = array[26].Split(spearator, count, StringSplitOptions.None);
            final = strlist[0] + " = " + DCP;
            System.Console.WriteLine("\n\nHERE: {0} ", final);



            //  Once all values are in array, respective to their lines, then write array element by element to file line by line
            //  Now run the python scipt to start main simulation
            //  Clean out database when all values have been put into file
        }

    }
   

}
