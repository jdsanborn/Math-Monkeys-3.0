/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * File Name: ProblemSetGenerator.cs
 * Class Name: ProblemSetGenerator
 * Summary: Generates math Problems based on the values of the passed ProblemSet 
 *  
 * Change Log
 * 
 * 22 March 2014
 * Jonathan Sanborn & Harvey Mercado
 * 
 * 2 April 2014
 * Jonathan Sanborn
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated Comments
 * Updated Flowerbox
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    //Coder of this class - Mary Venegas
    public class ProblemSetGenerator
    {
        const int NUM_TRIES = 4;
        const int NUM_OPERANDS = 2;


        #region Member Variables

        private ProblemSet problemSet;
        private List<Problem> problemList;
        private Random rand;

        #endregion


        #region Properties

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Gets the current List of Problems
        /// </summary>
        public List<Problem> GetProblemList
        {
            get { return problemList; }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Initialization function for Problem set Generator
        /// </summary>
        private void init()
        {
            rand = new Random();
            problemList = new List<Problem>();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Problem Set Generator constructor.
        /// </summary>
        /// <param name="problemSet">The problemSet to generate the problems from</param>
        public ProblemSetGenerator(ProblemSet problemSet)
        {
            init();

            this.problemSet = problemSet;
            GenerateProblems();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Will try to return a non zero denomitor within the passed in range
        /// If after NUM_TRIES a non zero value is not generated a value of one is returned
        /// </summary>
        /// <param name="opRange">The operand range that the value should be in.</param>
        /// <returns>A non zero value in the range or 1</returns>
        private int nonZeroDenominator(OperandsRange opRange)
        {
            int count = 0;
            int number = 0;

            while (number == 0 && count < NUM_TRIES)
            {
                number= rand.Next(opRange.rangeMin, opRange.rangeMax);
                count++;
               
            }
            
            if (count == NUM_TRIES)
            { number = 1; }

            return number;
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// attempts to generate a value in the range that will result in a non negative
        /// answer to the passed in operand. If after NUM_TRIES a non negative result is
        /// not obtained then the minmum vaule of the operands range is returned.
        /// </summary>
        /// <param name="oprand1">The first operand in the subtraction</param>
        /// <param name="opRange">The range for the second operand</param>
        /// <returns>A operand that will have a non negative result or the min value of the Operands range</returns>
        private int nonNegativeResult(int oprand1, OperandsRange opRange)
        {
            int count = 0;
            int number = 0;

            do
            {
                number = rand.Next(opRange.rangeMin, opRange.rangeMax);
                count++;
            } while (oprand1 - number < 0 && count < NUM_TRIES);
            
            if (count == NUM_TRIES)
            { number = opRange.rangeMin; }

            return number;
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Generates a value in operands range that will result in a whole number answer
        /// If after NUM_TRIES attempts a valid denomanator is not generated the value
        /// of 1 is returned in the denomantor
        /// </summary>
        /// <param name="numerator">The first operand in the division</param>
        /// <param name="denomanator">The Second operand in the division</param>
        /// <param name="opRange">The denomantors operands range</param>
        private void WholeNumberResult(ref int numerator, ref int denomanator, OperandsRange opRange)
        {
            int count = 0;

            while (numerator % denomanator > 0 && count < NUM_TRIES)
            {
                denomanator = rand.Next(opRange.rangeMin, opRange.rangeMax);
                denomanator = nonZeroDenominator(opRange);
            }

            if (count == NUM_TRIES)
            {
                denomanator = 1;
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Generates Problems based on the current ProblemSet
        /// </summary>
        /// <returns>The Problems generated from the ProblemSet</returns>
       public List<Problem> GenerateProblems()
        {

            if (problemSet.OperandsRange.Count == NUM_OPERANDS)
            {
                int[] number = new int[NUM_OPERANDS];

                for (int i = 0; i < problemSet.NumberOfProblems; i++)
                {

                    for (int j = 0; j < NUM_OPERANDS; j++)
                    {
                        number[j] = rand.Next(problemSet.OperandsRange[j].rangeMin, problemSet.OperandsRange[j].rangeMax);

                        if (problemSet.Operation == Operation.Addition && !problemSet.AllowNegativeProblem)
                        {
                            int count = 0;
                            while (number[j] < 0 && count < NUM_TRIES)
                            {
                                number[j] = rand.Next(problemSet.OperandsRange[j].rangeMin, problemSet.OperandsRange[j].rangeMax);
                                count++;
                                if (count == NUM_TRIES)
                                { number[j] = problemSet.OperandsRange[j].rangeMax; }
                            }
                        }

                        if (j > 0 && problemSet.Operation == Operation.Subtraction && !problemSet.AllowNegativeResult)
                        {
                            if (number[j - 1] - number[j] < 0)
                            {
                                number[j] = nonNegativeResult(number[j - 1], problemSet.OperandsRange[j]);
                            }
                        }

                        if (j > 0 && problemSet.Operation == Operation.Division && number[j] == 0)
                        {
                            number[j] = nonZeroDenominator(problemSet.OperandsRange[j]);
                        }

                        if (j > 0 && problemSet.Operation == Operation.Division && problemSet.WholeNumbersOnly && number[j-1] % number[j] > 0)
                        {
                            WholeNumberResult(ref number[j-1], ref number[j], problemSet.OperandsRange[j]);
                        }

                    }   

                    Problem p = null;
                    for (int k = 1; k < NUM_OPERANDS; k++)
                    {
                        if (p != null)
                        {
                            p = new Problem(problemSet.Operation, p, number[k]);
                        }
                        else
                        {
                            p = new Problem(problemSet.Operation, number[0], number[k]);
                        }
                        problemList.Add(p);
                    }

                }
            }

            return problemList;
        }

        #endregion


        #region DEPRECATED Code

        //Private Properties from problemSetGenerator interface
        //protected int _rangeBottom;
        //protected int _rangeTop;
        //protected int _numberOfProblems;
        //protected int _goal;
        //protected int _attemptsPerProblem;

        //// Fields definition
        //public int RangeBottom
        //{
        //    get
        //    {
        //        return _rangeBottom;
        //    }
        //    set
        //    {
        //        _rangeBottom = value;
        //    }
        //} // Allowed min: -100, max: 99
        //public int RangeTop
        //{
        //    get
        //    {
        //        return _rangeTop;
        //    }
        //    set
        //    {
        //        _rangeTop = value;
        //    }
        //}   // Allowed min: -99, max: 100
        //public int NumberOfProblems
        //{
        //    get
        //    {
        //        return _numberOfProblems;
        //    }
        //    set
        //    {
        //        _numberOfProblems = value;
        //       /* if (_numberOfProblems > 1 && _numberOfProblems < 21)
        //        {
        //            //ok
        //        }
        //        else
        //        {
        //            _numberOfProblems = 10;
        //            //setting it to default 
        //        }*/
        //    }
        //} // Allowed min: 1, max: 20
        //public int Goal
        //{
        //    get
        //    {
        //        return _goal;
        //    }
        //    set
        //    {
        //        _goal = value;
        //    }
        //} // Allowed min: 1, max: NumberOfProblems
        //public int AttemptsPerProblem
        //{
        //    get
        //    {
        //        return _attemptsPerProblem;
        //    }
        //    set
        //    {
        //        _attemptsPerProblem = value;
        //    }
        //} // Allowed min: 1, max 10

    
        // Additional requirement: RangeTop > RangeBottom at all times
    
        //public abstract void GenerateProblem();// called by GetNext; take care of generation and storage
#endregion


    }
}
