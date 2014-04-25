/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: AssignmentSet
 * assignment set contrans, a name, bottom range, toprange, number of problems, goal, and attemps 
 * usually created by admin from the admin form 
 * 
 * Modified
 * March 15, 2014 Name: Harvey Mercado & Jonathan Sanborn
 * Depreciated 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
   
    public class AssignmentSet
    {
        private string _Name;
        private int _BottomRange;
        private int _TopRange;
        private int _NumberofProblems;
        private int _Goal;
        private int _Attempts;

        public AssignmentSet()
        {
        }
        public string AssignmentName
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
        public int NumberofProblems
        {
            get
            {
                return _NumberofProblems;
            }
            set
            {
                _NumberofProblems = value;
            }
        }
        public int Goal
        {
        get
        {
        return _Goal;
        }
            set
            {
                _Goal = value;
            }
    }
        public int Attempts
        {
            get
            {
                return _Attempts;
            }
            set
            {
                _Attempts = value;
            }
        }
        public int BottomRange
        {
            get
            {
                return _BottomRange;
            }
            set
            {
                _BottomRange = value;
            }
        }
       public int TopRange
        {
            get
            {
                return _TopRange;
            }
            set
            {
                _TopRange = value;
            }
        }

    }
}
