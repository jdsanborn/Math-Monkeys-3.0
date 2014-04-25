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
    public partial class frmModifyUser : Form
    {
        #region Private Member Variables

        private MMControl mmControl;
        private frmEditUser editUserForm;

        #endregion

        #region Properties
        #endregion

        #region Event Handlers

        /// <summary>
        /// Closes the Modify New User dialog
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_CancelModifyUser ( object sender, EventArgs e )
        {
            Close ();
        }

        /// <summary>
        /// Modify Selected User
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_ModifySelectedUser ( object sender, EventArgs e )
        {
            Student modifiedstudent = dtgModifyUser.CurrentRow.DataBoundItem as Student;

            editUserForm.EditSelectedUser ( modifiedstudent );
        }

        /// <summary>
        /// Loads the Datagrid to Modify New User
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void LoadEvent_ModifyUserForm ( object sender, EventArgs e )
        {
            //dtgModifyUser.DataSource = studentBindingSource;
        }

        /// <summary>
        /// Updates the view when the form is activated to show the updated records in datagrid
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void FormActivatedEvent_ModifyUserForm ( object sender, EventArgs e )
        {
            Refresh ();
        }

        #endregion
        
        #region Private Methods
  
        #endregion

        #region Public Methods
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
        public frmModifyUser ( MMControl control )
        {
            InitializeComponent ();
            mmControl = control;
            studentBindingSource.DataSource = mmControl.StudentList;
            studentBindingSource.ResetBindings ( false );

            //Create the edit user form. Do not display it here.
            editUserForm = new frmEditUser ( control );
            dtgModifyUser.DataSource = studentBindingSource;
        }

        #endregion
    }
}
