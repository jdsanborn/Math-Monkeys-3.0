/********************************************
 * CSUSM CS 441 Spring 2014
 * The Code Monkeys
 * Project: Math Monkeys
 * Class Name: Problem
 * File Name: Problem.cs
 * Authors: Jonathan Sanborn & Harvey Mercado
 * Date: 22 March 2014
 * Summary: Class is represent a single math problem
 * 
 * 
 * Modified
 * 2 April 2014
 * Jonathan Sanborn
 * Restructured class for more flexibility
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Reduced the ALLOWANCE
 * Edited Comments
 * ********************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
 
    /// <summary>
    /// Jonathan Sanborn & Harvey Mercado
    /// 
    /// A Math problem and the answer to this problem
    /// </summary>
    public class Problem
    {

        //the error allowance between two "equal" doubles
        private const double ALLOWANCE = 0.01;


        #region Member Variables

        private Operation operation;
        private double?[] operand;

        #endregion


        #region Properties

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// </summary>
        public Operation Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// </summary>
        public double? Operand1
        {
            get { return operand[0]; }
            set { operand[0] = value; }
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// </summary>
        public double? Operand2
        {
            get { return operand[1]; }
            set { operand[1] = value; }
        }

        #endregion


        #region Methods

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// The answer to the provided equation
        /// </summary>
        /// <returns>The Answer to this problem</returns>
        public double? Answer()
        {
            double? answer = 0.0;

            switch (this.Operation)
            {
                case Operation.Addition:
                    answer = Operand1 + Operand2;
                    break;
                case Operation.Subtraction:
                    answer = Operand1 - Operand2;
                    break;
                case Operation.Multiplication:
                    answer = Operand1 * Operand2;
                    break;
                case Operation.Division:
                    if (Operand2 == 0)
                    { answer = null; }
                    else
                    { answer = Operand1 / Operand2; }
                    break;
                default:
                    answer = null;
                    break;
            }
            return answer;
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Returns a if the passed in answer is the same as this problem answer.
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public bool isCorrect(double answer)
        {
            if (Answer() == null)
            { return false; }

            double answerDiffrance = answer - Answer().Value;

            if (Math.Abs(answerDiffrance) < ALLOWANCE)
            { return true; }
            else
            { return false; }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// initializes the problem variables
        /// </summary>
        private void init()
        {
            Operation = Operation.None;
            operand = new double?[2];
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Default constructor
        /// </summary>
        public Problem()
        {
            init();
        }

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// parameterized constructor
        /// 
        /// 2 April 2014
        /// changed integers to doubles
        /// 
        /// </summary>
        /// <param name="operation">The operation this problem preforms</param>
        /// <param name="operand1">the first operand in the equation</param>
        /// <param name="operand2">the second operand in the equation</param>
        public Problem(Operation operation, double? operand1, double? operand2)
        {
            init();
            this.Operation = operation;
            this.Operand1 = operand1;
            this.Operand2 = operand2;
        }

        /// <summary>
        /// 2 April 204
        /// Jonathan Sanborn
        /// 
        /// Constructor for chaining problems together
        /// </summary>
        /// <param name="operation">The operation this problem preforms</param>
        /// <param name="problem">The problem that contains the result that will act as the first operand of this equation</param>
        /// <param name="operand2">the second operand in the equation</param>
        public Problem(Operation operation, Problem problem, int operand2)
        {
            init();
            this.Operation = operation;
            this.Operand1 = problem.Answer();
            this.Operand2 = operand2;
        }

        #endregion


    }
}
