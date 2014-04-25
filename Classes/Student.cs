/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: EndUser , implements from User class
 * has a name, an id, and a type 
 * 
 * 
 * Modified 
 * 
 * 29 March 2014 Jonathan Sanborn
 * Added Date of birth and grade
 * 
 * 30 March 2014 Jonathan Sanborn
 * Added "Assignment" Methods
 * 
 * 30 March 2014 Jonathan Sanborn
 * Implemented IXMLNode interfaces
 * and started to decouple Student from FileHandler
 * 
 * 9 April 2014 Jonathan Sanborn
 * Updated Comments
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace Math_Monkeys
{
    /// <summary>
    /// 29 March 2014
    /// Jonathan Sanborn
    /// Represents a Student user in the system
    /// </summary>
    [XmlType("User")]
    public class Student : User, IXMLnode
    {

        //List of report function
        //List<Report> rep1 = new List<Report>();


        #region Member Variables

        private DateTime? dob;
        private string grade;

        #endregion


        #region Properties

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// The Assignments that are assigned to this student
        /// </summary>
        public List<Assignment> Assignments { get; set; }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Assignments for this Student that have not been compleated
        /// </summary>
        public List<Assignment> IncompletedAssignments
        {
            get { return Assignments.Where(w => w.IsCompleted == false).ToList(); }
        }

        /// <summary>
        /// 29 March 2014
        /// Jonathan Sanborn
        /// gets or sets the date of birth of the student
        /// </summary>
        [XmlElement("DOB")]
        public DateTime? DOB 
        {
            get { return dob; }
            set
            {
                if (value > DateTime.Now)
                {
                    dob = DateTime.MinValue;
                }
                else if (value < DateTime.Now.AddYears(-120))
                {
                    dob = DateTime.MinValue;
                }
                else
                {
                    dob = value;
                }
            }
        }

        /// <summary>
        /// 29 March 2014
        /// Jonathan Sanborn
        /// Gets or sets a string value representing the grade of the student
        /// </summary>
        [XmlElement ("Grade")]
        public string Grade
        {
            get
            {
                return grade;
            }
            set
            {
                value = value.Trim();
                if (value.Length == 0 || value == null)
                {
                    grade = string.Empty;
                }
                else if (value.Length > Properties.Settings.Default.NameLengthMax)
                {
                    grade = value.Substring(0, Properties.Settings.Default.NameLengthMax);
                }
                else
                {
                    grade = value;
                }
            }
        }
        
        /// <summary>
        /// Jonathan Sanborn
        /// 30 March 2014
        /// 
        /// Returns a count of the Completed assignments for this Student
        /// </summary>
        public int CompletedAssignments
        {
            get
            {
                int count = 0;
                
                foreach (Assignment assign in Assignments)
                {
                    if (assign.IsCompleted)
                    {count++;}
                }
                return count;
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 30 March 2014
        /// 
        /// Returns a count of the incomplete assignments for this Student
        /// </summary>
        public int IncompleteAssignments
        {
            get
            {
                int count = 0;

                foreach (Assignment assign in Assignments)
                {
                    if (!assign.IsCompleted)
                    { count++; }
                }
                return count;
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 30 March 2014
        /// 
        /// returns a count of the total assignments for this Student
        /// </summary>
        public int TotalAssignments
        {
            get
            {
                return Assignments.Count;
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Get An XElement that represents this Student
        /// </summary>
        /// <returns>An XElement of this Student</returns>
        public override XElement GetXMLNode()
        {

            XElement loginRecords = new XElement("LoginRecords");

            foreach (Login L in LoginRecords)
            {
                loginRecords.Add(
                    new XElement("Login",
                        new XElement("Date", L.Date),
                        new XElement("Duration", L.Duration)
                    )
                );
            }


            XElement newUserNode = new XElement("User",
                             new XElement("ID", ID),
                             new XElement("Type", UserType),
                             new XElement("ScreenName", ScreenName),
                             new XElement("Name",
                                 new XElement("First", FirstName),
                                 new XElement("Last", LastName)),
                             new XElement("Password", Password),
                             loginRecords
                         );
            if (DOB != null)
            {
                newUserNode.Add(new XElement("DOB", DOB));
            }

            if (Grade != null && Grade.Length > 0)
            {
                newUserNode.Add(new XElement("Grade", Grade));
            }

            return newUserNode;
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Get the assignments for this student from the XML 
        /// </summary>
        /// <param name="mmControl"></param>
        private void getAssignments(MMControl mmControl)
        {
            Assignments = mmControl.FileHandler.GetAssignmentsByStudent(this);
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Initialization method for Student class
        /// </summary>
        private void init()
        {
            base.UserType = UserType.Student;
            Assignments = new List<Assignment>();
        }

        /// <summary>
        /// 29 March 2014
        /// Jonathan Sanborn
        /// 
        /// Default Constructor
        /// </summary>
        public Student():base()
        {
            init();
        }

        /// <summary>
        /// 29 March 2014
        /// Jonathan Sanborn
        /// 
        /// Parameterized constructor for A Student user
        /// </summary>
        /// <param name="mmControl">The Controller Object</param>
        /// <param name="id">Unique ID for the student in the system</param>
        /// <param name="fistName">The first Name of the student</param>
        /// <param name="lastName">The last name of the student</param>
        /// <param name="screenName">A unique screen name for the student</param>
        /// <param name="password">The password for the student</param>
        /// <param name="dob">The date of birth for the student</param>
        /// <param name="grade">The grade or group the student is in.</param>
        public Student(MMControl mmControl, string id,string fistName, string lastName, string screenName, string password, DateTime? dob, string grade)
            : base(id, UserType.Student, fistName, lastName, screenName, password)
        {
            init();

            this.DOB = dob;
            this.grade = grade;

            getAssignments(mmControl);
   
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Copy construct from a User object
        /// </summary>
        /// <param name="mmControl">The Controller Object</param>
        /// <param name="user">The User to copy</param>
        public Student(MMControl mmControl, User user)
            : base()
        {
            init();
            this.ID = user.ID;
            this.UserType = user.UserType;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.ScreenName = user.ScreenName;
            this.LoginRecords = user.LoginRecords;
            this.Password = user.Password;

            getAssignments(mmControl);
        }

         /// <summary>
        /// 31 March 2014
        /// Jonathan Sanborn
        /// 
        /// Constructor takes a user XML node and creates a user object
        /// </summary>
        /// <param name="mmControl">The Controller Object</param>
        /// <param name="d">An XElement Containing the Student data</param>
        public Student(MMControl mmControl, XElement d)
            : base(d)
        {
            init();

            if(d.Element("DOB") !=  null)
            {DOB = DateTime.Parse(d.Element("DOB").Value);}

            if(d.Element("Grade") != null)
            {Grade = d.Element("Grade").Value;}

            getAssignments(mmControl);

        }

        #endregion


        #region DEPRECATED Code

        ////loads reports from the user file
        //private void LoadProgress()
        //{

        //}

        //// make a report object  
        //private void SaveProgress()
        //{
        //    //would append to the list 

        //}

        ////14 March 2014 Jonathan Sanborn: User Type implmented in the User class 
        ////
        ////public string GetUserType()
        ////{
        ////    return "EndUser";
        ////}

        ////add correct problem set or modify existing problem set making sure that not 
        //protected void AddProblemSet(string problemSetName)
        //{

        //}

        #endregion


    }
}
