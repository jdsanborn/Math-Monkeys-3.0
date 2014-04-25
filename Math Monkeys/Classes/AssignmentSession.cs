/****************************************************************
 * Author: Jonathan Sanborn
 * Date: 2 April 2014
 * Filename: AssignmentSession.cs
 * Classname: AssignmentSession
 * Summary: Class to encapsulate a running Assignment for a Student
 * 
 * Modified
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated comments
 * 
 * 17 April 2014
 * Jeff Bunce
 * namespace changed for consistency
 *****************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    /// <summary>
    /// 2 April 2014
    /// Jonathan Sanborn
    /// 
    /// Class to encapsulate a running Assignment for a Student
    /// </summary>
    class AssignmentSession
    {


        #region Events

        public delegate void ProblemGradedEventHandler(object sender, EventArgs e);
        public event ProblemGradedEventHandler Correct;
        public event ProblemGradedEventHandler Incorrect;
        public event ProblemGradedEventHandler IncorrectAttemptsRemaining;

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        ///Raised the problem is correct
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnCorrect(EventArgs e)
        {
            if (Correct != null)
            { Correct(this, e); }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Raised on problem is Incorrect with no attempts remaining
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnIncorrect(EventArgs e)
        {
            if (Incorrect != null)
            { Incorrect(this, e); }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Raised on problem is Incorrect with attempts remaining
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnIncorrectAttemptsRemaining(EventArgs e)
        {
            if (IncorrectAttemptsRemaining != null)
            { IncorrectAttemptsRemaining(this, e); }
        }

        #endregion


        #region Member Variables

        private int problemsCorrect;
        private int problemsIncorrect;
        private int problemNumber;
        private int attemptsRemaining;
        private bool sessionRunning;

        private MMControl MMControl;
        private Assignment assignment;
        private AssignmentAttempt assignmentAttempt;
        private ProblemSetGenerator problemSetGenerator;
        private List<Problem> problemList;

        private Problem currentProblem;

        #endregion


        #region Properties

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Current Problem for this Assignment Session
        /// </summary>
        public Problem CurrentProblem
        {
            get { return currentProblem; }
        }


        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Total number of problems in the Assignment for this session
        /// </summary>
        public int TotalProblems
        {
            get { return (int) Assignment.ProblemSet.NumberOfProblems; }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// The number of problems correct
        /// </summary>
        public int ProblemsCorrect 
        { 
            get
            {return problemsCorrect;}
            
            set
            {
                if (value < 0)
                { problemsCorrect = 0; }
                else
                { problemsCorrect = value; }

            } 
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// The number of Incorrect
        /// </summary>
        public int ProblemsIncorrect
        {
            get
            { return problemsIncorrect; }

            set
            {
                if (value < 0)
                { problemsIncorrect = 0; }
                else
                { problemsIncorrect = value; }

            }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// The number problems attempted
        /// </summary>
        public int ProblemNumber
        {
            get
            {return problemNumber;}

            set
            {
                if (problemNumber < 0)
                { problemNumber = 0; }
                else
                { problemNumber = value; }
            }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Current Assignment
        /// </summary>
        public Assignment Assignment
        {
            get { return assignment; }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// The Current Assignment Attempted
        /// </summary>
        public AssignmentAttempt AssignmentAttempted
        {
            get { return assignmentAttempt; }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// </summary>
        private void init()
        {
            ProblemNumber = 0;
            ProblemsCorrect = 0;
            ProblemsIncorrect = 0;
            attemptsRemaining = 0;
            sessionRunning = false;
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Constructor for an Assignment Session
        /// </summary>
        /// <param name="mmControl">The Control Object</param>
        /// <param name="assign">The Assignment for this session</param>
        public AssignmentSession(MMControl mmControl, ref Assignment assign)
        {
            init();
            MMControl = mmControl;
            assignment = assign;
            problemSetGenerator = new ProblemSetGenerator(assignment.ProblemSet);
            assignmentAttempt = new AssignmentAttempt();
            problemList = problemSetGenerator.GetProblemList;

            attemptsRemaining = (int)Assignment.ProblemSet.NumberOfAttempts;
            currentProblem = problemList.First();
            problemList.Remove(CurrentProblem);
        }

        #endregion


        #region Methods

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Get the next problem in the assignment session
        /// </summary>
        /// <param name="answer">The Answer to the current problem</param>
        /// <returns>The next math problem based on the Assignments rules</returns>
        public Problem GetNextProblem(double answer)
        {
            if (!sessionRunning)
            {StartSession();}
            
            if (CurrentProblem.isCorrect(answer))
            {
                problemsCorrect++;
                attemptsRemaining = (int) Assignment.ProblemSet.NumberOfAttempts;

                OnCorrect(EventArgs.Empty);

                if (problemList.Count <= 0)
                {
                    currentProblem = null;
                }
                else
                {
                    ProblemNumber++;
                    currentProblem = problemList.First();
                    problemList.Remove(CurrentProblem);
                }
            }
            else if (attemptsRemaining <= 0 && Assignment.ProblemSet.NumberOfAttempts > 0)
            {
                problemsIncorrect++;
                attemptsRemaining = (int)Assignment.ProblemSet.NumberOfAttempts;

                OnIncorrect(EventArgs.Empty);

                if (problemList.Count <= 0)
                {
                    currentProblem = null;
                }
                else
                {
                    ProblemNumber++;
                    currentProblem = problemList.First();
                    problemList.Remove(CurrentProblem);
                }

            }
            else
            {
                OnIncorrectAttemptsRemaining(EventArgs.Empty);
            }
       
            attemptsRemaining--;
            return CurrentProblem;
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Start the current Assignment Session
        /// </summary>
        public void StartSession()
        {
            sessionRunning = true;
            ProblemNumber = 1;
            assignmentAttempt.ID = Guid.NewGuid().ToString();
            assignmentAttempt.Date = DateTime.Now;
            assignmentAttempt.Assignment = Assignment;
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// End the Current Assignment Session
        /// </summary>
        public void EndSession()
        {
            if (sessionRunning)
            {
                assignmentAttempt.TimeSpent = DateTime.Now - assignmentAttempt.Date;
                GradeSession();

                Assignment.AssignmentAttempts.Add(assignmentAttempt);

                MMControl.FileHandler.SaveNewAssignmentAttempt(assignmentAttempt);
                sessionRunning = false;
            }
        }

        /// <summary>
        /// 9 April 2014
        /// Jonathan Sanborn
        /// 
        /// Grade the current session
        /// </summary>
        private void GradeSession()
        {
            if (Assignment.ProblemSet.NumberOfProblems > 0)
            { assignmentAttempt.Grade = (double) problemsCorrect / (double) Assignment.ProblemSet.NumberOfProblems; }

            if (assignmentAttempt.Grade >= Assignment.ProblemSet.Goal)
            {
                Assignment.IsCompleted = true;
                Assignment.DateCompleted = DateTime.Now;
                
                MMControl.FileHandler.UpdateAssignment(Assignment);
            }

        }

        #endregion


    }
}
