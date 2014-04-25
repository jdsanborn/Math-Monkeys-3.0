/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Phase 2 Programmers: Jonathan Sanborn, Harvey Mercado
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * File Name: MMControl.cs
 * Class Name: MMControl  
 * 
 * intended to unite all forms in one class
 * 
 * as of March 2, not implemented yet. 
 * 
 * March 3, 2014 Modified by Mary Venegas
 * implementing a control class to fit all forms in the application
 * 
 * March 16, 2014 
 * implementing control class as program controller
 * 
 *22 March 2014
 *Jonathan Sanborn, Harvey Mercado
 *Added sort to the users list
 *Created the UserLogin() method by adding to and reorganizing existing code
 *to add basic password functionality.
 *Added basic AuthenticateUser(User user, string password)
 *Added Comments
 * 
 * 
 * 23 March 2014
 * Jonathan Sanborn
 * 
 * 1 April 2014
 * Jonathan Sanborn
 * Incorporated Student Drill form and
 * Student results form
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated comments
 * Updated flowerbox
 * 
 * 19 April 2014
 * Jeff Bunce
 * Cleared password field if password is incorrect
 * 
 * 21 April 2014
 * Jeff Bunce
 * Refactoring..
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Math_Monkeys.Classes;
using Math_Monkeys.Forms;
using System.IO;
using System.Reflection;

namespace Math_Monkeys
{
    /// <summary>
    /// 22 March 2014
    ///Jonathan Sanborn, Harvey Mercado
    ///The  Brain and gate keeper of the application
    /// </summary>
    public class MMControl
    {


        #region Member Variables

        private User currentUser;
        private Student currentStudent;
        private AssignmentSession assignmentSession;

        private frmLogin LoginForm;
        private frmAdminControl AdminForm;
        private frmStudentWelcome StudentWelcomeForm;
        private frmStudentDrill StudentDrillForm;
        private frmDrillResult StudentResultForm;

        //AG-JB
        private frmAddProblemSet addProblemSet;
        private frmRemoveProblemSet removeProblemSet;
        private frmProblemSetDefaults problemSetDefaults;
        private frmDrillScreenSettings drillSettings;

        private List<User> allUserList;
        private List<Student> studentList;
        private List<Admin> adminList;
        private List<ProblemSet> problemSetList;

        private List<string> numberOfAttempts; //List for the number Of attempts drop downs
        private List<string> numberOfAttemptsDefault; //List for the number Of attempts default drop downs

        private FileHandler fileHandler;

        #endregion


