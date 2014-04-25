/********************************************
 * CSUSM CS 441 Spring 2014
 * The Code Monkeys
 * Project: Math Monkeys
 * Class Name: frmWelcomeStudent.cs
 * File Name: frmWelcomeStudent
 * UI Design: Arun Gopinath
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
using Math_Monkeys.Forms;

namespace Math_Monkeys.Forms
{
    public partial class frmStudentWelcome : Form
    {

        private MMControl MMControl;

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Constructor
        /// </summary>
        /// <param name="mmControl">Controller Object</param>
        public frmStudentWelcome(MMControl mmControl)
        {
            InitializeComponent();
                    
            MMControl = mmControl;

            lblUserName.Text = MMControl.CurrentUser.GetFullName;
            lblLoginDate.Text = MMControl.CurrentUser.LastLogin().Date.ToString();
            lblDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
            tmrClock.Start();

        }

    
        /// <summary>
        /// Jonathan Sanborn
        /// Updates the Current Time label to the current time
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Event Arguments</param>
        private void tmrClock_Tick(object sender, EventArgs e)
        {
           lblDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        } 

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Starts the Math Drill
        /// </summary>
        /// <param name="sender">The object that raised this event</param>
        /// <param name="e">The event arguments</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            MMControl.StartDrill(sender,e);
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Logs the current user out of the system
        /// </summary>
        /// <param name="sender">The object that raised this event</param>
        /// <param name="e">the event arguments</param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MMControl.UserLogout(sender, e);
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
  
    }
}
