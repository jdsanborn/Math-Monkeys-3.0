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

        private MMControl MMControl;

        #endregion

        #region Private Properties
        #endregion

        #region Private Methods

        /// <summary>
        /// Closes the Add New User dialog
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonCancelAddUserClicked ( object sender, EventArgs e )
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
        private void ButtonAddUserClicked ( object sender, EventArgs e )
        {
            string fName = txtNewStudentFirstName.Text.Trim ();
            string lName = txtNewStudentLastName.Text.Trim ();
            string screenName = txtNewStudentScreenName.Text.Trim ();
            string password = txtNewStudentPassword.Text.Trim ();
            string passwordVerify = txtNewStudentVerifyPassword.Text.Trim ();
            string grade = txtNewStudentGrade.Text.Trim ();
            DateTime? DOB = dtpAddStudentDOB.Value;
            
            bool[] isValid = new bool[7];

            isValid[0] = true;
            isValid[1] = validName ( txtNewStudentFirstName );
            isValid[2] = validName ( txtNewStudentLastName );
            isValid[3] = validScreenName ( txtNewStudentScreenName );
            isValid[4] = validPassword ( txtNewStudentPassword, txtNewStudentVerifyPassword );
            isValid[5] = validGrade ( txtNewStudentGrade );
            isValid[6] = validDate ( dtpAddStudentDOB );
            foreach (bool b in isValid)
            {
                if (!b)
                { isValid[0] = false; }
            }

            if (!isValid[0])
            {
                MessageBox.Show ( "Invaild data detected. Please correct the errors and try again.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
            else
            {

                Student newStudent = new Student ( MMControl, Guid.NewGuid ().ToString (), fName, lName, screenName, password, DOB, grade );
                MMControl.AddNewStudent ( newStudent );
            }
//            this.Close ();
        }
        private bool validPassword ( object sender )
        {
            bool isValid = true;
            TextBox txtBox = ( TextBox )sender;

            if (txtBox.Text == null)
            {
                errorProviderNewUser.SetError ( txtBox, "Please Enter A Value" );
                isValid = false;
            }
            else if (txtBox.Text.Length < Properties.Settings.Default.NameLengthMin)
            {
                errorProviderNewUser.SetError ( txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " charcters long." );
                isValid = false;
            }
            else if (txtBox.Text.Length > Properties.Settings.Default.MaxPasswordLength)
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

        private bool validDate ( object sender )
        {
            bool isValid = true;

            DateTimePicker dtp = sender as DateTimePicker;

            if (dtp.Value > DateTime.Now)
            {
                errorProviderNewUser.SetError ( dtp, "The date cannot be set to a future value." );
                isValid = false;
            }
            else if (dtp.Value < DateTime.Now.AddYears ( -120 ))
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

        private bool validGrade ( object sender )
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox != null)
            { return validName ( sender ); }

            else
            { return false; }
        }
        private bool validPassword ( object sender1, object sender2 )
        {
            bool isValid = true;
            TextBox txtBox1 = ( TextBox )sender1;
            TextBox txtBox2 = ( TextBox )sender2;

            if (txtBox1.Text != txtBox2.Text)
            {
                errorProviderNewUser.SetError ( txtBox1, "Passwords must match" );
                errorProviderNewUser.SetError ( txtBox2, "Passwords must match" );
                isValid = false;
            }
            else if (!validPassword ( sender1 ) || !validPassword ( sender2 ))
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

        private bool validName ( object sender )
        {
            bool isValid = false;
            TextBox txtBox = ( TextBox )sender;

            if (txtBox != null)
            {
                if (txtBox.Text == null)
                {
                    errorProviderNewUser.SetError ( txtBox, "Please Enter A Value" );
                    isValid = false;
                }
                else if (txtBox.Text.Length < Properties.Settings.Default.NameLengthMin)
                {
                    errorProviderNewUser.SetError ( txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " characters long." );
                    isValid = false;
                }
                else if (txtBox.Text.Length > Properties.Settings.Default.NameLengthMax)
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

        private bool validScreenName ( object sender )
        {
            bool isValid = true;
            TextBox txtBox = ( TextBox )sender;

            int count = MMControl.AllUserList.Where ( w => w.ScreenName == txtBox.Text ).Count ();

            if (txtBox.Text == null)
            {
                errorProviderNewUser.SetError ( txtBox, "Please Enter A Value" );
                isValid = false;
            }
            else if (txtBox.Text.Length < Properties.Settings.Default.ScreenNameMin)
            {
                errorProviderNewUser.SetError ( txtBox, "Screen name is too short. Value must be at least " + Properties.Settings.Default.ScreenNameMin + " characters long." );
                isValid = false;
            }
            else if (txtBox.Text.Length > Properties.Settings.Default.ScreenNameMax)
            {
                errorProviderNewUser.SetError ( txtBox, "Screen name is too Long. Value must be less than " + Properties.Settings.Default.ScreenNameMax + " characters long." );
                isValid = false;
            }
            else if (count > 0)
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

        #endregion

        #region Constructors

        public frmAddUser ( MMControl mmControl )
        {
            InitializeComponent ();
            MMControl = mmControl;
            studentBindingSource.DataSource = MMControl.StudentList;
        }
        
        #endregion

        private void txtNewStudentFirstName_KeyPress ( object sender, KeyPressEventArgs e )
        {
            MMControl.NameOnly ( sender, e );
        }

        #region Public Properties
        #endregion

        #region Public Methods
        #endregion

    }
}
