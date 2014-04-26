using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Math_Monkeys.Forms;
using System.Windows.Forms;

namespace Math_Monkeys.Classes
{
    class Validator
    {
        #region Private Member Variables
        
        private MMControl mmControl;

        #endregion

        #region Properties

 
        #endregion

        #region Event Handlers


        #endregion

        #region Private Methods

 
        #endregion

        #region Public Methods

        public bool IsNameValid ( string name, out string errMsg )
        {
            bool isValid = true;
            errMsg = string.Empty;

            if ( name != null )
            {
                if ( name.Length < 2 )
                {
                    errMsg = "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " characters long.";
                    isValid = false;
                }
                else if ( name.Length > Properties.Settings.Default.NameLengthMax )
                {
                    errMsg = "Value is too Long. Value must be less than " + Properties.Settings.Default.NameLengthMax + " characters long.";
                    isValid = false;
                }
                else
                {
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
        public bool IsScreenNameValid ( string name, out string errMsg )
        {
            bool isValid = true;
            errMsg = string.Empty;

            int count = mmControl.AllUserList.Where ( w => w.ScreenName == name ).Count ();

            if ( name == null )
            {
                errMsg = "Please Enter A Value";
            }
            else if ( name.Length < Properties.Settings.Default.ScreenNameMin )
            {
                errMsg = "Screen name is too short. Value must be at least " + Properties.Settings.Default.ScreenNameMin + " characters long.";
            }
            else if ( name.Length > Properties.Settings.Default.ScreenNameMax )
            {
                errMsg = "Screen name is too Long. Value must be less than " + Properties.Settings.Default.ScreenNameMax + " characters long.";
            }
            else if ( count > 0 )
            {
                errMsg = "Screen name must be unique.";
            }

            if ( string.IsNullOrEmpty ( errMsg ) == false)
                isValid = false;

            return isValid;
        }

        public bool IsPasswordValid ( string pwd, out string errMsg )
        {
            bool isValid = true;
            errMsg = string.Empty;

            if ( pwd == null )
            {
                errMsg = "Please Enter A Value";
                isValid = false;
            }
            else if ( pwd.Length < Properties.Settings.Default.NameLengthMin )
            {
                errMsg= "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " charcters long.";
                isValid = false;
            }
            else if ( pwd.Length > Properties.Settings.Default.MaxPasswordLength )
            {
                errMsg = "Value is too Long. Value must be less than " + Properties.Settings.Default.MaxPasswordLength + " charcters long.";
                isValid = false;
            }

            if ( string.IsNullOrEmpty ( errMsg ) == false )
                isValid = false;

            return isValid;
        }

        public bool IsGradeValid ( string grade, out string errMsg )
        {
            bool isValid = true;
            errMsg = string.Empty;
            int studentGrade;
            bool ret = int.TryParse ( grade, out studentGrade );

            if ( studentGrade < 1 || studentGrade > 3 )
            {
                errMsg = "Math Monkeys is for 1 - 3 grades.";
            }

            if ( string.IsNullOrEmpty ( errMsg ) == false )
                isValid = false;

            return isValid;
        }

        public bool IsDateValid ( DateTimePicker date, out string errMsg )
        {
            bool isValid = true;
            errMsg = string.Empty;


            if ( date.Value > DateTime.Now )
            {
                errMsg = "The date cannot be set to a future value.";
            }
            else if ( date.Value < DateTime.Now.AddYears ( -120 ) )
            {
                errMsg = "The date cannot be set to more than 120 years in the past.";
            }

            if ( string.IsNullOrEmpty ( errMsg ) == false )
                isValid = false;

            return isValid;
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mmControl">Controller object</param>
        /// <history>
        ///     <Created  24 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 24 April 2014></Modified>
        /// </history>
        public Validator ( MMControl controller )
        {
            mmControl = controller;
        }

        #endregion
    }

}
