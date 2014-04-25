/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: AssignNewProblemSet
 * 
 * //currently not implemented 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Monkeys
{
    // Not implemented yet
    public partial class AssignNewProblemSet : Form
    {
        User _Student = new User(); 

        public AssignNewProblemSet()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //trying to attempt to create a new assigment set for selectef student


        }
    }
}
