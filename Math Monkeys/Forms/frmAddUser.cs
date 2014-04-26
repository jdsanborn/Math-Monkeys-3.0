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
    public partial class frmAddUser : Form
    {
        #region Private Member Variables

        private MMControl mmControl;

        #endregion


        #region Properties
        #endregion


        #region Event Handlers
        /// <summary>
        /// Handle the key press event for Name field. Run validation check
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void KeyPressEvent_Name ( object sender, KeyPressEventArgs e )
        {
            NameOnly ( sender, e );
        }

        /// <summary>
        /// Handle the key press event for Grade field. Run validation check
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void KeyPressEvent_Grade ( object sender, KeyPressEventArgs e )
        {
            NumberOnly ( sender, e );
        }

        /// <summary>
        ///Load form event. Make sure that all the fields are clear.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void LoadEvent_AddNewUserForm ( object sender, EventArgs e )
        {
            ClearAllAddUserFormFields ();
        }

        /// <summary>
        /// Handle the button press event for Add&New Button. Add the user, clear
        /// the form fields and do not close the form.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_AddNewUsers ( object sender, EventArgs e )
        {
            AddUser ( sender, e );
            ClearAllAddUserFormFields ();
        }
        /// <summary>
        /// Closes the Add New User dialog
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_CancelAddUser ( object sender, EventArgs e )
        {
            Close ();
        }

        /// <summary>
        /// Adds the new User to the System
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  17 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_AddUser ( object sender, EventArgs e )
        {
            bool ret = AddUser ( sender, e );

            if ( ret == true )
                Close ();
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Clears all the edit fields in the Add User form
        /// </summary>
        /// <history>
        ///     <Created  20 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 20 April 2014></Modified>
        /// </history>
        private void ClearAllAddUserFormFields ()
        {
            var t = this.Controls.OfType<TextBox> ().AsEnumerable<TextBox> ();
            foreach ( TextBox item in t )
            {
                item.Text = "";
            }
        }

        /// <summary>
        /// Add the user to the database
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <returns>true if Add was successful, else false</returns>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Changed void return to bool, to indicate succeess or failure</notes>
        ///     </Modified>
        /// </history>
        private bool AddUser ( object sender, EventArgs e )
        {
            bool addSuccess = true;

            string fName = txtNewStudentFirstName.Text.Trim ();
            string lName = txtNewStudentLastName.Text.Trim ();
            string screenName = txtNewStudentScreenName.Text.Trim ();
            string password = txtNewStudentPassword.Text.Trim ();
            string passwordVerify = txtNewStudentVerifyPassword.Text.Trim ();
            string grade = txtNewStudentGrade.Text.Trim ();
            DateTime? DOB = dtpAddStudentDOB.Value;

            //Validate the input
            if ( IsNewUserInputValid () == false )
            {
                MessageBox.Show ( "Invaild data detected. Please correct the errors and try again.",
                                    "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                addSuccess = false;
            }
            else
            {
                Student newStudent = new Student ( mmControl, Guid.NewGuid ().ToString (), fName, lName, screenName, password, DOB, grade );
                mmControl.AddNewStudent ( newStudent );
                MessageBox.Show ( "Student Added.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }

            return addSuccess;
        }

        #endregion


        #region Public Methods
        #endregion


        #region Validation

        /// Allows only name charcters to be entered in the passed in textbox
        /// </summary>
        /// <param name="sender">The object that raised the event. A textbox</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  22 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control</notes>
        ///     </Modified>
        /// </history>
        public void NameOnly ( object sender, KeyPressEventArgs e )
        {
            if ( !char.IsControl ( e.KeyChar )
                && !char.IsLetterOrDigit ( e.KeyChar )
                && e.KeyChar != '-'
                && e.KeyChar != '`'
                && e.KeyChar != '~'
                && e.KeyChar != ' '
                && e.KeyChar != '.'
                && e.KeyChar != ','
                && e.KeyChar != '\''
                )
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validate the input is numbers only
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 20 April 2014></Modified>
        /// </history>        
        public void NumberOnly ( object sender, KeyPressEventArgs e )
        {
            if ( !char.IsControl ( e.KeyChar )
                && !char.IsDigit ( e.KeyChar ) )
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validate all the input fields in the Add form
        /// </summary>
        /// <returns>True if all fields have valid data.</returns>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 20 April 2014></Modified>
        /// </history>        
        private bool IsNewUserInputValid ()
        {
            bool[] isValid = new bool[7];

            isValid[0] = true;
            isValid[1] = validName ( txtNewStudentFirstName );
            isValid[2] = validName ( txtNewStudentLastName );
            isValid[3] = validScreenName ( txtNewStudentScreenName );
            isValid[4] = validPassword ( txtNewStudentPassword, txtNewStudentVerifyPassword );
            isValid[5] = validGrade ( txtNewStudentGrade );
            isValid[6] = validDate ( dtpAddStudentDOB );

            foreach ( bool b in isValid )
            {
                if ( !b )
                { isValid[0] = false; }
            }

            if ( !isValid[0] )
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validate the input for length. Must be within the length requirement
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 20 April 2014></Modified>
        /// </history>        
        private bool validName ( object sender )
        {
            bool isValid = false;
            TextBox txtBox = ( TextBox )sender;

            if ( txtBox != null )
            {
                if ( txtBox.Text == null )
                {
                    errorProviderNewUser.SetError ( txtBox, "Please Enter A Value" );
                    isValid = false;
                }
                else if ( txtBox.Text.Length < Properties.Settings.Default.NameLengthMin )
                {
                    errorProviderNewUser.SetError ( txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " characters long." );
                    isValid = false;
                }
                else if ( txtBox.Text.Length > Properties.Settings.Default.NameLengthMax )
                {
                    errorProviderNewUser.SetError ( txtBox, "Value is too Long. Value must be less than " + Properties.Settings.Default.NameLengthMax + " characters long." );
                    isValid = false;
                }
                else
                {
                    errorProviderNewUser.SetError ( txtBox, string.Empty );
                    isValid = true;
                }
            }
            return isValid;

        }

        /// <summary>
        /// Validate the screen name
        /// </summary>
        /// <param name="sender">The object that raised the event. A textbox</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  22 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control</notes>
        ///     </Modified>
        /// </history>
        private bool validScreenName ( object sender )
        {
            bool isValid = true;
            TextBox txtBox = ( TextBox )sender;

            int count = mmControl.AllUserList.Where ( w => w.ScreenName == txtBox.Text ).Count ();

            if ( txtBox.Text == null )
            {
                errorProviderNewUser.SetError ( txtBox, "Please Enter A Value" );
                isValid = false;
            }
            else if ( txtBox.Text.Length < Properties.Settings.Default.ScreenNameMin )
            {
                errorProviderNewUser.SetError ( txtBox, "Screen name is too short. Value must be at least " + Properties.Settings.Default.ScreenNameMin + " characters long." );
                isValid = false;
            }
            else if ( txtBox.Text.Length > Properties.Settings.Default.ScreenNameMax )
            {
                errorProviderNewUser.SetError ( txtBox, "Screen name is too Long. Value must be less than " + Properties.Settings.Default.ScreenNameMax + " characters long." );
                isValid = false;
            }
            else if ( count > 0 )
            {
                errorProviderNewUser.SetError ( txtBox, "Screen name must be unique." );
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError ( txtBox, string.Empty );
            }
            return isValid;
        }

        /// <summary>
        /// Validate the password
        /// </summary>
        /// <param name="sender">The object that raised the event. A textbox</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  22 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control</notes>
        ///     </Modified>
        /// </history>/// <summary>
        private bool validPassword ( object sender )
        {
            bool isValid = true;
            TextBox txtBox = ( TextBox )sender;

            if ( txtBox.Text == null )
            {
                errorProviderNewUser.SetError ( txtBox, "Please Enter A Value" );
                isValid = false;
            }
            else if ( txtBox.Text.Length < Properties.Settings.Default.NameLengthMin )
            {
                errorProviderNewUser.SetError ( txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " charcters long." );
                isValid = false;
            }
            else if ( txtBox.Text.Length > Properties.Settings.Default.MaxPasswordLength )
            {
                errorProviderNewUser.SetError ( txtBox, "Value is too Long. Value must be less than " + Properties.Settings.Default.MaxPasswordLength + " charcters long." );
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError ( txtBox, string.Empty );
            }
            return isValid;
        }

        /// <summary>
        /// Validate the password and verify password match
        /// </summary>
        /// <param name="sender">The object that raised the event. A textbox</param>
        /// <param name="e">The event arguments</param>
        /// <returns>True if inputs match</returns>
        /// <history>
        ///     <Created  22 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control</notes>
        ///     </Modified>
        /// </history>
        private bool validPassword ( object sender1, object sender2 )
        {
            bool isValid = true;
            TextBox txtBox1 = ( TextBox )sender1;
            TextBox txtBox2 = ( TextBox )sender2;

            if ( txtBox1.Text != txtBox2.Text )
            {
                errorProviderNewUser.SetError ( txtBox1, "Passwords must match" );
                errorProviderNewUser.SetError ( txtBox2, "Passwords must match" );
                isValid = false;
            }
            else if ( !validPassword ( sender1 ) || !validPassword ( sender2 ) )
            {
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError ( txtBox1, string.Empty );
                errorProviderNewUser.SetError ( txtBox2, string.Empty );
                isValid = true;
            }
            return isValid;
        }

        /// <summary>
        /// Validate the grade. 
        /// </summary>
        /// <param name="sender">The object that raised the event. A textbox</param>
        /// <param name="e">The event arguments</param>
        /// <returns>True if the input is valid</returns>
        /// <history>
        ///     <Created  22 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control</notes>
        ///     </Modified>
        /// </history>
        private bool validGrade ( object sender )
        {
            TextBox txtBox = sender as TextBox;

            if ( txtBox != null )
            { return validName ( sender ); }

            else
            { return false; }
        }

        /// <summary>
        /// Validate the date entry.
        /// </summary>
        /// <param name="sender">The object that raised the event. A textbox</param>
        /// <param name="e">The event arguments</param>
        /// <returns>True if the date is valid</returns>
        /// <history>
        ///     <Created  22 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 20 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control</notes>
        ///     </Modified>
        /// </history>
        private bool validDate ( object sender )
        {
            bool isValid = true;

            DateTimePicker dtp = sender as DateTimePicker;

            if ( dtp.Value > DateTime.Now )
            {
                errorProviderNewUser.SetError ( dtp, "The date cannot be set to a future value." );
                isValid = false;
            }
            else if ( dtp.Value < DateTime.Now.AddYears ( -120 ) )
            {
                errorProviderNewUser.SetError ( dtp, "The date cannot be set to more than 120 years in the past." );
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError ( dtp, string.Empty );
                isValid = true;
            }
            return isValid;
        }

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
        public frmAddUser ( MMControl mmControl )
        {
            InitializeComponent ();
            this.mmControl = mmControl;
            studentBindingSource.DataSource = mmControl.StudentList;
        }

        #endregion


    }
}
