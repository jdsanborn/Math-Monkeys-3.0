/********************************************
 * CSUSM CS 441 Spring 2014
 * The Code Monkeys
 * Project: Math Monkeys
 * Class Name: frmWelcomeStudent.cs
 * File Name: frmWelcomeStudent
 * UI Design: Arun Gopinath
 * Author: Jonathan Sanborn
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated Comments
 * 
 * ********************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Monkeys.Forms
{
    public partial class frmDrillResult : Form
    {
        private MMControl MMControl;

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Constructor
        /// </summary>
        /// <param name="mmControl">The Controller Object</param>
        public frmDrillResult(MMControl mmControl)
        {
            InitializeComponent();
            MMControl = mmControl;


            if (MMControl.CurrentStudent.IncompleteAssignments > 0)
            {
                btnNextAssignment.Enabled = true;
            }
            else
            {
                btnNextAssignment.Enabled = false;
            }
            
            lblNumCorrect.Text = MMControl.AssignmentSession.ProblemsCorrect.ToString();
            lblNumWrong.Text = MMControl.AssignmentSession.ProblemsIncorrect.ToString();
            lblPercentGrade.Text = MMControl.AssignmentSession.AssignmentAttempted.Grade.ToString("p");
            lblTimeSpent.Text = MMControl.AssignmentSession.AssignmentAttempted.TimeSpent.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Logs the current user out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MMControl.UserLogout(sender, e);
        }

        /// <summary>
        /// Gets the next assignment for the logged in user
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="e">the event arguments</param>
        private void btnNextAssignment_Click(object sender, EventArgs e)
        {
            MMControl.StartDrill(sender, e);
        }

        private void lblNumWrong_Click(object sender, EventArgs e)
        {

        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }

        private void lblPercentGrade_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeSpent_Click(object sender, EventArgs e)
        {

        }

        private void gbxResults_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
