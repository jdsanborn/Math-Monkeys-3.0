/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: AdditionProblemSet
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{

    // Coder of this class - Mary Venegas
    class AdditionProblemSet : ProblemSetGenerator
    {

        //Properties for class
        //Minued-Subtrahend=Difference
        private int _addend1;
        private int _addend2;
        private int _sum; //answer
        private int _correctSoFar = 0;

        //Empty contructor: used to set up a new addition problemset
        public AdditionProblemSet()
        {
            //nothing
        }
        //Constructor that has necessary parameters.
        public AdditionProblemSet(int bottomRange, int topRange, int problems, int goal, int attempts)
        {
            base._rangeBottom = bottomRange;
            base._rangeTop = topRange;
            base._numberOfProblems = problems;
            base._goal = goal;
            base._attemptsPerProblem = attempts;
        }

        //return the number that are correct
        public int CorrectSoFar
        {
            get
            {
                return _correctSoFar;
            }

        } // initialize at the top to 0

        //return a string with the currect problems
        public string CurrentProblem
        {
            get
            {
                string addSentence = _addend1 + "+" + _addend2;
                return addSentence;
            }
        } // the problem generated in string form

        //returns answer as a string
        public string CurrentAnswer
        {
            get
            {
                return _sum.ToString();
            }
        } // the answer to generated problem; string form

        // Methods
        public string GetNext()
        {
            GenerateProblem();
            string addSentence = _addend1 + " + " + _addend2;

            return addSentence;
        } // calls GenerateProblem(), returns the generated problem

        public bool CheckAnswer(string userAnswer)
        {
            if (userAnswer == _sum.ToString())
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
            _addend1 = rnd.Next(base._rangeBottom, base._rangeTop);
            _addend2 = rnd.Next(base._rangeBottom, base._rangeTop);
            _sum = _addend1 + _addend2;
        } // called by GetNext; take care of generation and storage


    }
}
