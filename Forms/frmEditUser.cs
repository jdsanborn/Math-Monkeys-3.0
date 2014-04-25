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
    public partial class frmEditUser : Form
    {
        #region Private Member Variables
        
        private MMControl mmControl;
        private User selectedUser;

        #endregion

        #region Properties
        #endregion

        #region Event Handlers

        /// <summary>
        /// Closes the Edit Selected user form
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_CancelEditUser ( object sender, EventArgs e )
        {
            Close ();
        }

        /// <summary>
        /// Saves the changes after the admin/teacher changed the user details and hit the
        /// Save button.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_SaveEditUser ( object sender, EventArgs e )
        {
            string fName = txtModStudentFirstName.Text.Trim ();
            string lName = txtModStudentLastName.Text.Trim ();
            string screenName = txtModStudentScreenName.Text.Trim ();
            string password = txtModStudentPassword.Text.Trim ();
            string passwordVerify = txtModStudentVerifyPassword.Text.Trim ();
            string grade = txtModStudentGrade.Text.Trim ();
            DateTime? DOB = dtpModStudentDOB.Value;

            //Validate the input

            //Update the db
            selectedUser.FirstName = fName;
            selectedUser.LastName = lName;
            selectedUser.ScreenName = screenName;
            if ( selectedUser.UserType == UserType.Administrator )
            {
            }
            else
            {
                Student s = ( Student )selectedUser;
                s.Grade = grade;
            }

            //            Student student = new Student(mmControl, Guid.NewGuid().ToString(), fName, lName, screenName, password, DOB, grade);
            if ( selectedUser != null )
            { mmControl.FileHandler.UpdateUser ( selectedUser ); }
            Close ();
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        /// <summary>
        /// Called by the Modify user after the admin selects a student/admin from the datagrid
        /// </summary>
        /// <param name="user">User that needs to be modified</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        public void EditSelectedUser ( Student u )
        {
            selectedUser = u;
            Student student = u as Student;
            txtModStudentFirstName.Text = u.FirstName;
            txtModStudentLastName.Text = u.LastName;
            txtModStudentScreenName.Text = u.ScreenName;
            txtModStudentPassword.Text = u.Password;
            txtModStudentVerifyPassword.Text = u.Password;
            txtModStudentGrade.Text = student.Grade;
            dtpModStudentDOB.Value = student.DOB.Value;

            ShowDialog ();
        }

        #endregion

        #region Validation
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mmControl">Controller object</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        public frmEditUser ( MMControl mm )
        {
            mmControl = mm;
            InitializeComponent ();
        }

        #endregion
    }
}
