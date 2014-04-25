/* March 15, 2014 Jonathan Sanborn & Harvey Mercado
 * Filename: AssignmentAttempt.cs
 * Classname: AssignmentAttempt
 * 
 * Description: Records each attempt a student makes on a specific assignment
 * CSUSM CS 441
 * 
 * 22 March 2014
 * Jonathan Sanborn & Harvey Mercado
 * Added comments
 * 
 * 
 * 30 March 2014
 * Jonathan Sanborn
 * Added XML Decoupling from the File Handler object
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
    ///  22 March 2014
    ///  Jonathan Sanborn & Harvey Mercado
    /// A class to represent an assignment that has been attempted by a given user
    /// </summary>
     [XmlType("AssignmentAttempt")]
    public class AssignmentAttempt: IXMLnode
    {


        #region Member Variables

        private string id;
        private Assignment assignment;
        private DateTime date;
        private double grade;
        private TimeSpan timeSpent;

        #endregion


        #region Properties

         /// <summary>
        /// 22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
        ///  A unique ID to represent the assignment attempt
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
        ///  22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
        ///  An Assignment ID that refers to an existing assignment in the system
         /// </summary>
        [XmlElement("AssignmentID")]
        public string AssignmentID
        {
            get
            { 
                return this.Assignment.ID;
            }
           
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Assignment that this assignmentAttempt belongs to.
        /// </summary>
        public Assignment Assignment
        {
            get
            {
                return this.assignment;
            }
            set
            {
                this.assignment = value;
            }
        }

         /// <summary>
        ///  22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
         /// A date the represents the date and time the assignment was attempted
         /// </summary>
        [XmlElement("Date")]
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value > DateTime.Now.AddDays(1.0))
                {
                    date = DateTime.Now;
                }
                else if (value < DateTime.Now.AddYears(-5))
                {
                    date = DateTime.Now.AddYears(-5);
                }
                else
                {
                    date = value;
                }
            }
        }

         /// <summary>
        ///  22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
        ///  The grade as a percent from 0.0-1.0 that indicated the number correct on this assignment attempt
         /// </summary>
        [XmlElement("Grade")]
        public double Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 0.0)
                {
                    grade = 0.0;
                }
                else if (value > 1.0)
                {
                    grade = 1.0;
                }
                else
                {
                    grade = value;
                }
            }
        }

         /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// The amount of time taken working on this attempt
         /// </summary>
        [XmlElement("TimeSpent")]
        public TimeSpan TimeSpent
        {
            get
            {
                return timeSpent;
            }
            set
            {
                timeSpent = value;
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// An XElement that represents this AssignmentAttempt
        /// </summary>
        /// <returns>An XElement of this Assignment Attempt</returns>
        public XElement GetXMLNode()
        {
            var newAssignmentAttemptNode = new XElement("AssignmentAttempt",
                            new XElement("ID", ID),
                            new XElement("AssignmentID", AssignmentID),
                            new XElement("Date", Date),
                            new XElement("Grade", Grade),
                            new XElement("TimeSpent", TimeSpent)
                            );

            return newAssignmentAttemptNode;
        }

        #endregion


        #region Constructors

        /// <summary>
        ///  22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
        ///  initialization method that sets default values for all
        ///  Assignment Attempt properties
        /// </summary>
        private void init()
        {
            this.ID = string.Empty;
            this.Date = DateTime.MinValue;
            this.Grade = 0.0;
            this.TimeSpent = TimeSpan.Zero;
        }

         /// <summary>
         /// 
        ///  22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
        ///  Default Constructor
         /// </summary>
        public AssignmentAttempt()
        {
            init();

        }

         /// <summary>
        ///  22 March 2014
        ///  Jonathan Sanborn & Harvey Mercado
        ///  Parameterized Constructor
         /// </summary>
         /// <param name="id">A Unique ID to identify the assignment attempt</param>
         /// <param name="assignment">The assignment that was attempted</param>
         /// <param name="date">The Date and time the assignment was attempted</param>
         /// <param name="grade">The percent correct on this attempt as a value 0.0-1.0</param>
         /// <param name="timeSpent">The amount of time the user spent working on this assignment attempt</param>
        public AssignmentAttempt(string id, Assignment assignment, DateTime date, double grade, TimeSpan timeSpent)
        {
            init();

            this.ID = id;
            this.Assignment = assignment;
            this.Date = date;
            this.Grade = grade;
            this.TimeSpent = timeSpent;
        }

         /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
         /// 
         /// Creates a Assignment Attempt from the passed in XML node
         /// </summary>
         /// <param name="assign">The Assignment that was attempted</param>
         /// <param name="d">A assignment Attempt XElement</param>
        public AssignmentAttempt(Assignment assign, XElement d)
        {
            ID = d.Element("ID").Value;
            Date = DateTime.Parse(d.Element("Date").Value);
            Grade = Double.Parse(d.Element("Grade").Value);
            TimeSpent = System.Xml.XmlConvert.ToTimeSpan(d.Element("TimeSpent").Value);
            Assignment = assign;
        }

        #endregion


    }
}
