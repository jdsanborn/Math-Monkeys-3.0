/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Report
 *      member: _assignmentName,string; _jungleName,string; _wasAssigmentCompleted,bool; _assignmentGoal,int;
 *      _assignmentGrade,double; _dateAssigned, DateTime;_dateAttemptedDateTime, DateTime.
 * Functions: 
 *     Getters && Setters
 *          One for each member
 * */

/* Modified: February 22, 2014 -by Mary
 *          March 1, 2014, made _dateAttempted a nullable date and also its setter and getter
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    public class Report
    {
       // private int _studentID;
        private string _assignmentName;
        private string _jungleName;
        private bool _wasAssigmentCompleted;
        private int _assignmentGoal;
        private double _assignmentGrade;
        private DateTime _dateAssigned;
        private DateTime? _dateAttempted;

        public Report()
        {   
        }
        //setting and getting Assignment Name
        public string AssignmentName 
        { 
            get { 
                return _assignmentName; 
            }
            set
            {
                _assignmentName = value;
            }
        }
        public string JungleName
        {
            get
            {
                return _jungleName;
            }
            set
            {
                _jungleName = value;
            }
        }

        //setting and getting Completed statues
        public bool Completed 
        { 
            get 
            { 
                return _wasAssigmentCompleted; 
            }
            set
            {
                _wasAssigmentCompleted = value; 
            }
        }

        //getting and setting assignment Goal
        public int AssignmentGoal 
        { 
            get 
            { 
                return _assignmentGoal; 
            }
            set
            {
                _assignmentGoal = value;
            }
        }

        //setting and getting assignment grade
        public double AssignmentGrade 
        { 
            get 
            { 
                return _assignmentGrade; 
            }
            set
            {
                _assignmentGrade = value; 
            }
        }

        public DateTime DateAssigned
        {
            get
            {
                return _dateAssigned;
            }
            set
            {
                _dateAssigned = value; 
            }
        }
        //setting and getting the day attempted the problem
        public DateTime? DateAttempted 
        { 
            get 
            { 
                return _dateAttempted; 
            }
            set
            {
                _dateAttempted = value; 
            }
        }

    }
}
