/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Form3Remove
 *   Functions:
 *      Event Handlers functions: 
 *          btnRemove_Click(...) display a Message box to make sure they are ok with they selection
 *          Form3Remove_Load(...)calls UpdateDDL()
 *          ddlStudentRemove_SelectedIndexChanged_1(...) gets the user name to be removed and sets it to userToRemove
 *      RemoveUser(), the process to remove user
 *      UpdateDDL(), the process to populate user for remove form drop down list
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
    // Coder of this class - Jeff Cribben
    public partial class Form3Remove : Form
    {
        ListOfUsersXMLHandler userHandler = new ListOfUsersXMLHandler();
        protected string userToRemove;

        public Form3Remove()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //those the remove stuff and shows a message box to verify if this is what they desire
            //then close
            DialogResult result = MessageBox.Show("Are you sure you want to remove " + userToRemove + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { // remove
                RemoveUser();
            }
            else
            {     //don't remove user
            }
        }

        private void RemoveUser()
        {

            try
            {
                userHandler.RemoveUserFromXML(userToRemove, "ListOfUsers.xml");
                UpdateDDL();
                ddlStudentRemove.SelectedIndex = 0;
            }
            catch (Exception e)
            {
            }

        }
        private void UpdateDDL()
        {

            ddlStudentRemove.Items.Clear();

            List<string> EndUserList = new List<string>();
            EndUserList.Clear();

            string filename = "ListOfUsers.xml"; // FILENAME OF LIST OF USERS XML
            EndUserList = userHandler.GetUserNames(filename);


            for (int i = 1; i < EndUserList.Count; i++)
            {
                try
                {
                    ddlStudentRemove.Items.Insert(i - 1, EndUserList[i]); // Removes default admin from remove list
                }
                catch (ArgumentOutOfRangeException x)
                {

                }
            }

        }

        private void Form3Remove_Load(object sender, EventArgs e)
        {
            UpdateDDL();
            ddlStudentRemove.SelectedIndex = 0; // Sets default position for the drop down list

        }

        private void ddlStudentRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            userToRemove = ddlStudentRemove.SelectedItem.ToString(); // Gets the user to remove's name
        }

        private void ddlStudentRemove_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            userToRemove = ddlStudentRemove.SelectedItem.ToString();
        }

    }
}
