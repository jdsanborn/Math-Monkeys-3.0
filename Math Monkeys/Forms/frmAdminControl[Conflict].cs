/********************************************
 * CSUSM CS 441 Spring 2014
 * The Code Monkeys
 * Project: Math Monkeys
 * Class Name: frmAdminControl.cs
 * File Name: frmAdminControl
 * UI Design: Arun Gopinath
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated Comments
 * 
 * 19 April 2014
 * Jeff Bunce
 * Worked on making current UI work with MDI
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
using System.Threading.Tasks;

namespace Math_Monkeys
{
    public partial class frmAdminControl : Form
    {
        #region Private Member Variables

        // Refrence to Controller.
        private MMControl MMControl;

        // For animation.
        private bool menuHidden = false; 

        // Add user UI class
        private frmAddUser AddUserForm;
        private frmModifyUser ModifyUserForm;
        private frmRemoveUsers RemoveUsersForm;

        #endregion

        #region Private Properties
        #endregion

        #region Private Methods

        //Todo
        private void MenuItemAddUserClicked ( object sender, EventArgs e )
        {
            var t = AddUserForm.Controls.OfType<TextBox> ().AsEnumerable<TextBox> ();
            foreach (TextBox item in t)
            {
                item.Text = "";
            } 
            
            AddUserForm.ShowDialog ();
        }

        #endregion

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Constructor
        /// </summary>
        /// <param name="mmControl">The controller object</param>
        public frmAdminControl(MMControl mmControl)
        {
            InitializeComponent();
            MMControl = mmControl;

            AddUserForm = new frmAddUser(mmControl);
            ModifyUserForm = new frmModifyUser ( mmControl );
            RemoveUsersForm = new frmRemoveUsers ( mmControl );


            //AG-JB
            //lblCurrentTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
            //tmrClock.Start();

            /////Set the bindings
            //studentBindingSource.DataSource = MMControl.StudentList;
            //problemSetBindingSource.DataSource = MMControl.ProblemSetList;
            //assignmentsBindingSource.DataSource = studentBindingSource;
            //incompletedAssignmentsBindingSource.DataSource = studentBindingSource;
            //ddlNewProblemSetAttempts.DataSource = MMControl.NumberOfAttempts;
            //ddlDefaultsAttempts.DataSource = MMControl.NumberOfAttemptsDefault;

            //UpdateBindings();

            //loadProblemSetDefaults();

            //tbcAdmin.SelectedIndexChanged += new EventHandler(tbcAdmin_SelectedIndexChanged);

            ///// Set the initial valid date ranges for repots tab
            //dtpStartDate.MinDate = DateTime.Now.AddYears(-120);
            //dtpStartDate.Value = DateTime.Now.AddYears(-5);
            //dtpStartDate.MaxDate = DateTime.Now;
            //dtpEndDate.MinDate = DateTime.Now.AddYears(-120);
            //dtpEndDate.Value = DateTime.Now;
            //dtpEndDate.MaxDate = DateTime.Now;

            //lblAdminName.Text = MMControl.CurrentUser.GetFullName;
            //lblLoginDate.Text = MMControl.CurrentUser.LastLogin().Date.ToString();

        }

        #region Methods

        #region Validation Methods
        /*
            /// <summary>
            ///Jonathan Sanborn
            ///
            /// Methods in this section validate the
            /// Data entered into the forms
            /// </summary>
           
      */

        private bool validScreenName(object sender)
        {
            bool isValid = true;
            TextBox txtBox = (TextBox)sender;

            int count = MMControl.AllUserList.Where(w => w.ScreenName == txtBox.Text).Count();

            if (txtBox.Text == null)
            {
                errorProviderNewUser.SetError(txtBox, "Please Enter A Value");
                isValid = false;
            }
            else if (txtBox.Text.Length < Properties.Settings.Default.ScreenNameMin)
            {
                errorProviderNewUser.SetError(txtBox, "Screen name is too short. Value must be at least " + Properties.Settings.Default.ScreenNameMin + " characters long.");
                isValid = false;
            }
            else if (txtBox.Text.Length > Properties.Settings.Default.ScreenNameMax)
            {
                errorProviderNewUser.SetError(txtBox, "Screen name is too Long. Value must be less than " + Properties.Settings.Default.ScreenNameMax + " characters long.");
                isValid = false;
            }
            else if (count > 0)
            {
                errorProviderNewUser.SetError(txtBox, "Screen name must be unique.");
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(txtBox, string.Empty);
            }
            return isValid;
        }

        private bool validPassword(object sender1, object sender2)
        {
            bool isValid = true;
            TextBox txtBox1 = (TextBox)sender1;
            TextBox txtBox2 = (TextBox)sender2;

            if (txtBox1.Text != txtBox2.Text)
            {
                errorProviderNewUser.SetError(txtBox1, "Passwords must match");
                errorProviderNewUser.SetError(txtBox2, "Passwords must match");
                isValid = false;
            }
            else if (!validPassword(sender1) || !validPassword(sender2))
            {
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(txtBox1, string.Empty);
                errorProviderNewUser.SetError(txtBox2, string.Empty);
                isValid = true;
            }
            return isValid;
        }

        private bool validPassword(object sender)
        {
            bool isValid = true;
            TextBox txtBox = (TextBox)sender;

            if (txtBox.Text == null)
            {
                errorProviderNewUser.SetError(txtBox, "Please Enter A Value");
                isValid = false;
            }
            else if (txtBox.Text.Length < Properties.Settings.Default.NameLengthMin)
            {
                errorProviderNewUser.SetError(txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " charcters long.");
                isValid = false;
            }
            else if (txtBox.Text.Length > Properties.Settings.Default.MaxPasswordLength)
            {
                errorProviderNewUser.SetError(txtBox, "Value is too Long. Value must be less than " + Properties.Settings.Default.MaxPasswordLength + " charcters long.");
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(txtBox, string.Empty);
            }
            return isValid;
        }

        private bool validProblemSetName(object sender, Operation operation)
        {
            bool isValid = false;
            //AG-JB
            //TextBox txtBox = sender as TextBox;

            //if (txtBox != null)
            //{
            //    int count = 0;

            //    count = MMControl.ProblemSetList.Where(w => w.Name == txtNewProblemSetName.Text.Trim() + " " + operation.ToString()).Count();

            //    if (count > 0)
            //    {
            //        errorProviderNewUser.SetError(txtBox,
            //                            "Problem set name must be unique. \""
            //                            + txtNewProblemSetName.Text.Trim()
            //                            + " "
            //                            + operation.ToString()
            //                            + "\" already exists in the system.");
            //        isValid = false;
            //    }
            //    else
            //    {
            //        isValid = validName(txtBox);
            //    }
            //}
            return isValid;
        }

        private bool validName(object sender)
        {
            bool isValid = false;
            TextBox txtBox = (TextBox)sender;

            if (txtBox != null)
            {
                if (txtBox.Text == null)
                {
                    errorProviderNewUser.SetError(txtBox, "Please Enter A Value");
                    isValid = false;
                }
                else if (txtBox.Text.Length < Properties.Settings.Default.NameLengthMin)
                {
                    errorProviderNewUser.SetError(txtBox, "Value is too short. Value must be at least " + Properties.Settings.Default.NameLengthMin + " characters long.");
                    isValid = false;
                }
                else if (txtBox.Text.Length > Properties.Settings.Default.NameLengthMax)
                {
                    errorProviderNewUser.SetError(txtBox, "Value is too Long. Value must be less than " + Properties.Settings.Default.NameLengthMax + " characters long.");
                    isValid = false;
                }
                else
                {
                    errorProviderNewUser.SetError(txtBox, string.Empty);
                    isValid = true;
                }
            }
            return isValid;

        }

        private bool validNumberOfProblems(object sender)
        {
            bool isValid = true;
            int numProblems = -1;

            TextBox txtBox = (TextBox)sender;

            if (txtBox.Text.Length > 0)
            { numProblems = int.Parse(txtBox.Text); }

            if (txtBox.Text == null)
            {
                errorProviderNewUser.SetError(txtBox, "Please Enter A Value");
                isValid = false;
            }
            else if (numProblems < Properties.Settings.Default.NumberProblemsMin)
            {
                errorProviderNewUser.SetError(txtBox,
                    "Number of Problems must be greater than " + Properties.Settings.Default.NumberProblemsMin.ToString());
                isValid = false;
            }
            else if (numProblems > Properties.Settings.Default.NumberProblemsMax)
            {
                errorProviderNewUser.SetError(txtBox,
                    "Number of Problems must be less than " + Properties.Settings.Default.NumberProblemsMax.ToString());
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(txtBox, string.Empty);
                isValid = true;
            }
            return isValid;
        }

        private bool validGoal(object sender)
        {
            bool isValid = true;
            TextBox txtBox = (TextBox)sender;
            double goal = -1.0;

            if (txtBox.Text != null)
            {
                if (txtBox.Text.Length > 0)
                { goal = double.Parse(txtBox.Text); }
            }

            if (txtBox.Text == null)
            {
                errorProviderNewUser.SetError(txtBox, "Please Enter A Value from "
                    + Properties.Settings.Default.GoalMin.ToString() + "% to "
                    + Properties.Settings.Default.GoalMax.ToString() + "%");
                isValid = false;
            }
            else if (goal < Properties.Settings.Default.GoalMin)
            {
                errorProviderNewUser.SetError(txtBox,
                    "Goal must be greater than " + Properties.Settings.Default.GoalMin.ToString() + "%");
                isValid = false;
            }
            else if (goal > Properties.Settings.Default.GoalMax)
            {
                errorProviderNewUser.SetError(txtBox,
                    "Goal must be less than or equal to " + Properties.Settings.Default.GoalMax.ToString() + "%");
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(txtBox, string.Empty);
                isValid = true;
            }
            return isValid;
        }

        private bool validAttempts(object sender)
        {
            bool isValid = false;

            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedIndex > -1)
            {
                int attempts = comboBox.SelectedIndex;
                if (attempts < 0)
                {
                    errorProviderNewUser.SetError(comboBox, "Please Select a Value");
                    isValid = false;
                }
                else { isValid = true; }
            }
            return isValid;
        }

        private bool validRange(object sender)
        {
            bool isValid = false;

            TextBox txtBox = sender as TextBox;

            if (txtBox != null)
            {

                if (txtBox.Text.Length < 1)
                {
                    errorProviderNewUser.SetError(txtBox, "Please Select a Value");
                    isValid = false;
                }
                else
                {
                    errorProviderNewUser.SetError(txtBox, string.Empty);
                    isValid = true;
                }
            }
            return isValid;
        }

        private bool validRange(object min, object max)
        {
            bool isValid = false;

            TextBox minBox = min as TextBox;
            TextBox maxBox = max as TextBox;
            if (minBox != null && maxBox != null)
            {

                if (minBox.Text.Length < 1)
                {
                    errorProviderNewUser.SetError(minBox, "Please Select a Value");
                    isValid = false;
                }
                else if (maxBox.Text.Length < 1)
                {
                    errorProviderNewUser.SetError(maxBox, "Please Select a Value");
                    isValid = false;
                }
                else
                {
                    int number1 = int.Parse(minBox.Text);
                    int number2 = int.Parse(maxBox.Text);

                    if (number1 > number2)
                    {
                        errorProviderNewUser.SetError(minBox, "Must be less than or equal to Max Number");
                        errorProviderNewUser.SetError(maxBox, "Must be greaer than or equal to Max Number");
                        isValid = false;
                    }
                    else
                    {
                        errorProviderNewUser.SetError(minBox, string.Empty);
                        errorProviderNewUser.SetError(maxBox, string.Empty);
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        private bool validGrade(object sender)
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox != null)
            { return validName(sender); }

            else
            { return false; }
        }

        private bool validDate(object sender)
        {
            bool isValid = true;

            DateTimePicker dtp = sender as DateTimePicker;

            if (dtp.Value > DateTime.Now)
            {
                errorProviderNewUser.SetError(dtp, "The date cannot be set to a future value.");
                isValid = false;
            }
            else if (dtp.Value < DateTime.Now.AddYears(-120))
            {
                errorProviderNewUser.SetError(dtp, "The date cannot be set to more than 120 years in the past.");
                isValid = false;
            }
            else
            {
                errorProviderNewUser.SetError(dtp, string.Empty);
                isValid = true;
            }
            return isValid;
        }

        #endregion

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Loads the problem set defaults from the settings file
        /// </summary>
        private void loadProblemSetDefaults()
        {
            //AG-JB
            //txtDefaultsNumberofProblems.Text = Properties.Settings.Default.DefaultNumberOfProblems;
            //txtDefaultGoal.Text = Properties.Settings.Default.DefaultGoal;

            //ddlDefaultsAttempts.SelectedIndex = Properties.Settings.Default.DefaultNumberAttempts;

            //cbxDefaultAllowNegativeAnswers.Checked = Properties.Settings.Default.DefaultNegAnswers;
            //cbxDefaultsWholeNumbers.Checked = Properties.Settings.Default.DefaultWholeNumbers;
            //cbxDefaultAllowNeagativeNumbers.Checked = Properties.Settings.Default.DefaultNegNumbers;

            //txtNewProblemSetNumberProblems.Text = Properties.Settings.Default.DefaultNumberOfProblems;
            //txtNewProblemSetGoal.Text = Properties.Settings.Default.DefaultGoal;

            //ddlNewProblemSetAttempts.SelectedIndex = Properties.Settings.Default.DefaultNumberAttempts;

            //cbxNewProblemSetNegativeAnswers.Checked = Properties.Settings.Default.DefaultNegAnswers;
            //cbxNewProblemWholeNumber.Checked = Properties.Settings.Default.DefaultWholeNumbers;
            //cbxNewProblemAdditionAllowNegative.Checked = Properties.Settings.Default.DefaultNegNumbers;

        }

        /// <summary>
        /// 30 March 2014
        /// Jonathan Sanborn
        /// 
        /// Updated for new UI
        /// 
        /// Gets the Users data from the form
        /// Validates the data
        /// creates a new user on valid data
        /// passes the new user to the MMContol object
        /// </summary>
        private void CreateUser()
        {

            //string fName = txtNewStudentFirstName.Text.Trim();
            //string lName = txtNewStudentLastName.Text.Trim();
            //string screenName = txtNewStudentScreenName.Text.Trim();
            //string password = txtNewStudentPassword.Text.Trim();
            //string passwordVerify = txtNewStudentVerifyPassword.Text.Trim();
            //string grade = txtNewStudentGrade.Text.Trim();
            //DateTime? DOB = dtpAddStudentDOB.Value;

            //bool[] isValid = new bool[7];

            //isValid[0] = true;
            //isValid[1] = validName(txtNewStudentFirstName);
            //isValid[2] = validName(txtNewStudentLastName);
            //isValid[3] = validScreenName(txtNewStudentScreenName);
            //isValid[4] = validPassword(txtNewStudentPassword, txtNewStudentVerifyPassword);
            //isValid[5] = validGrade(txtNewStudentGrade);
            //isValid[6] = validDate(dtpAddStudentDOB);

            //foreach (bool b in isValid)
            //{
            //    if (!b)
            //    { isValid[0] = false; }
            //}

            //if (!isValid[0])
            //{
            //    MessageBox.Show("Invaild data detected. Please correct the errors and try again.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
                //Student newStudent = new Student(MMControl, Guid.NewGuid().ToString(), fName, lName, screenName, password, DOB, grade);
                //MMControl.AddNewStudent(newStudent);

                //if (rbtStudent.Checked)
                //{
                //    type = UserType.Student;
                //    Student newStudent = new Student(Guid.NewGuid().ToString(), type, fName, lName, screenName, password);
                //    MMControl.AddNewStudent(newStudent);
                //}
                //else if (rbtAdmin.Checked)
                //{
                //    type = UserType.Administrator;
                //    Admin newAdmin = new Admin(Guid.NewGuid().ToString(), type, fName, lName, screenName, password);
                //    MMControl.AddNewAdmin(newAdmin);
                //}
                //else
                //{
                //    type = UserType.None;
                //    User newUser = new User(Guid.NewGuid().ToString(), type, fName, lName, screenName, password);
                //    MMControl.AddNewUser(newUser);
                //}

                //tmrShowLabel.Start();
                //lblNewUserCreated.Enabled = true;
                //lblNewUserCreated.Visible = true;
            //    ResetNewUserForm();
            //    UpdateBindings();
            //    this.Update();
            //}
        }

        /// <summary>
        /// 6 April 2014
        /// Jonathan Sanborn
        /// 
        /// Validates and Modifies the currently selected student in the dgvRemoveStudent
        /// </summary>
        private void ModifyUser()
        {
            //bool[] isValid = new bool[7];

            //isValid[0] = true;
            //isValid[1] = validName(txtRemoveStudentFirst);
            //isValid[2] = validName(txtRemoveStudentLast);
            //isValid[3] = validScreenName(txtRemoveStudentScreen);
            //isValid[4] = validPassword(txtRemoveStudentPassword, txtRemoveStudentVerifyPassword);
            //isValid[5] = validGrade(txtRemoveStudentGrade);
            //isValid[6] = validDate(dtpRemoveDOB);

            //foreach (bool b in isValid)
            //{
            //    if (!b)
            //    { isValid[0] = false; }
            //}

            //if (!isValid[0])
            //{
            //    MessageBox.Show("Invaild Student data detected. Please correct the errors and try again.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    Student student = dgvRemoveStudent.CurrentRow.DataBoundItem as Student;

            //    if (student != null)
            //    { MMControl.FileHandler.UpdateUser(student); }

            //    UpdateBindings();
            //    this.Update();
            //}
        }

        /// <summary>
        /// Jonathan Sanborn
        /// Removes the currently selected user(s)
        /// </summary>
        private void RemoveUser()
        {
            //List<Student> SelectedStudents = new List<Student>();

            //foreach (DataGridViewRow row in dgvRemoveStudent.SelectedRows)
            //{
            //    SelectedStudents.Add((Student)row.DataBoundItem);
            //}

            //if (SelectedStudents.Count > 0)
            //{
            //    DialogResult result = MessageBox.Show("You are a about to remove "
            //                    + SelectedStudents.Count.ToString()
            //                    + " Sudents and their assignments from the system.\n\n Do you wish to continue?",
            //                    "Remove Students",
            //                    MessageBoxButtons.YesNo,
            //                    MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {

            //        MMControl.RemoveStudents(SelectedStudents);
            //        UpdateBindings();
            //        MessageBox.Show(SelectedStudents.Count + " Students Deleted.", "Students Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        /// <summary>
        /// Creates a problem set useing the passed in values
        /// </summary>
        /// <param name="txtOperands">The textboxes with the operands ranges in them</param>
        /// <param name="Operation">The Operation for the problem set</param>
        /// <param name="numProblems">The number of problems in the problem set</param>
        /// <param name="numAttempts">The number of attempts befor the problem is counted wrong</param>
        /// <param name="goal">The goal to pass the problem set value 0.0 - 1.0</param>
        /// <param name="isValid">A list of bools to add isValid tags too</param>
        /// <returns>The created problemSet or null</returns>
        private ProblemSet operationChecked(TextBox[] txtOperands, Operation Operation, int numProblems, int numAttempts, Double goal, List<bool> isValid)
        {
            //bool validRange1 = validRange(txtOperands[0], txtOperands[1]);
            //bool validRange2 = validRange(txtOperands[2], txtOperands[3]);

            //isValid.Add(validRange1);
            //isValid.Add(validRange2);
            //isValid.Add(validProblemSetName(txtNewProblemSetName, Operation));
            //if (!validRange1 || !validRange2)
            if(true)
            {
                return null;
            }
            else
            {
                //OperandsRange range1 = new OperandsRange();
                //OperandsRange range2 = new OperandsRange();
                //List<OperandsRange> operandsRange = new List<OperandsRange>();

                //if (txtOperands[0].Text.Length > 0)
                //{ range1.rangeMin = int.Parse(txtOperands[0].Text); }
                //if (txtOperands[1].Text.Length > 0)
                //{ range1.rangeMax = int.Parse(txtOperands[1].Text); }

                //if (txtOperands[2].Text.Length > 0)
                //{ range2.rangeMin = int.Parse(txtOperands[2].Text); }
                //if (txtOperands[3].Text.Length > 0)
                //{ range2.rangeMax = int.Parse(txtOperands[3].Text); }

                //operandsRange.Add(range1);
                //operandsRange.Add(range2);

                //return new ProblemSet(Guid.NewGuid().ToString(),
                //               txtNewProblemSetName.Text + " " + Operation.ToString(),
                //               Operation,
                //               operandsRange,
                //               (uint)numProblems,
                //               (uint)numAttempts,
                //               goal,
                //               cbxNewProblemAdditionAllowNegative.Checked,
                //               cbxNewProblemSetNegativeAnswers.Checked,
                //               cbxNewProblemWholeNumber.Checked
                //            );
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// gets the values from the form validates them 
        /// and if valid creates a problem set
        /// </summary>
        private void CreateProblemSet()
        {
            //AG-JB
            //int numProblems = -1;
            //double goal = -1;
            //int numAttempts = -1;

            //List<bool> isValid = new List<bool>();

            //if (txtNewProblemSetNumberProblems.Text.Length > 0)
            //{ numProblems = int.Parse(txtNewProblemSetNumberProblems.Text.Trim()); }

            //if (txtNewProblemSetGoal.Text.Length > 0)
            //{ goal = double.Parse(txtNewProblemSetGoal.Text.Trim()); }

            //if (ddlNewProblemSetAttempts.SelectedIndex > -1)
            //{ numAttempts = ddlNewProblemSetAttempts.SelectedIndex; }

            //List<ProblemSet> ProblemSetList = new List<ProblemSet>();
            //bool operationSelected = false;

            //isValid.Add(validNumberOfProblems(txtNewProblemSetNumberProblems));
            //isValid.Add(validGoal(txtNewProblemSetGoal));
            //isValid.Add(validAttempts(ddlNewProblemSetAttempts));

            //goal = goal / 100.0;

            //AG-JB
            //if (cbxNewProblemAddition.Checked)
            //{
            //    operationSelected = true;
            //    TextBox[] TextOperands = new TextBox[4];

            //    TextOperands[0] = txtNewProblemSetAdditionFirstOperandMin;
            //    TextOperands[1] = txtNewProblemSetAdditionFirstOperandMax;
            //    TextOperands[2] = txtNewProblemSetAdditionSecondOperandMin;
            //    TextOperands[3] = txtNewProblemSetAdditionSecondOperandMax;
            //    ProblemSetList.Add(operationChecked(TextOperands, Operation.Addition, numProblems, numAttempts, goal, isValid));
            //}

            //AG-JB
            //if (cbxNewProblemMinus.Checked)
            //{
            //    operationSelected = true;
            //    TextBox[] TextOperands = new TextBox[4];

            //    TextOperands[0] = txtNewProblemSetMinusFirstOperandMin;
            //    TextOperands[1] = txtNewProblemSetMinusFirstOperandMax;
            //    TextOperands[2] = txtNewProblemSetMinusSecondOperandMin;
            //    TextOperands[3] = txtNewProblemSetMinusSecondOperandMax;
            //    ProblemSetList.Add(operationChecked(TextOperands, Operation.Subtraction, numProblems, numAttempts, goal, isValid));
            //}

            //AG-JB
            //if (cbxNewProblemTimes.Checked)
            //{
            //    operationSelected = true;
            //    TextBox[] TextOperands = new TextBox[4];

            //    TextOperands[0] = txtNewProblemSetTimesFirstOperandMin;
            //    TextOperands[1] = txtNewProblemSetTimesFirstOperandMax;
            //    TextOperands[2] = txtNewProblemSetTimesSecondOperandMin;
            //    TextOperands[3] = txtNewProblemSetTimesSecondOperandMax;
            //    ProblemSetList.Add(operationChecked(TextOperands, Operation.Multiplication, numProblems, numAttempts, goal, isValid));
            //}

            //AG-JB
            //if (cbxNewProblemDivide.Checked)
            //{
            //    operationSelected = true;
            //    TextBox[] TextOperands = new TextBox[4];

            //    TextOperands[0] = txtNewProblemSetDivideFirstOperandMin;
            //    TextOperands[1] = txtNewProblemSetDivideFirstOperandMax;
            //    TextOperands[2] = txtNewProblemSetDivideSecondOperandMin;
            //    TextOperands[3] = txtNewProblemSetDivideSecondOperandMax;
            //    ProblemSetList.Add(operationChecked(TextOperands, Operation.Division, numProblems, numAttempts, goal, isValid));
            //}

            //AG-JB
            //if (ProblemSetList.Count > 0 && operationSelected)
            //{
            //    bool validForm = true;
            //    foreach (bool b in isValid)
            //    {
            //        if (!b)
            //        {
            //            validForm = false;
            //            break;
            //        }
            //    }

            //    if (validForm)
            //    {
            //        foreach (ProblemSet p in ProblemSetList)
            //        {
            //            MMControl.AddProblemSet(p);
            //        }
            //        ResetNewProblemSetForm();
            //    }
            //}

            //UpdateBindings();

        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Creates the Assignments for the currently selected students and Problem sets
        /// </summary>
        private void CreateAssignment()
        {
            //List<ProblemSet> problemSetList = new List<ProblemSet>();
            //List<Student> SelectedStudents = new List<Student>();

            //foreach (DataGridViewRow row in dgvAssignStudents.SelectedRows)
            //{
            //    SelectedStudents.Add((Student)row.DataBoundItem);
            //}

            //foreach (ProblemSet ps in lbxAvailable.SelectedItems)
            //{
            //    problemSetList.Add(ps);
            //}

            //MMControl.AddNewAssignment(SelectedStudents, problemSetList);

            //UpdateBindings();

        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Deletes the currently selected assinment(s) from the system
        /// </summary>
        private void DeleteAssignment()
        {
            //List<Assignment> SelectedAssignments = new List<Assignment>();

            //foreach (Assignment A in lbxAssigned.SelectedItems)
            //{ SelectedAssignments.Add(A); }

            //MMControl.DeleteAssignments(SelectedAssignments);
            //UpdateBindings();
        }

        /// <summary>
        /// Updates all the forms databindings
        /// </summary>
        private void UpdateBindings()
        {
            studentBindingSource.ResetBindings(false);
            problemSetBindingSource.ResetBindings(false);
            assignmentsBindingSource.ResetBindings(false);
            incompletedAssignmentsBindingSource.ResetBindings(false);

            this.Update();
        }

        /// <summary>
        /// 30 March 2014
        /// Jonathan Sanborn
        /// 
        /// Updated for new UI
        /// </summary>
        private void ResetNewUserForm()
        {
            ////rbtStudent.Checked = true;

            //txtNewStudentFirstName.Text = string.Empty;
            //txtNewStudentLastName.Text = string.Empty;
            //txtNewStudentScreenName.Text = string.Empty;
            //txtNewStudentPassword.Text = String.Empty;
            //txtNewStudentVerifyPassword.Text = String.Empty;
            //txtNewStudentGrade.Text = string.Empty;
            //dtpAddStudentDOB.Value = DateTime.Now;
            //txtNewStudentFirstName.Focus();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Resets the create problem set Controls to there default state
        /// </summary>
        private void ResetNewProblemSetForm()
        {
            //AG-JB
            //txtNewProblemSetName.Text = string.Empty;

            //cbxNewProblemAddition.Checked = false;
            //cbxNewProblemMinus.Checked = false;
            //cbxNewProblemTimes.Checked = false;
            //cbxNewProblemDivide.Checked = false;

            //txtNewProblemSetAdditionFirstOperandMin.Text = string.Empty;
            //txtNewProblemSetAdditionFirstOperandMax.Text = string.Empty;
            //txtNewProblemSetAdditionSecondOperandMin.Text = string.Empty;
            //txtNewProblemSetAdditionSecondOperandMax.Text = string.Empty;

            //txtNewProblemSetMinusFirstOperandMin.Text = string.Empty;
            //txtNewProblemSetMinusFirstOperandMax.Text = string.Empty;
            //txtNewProblemSetMinusSecondOperandMin.Text = string.Empty;
            //txtNewProblemSetMinusSecondOperandMax.Text = string.Empty;

            //txtNewProblemSetTimesFirstOperandMin.Text = string.Empty;
            //txtNewProblemSetTimesFirstOperandMax.Text = string.Empty;
            //txtNewProblemSetTimesSecondOperandMin.Text = string.Empty;
            //txtNewProblemSetTimesSecondOperandMax.Text = string.Empty;

            //txtNewProblemSetDivideFirstOperandMin.Text = string.Empty;
            //txtNewProblemSetDivideFirstOperandMax.Text = string.Empty;
            //txtNewProblemSetDivideSecondOperandMin.Text = string.Empty;
            //txtNewProblemSetDivideSecondOperandMax.Text = string.Empty;

            //loadProblemSetDefaults();

        }

        /// <summary>
        /// Jonathan Sanborn
        /// Saves the currently set values in Defaults section
        /// </summary>
        private void SaveProblemSetDefaults()
        {
            //AG-JB
            //Properties.Settings.Default.DefaultNumberAttempts = ddlDefaultsAttempts.SelectedIndex;

            //Properties.Settings.Default.DefaultNumberOfProblems = txtDefaultsNumberofProblems.Text;
            //Properties.Settings.Default.DefaultGoal = txtDefaultGoal.Text;

            //Properties.Settings.Default.DefaultNegNumbers = cbxDefaultAllowNeagativeNumbers.Checked;
            //Properties.Settings.Default.DefaultNegAnswers = cbxDefaultAllowNegativeAnswers.Checked;
            //Properties.Settings.Default.DefaultWholeNumbers = cbxDefaultsWholeNumbers.Checked;

            //Properties.Settings.Default.Save();
        }

        #endregion

        #region Events

        #region Key Press Events

        private void txtRangeMin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtRangeMax1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtRangeMin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtRangeMax2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtProblemSetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtScreenName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtNewProblemSetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtProblemNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.PositiveIntNumberOnly(sender, e);
        }

        private void txtGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.PositiveDoubleNumberOnly(sender, e);
        }

        private void txtNewStudentFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtNewStudentLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtNewStudentScreenName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtNewStudentPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        private void txtNewStudentAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.PositiveIntNumberOnly(sender, e);
        }

        private void txtProblemSetDefaultsMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtPoblemSetDefaultsMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.IntNumberOnly(sender, e);
        }

        private void txtProblemSetDefaultsGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.PositiveDoubleNumberOnly(sender, e);
        }

        private void txtProblemSetDefaultsNumberOfProblems_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.PositiveIntNumberOnly(sender, e);
        }

        private void txtAddStudentGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.NameOnly(sender, e);
        }

        #endregion

        #region Validating Events

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtScreenName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtNewProblemSetGoal_Validating(object sender, CancelEventArgs e)
        {
            validGoal(sender);
        }

        private void txtNewProblemSetNumberProblems_Validating(object sender, CancelEventArgs e)
        {
            validNumberOfProblems(sender);
        }

        private void txtNewProblemSetName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtProblemSetName_Validating(object sender, CancelEventArgs e)
        {
            validName(sender);
        }

        private void txtNewStudentPassword_Validating(object sender, CancelEventArgs e)
        {
            validPassword(sender);
        }

        private void dtpAddStudentDOB_Validating(object sender, CancelEventArgs e)
        {
            validDate(sender);
        }

        private void txtNewProblemOperand_Validating(object sender, CancelEventArgs e)
        {
            validRange(sender);
        }

        #endregion

        #region Check Chanaged Events

        private void DisableNewProblemSetButton()
        {
            //AG-JB
            //if (!cbxNewProblemAddition.Checked
            //    && !cbxNewProblemMinus.Checked
            //    && !cbxNewProblemTimes.Checked
            //    && !cbxNewProblemDivide.Checked)
            //{ btnSaveNewProblemSet.Enabled = false; }
        }

        private void cbxNewProblemSetAddition_CheckedChanged(object sender, EventArgs e)
        {
            //AG-JB
            //if (cbxNewProblemAddition.Checked)
            //{
            //    txtNewProblemSetAdditionFirstOperandMin.Enabled = true;
            //    txtNewProblemSetAdditionFirstOperandMax.Enabled = true;
            //    txtNewProblemSetAdditionSecondOperandMin.Enabled = true;
            //    txtNewProblemSetAdditionSecondOperandMax.Enabled = true;
            //    cbxNewProblemAdditionAllowNegative.Enabled = true;
            //    btnSaveNewProblemSet.Enabled = true;
            //}
            //else
            //{
            //    txtNewProblemSetAdditionFirstOperandMin.Enabled = false;
            //    txtNewProblemSetAdditionFirstOperandMax.Enabled = false;
            //    txtNewProblemSetAdditionSecondOperandMin.Enabled = false;
            //    txtNewProblemSetAdditionSecondOperandMax.Enabled = false;

            //    errorProviderNewUser.SetError(txtNewProblemSetAdditionFirstOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetAdditionFirstOperandMax, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetAdditionSecondOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetAdditionSecondOperandMax, string.Empty);

            //    cbxNewProblemAdditionAllowNegative.Enabled = false;
            //    DisableNewProblemSetButton();
            //}
        }

        private void cbxNewProblemSetMinus_CheckedChanged(object sender, EventArgs e)
        {
            //AG-JB
            //if (cbxNewProblemMinus.Checked)
            //{
            //    txtNewProblemSetMinusFirstOperandMin.Enabled = true;
            //    txtNewProblemSetMinusFirstOperandMax.Enabled = true;
            //    txtNewProblemSetMinusSecondOperandMin.Enabled = true;
            //    txtNewProblemSetMinusSecondOperandMax.Enabled = true;
            //    cbxNewProblemSetNegativeAnswers.Enabled = true;
            //    btnSaveNewProblemSet.Enabled = true;
            //}
            //else
            //{
            //    txtNewProblemSetMinusFirstOperandMin.Enabled = false;
            //    txtNewProblemSetMinusFirstOperandMax.Enabled = false;
            //    txtNewProblemSetMinusSecondOperandMin.Enabled = false;
            //    txtNewProblemSetMinusSecondOperandMax.Enabled = false;

            //    errorProviderNewUser.SetError(txtNewProblemSetMinusFirstOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetMinusFirstOperandMax, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetMinusSecondOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetMinusSecondOperandMax, string.Empty);

            //    cbxNewProblemSetNegativeAnswers.Enabled = false;
            //    DisableNewProblemSetButton();
            //}
        }

        private void cbxNewProblemSetTimes_CheckedChanged(object sender, EventArgs e)
        {
            //AG-JB
            //if (cbxNewProblemTimes.Checked)
            //{
            //    txtNewProblemSetTimesFirstOperandMin.Enabled = true;
            //    txtNewProblemSetTimesFirstOperandMax.Enabled = true;
            //    txtNewProblemSetTimesSecondOperandMin.Enabled = true;
            //    txtNewProblemSetTimesSecondOperandMax.Enabled = true;
            //    btnSaveNewProblemSet.Enabled = true;
            //}
            //else
            //{
            //    txtNewProblemSetTimesFirstOperandMin.Enabled = false;
            //    txtNewProblemSetTimesFirstOperandMax.Enabled = false;
            //    txtNewProblemSetTimesSecondOperandMin.Enabled = false;
            //    txtNewProblemSetTimesSecondOperandMax.Enabled = false;

            //    errorProviderNewUser.SetError(txtNewProblemSetTimesFirstOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetTimesFirstOperandMax, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetTimesSecondOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetTimesSecondOperandMax, string.Empty);
            //    DisableNewProblemSetButton();

            //}
        }

        private void cbxNewProblemSetDivide_CheckedChanged(object sender, EventArgs e)
        {
            //AG-JB
            //if (cbxNewProblemDivide.Checked)
            //{
            //    txtNewProblemSetDivideFirstOperandMin.Enabled = true;
            //    txtNewProblemSetDivideFirstOperandMax.Enabled = true;
            //    txtNewProblemSetDivideSecondOperandMin.Enabled = true;
            //    txtNewProblemSetDivideSecondOperandMax.Enabled = true;
            //    cbxNewProblemWholeNumber.Enabled = true;
            //    btnSaveNewProblemSet.Enabled = true;

            //}
            //else
            //{
            //    txtNewProblemSetDivideFirstOperandMin.Enabled = false;
            //    txtNewProblemSetDivideFirstOperandMax.Enabled = false;
            //    txtNewProblemSetDivideSecondOperandMin.Enabled = false;
            //    txtNewProblemSetDivideSecondOperandMax.Enabled = false;

            //    errorProviderNewUser.SetError(txtNewProblemSetDivideFirstOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetDivideFirstOperandMax, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetDivideSecondOperandMin, string.Empty);
            //    errorProviderNewUser.SetError(txtNewProblemSetDivideSecondOperandMax, string.Empty);

            //    cbxNewProblemWholeNumber.Enabled = false;
            //    DisableNewProblemSetButton();
            //}
        }

        #endregion

        #region Click Events

        private void btnNewProblemSetSave_Click(object sender, EventArgs e)
        {
            CreateProblemSet();
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MMControl.UserLogout(sender, e);
        }

        private void btnAssignProblemSet_Click(object sender, EventArgs e)
        {
            CreateAssignment();
            UpdateBindings();
        }

        private void btnSaveNewProblemSet_Click(object sender, EventArgs e)
        {
            CreateProblemSet();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        { RemoveUser(); }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveProblemSetDefaults();
        }

        private void btnRemoveAssigned_Click(object sender, EventArgs e)
        {
            DeleteAssignment();
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            ModifyUserForm.ShowDialog ();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Forms.frmMathMonkeysAbout();
            frm.ShowDialog();
        }

        #endregion

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
            lblCurrentTime.TextAlign = ContentAlignment.MiddleRight;
            this.Update();
        }

        private void ddlAssignProblemSetStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBindings();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// clears all validation errors to nullifie "Christmas Tree" Error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProblemSetDefaults();
            errorProviderNewUser.Clear();
        }

        private void frmAdminControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            MMControl.CurrentUser.Logout(MMControl);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
        //    dtpEndDate.MinDate = dtpStartDate.Value;
        //    DateFilter();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpStartDate.MaxDate = dtpEndDate.Value;
            //DateFilter();
        }

        #endregion

        /// <summary>
        /// DOES NOT WORK AS OF 9 April 2014
        /// </summary>
        private void DateFilter()
        {
            //if (dtpStartDate.Value > dtpEndDate.Value)
            //{
            //    assignmentsBindingSource.Filter = string.Empty;
            //    errorProviderNewUser.SetError(dtpStartDate, "Start date must be less than or equal to end Date");
            //    errorProviderNewUser.SetError(dtpEndDate, "Start date must be less than or equal to end Date");
            //}
            //else
            //{
            //    errorProviderNewUser.SetError(dtpStartDate, string.Empty);
            //    errorProviderNewUser.SetError(dtpEndDate, string.Empty);
            //    assignmentsBindingSource.Filter = "DateAssigned >= #"
            //       + dtpStartDate.Value.ToShortDateString()
            //       + "# && DateAssigned <= #"
            //       + dtpEndDate.Value.ToShortDateString()
            //       + "#";
            //}
        }

        private void modifyStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyUserForm.ShowDialog ();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Arun Gopinath, Jeff Bunce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMControl.UserLogout(this, e);
        }


        private void removeStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUsersForm.ShowDialog ();
        }

        private void addProblemSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMControl.AddProblemSet();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMControl.RemoveProblemSet();
        }

        private void problemSetDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMControl.ProblemSetDefaults();
        }

        private void mathDrillSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MMControl.MathDrillSettings();
        }

        private void printSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void parentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // REFACTOR ME
            frmParentReport testchild = new frmParentReport();
            testchild.MdiParent = this;
            testchild.Show();
            waitOneSec(sender, e);
            testchild.WindowState = FormWindowState.Maximized;
        }

        private void waitOneSec(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300); // actually 1/3 of a second
        }

        private void frmAdminControl_Load(object sender, EventArgs e)
        {

        }

        private void menuStripAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (!menuHidden)
            {
                Timer animTimer = new Timer();
                animTimer.Interval = 2000; // milliseconds
                //animTimer.Stop();
                animTimer.Start();
                //menuHideTimer_Tick(animTimer, e);
            }
        }

        private void menuHideTimer_Tick(object sender, EventArgs e)
        {
            //  hide menu animation
            int pixelsHigh = 120;
            for (int px = 0; px < pixelsHigh; px++)
            {
                if (px < 3)
                {
                    System.Threading.Thread.Sleep(16);
                    Refresh();
                }
                pnlGreeting.Location = new Point(0, -px);
                if ((px % 2) == 0)
                    Refresh();
            }
            Timer t = (Timer)sender;
            t.Stop();
            menuHidden = true;
        }

         #region DEPRACATED Code

        /*
            //string name = txtProblemSetName.Text;
            //Operation operation;
            //bool isValid = false;

            //ProblemSet problemSet = new ProblemSet();
            //OperandsRange range1 = new OperandsRange();
            //OperandsRange range2 = new OperandsRange();

            //isValid = validName(txtProblemSetName);

            //if (!isValid)
            //{
            //    MessageBox.Show("Problem Set Name is invalid. Please Make the needed corrections and resubmit.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{

            //    range1.rangeMin = int.Parse(txtRangeMin1.Text);
            //    range1.rangeMax = int.Parse(txtRangeMax1.Text);
            //    range2.rangeMin = int.Parse(txtRangeMin2.Text);
            //    range2.rangeMax = int.Parse(txtRangeMax2.Text);

            //    /////////////////////////////////////////////////////
            //    // need to change method to only allow in values
            //    ////////////////////////////////////////////////////


            //    if (rbtAddition.Checked)
            //    { operation = Operation.Addition; }

            //    else if (rbtSubtraction.Checked)
            //    { operation = Operation.Subtraction; }

            //    else if (rbtTimes.Checked)
            //    { operation = Operation.Multiplication; }

            //    else if (rbtDivide.Checked)
            //    { operation = Operation.Division; }

            //    else
            //    { operation = Operation.None; }

            //    problemSet.ID = Guid.NewGuid().ToString();
            //    problemSet.Name = name;
            //    problemSet.Operation = operation;



            //}*/
        //dgvStudents.DataSource = MMControl.StudentList;
        //dgvStudents.Update();

        //lbxAssigned.DataSource = MMControl.StudentList;
        //lbxAssigned.Update();

        //dgvAssignStudents.DataSource = MMControl.StudentList;
        //dgvAssignStudents.Update();

        //dgvRemoveStudent.DataSource = MMControl.StudentList;
        // dgvRemoveStudent.Update();

        //AG Comment start
        //ddlAssignProblemSetStudent.DataSource = mmControl.StudentList;
        //ddlAssignProblemSetStudent.DisplayMember = "GetFullName";
        //ddlAssignProblemSetStudent.ValueMember = "ID";
        //ddlAssignProblemSetStudent.Update();
        //AG Comment end


        //AG Comment start
        //var stude = from stu in MMControl.StudentList
        //            where stu.ID == ddlAssignProblemSetStudent.SelectedValue.ToString()
        //            select stu
        //                   ;

        //Student student = stude.ToList()[0];

        //var problemSet = from probSet in MMControl.ProblemSetList
        //                 where probSet.ID == lbxAvailable.SelectedValue.ToString()
        //                 select probSet;


        //if (student != null)
        //{
        //    foreach (ProblemSet prob in problemSet.ToList())
        //    {
        //        Assignment assign = new Assignment(Guid.NewGuid().ToString(), student, prob);
        //        MMControl.AddNewAssignment(assign);
        //        student.Assignments.Add(assign);
        //    }
        //}
        //AG Comment start

        //private void cobxNewProblemSetAdditionMin_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MMControl.IntNumberOnly(sender, e);
        //}

        //private void cobxNewProblemSetAddMax_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MMControl.IntNumberOnly(sender, e);
        //}

        //private void cobxNewProblemSetMinusMin_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MMControl.IntNumberOnly(sender, e);
        //}

        //private void cobxNewProblemSetMinusMax_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MMControl.IntNumberOnly(sender, e);
        //}

        //private void cobxNewProblemSetDivideMin_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MMControl.IntNumberOnly(sender, e);
        //}

        //private void cobxNewProblemSetDivideMax_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    MMControl.IntNumberOnly(sender, e);
        //}

        //private void ddlNewStudentGrade_Validating(object sender, CancelEventArgs e)
        //{
        //    validGrade(sender);
        //}

        //private void tmrShowLabel_Tick(object sender, EventArgs e)
        //{
        //    //lblNewUserCreated.Enabled = false;
        //    //lblNewUserCreated.Visible = false;
        //    //this.Update();
        //    //tmrShowLabel.Stop();
        //}

        //private void btnFont_Click(object sender, EventArgs e)
        //{
        //    fdAdmin.ShowDialog(this);
        //    Properties.Settings.Default.Save();
        //}


        #endregion

    }
}