        #region Properties

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// A List of strings for the Number of Attempts Drop Downs
        /// </summary>
        public List<string> NumberOfAttempts
        {
            get { return numberOfAttempts; }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// A List of strings for the Number of Attempts default Drop Downs
        /// </summary>
        public List<string> NumberOfAttemptsDefault
        {
            get { return numberOfAttemptsDefault; }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// An Assignment Session
        /// </summary>
        internal AssignmentSession AssignmentSession
        {
            get { return assignmentSession; }
            set { assignmentSession = value; }
        }

        /// <summary>
        ///22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        /// A list that contains and tracks all users in the system
        /// </summary>
        internal List<User> AllUserList
        {
            get
            {
                allUserList.Sort();
                return allUserList;
            }
            private set { allUserList = value; }
        }

        /// <summary>
        ///22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        /// A list that contains and tracks all Students in the system
        /// </summary>
        internal List<Student> StudentList
        {
            get { return studentList; }
            private set { studentList = value; }
        }

        /// <summary>
        ///22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        /// A list that contains and tracks all Admins in the system
        /// </summary>
        internal List<Admin> AdminList
        {
            get { return adminList; }
            private set { adminList = value; }
        }

        /// <summary>
        ///22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        /// The currently logged in user
        /// </summary>
        public User CurrentUser
        {
            get
            { return currentUser; }
        }

        /// <summary>
        ///1 April 2014
        ///Jonathan Sanborn
        /// The currently logged in student
        /// </summary>
        public Student CurrentStudent
        {
            get
            { return currentStudent; }
        }

        /// <summary>
        ///22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        /// A list that contains and tracks problem sets in the system
        /// </summary>
        internal List<ProblemSet> ProblemSetList
        {
            get { return problemSetList; }
            private set { problemSetList = value; }
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// File Handler for all objects to use
        /// </summary>
        public FileHandler FileHandler
        {
            get
            {
                if (fileHandler == null)
                { fileHandler = new FileHandler(this); }
                return fileHandler;
            }
        }

        #endregion


        #region Event Handlers

        /// <summary>
        /// 
        /// 22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        ///Updates the currently selected user
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        public void LoginSelectionChanged(object sender, EventArgs e)
        {
            ComboBox changed = sender as ComboBox;

            currentUser = (User)changed.SelectedValue;
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Handles the user Login event
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="e">The event arguments</param>
        public void Login(object sender, EventArgs e)
        {
            UserLogin();
        }

        /// <summary>
        /// 22 March 2014 
        /// Jonathan Sanborn & Harvey Mercado
        /// Handels when user issues a logout commnad
        /// </summary>
        /// <param name="sender">the object that raised the event</param>
        /// <param name="e">the event arguments</param>
        public void UserLogout(object sender, EventArgs e)
        {
            Form myForm = null;

            if (sender is Button)
            {
                Button btn = sender as Button;
                myForm = btn.FindForm();
            }
            else if (sender is frmAdminControl)
            {
                myForm = sender as frmAdminControl;

            }

            if (myForm != null)
            {
                currentUser.Logout(this);

                myForm.Hide();
                myForm.Close();

                LoginForm = new frmLogin(this);
                LoginForm.ShowDialog();
            }
        }

        /// <summary>
        /// 1 April 2014
        /// Jonathan Sanborn
        /// 
        /// Displays the Student Welcome Form
        /// </summary>
        /// <param name="sender">The initating object</param>
        /// <param name="e">Event Args</param>
        public void StartDrill(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                Form myForm = btn.FindForm();

                myForm.Hide();
                myForm.Close();

                StudentDrillForm = new frmStudentDrill(this);
                StudentDrillForm.ShowDialog();
            }
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// Displays the Results form to the user
        /// </summary>
        /// <param name="sender">The object that raised this event</param>
        /// <param name="e">The event arguments</param>
        public void DisplayResults(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            TextBox txt = sender as TextBox;
            if (btn != null)
            {
                Form myForm = btn.FindForm();

                myForm.Hide();
                myForm.Close();

                StudentResultForm = new frmDrillResult(this);
                StudentResultForm.ShowDialog();
            }

            else if (txt != null)
            {
                Form myForm = txt.FindForm();

                myForm.Hide();
                myForm.Close();

                StudentResultForm = new frmDrillResult(this);
                StudentResultForm.ShowDialog();
            }
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Allows only interger numbers to be entered in the passed in textbox
        /// </summary>
        /// <param name="sender">A textbox</param>
        /// <param name="e">the event args</param>
        public void IntNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }

                //in the key is the negative sign and it is not the first charcter ignore it.
                if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Allows only postive interger numbers to be entered in the passed in textbox
        /// </summary>
        /// <param name="sender">A textbox</param>
        /// <param name="e">the event args</param>
        public void PositiveIntNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Allows only double numbers to be entered in the passed in textbox
        /// </summary>
        /// <param name="sender">A textbox</param>
        /// <param name="e">the event args</param>
        public void DoubleNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }

                //If the key is a decimal point and it is the second one ignore it.
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                //in the key is the negative sign and it is not the first charcter ignore it.
                if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Allows only positive double numbers to be entered in the passed in textbox
        /// </summary>
        /// <param name="sender">A textbox</param>
        /// <param name="e">the event args</param>
        public void PositiveDoubleNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                //If the key is a decimal point and it is the second one ignore it.
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

            }
        }

        /// <summary>
        /// 22 March 2014 
        /// Jonathan Sanborn & Harvey Mercado
        /// Allows only name charcters to be entered in the passed in textbox
        /// </summary>
        /// <param name="sender">A textbox</param>
        /// <param name="e">the event args</param>
        public void NameOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetterOrDigit(e.KeyChar)
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
        /// 29 March 2014
        /// Jonathan Sanborn
        /// Allows only valid password cars in the passed in textbox
        /// </summary>
        /// <param name="sender">The object that rasied this event</param>
        /// <param name="e">The event arguments</param>
        public void PasswordCharsOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetterOrDigit(e.KeyChar)
                )
            {
                e.Handled = true;
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Loads the number of attempts list with the strings found in the
        /// NumberOfAttempts.txt embedded text file
        /// values are currently keyed to the index of the ddl
        /// should be altered for more versitle functionality.
        /// </summary>
        private void LoadNumberOfAttempts()
        {
            char[] delimiterChars = { '\n', '\r', '\t' };
            NumberOfAttempts.Clear();

            numberOfAttempts = Properties.Resources.NumberOfAttempts.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).ToList();
            numberOfAttemptsDefault = Properties.Resources.NumberOfAttempts.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        ///// <summary>
        ///// 1 April 2014
        ///// Jonathan Sanborn
        ///// 
        ///// Gets the assignements and assignments of the passed in student.
        ///// </summary>
        ///// <param name="student">The Student to load with the assignment</param>
        //public void GetStudentAssignments(ref Student student)
        //{
        //    student.Assignments.Clear();
        //    student.AssignmentAttempts.Clear();

        //    student.Assignments.AddRange(FileHandler.GetAssignmentsByUser(student));

        //    foreach (Assignment assign in student.Assignments)
        //    {
        //        student.AssignmentAttempts.AddRange(FileHandler.GetAssignmentAttemptsByAssignmentID(assign.ID));
        //    }

        //}

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Called to login the user currently set
        /// 
        /// 21 April 2014
        /// Jeff Bunce
        /// Refactored
        /// 
        /// </summary>
        internal void UserLogin()
        {
            if (currentUser == null) 
            {
                MessageBox.Show("Please Select a user.", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;  // must select a user
            }


            TextBox txtPassword = LoginForm.Controls.Find("txtPassword", true)[0] as TextBox;
            if (AuthenticateUser(CurrentUser, txtPassword.Text)) 
            {
                txtPassword.Text = string.Empty;
                currentUser.Login();
            }
            else
            {                
                MessageBox.Show("Wrong Password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = String.Empty;
                return;  // selected user must authenticate
            }


            if (currentUser.UserType == UserType.Student)
            {
                    currentStudent = StudentList.Where(w => currentUser.ID == w.ID).First();

                    ProblemSetList.Clear();

                    if (currentStudent.IncompleteAssignments > 0)
                    {
                        LoginForm.Hide();
                        LoginForm.Close();
                        Assignment assign = CurrentStudent.Assignments.Where(w => !w.IsCompleted).First();
                        assignmentSession = new AssignmentSession(this, ref assign);
                        StudentWelcomeForm = new Forms.frmStudentWelcome(this);
                        StudentWelcomeForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(currentUser.ScreenName + " currently has no assignments. Please go see your teacher.", "Go See Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currentUser.Logout(this);
                    }
            }
            else if (currentUser.UserType == UserType.Administrator)
            {
                    LoginForm.Hide();
                    LoginForm.Close();

                    ProblemSetList = FileHandler.GetAllProblemSets();

                    AdminForm = new frmAdminControl(this);
                    AdminForm.ShowDialog();
            }
        }


        internal void MathDrillSettings()
        {
            drillSettings = new frmDrillScreenSettings();
            drillSettings.ShowDialog();
        }
        internal void ProblemSetDefaults()
        {
            problemSetDefaults = new frmProblemSetDefaults();
            problemSetDefaults.ShowDialog();
        }
        internal void RemoveProblemSet()
        {
            removeProblemSet = new frmRemoveProblemSet();
            removeProblemSet.ShowDialog();
        }
        internal void AddProblemSet()
        {
            addProblemSet = new frmAddProblemSet(this);
            addProblemSet.ShowDialog();
        }
        /// <summary>
        ///  22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// returns a bool of if the user is valid
        /// 
        /// 21 April 2014
        /// Jeff Bunce
        /// Refactored.  Keeping this as a function because
        /// other methods of authentication can be easily
        /// swapped out in lieu of password authentication.
        /// </summary>
        /// <param name="user">The user to authenticate</param>
        /// <param name="password">the password for the user</param>
        /// <returns>if the user is valid</returns>
        internal bool AuthenticateUser(User user, string password)
        {
            return (user.Password == password);
        }

        /// <summary>
        ///  22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Adds a new student to the system
        /// </summary>
        /// <param name="newUser">A student user to add to the system</param>
        internal void AddNewStudent(Student newUser)
        {

            AllUserList.Add(newUser);
            StudentList.Add(newUser);
            this.FileHandler.SaveNewUser(newUser);
        }

        /// <summary>
        /// 5 April 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Removes all the students and their asscoiated objects in the passed in list from the system.
        /// </summary>
        /// <param name="RemoveList">The List of students to remove</param>
        public void RemoveStudents(List<Student> RemoveList)
        {
            foreach (Student s in RemoveList)
            {
                foreach (Assignment a in s.Assignments)
                {
                    foreach (AssignmentAttempt aa in a.AssignmentAttempts)
                    { FileHandler.DeleteAssignmentAttempt(aa); }

                    FileHandler.DeleteAssignment(a);
                }

                StudentList.Remove(s);
                AllUserList.Remove(s);
                FileHandler.DeleteUser(s);
            }
        }

        /// <summary>
        ///  22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Add a new problem set to the system
        /// </summary>
        /// <param name="problemSet">The problem set to add to the system</param>
        internal void AddProblemSet(ProblemSet problemSet)
        {
            ProblemSetList.Add(problemSet);
            this.FileHandler.SaveNewProblemSet(problemSet);
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Creates a new assignment for each sudent in the passed in List foreach problemSet in
        /// the passed in List
        /// </summary>
        /// <param name="students">The list of Students to create assignments for</param>
        /// <param name="problemSetList">The List of Problemsets to create assignmetns from</param>
        public void AddNewAssignment(List<Student> students, List<ProblemSet> problemSetList)
        {
            foreach (Student student in students)
            {
                Student s = StudentList.Where(w => student.ID == w.ID).First();
                foreach (ProblemSet ps in problemSetList)
                {
                    Assignment assign = new Assignment(this, Guid.NewGuid().ToString(), s, ps);
                    s.Assignments.Add(assign);
                    FileHandler.SaveNewAssignment(assign);
                }
            }
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// Deletes the passed in list of assignments from the passed in list of students
        /// 
        /// </summary>
        /// <param name="StudentList">The List of students to delete assignments from</param>
        /// <param name="AssignmentList">The list of Assignments to delete</param>
        public void DeleteAssignments(List<Assignment> AssignmentList)
        {
            foreach (Assignment A in AssignmentList)
            {
                A.Student.Assignments.Remove(A);
                FileHandler.DeleteAssignment(A);
            }
        }

        /// <summary>
        /// Starts the Math monkeys applicaion running
        /// </summary>
        /// <returns>Exit status</returns>
        public int RunProgram()
        {
            LoginForm = new frmLogin(this);
            LoginForm.ShowDialog();

            return 0;
        }

        #endregion


        #region Constructors

        /// <summary>
        /// 22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        ///Initialization Method for MMControl
        ///Sets all values to there default constructors
        /// </summary>
        private void init()
        {
            fileHandler = new FileHandler(this);
            AdminList = new List<Admin>();
            StudentList = new List<Student>();
            AllUserList = new List<User>();

            ProblemSetList = new List<ProblemSet>();

            numberOfAttempts = new List<string>();
            numberOfAttemptsDefault = new List<string>();

        }

        /// <summary>
        /// 22 March 2014
        ///Jonathan Sanborn & Harvey Mercado
        /// Default Constructor
        /// </summary>
        public MMControl()
        {
            init();

            AdminList = FileHandler.GetAllAdmins();
            StudentList = FileHandler.GetAllStudents();
            AllUserList = FileHandler.GetAllUsers();
            LoadNumberOfAttempts();
        }

        #endregion


        #region DEPRECATED CODE

        //AssignmentList = FileHandler.GetAllAssignments();
        //AssignmentAttemptList = FileHandler.GetAllAssignmentAttempts();

        //bool hasAssignments = false;

        //AssignmentList = FileHandler.GetAssignmentsByUser(currentUser);
        //AssignmentAttemptList.Clear();

        //functionality movend into student object
        //foreach (Assignment assign in AssignmentList)
        //{
        //    AssignmentAttemptList.AddRange(FileHandler.GetAssignmentAttemptsByAssignmentID(assign.ID));
        //    ProblemSetList.Add(FileHandler.GetProblemSetByID(assign.ProblemSetID));
        //    if (!assign.IsCompleted)
        //    {hasAssignments = true;}
        //}

        /// <summary>
        ///  22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Adds a new Admin to the system
        /// </summary>
        /// <param name="newUser">A Admin user to add to the system</param>
        //internal void AddNewAdmin(Admin newUser)
        //{
        //    AllUserList.Add(newUser);
        //    AdminList.Add(newUser);
        //    this.FileHandler.SaveNewUser(newUser);
        //}

        ///// <summary>
        /////  22 March 2014
        ///// Jonathan Sanborn & Harvey Mercado
        ///// Adds a new User to the system
        ///// </summary>
        ///// <param name="newUser">A User to add to the system</param>
        //internal void AddNewUser(Student newUser)
        //{
        //    AllUserList.Add(newUser);
        //    this.FileHandler.SaveNewUser(newUser);
        //}



        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="assign"></param>
        //internal void AddNewAssignment(Assignment assign)
        //{
        //   // AssignmentList.Add(assign);
        //    this.FileHandler.SaveNewAssignment(assign);
        //}

        /////<summary>
        /////22 March 2014
        /////Jonathan Sanborn & Harvey Mercado
        ///// A list that contains and tracks Assignments in the system
        ///// </summary>
        //internal List<Assignment> AssignmentList
        //{
        //    get { return assignmentList; }
        //    private set { assignmentList = value; }
        //}

        /////<summary>
        /////22 March 2014
        /////Jonathan Sanborn & Harvey Mercado
        ///// A list that contains and tracks Assignments Attempts in the system
        ///// </summary>
        //internal List<AssignmentAttempt> AssignmentAttemptList
        //{
        //    get { return assignmentAttemptList; }
        //    private set { assignmentAttemptList = value; }
        //}

        // List<AssignmentSet> AllAssignmentList;
        //private List<Assignment> assignmentList;
        //private List<AssignmentAttempt> assignmentAttemptList;

        //private string _Message;
        //List<Jungle> Jungles = new List<Jungle>();
        //Math Sets
        //AdditionProblemSet addition = new AdditionProblemSet();
        //SubtractionProblemSet subtraction = new SubtractionProblemSet();


        ////Loging Form 
        //// return a list of existent user
        //public List<User> GetUsers()
        //{
        //    return AllUserList;
        //}


        ////Messge to Return 
        //public string Message
        //{
        //    get
        //    {
        //        return _Message;
        //    }
        //    set
        //    {
        //        _Message = value;
        //    }
        //}

        //

        //

        //
        #endregion


    }
}
