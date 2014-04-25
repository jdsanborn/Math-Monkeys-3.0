/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Jungle
 * Purpose defines a name for the jungle and a Math Operation sign, for now the addition(+) and subtraction(-) sign
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    public class Jungle
    {
        private string _Name;
        private char _MathOperation;

       // private int _BottomRange;
        //private int _TopRange;

        public Jungle()
        {

        }
        public string JungleName
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public char MathOperation
        {
            get
            {
                return _MathOperation;
            }
            set
            {
                _MathOperation = value;
            }
        }



    }
}
