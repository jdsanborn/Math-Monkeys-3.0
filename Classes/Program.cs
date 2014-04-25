/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Program
 * -start the initial loging form- generated function by Visual Studio
 * 
 * Modified:
 * 
 * 14 March, 2014 
 * Jonathan Sanborn
 * added threading and mutex to only allow one instance of program to run.
 *                      http://www.ai.uga.edu/mc/SingleInstance.html
 *      
 * 17 April, 2014
 * Jeff Bunce and Arun Gopinath
 * Small refactors in most .cs files
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO; 
//when we have our xml
using System.Xml;

using System.Threading;
using System.Diagnostics;


namespace Math_Monkeys
{
    static class Program
    {
         /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = true;

            using (Mutex mutex = new Mutex(true, "Math Monkeys", out createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    MMControl programController = new MMControl();
                    programController.RunProgram();
                    //Application.Run(new frmLogin()); 
                }
                else
                {
                    MessageBox.Show("Math Monkeys is already running.", "Math Monkeys", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
                }
            }



            #region Test Code

            /* XmlDocument xd = new XmlDocument();
             xd.Load(@"\t.xml");
            // Console.WriteLine(xd.SelectSingleNode("Test/testitem/name").InnerText);
             //Console.ReadKey(); 
             * */

            #endregion


        }
    }
}
