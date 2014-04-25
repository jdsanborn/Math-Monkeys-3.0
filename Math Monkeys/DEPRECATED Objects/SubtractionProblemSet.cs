/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name:  SubtractionProblemSet
 * Functions: 
 * -SubtractionProblemSet() constructors does nothing 
 * -SubtractionProblemSet()constructor that accepts 5 integers to create a new subtraction set
 * -CorrectSoFar, gets the numbe of problems that are user has correct
 * -CurrentProblem returns a string of current problems
 * -CurrentAnswer returns the correct answer for the current problem
 * -GetNext(), calls generate problem and returns the new problem
 * -CheckAnswer returns a bool; true if answer matches the paramenter and increment _correctSoFar else returns false
 * -GenerateProblem() called by GetNext(), return a new set of random numbers and assign thems to the class properties 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{ // Coder of this class - Mary Venegas
    class SubtractionProblemSet : ProblemSetGenerator
    {
        //Properties for class
        //Minued-Subtrahend=Difference
        private int _minued;
        private int _subtrahend;
        private int _difference; //answer
        private int _correctSoFar = 0;

        public SubtractionProblemSet()
        {
            //nothing
        }
        //Constructor
        public SubtractionProblemSet(int bottomRange, int topRange, int problems, int goal, int attempts)
        {
            base._rangeBottom = bottomRange;
            base._rangeTop = topRange;
            base._numberOfProblems = problems;
            base._goal = goal;
            base._attemptsPerProblem = attempts;

        }

        // Additional requirement: RangeTop > RangeBottom at all times
        public int CorrectSoFar
        {
            get
            {
                return _correctSoFar;
            }
        } // initialize to 0
        public string CurrentProblem
        {
            get
            {
                string subSentence = _minued + "-" + _subtrahend;
                return subSentence;
            }
        } // the problem generated in string form
        public string CurrentAnswer
        {
            get
            {
                return _difference.ToString();
            }
        } // the answer to generated problem; string form

        // Methods
        public string GetNext()
        {
            GenerateProblem();
            string subSentence = _minued + " - " + _subtrahend;

            return subSentence;
        } // calls GenerateProblem(), returns the generated problem
        public bool CheckAnswer(string userAnswer)
        {
            if (userAnswer == _difference.ToString())
            {
                _correctSoFar++;
                return true;
            }
            else
            {
                return false;
            }
        } // used to check an End-users answer

        public override void GenerateProblem()
        {
            Random rnd = new Random();
            _minued = rnd.Next(base._rangeBottom, base._rangeTop);
            _subtrahend = rnd.Next(base._rangeBottom, base._rangeTop);
            _difference = _minued - _subtrahend;
        } // called by GetNext; take care of generation and storage

    }
}