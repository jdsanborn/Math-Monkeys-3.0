/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: frmLogin
 * FileName: frmLogin.cs
 * 
 * Updated UI Design: Arun Gopinath
 * 
 * Modified
 * 30 March 2014
 * Jonathan Sanborn
 * 
 * 6 April 2014
 * Jonathan Sanborn
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * update comments
 * updated flowerbox
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO; 


namespace Math_Monkeys
{
    // Coder of this class - Mary Venegas + Jeff Cribben
    public partial class frmLogin : Form
    {
        private MMControl MMControl;

        /// <summary>
        /// Jonathan Sanborn
        /// Constructor
        /// 
        /// </summary>
        /// <param name="mmControl">The controller Object</param>
        public frmLogin(MMControl mmControl)
        {
            InitializeComponent();
            MMControl = mmControl;
            
            this.ddlUserName.SelectedIndexChanged += new EventHandler(MMControl.LoginSelectionChanged);

           userBindingSource.DataSource = MMControl.AllUserList;

            //done so that the selected index changed event fires
            //needs more elegent solution
           ddlUserName.SelectedIndex = -1;
           ddlUserName.SelectedIndex = 0;
           ddlUserName.Focus();
            
        }
        
        /// <summary>
        /// On form load Sets the inital time and
        /// set the focus to the user ddl
        /// </summary>
        /// <param name="sender">The object that rasied the event</param>
        /// <param name="e">The event arguments</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            setTime();
            this.ddlUserName.Focus(); 
        }

        /// <summary>
        /// Set the current date in login form
        /// </summary>
        /// <param name="sender">The object that raised this event</param>
        /// <param name="e">the event arguments</param>
        public void timer1_Tick(object sender, EventArgs e)
        {setTime();}

        /// <summary>
        /// 6 April 2014
        /// Jonathan Sanborn
        /// Consolidated code from muliple locations into one location
        /// 
        /// Displays the current time in the time label
        /// </summary>
        private void setTime()
        {
            this.lblTodayDate.Text = DateTime.Today.ToShortDateString();
            this.lblTodayDate.Text += " ";
            this.lblTodayDate.Text += DateTime.Now.ToShortTimeString();
        }

 
        /// <summary>
        /// 6 April 2014
        /// Jonathan Sanborn
        /// 
        /// Allows only valid charcters into the password text box
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">the event arguments</param>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.PasswordCharsOnly(sender, e);

            if (e.KeyChar == (char)Keys.Enter && txtPassword.Text.Length > 0)
            {
                MMControl.Login(sender, e);
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// Attempts the login the current user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MMControl.Login(sender, e);
        }

        /// <summary>
        /// Jonathan Sanborn
        /// Emptys the password field when a diffent user is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }

        private void lblPleaseChoose_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        #region DEPRECATED Code

        //private List<User> EndUserList = new List<User>();
        //public bool AdminWorking = false; 

        //ddlUserName.DataSource = mmControl.AllUserList;
        //ddlUserName.DisplayMember = "ScreenName";
        //ddlUserName.Update();
        //Form1_Load();


        //public frmLogin(ref User user)
        //{
        //    InitializeComponent();
        //    //this.ddlUserName = user;
        //}

        ////Fill out the dropDown list with user accessible to this application
        //public void updateDdlist()
        //{
        //    //ddlUserName.Items.Clear();
        //    //EndUserList.Clear(); 

        //    //ListOfUsersXMLHandler userHandler = new ListOfUsersXMLHandler();
            
        //    ////List<string> AdminList = userHandler.GetAdminList();
        //    //string filename = "ListOfUsers.xml"; // FILENAME OF LIST OF USERS XML
        //    //EndUserList = userHandler.ReadFile(filename);

        //    //btnBegin.Update();
        //    //for (int i = 0; i < EndUserList.Count; i++)
        //    //{
        //    //    try
        //    //    {
        //    //        ddlUserName.Items.Insert(i, EndUserList[i].ScreenName);
        //    //    }
        //    //    catch (ArgumentOutOfRangeException x)
        //    //    {

        //    //    }
        //    //}
        //}

        //when begin button is hit we determine which user was chosen and they applay the correct action
        //if admin type open the admin application, else if enduser open the math session
        //  private void btnBegin_Click(object sender, EventArgs e)
        // {
        //int reset=0;
        //if((ddlUserName.SelectedIndex) != -1)
        //{
        //for (int i=reset; i < EndUserList.Count; i++)
        //{
        //    try
        //    {
        //        if (ddlUserName.SelectedItem.ToString() == EndUserList[i].ScreenName)
        //        {
        //            if (EndUserList[i].UserType == UserType.Administrator)
        //            {
        //                AdminWorking = true;
        //                i = reset;
        //                Admin_Control adminscreen = new Admin_Control(EndUserList[i]);
        //                adminscreen.ShowDialog();
        //                updateDdlist();
        //                AdminWorking = false;
        //            }
        //            else if (EndUserList[i].UserType == UserType.Student)
        //            {
        //                Math_Problem_Screen nextscreen = new Math_Problem_Screen(EndUserList[i]);
        //                //Problem_Select_Screen nextscreen = new Problem_Select_Screen(EndUserList[i]);
        //                //nextscreen.WelcomeLabel = "WELCOME " + EndUserList[i].ScreenName;
        //                nextscreen.ShowDialog();
        //            }
        //        }
        //    }
        //    catch (NullReferenceException x)
        //    {

        //    }
        //}
        //}
        //}
        #endregion

    }
}
