/* March 15, 2014 Jonathan Sanborn & Harvey Mercado
 * Filename: ProblemSet.cs
 * Classname: ProblemSet
 * Description: Class to represent individual problem sets that can be assigned to 0, 1, or many students
 * CSUSM CS 441
 * 
 * 
 * 22 March 2014
 * Jonathan Sanborn & Harvey Mercado
 * Converted operation to an array
 * 
 * 
 * 30 March 2014
 * Jonathan Sanborn
 * Added XML to decouple from the file handler
 * 
 * 2 April 2014
 * Jonathan Sanborn
 * Added bool options
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated Comments
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
    /// Jonathan Sanborn & Harvey Mercado
    /// 
    /// Represents a ProblemSet which is a collection of values
    /// that identify ranges and other relvent values for Problems
    /// </summary>
    [XmlType("ProblemSet")]
    public class ProblemSet: IXMLnode
    {


        #region Member Variables
       
        private string id;
        private string name;
        private Operation operation;
        private List<OperandsRange> operandsRange;
        private uint numberOfProblems;
        private uint numberOfAttempts;
        private double goal;
        private bool allowNegativeProblem;
        private bool allowNegativeResult;
        private bool wholeNumbersOnly;

        #endregion


        #region Properties

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// A Unique ID that identifies the problem set
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
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// A Unique Name for the Problem Set
        /// </summary>
        [XmlElement("Name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    name = string.Empty;
                }
                else
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// The Operation that is in this Problem Set
        /// </summary>
        [XmlElement("Operation")]
        public Operation Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
            }
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// A collection of Operands ranges for this ProblemSet
        /// </summary>
        [XmlElement("Operands")]
        public List<OperandsRange> OperandsRange
        {
            get
            {
                return operandsRange;
            }
            set
            {
                operandsRange = value;
            }
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// The Number of Problems that are to be in this ProblemSet per Session
        /// </summary>
        [XmlElement("NumberOfProblems")]
        public uint NumberOfProblems
        {
            get
            {
                return numberOfProblems;
            }
            set
            {
                numberOfProblems = value;
            }
        }

        /// <summary>
        ///  22 March 2014 Jonathan Sanborn & Harvey Mercado
        /// The percent of problems that must be correct to pass this assignment
        /// values 0.0-1.0.
        /// </summary>
        [XmlElement("Goal")]
        public double Goal
        {
            get
            {
                return goal;
            }
            set
            {
                if (value < 0.0)
                {
                    goal = 0.0;
                }
                else if (value > 1.0)
                {
                    goal = 1.0;
                }
                else
                {
                    goal = value;
                }
            }
        }

        /// <summary>
        /// 2 April 2014 Jonathan Sanborn
        /// 
        /// The number of attempt to get the correct answer before
        /// the problem is counted wrong.
        /// </summary>
        [XmlElement("NumberOfAttempts")]
        public uint NumberOfAttempts
        {
            get { return numberOfAttempts; }
            set
            {
                if (value > Properties.Settings.Default.AttemptsMax)
                {
                    numberOfAttempts = Properties.Settings.Default.AttemptsMax;
                }
                else
                {
                    numberOfAttempts = value;
                }
            }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// Should the problem allow negative value operands
        /// currently only applies to addition
        /// </summary>
        [XmlElement("AllowNegativeProblem")]
        public bool AllowNegativeProblem
        {
            set {allowNegativeProblem = value;}
            get { return allowNegativeProblem; }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// Should the answer to the problems be allowed to be negative.
        /// currently only applies to subtraction
        /// </summary>
        [XmlElement("AllowNegativeResult")]
        public bool AllowNegativeResult
        {
            set { allowNegativeResult = value; }
            get { return allowNegativeResult; }
        }

        /// <summary>
        /// 2 April 2014
        /// Jonathan Sanborn
        /// 
        /// Should the answer to the problms be allowed to be a fraction.
        /// currently only applies to division
        /// </summary>
        [XmlElement("WholeNumbersOnly")]
        public bool WholeNumbersOnly
        {
            set { wholeNumbersOnly = value; }
            get { return wholeNumbersOnly; }
        }

        #endregion


        #region Methods

        /// <summary>
        /// 30 March 2014
        /// Jonathan Sanborn
        /// 
        /// Gets the Problem Sets properties as XML
        /// 
        /// 2 April 2014
        /// Jonathan Sanborn
        /// added bools
        /// </summary>
        /// <returns>An XElement of the Problem Sets properties</returns>
        public XElement GetXMLNode()
        {
            XElement operands = new XElement("Operands");

            foreach (OperandsRange range in OperandsRange)
            {
                operands.Add(new XElement("OperandsRange",
                                            new XElement("RangeMin", range.rangeMin),
                                            new XElement("RangeMax", range.rangeMax)
                                        )
                            );
            }

            var newProblemSetNode = new XElement("ProblemSet",
                 new XElement("ID", ID),
                 new XElement("Name", Name),
                 new XElement("Operation", Operation),
                 operands,
                 new XElement("NumberOfProblems", NumberOfProblems),
                 new XElement("NumberOfAttempts", NumberOfAttempts),
                 new XElement("Goal", Goal),
                 new XElement("AllowNegativeProblem", AllowNegativeProblem),
                 new XElement("AllowNegativeResult", AllowNegativeResult),
                 new XElement("WholeNumbersOnly", WholeNumbersOnly)
                 );
            return newProblemSetNode;
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// Initalzation Method for this class
        /// </summary>
        private void init()
        {
            ID = string.Empty;
            Name = string.Empty;
            Operation = Operation.None;
            OperandsRange = new List<Math_Monkeys.OperandsRange>();
            NumberOfProblems = 0;
            NumberOfAttempts = 0;
            Goal = 0.0;
            AllowNegativeProblem = false;
            AllowNegativeResult = false;
            WholeNumbersOnly = true;
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// Default construtor
        /// 
        /// </summary>
        public ProblemSet()
        {
            init();            
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// A paremeterized constructor
        /// </summary>
        /// <param name="id">A unique id for the problem set</param>
        /// <param name="name">A unique name for the problem set</param>
        /// <param name="operation">the operation that is represented by the problem set</param>
        /// <param name="operandsRange">A collection of ranges for each operand in the set</param>
        /// <param name="numberOfProblems">the number of problems to generate</param>
        /// <param name="numberOfAttempts">the number of attempts to allow until the problem is counted wrong. A value of zero indicates "Until Correct" </param>
        /// <param name="goal">The goal as a precentage from 0.0 - 1.0 of the problems needed to pass the set</param>
        /// <param name="negativeProblem">Allow negtives in addition operands. Defaults to false</param>
        /// <param name="negativeResult">Allow negatives in subtraction answers. Defaults to false</param>
        /// <param name="wholeNumbers">Allow only whole number answers to division problems. Defaults to true</param>
        public ProblemSet(string id, 
                            string name, 
                            Operation operation, 
                            List<OperandsRange> operandsRange, 
                            uint numberOfProblems, 
                            uint numberOfAttempts, 
                            double goal, 
                            bool negativeProblem = false, 
                            bool negativeResult = false, 
                            bool wholeNumbers = true)

        {
            init();
            this.ID = id;
            this.Name = name;
            this.Operation = operation;
            this.OperandsRange = operandsRange;
            this.NumberOfProblems = numberOfProblems;
            this.NumberOfAttempts = numberOfAttempts;
            this.Goal = goal;
            this.AllowNegativeProblem = negativeProblem;
            this.AllowNegativeResult = negativeResult;
            this.WholeNumbersOnly = wholeNumbers;
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// XML constructor
        /// </summary>
        /// <param name="d">An XElement contaning all necessary fields to created a Problem set</param>
        public ProblemSet(XElement d)
        {
            this.ID = d.Element("ID").Value;
            this.Name = d.Element("Name").Value;
            this.Operation = (Operation)Enum.Parse(typeof(Operation), d.Element("Operation").Value);
            this.OperandsRange = (List<OperandsRange>)(from elem in d.Element("Operands").Descendants("OperandsRange")
                                                   select new OperandsRange(int.Parse( elem.Element("RangeMin").Value),
                                                   int.Parse( elem.Element("RangeMax").Value))).ToList();
            this.NumberOfProblems = uint.Parse(d.Element("NumberOfProblems").Value);
            this.NumberOfAttempts = uint.Parse(d.Element("NumberOfAttempts").Value);
            this.Goal = double.Parse(d.Element("Goal").Value);
            this.AllowNegativeProblem = bool.Parse(d.Element("AllowNegativeProblem").Value);
            this.AllowNegativeResult = bool.Parse(d.Element("AllowNegativeResult").Value);
            this.WholeNumbersOnly = bool.Parse(d.Element("WholeNumbersOnly").Value);
                     
        }

        #endregion


    }
}
