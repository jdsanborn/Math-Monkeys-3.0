/* March 15, 2014 Jonathan Sanborn & Harvey Mercado
 * Filename: Assignment.cs
 * Classname: Assignment
 * 
 * Description: Class is used to associate the students with their assigned problem sets 
 * and goal of individual students to pass the assignment
 * CSUSM CS 441
 * 
 * 22 March 2014 Jonathan Sanborn & Harvey Mercado
 * Added Comments
 * and completed property
 * 
 * 30 March 2014 Jonathan Sanborn
 * Added XmL to decouple from the FileHandler
 * Added Date Completed property
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated comments
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Math_Monkeys
{
    /// <summary>
    /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
    /// The class represents an assignment that is linked to a user
    /// and a problem set.
    /// </summary>
    [XmlType("Assignment")]
    public class Assignment: IXMLnode
    {


        #region Member Variables

        private string id;
        private Student student;
        private ProblemSet problemSet;
        private bool isCompleted;
        private DateTime dateAssigned;
        private DateTime? dateCompleted;
        private List<AssignmentAttempt> assignmentAttempts; 

        #endregion 


        #region Properties

        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// A Unique ID to identify the assignment.
        /// </summary>
        [XmlElement("ID")]
        public string ID
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }

        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// A user id the refers to an existing user in the system
        /// </summary>
        [XmlElement("UserID")]
        public string UserID
        {
            get
            {
                return Student.ID; 
            }
            
        }

        /// <summary>
        /// 30 March 2014
        /// Jonathan Sanborn
        /// 
        /// Get, Sets the date that the assignment was completed
        /// </summary>
        [XmlElement("DateCompleted")]
        public DateTime? DateCompleted 
        { 
            get { return dateCompleted; } 
            set
            {
                if (value == null)
                {
                    dateCompleted = null;
                }
                else if (value > DateTime.Now)
                {
                    dateCompleted = DateTime.Now;
                }
                else if (value < DateTime.Now.AddYears(-10))
                {
                    dateCompleted = DateTime.MinValue;
                }
                else
                {
                    dateCompleted = value;
                }
            }  
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Student that this assignment belongs to
        /// </summary>
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// A Problem Set ID the refers to an existing problem set in the system
        /// </summary>
        [XmlElement("ProblemSetID")]
        public string ProblemSetID
        {
            get
            {
                return this.ProblemSet.ID;
            }
           
        }
        
        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Name of the problem set this assignment is built from
        /// </summary>
        public string ProblemSetName
        {
            get { return ProblemSet.Name; }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Problem set this assignment is built on
        /// </summary>
        public ProblemSet ProblemSet
        {
            get
            {
                return problemSet;
            }

            set
            {
                problemSet = value;
            }
        }

        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// A boolean indicating if the assignment has been Completed by the user
        /// </summary>
        [XmlElement ("Completed")]
        public bool IsCompleted 
        { 
            get { return isCompleted; } 
            set {isCompleted = value ;} 
        }

        /// <summary>
        /// Jonathan Sanborn
        /// The Date the Assignment was created
        /// </summary>
        [XmlElement ("DateAssigned")]
        public DateTime DateAssigned
        {
            get { return dateAssigned; }
            set { dateAssigned = value; }
        }

        /// <summary>
        /// 6 April 2014
        /// Jonathan Sanborn
        /// 
        /// Any assignment attempts for this assignment
        /// </summary>
        public List<AssignmentAttempt> AssignmentAttempts
        {
            get { return assignmentAttempts; }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The number of times this assignment has been attempted by the student
        /// </summary>
        public int NumberOfAttempts
        { get { return AssignmentAttempts.Count; } }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The least amount of time the student has spent attempting this assignment
        /// </summary>
        public TimeSpan FastestTime
        {
            get
            {
                TimeSpan time = TimeSpan.MaxValue;
                foreach (AssignmentAttempt aa in AssignmentAttempts)
                {
                    if (aa.TimeSpent < time)
                    { time = aa.TimeSpent; }
                }

                return time;
            }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Highest Grade that the student has achieved on this assignment so far.
        /// </summary>
        public double HighestGrade
        {
            get
            {
                double grade = 0.0;

                foreach (AssignmentAttempt aa in AssignmentAttempts)
                {
                    if (aa.Grade > grade)
                    { grade = aa.Grade; }
                }
                return grade;
            }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Date of the Last time this assignment was attempted
        /// </summary>
        public DateTime LastAttemptDate
        {
            get
            {
                DateTime date = DateTime.MinValue;
                foreach (AssignmentAttempt aa in AssignmentAttempts)
                {
                    if (aa.Date > date)
                    { date = aa.Date; }
                }

                return date;
            }
        }
        
        #endregion


        #region Methods

        /// <summary>
        /// 4 April 2014
        /// Jonathan Sanborn
        /// 
        /// Returns and XElement of this object
        /// </summary>
        /// <returns>An XElement of this object</returns>
        public XElement GetXMLNode()
        {
            var newAssignmentNode = new XElement("Assignment",
                                        new XElement("ID", ID),
                                        new XElement("UserID", UserID),
                                        new XElement("ProblemSetID", ProblemSetID),
                                        new XElement("DateAssigned", DateAssigned),
                                        new XElement("Completed", IsCompleted)
                                      );
            if (IsCompleted)
            {newAssignmentNode.Add(new XElement("DateCompleted", DateCompleted));}

            return newAssignmentNode;
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Gets all the assignment attempts for this assignment that are stored in the XML
        /// </summary>
        /// <param name="mmControl">The Control object</param>
        private void GetAssignmentAttempts(MMControl mmControl)
        {
            
            assignmentAttempts = mmControl.FileHandler.GetAssignmentAttemptsByAssignment(this);

            foreach (AssignmentAttempt aa in assignmentAttempts)
            {
                aa.Assignment = this;
            }
        }


        #endregion


        #region Constructors

        /// <summary>
        ///  22 March 2014 Jonathan Sanborn & Harvey Mercado
        ///  init method that initializes the assignment variables
        /// </summary>
        private void init()
        {
            ID = string.Empty;
            IsCompleted = false;
            this.DateAssigned = DateTime.Now;
            assignmentAttempts = new List<AssignmentAttempt>();
        }

        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// Default constructor for Assignment
        /// </summary>
        public Assignment()
        {
            init();
        }


        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// Parameterized constructor for Assignment
        /// </summary>
        /// <param name="id">A unique ID for the Assignment</param>
        /// <param name="userID">The unique ID of the user that the assignment is assigned to.</param>
        /// <param name="problemSetId">the problem set Id of the for which the Problem Set that the assignment is built on</param>
        /// <param name="goal">The percent of problems that must be correct to pass this assignment values 0.0-1.0.</param>
        public Assignment(MMControl mmControl, string id, Student student, ProblemSet problemSet)
        {
            init();

            this.ID = id;
            this.Student = student;
            this.ProblemSet = problemSet;
            this.DateAssigned = DateTime.Now;
            GetAssignmentAttempts(mmControl);
           
        }

        /// <summary>
        /// 22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// Parameterized constructor for Assignment
        /// </summary>
        /// <param name="mmControl">The Control Object</param>
        /// <param name="id">A unique ID for the Assignment</param>
        /// <param name="student">The student that this assignment belongs to.</param>
        /// <param name="problemSet">the problem set the assignment is built on</param>
        /// <param name="isCompleted">a boolean indicating that the assignment has been Completed</param>
        public Assignment(MMControl mmControl, string id, Student student, ProblemSet problemSet, bool isCompleted)
        {
            init();

            this.ID = id;
            this.Student = student;
            this.ProblemSet = problemSet;
            this.IsCompleted = isCompleted;
            this.DateAssigned = DateTime.Now;

            GetAssignmentAttempts(mmControl);
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// XML Constructor
        /// </summary>
        /// <param name="mmControl">The Control Object</param>
        /// <param name="s">The Student this assignment belongs to</param>
        /// <param name="d">An XElement that represents a Assignment</param>
        public Assignment(MMControl mmControl, Student s, XElement d)
        {
             ID = d.Element("ID").Value;
             ProblemSet = mmControl.FileHandler.GetProblemSetByID(d.Element("ProblemSetID").Value);
             DateAssigned = DateTime.Parse( d.Element("DateAssigned").Value);
             IsCompleted = bool.Parse(d.Element("Completed").Value);

             if (d.Element("DateCompleted") != null)
             { DateCompleted = DateTime.Parse(d.Element("DateCompleted").Value); }

             Student = s;
             GetAssignmentAttempts(mmControl);
        }

        #endregion
        

    }
}
