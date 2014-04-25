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
    public partial class frmRemoveUsers : Form
    {
        #region Private Member Variables

        private MMControl mmControl;

        #endregion

        #region Properties

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handle Load form event. Populates the datagrid with list of users.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void LoadEvent_RemoveUserForm ( object sender, EventArgs e )
        {
            dtgRemoveUsers.DataSource = mmControl.StudentList;
        }

        /// <summary>
        /// Handle the Remove selected user Button press event. Removes the user from the db
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_RemoveSelectedUser ( object sender, EventArgs e )
        {
            List<Student> SelectedStudents = new List<Student> ();

            foreach ( DataGridViewRow row in dtgRemoveUsers.SelectedRows )
            {
                Student s = ( Student )row.DataBoundItem;
                SelectedStudents.Add ( ( Student )row.DataBoundItem );
            }

            if ( SelectedStudents.Count > 0 )
            {
                DialogResult result = MessageBox.Show ( "You are a about to remove "
                                + SelectedStudents.Count.ToString ()
                                + " Sudents and their assignments from the system.\n\n Do you wish to continue?",
                                "Remove Students",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question );
                if ( result == DialogResult.Yes )
                {

                    mmControl.RemoveStudents ( SelectedStudents );
                    //REFACTOR
                    dtgRemoveUsers.DataSource = null;
                    dtgRemoveUsers.Refresh ();
                    dtgRemoveUsers.DataSource = mmControl.StudentList;
                    dtgRemoveUsers.Refresh ();
                    MessageBox.Show ( SelectedStudents.Count + " Students Deleted.", "Students Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }
        }

        /// <summary>
        /// Closes the Remove User dialog
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 18 April 2014></Modified>
        /// </history>        
        private void ButtonPressEvent_CancelRemoveUser ( object sender, EventArgs e )
        {
            Close ();
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
        public frmRemoveUsers ( MMControl controller )
        {
            mmControl = controller;
            InitializeComponent ();
        }

        #endregion
    }
}
