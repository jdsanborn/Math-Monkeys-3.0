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
    public partial class frmAssignStudents : Form
    {
        #region Private Member Variables

        private MMControl mmControl;

        #endregion

        #region Properties
        #endregion

        #region Event Handlers

        /// <summary>
        /// Closes the Assignment dialog
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_DoneAssignStudent ( object sender, EventArgs e )
        {
            Close ();
        }

        /// <summary>
        /// Load form event. Make sure that the list boxes are populated with student names, problem sets.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>
        private void LoadEvent_AssignStudentsForm ( object sender, EventArgs e )
        {
            studentBindingSource.DataSource = mmControl.StudentList;
            problemSetBindingSource.DataSource = mmControl.ProblemSetList;
//            dtgProblemSetList.DataSource = mmControl.ProblemSetList;
            //dgvCurrentAssignments.DataSource = 

            //Show all the problem set by default
            cbAddition.Checked = true;
            cbSubtraction.Checked = true;
            cbMultiplication.Checked = true;
            cbDivision.Checked = true;

            UpdateBindings ();
            //dtgProblemSet.DataSource = mmControl.ProblemSetList.FindAll ( s => s.Operation == Operation.Division );
        }

        /// <summary>
        /// Filter the ProblemSet datagrid based on the checked operations.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>
        private void CheckBoxCheckedEvent_Operations ( object sender, EventArgs e )
        {

            List<ProblemSet> psList = new List<ProblemSet> ();
            foreach ( ProblemSet ps in mmControl.ProblemSetList )
            {
                if ( cbAddition.Checked && ps.Operation == Operation.Addition )
                {
                    psList.Add ( ps );
                }
                if ( cbSubtraction.Checked && ps.Operation == Operation.Subtraction )
                {
                    psList.Add ( ps );
                }
                if ( cbMultiplication.Checked && ps.Operation == Operation.Multiplication )
                {
                    psList.Add ( ps );
                }
                if ( cbDivision.Checked && ps.Operation == Operation.Division )
                {
                    psList.Add ( ps );
                }
            }
            dtgProblemSetList.DataSource = psList;
        }

        /// <summary>
        /// Add the selected problem set(s) to the selected student.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_AddProblemSets ( object sender, EventArgs e )
        {
            CreateAssignment ();
        }
       

        /// <summary>
        /// Remove selected problem set(s) from selected student.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>
        private void ButtonPressEvent_RemoveProblemSets ( object sender, EventArgs e )
        {
            DeleteAssignment ();
        }

        
        #endregion

        #region Private Methods
        
        /// <summary>
        /// Helper function to add the problem sets to the student
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>        
        private void CreateAssignment ()
        {
            List<ProblemSet> problemSetList = new List<ProblemSet> ();
            List<Student> SelectedStudents = new List<Student> ();

            foreach ( DataGridViewRow row in dtgStudentList.SelectedRows )
            {
                SelectedStudents.Add ( ( Student )row.DataBoundItem );
            }

            dtgProblemSetList.Refresh ();
            foreach ( DataGridViewRow row in dtgProblemSetList.SelectedRows )
            {
                ProblemSet ps = (ProblemSet) row.DataBoundItem;
                problemSetList.Add ( ps );
            }

            mmControl.AddNewAssignment ( SelectedStudents, problemSetList );

            UpdateBindings ();
        }

        /// <summary>
        /// Update Databinding for the current form (Assign Student Form).
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 23 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control screen and reused it in this form</notes>
        ///     </Modified>
        /// </history>        
        private void UpdateBindings ()
        {
            studentBindingSource.ResetBindings ( false );
            problemSetBindingSource.ResetBindings ( false );
            incompletedAssignmentsBindingSource.ResetBindings ( false );

            this.Update ();
        }

        /// <summary>
        /// Removes the currently selected problem set from the students list of problem sets
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        /// <history>
        ///     <Created  18 March 2014>Jonathan Sanborn</Created>
        ///     <Modified 23 April 2014>Arun Gopinath && Jeff Bunce
        ///         <notes>Moved this method from Admin control screen and reused it in this form</notes>
        ///     </Modified>
        /// </history>        
        private void DeleteAssignment ()
        {
            List<Assignment> SelectedAssignments = new List<Assignment> ();

            foreach ( DataGridViewRow row in dgvCurrentAssignments.SelectedRows )
            {
                Assignment assign = ( Assignment )row.DataBoundItem;
                SelectedAssignments.Add ( assign ); 
            }

            mmControl.DeleteAssignments ( SelectedAssignments );
            UpdateBindings ();
        }
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
        ///     <Created  23 April 2014>Arun Gopinath && Jeff Bunce</Created>
        ///     <Modified 23 April 2014></Modified>
        /// </history>
        public frmAssignStudents ( MMControl controller )
        {
            mmControl = controller;
            InitializeComponent();
        }

        #endregion

    }
}
