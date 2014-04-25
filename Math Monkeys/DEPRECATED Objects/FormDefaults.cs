/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: FormDefaults
 * 
 * -has private properties for a set 
 * botton, top range, number of problems, goa, and attempts per problem. 
 * this class allows setting and getting this properties 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    //Coder of this class - Mary Venegas
    public class FormDefaults
    {
        //properties for default
        private int _rangeBottom;
        private int _rangeTop;
        private int _numberOfProblems;
        private int _goal;
        private int _attemptsPerProblem;

        //Default constructor    
        public FormDefaults()
        {
            _rangeBottom = 1;
            _rangeTop = 10;
            _numberOfProblems = 10;
            _goal = 100; //round up percent
            _attemptsPerProblem = 1;
        }
        public FormDefaults(int bottom, int top, int numberOfProblems, int goal, int attempt)
        {
            this._rangeBottom = bottom;
            this._rangeTop = top; //must be greater than bottom range
            this._numberOfProblems = numberOfProblems;
            this._goal = goal;
            this._attemptsPerProblem = attempt;
        }
       
        //setting specific parts
        public int RangeBottom
        {
            get
            {
                return _rangeBottom;
            }
            set 
            {
                _rangeBottom = value; 
            }
        }
        public int RangeTop 
        {
            get
            {
                return _rangeTop;
            }
            set
            {
                _rangeTop = value; 
            }
        }   // Allowed min: -99, max: 100
        public int NumberOfProblems 
        { 
            get
            {
                return _numberOfProblems;
            }
            set
            {
                _numberOfProblems = value; 
            }
            } // Allowed min: 1, max: 20
        public int Goal 
        {
            get
            {
                return _goal;
            }
            set
            {
                _goal = value;
            }
        } // Allowed min: 1, max: NumberOfProblems
        public int AttemptsPerProblem 
        {
            get
            {
                return _attemptsPerProblem;
            }
            set
            {
                _attemptsPerProblem = value;
            }
        } // Allowed min: 1, max 10 
    }
}
