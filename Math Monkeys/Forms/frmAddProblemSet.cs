using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Monkeys.Forms
{
    public partial class frmAddProblemSet : Form
    {

        private MMControl MMControl;


        #region Event Handlers

        public frmAddProblemSet(MMControl mmControl)
        {
            InitializeComponent();
            MMControl = mmControl;
            problemSetBindingSource.DataSource = MMControl.ProblemSetList;
        }

        private void frmAddProblemSet_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AttemptProblemSetCreate(sender))
            {
                CloseThisForm();
            }
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (AttemptProblemSetCreate(sender))
            {
                LoadDefaultValues();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseThisForm();
        }

        private void rdoAddOperation_CheckedChanged(object sender, EventArgs e)
        {
            AdditionSelected();
        }

        private void rdoSubOperation_CheckedChanged(object sender, EventArgs e)
        {
            SubtractionSelected();
        }

        private void rdoMultOperation_CheckedChanged(object sender, EventArgs e)
        {
            MultiplicationSelected();
        }

        private void rdoDivOperation_CheckedChanged(object sender, EventArgs e)
        {
            DivisionSelected();
        }

        #endregion




        #region GUI-Specific Methods

        #region IViewtoControl


        // Do everything necessary to set up the form
        internal bool InitializeForm()
        {
            LoadDefaultValues();

            // set the option to Addition by default
            cbxDivisionWholeNumberAnswers.Enabled = false;
            cbxSubtractionAllowNegativeAnswers.Enabled = false;


            rdoDivOperation.Checked = true;
            rdoAddOperation.Checked = true;
            return true;
        }
        #region InitializeForm() sub-Functions

        // Load Form Defaults
        private bool LoadDefaultValues() // currently only clears the text fields and inits the 
        {
            ClearTextFields(); //!!!!!!!!!!!!!!!!!!!!!!!
            ddlAttemptsPerProblem.SelectedIndex = 1; //!!!!!!!!!!!!Load from settings

            return true;
        }
        #endregion


        #endregion




        #region IPassInputToControl
        // Generally, these methods will be extremely tightly coupled to an interface 
        //  because this should be the only place that specific controls on forms should
        //  be referenced directly.
        //                                   They do not belong in a Control object.

        private bool ClearTextFields()
        {
            txtFirstOperandRangeMin.Text = string.Empty;
            txtFirstOperandRangeMax.Text = string.Empty;
            txtSecondOperandRangeMin.Text = string.Empty;
            txtSecondOperandRangeMax.Text = string.Empty;
            txtGoal.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNumberOfProblems.Text = string.Empty;

            return true;
            // the following should be REFACTORED into the control
        }
        #endregion


        #region Validation Methods
        // validiton methods remain local to the form 
        //  because they are tied directly to UI controls


        private bool ValidateFormData(object sender)
        {

            // Order matters for these conditionals because
            //   the first to fail is the last to be executed and so focus is set
            //   to that control
            return (validProblemSetName(txtName) &&
                validNumberOfProblems(txtNumberOfProblems) &&
                validGoal(txtGoal) &&
                validAttempts(ddlAttemptsPerProblem) &&
                validRange(txtFirstOperandRangeMin, txtFirstOperandRangeMax) &&
                validRange(txtSecondOperandRangeMin, txtSecondOperandRangeMax));
      
        }

        private bool validName(object sender)  //!!!!!!!!!!!!!!! Should become a Control Function because lots of forms could use this
        //   and because this ties directly to system-wide settings
        {
            bool isValid = false; // assume bad input until proven otherwise
            TextBox txtBox = sender as TextBox;

            // check for dangerous input first
            if (txtBox == null)
            {
                return false; // textbox cannot be empty
            }

            // then check for compliance with settings global to Math Monkeys
            if (txtBox.Text == null)
            {
                errorProvider.SetError(txtBox, "Please Enter A Value");
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else if (txtBox.Text.Length < Properties.Settings.Default.NameLengthMin)
            {
                errorProvider.SetError(txtBox, "Value is too short. Value must be at least "
                    + Properties.Settings.Default.NameLengthMin + " characters long.");
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else if (txtBox.Text.Length > Properties.Settings.Default.NameLengthMax)
            {
                errorProvider.SetError(txtBox, "Value is too Long. Value must be less than "
                    + Properties.Settings.Default.NameLengthMax + " characters long.");
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else
            {
                errorProvider.SetError(txtBox, string.Empty);

                isValid = true;
            }
            return isValid;

        }

        private bool validNumberOfProblems(object sender)
        {
            bool isValid = false; // assume bad input until proven otherwise
            int numProblems = -1;

            TextBox txtBox = (TextBox)sender;


            // check for dangerous input first
            if (txtBox.Text == null)
            {
                errorProvider.SetError(txtBox, "Please Enter A Value");
                txtBox.Focus(); txtBox.Text = string.Empty;
                return false; // textbox cannot be emtpy
            }
            else if (txtBox.Text.Length > 0)
            {
                try
                {
                    numProblems = int.Parse(txtBox.Text);
                }
                catch (Exception ex) // !!!!!!!!!!!!!!!!!!!!!!   more particular exception handling needed
                {
                    errorProvider.SetError(txtBox, "Please enter a numeric value");
                    txtBox.Focus(); txtBox.Text = string.Empty;
                    return false; // must enter a numeric value to verify that value
                }
            }


            // check for compliance with settings global to Math Monkeys
            if (numProblems < Properties.Settings.Default.NumberProblemsMin)
            {
                errorProvider.SetError(txtBox,
                    "Number of Problems must be greater than " + Properties.Settings.Default.NumberProblemsMin.ToString());
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else if (numProblems > Properties.Settings.Default.NumberProblemsMax)
            {
                errorProvider.SetError(txtBox,
                    "Number of Problems must be less than " + Properties.Settings.Default.NumberProblemsMax.ToString());
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else
            {
                errorProvider.SetError(txtBox, string.Empty);

                isValid = true;
            }
            return isValid;
        }

        private bool validGoal(object sender)
        {
            bool isValid = false; // assume bad input until proven otherwise
            TextBox txtBox = sender as TextBox;
            double goal = -1.0;


            // check for dangerous input first
            if (txtBox.Text == null)
            {
                errorProvider.SetError(txtBox, "Please Enter A Value from "
                    + Properties.Settings.Default.GoalMin.ToString() + "% to "
                    + Properties.Settings.Default.GoalMax.ToString() + "%");
                txtBox.Focus(); txtBox.Text = string.Empty;
                return false;
            }


            // attempt to parse a double
            if (txtBox.Text.Length > 0)
            {
                try
                {
                    goal = double.Parse(txtBox.Text);
                }
                catch (Exception e) // !!!!!!!!!!!!!!!!!!!! use more specific exception handling
                {
                    errorProvider.SetError(txtBox, "Please Enter A Value from "
                    + Properties.Settings.Default.GoalMin.ToString() + "% to "
                    + Properties.Settings.Default.GoalMax.ToString() + "%");
                    txtBox.Focus(); txtBox.Text = string.Empty;
                    return false;
                }
            }


            // then check for compliance with settings global to Math Monkeys
            if (goal < Properties.Settings.Default.GoalMin)
            {
                errorProvider.SetError(txtBox,
                    "Goal must be greater than " + Properties.Settings.Default.GoalMin.ToString() + "%");
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else if (goal > Properties.Settings.Default.GoalMax)
            {
                errorProvider.SetError(txtBox,
                    "Goal must be less than or equal to " + Properties.Settings.Default.GoalMax.ToString() + "%");
                txtBox.Focus(); txtBox.Text = string.Empty;
            }
            else
            {
                errorProvider.SetError(txtBox, string.Empty);

                isValid = true;
            }
            return isValid;
        }

        private bool validAttempts(object sender)
        {
            bool isValid = false; // assume bad input until proven otherwise

            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedIndex > -1)
            {
                int attempts = comboBox.SelectedIndex;
                if (attempts < 0)
                {
                    errorProvider.SetError(comboBox, "Please Select a Value");
                    comboBox.Focus(); comboBox.Text = string.Empty;
                    isValid = false;
                }
                else { isValid = true; }
            }
            return isValid;
        }

        private bool validRange(object sender)
        {
            bool isValid = false; // assume bad input until proven otherwise

            TextBox txtBox = sender as TextBox;

            // check for dangerous input first
            if (txtBox != null || txtBox.Text.Length < 1)
            {
                errorProvider.SetError(txtBox, "Please Select a Value");
                txtBox.Focus(); txtBox.Text = string.Empty;
                return false; // textbox must not be empty
            }

            // check that the range itself is valid
            if (txtBox == txtFirstOperandRangeMin)
                isValid = validRange(txtBox, txtFirstOperandRangeMax);
            else if (txtBox == txtFirstOperandRangeMax)
                isValid = validRange(txtFirstOperandRangeMin, txtBox);
            else if (txtBox == txtSecondOperandRangeMin)
                isValid = validRange(txtBox, txtSecondOperandRangeMax);
            else if (txtBox == txtSecondOperandRangeMax)
                isValid = validRange(txtSecondOperandRangeMin, txtBox);


            return isValid;
        }

        private bool validRange(object min, object max)
        {
            bool isValid = false; // assume bad input until proven otherwise

            TextBox minBox = min as TextBox;
            TextBox maxBox = max as TextBox;

            // check for dangerous input
            if (minBox == null || maxBox == null)
            {
                return false; // min and max must have an entry
                // no error provided so as to not be annoying
            }


            // display where inputs have not been entered yet
            if (minBox.Text.Length < 1)
            {
                errorProvider.SetError(minBox, "Please Select a Value");
                minBox.Focus(); minBox.Text = string.Empty;
                isValid = false;
            }
            else if (maxBox.Text.Length < 1)
            {
                errorProvider.SetError(maxBox, "Please Select a Value");
                maxBox.Focus(); maxBox.Text = string.Empty;
                isValid = false;
            }
            else  // try to parse numbers
            {

                int smallerNumber, largerNumber;
                try
                {
                    smallerNumber = int.Parse(minBox.Text);
                    largerNumber = int.Parse(maxBox.Text);
                    if (smallerNumber > largerNumber) // then check that min does not exceed max
                    {
                        errorProvider.SetError(minBox, "Must be less than or equal to Max Number");
                        minBox.Focus(); minBox.Text = string.Empty; //                  !!!!!!!!!!!!!!!!Won't focus on Maxbox if it is the problem
                        errorProvider.SetError(maxBox, "Must be greaer than or equal to Max Number");
                    }
                    else
                    {
                        errorProvider.SetError(minBox, string.Empty);
                        errorProvider.SetError(maxBox, string.Empty);
                        isValid = true;
                    }
                }
                catch (Exception e)
                {
                    errorProvider.SetError(minBox, "Value must be numeric");
                    minBox.Focus(); minBox.Text = string.Empty; //                      !!!!!!!!!!!!!!!!!Won't focus on Maxbox if it is the problem
                    errorProvider.SetError(maxBox, "Value must be numeric");
                }

            }

            return isValid;
        }

        private bool validProblemSetName(object sender)
        {
            TextBox txtBox = sender as TextBox;

            // check for dangerous input first
            if (txtBox == null)
            {
                return false; // name must not be 0 characters long
            }

            // check that name is unique
            int count = 0;
            count = MMControl.ProblemSetList.Where(w => w.Name == txtName.Text.Trim()).Count();// + " " + operation.ToString()).Count();
            if (count > 0)
            {
                errorProvider.SetError(txtBox, 
                                    "Problem set name must be unique. "
                                    + txtName.Text.Trim()
                                    //+ " ";
                                    //+ operation.ToString()
                                    + " already exists in the system.");
                txtBox.Focus(); txtBox.Text = string.Empty;
                return false; // name must be unique
            }


            // check that name conforms to system-wide settings
             return validName(txtBox);
        }

        #endregion







        private Operation GetOperation()
        {
            Operation selectedOp = Operation.None;

            if (rdoAddOperation.Checked)
                selectedOp = Operation.Addition;
            else if (rdoDivOperation.Checked)
                selectedOp = Operation.Division;
            else if (rdoMultOperation.Checked)
                selectedOp = Operation.Multiplication;
            else if (rdoSubOperation.Checked)
                selectedOp = Operation.Subtraction;

            return selectedOp;
        }


        #endregion


        #region Methods That Need To Become Methods in Appropriate Control Class

        // Addition Selected 
        internal void AdditionSelected()
        {
            cbxAdditionAllowNegative.Enabled = true;
            cbxSubtractionAllowNegativeAnswers.Enabled = false;
            cbxDivisionWholeNumberAnswers.Enabled = false;
            //cbxAdditionAllowNegative = Default.....
        }
        // Subtraction Selected 
        internal void SubtractionSelected()
        {
            cbxSubtractionAllowNegativeAnswers.Enabled = true;
            cbxAdditionAllowNegative.Enabled = false;
            cbxDivisionWholeNumberAnswers.Enabled = false;
            //cbxSubtractionAllowNegativeAnswers = Default.....
        }
        // Division Selected 
        internal void DivisionSelected()
        {
            cbxDivisionWholeNumberAnswers.Enabled = true;
            cbxAdditionAllowNegative.Enabled = false;
            cbxSubtractionAllowNegativeAnswers.Enabled = false;
            //cbxDivisionWholeNumberAnswers = Default.....
        }
        // Multiplication Selected 
        internal void MultiplicationSelected()
        {
            cbxDivisionWholeNumberAnswers.Enabled = false;
            cbxAdditionAllowNegative.Enabled = false;
            cbxSubtractionAllowNegativeAnswers.Enabled = false;
        }


        /// <summary>
        /// Creates a problem set useing the passed in values
        /// !!Assumes data has been validated!
        /// </summary>
        /// <param name="txtOperands">The textboxes with the operands ranges in them</param>
        /// <param name="Operation">The Operation for the problem set</param>
        /// <param name="numProblems">The number of problems in the problem set</param>
        /// <param name="numAttempts">The number of attempts before the problem is counted wrong</param>
        /// <param name="goal">The goal to pass the problem set value 0.0 - 1.0</param>
        /// <param name="isValid">A list of bools to add isValid tags too</param>
        /// <returns>The created problemSet or null</returns>
        private ProblemSet ConstructProblemSet()//TextBox[] txtOperands, Operation Operation, int numProblems, int numAttempts, Double goal, List<bool> isValid)
        {
            OperandsRange range1 = new OperandsRange();
            OperandsRange range2 = new OperandsRange();
            List<OperandsRange> operandsRange = new List<OperandsRange>();
            range1.rangeMin = int.Parse(txtFirstOperandRangeMin.Text);
            range1.rangeMax = int.Parse(txtFirstOperandRangeMax.Text);
            range2.rangeMin = int.Parse(txtSecondOperandRangeMin.Text);
            range2.rangeMax = int.Parse(txtSecondOperandRangeMax.Text);

            operandsRange.Add(range1);
            operandsRange.Add(range2);

            return new ProblemSet(Guid.NewGuid().ToString(),
                           txtName.Text,
                           GetOperation(),
                           operandsRange,
                           uint.Parse(txtNumberOfProblems.Text),
                           (uint)ddlAttemptsPerProblem.TabIndex,
                           double.Parse(txtGoal.Text),
                           cbxAdditionAllowNegative.Checked,
                           cbxSubtractionAllowNegativeAnswers.Checked,
                           cbxDivisionWholeNumberAnswers.Checked
                        );
        }



        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Loads the problem set defaults from the settings file
        /// </summary>
        private void loadProblemSetDefaults()
        {
            txtNumberOfProblems.Text = Properties.Settings.Default.DefaultNumberOfProblems;
            txtGoal.Text = Properties.Settings.Default.DefaultGoal;

            ddlAttemptsPerProblem.SelectedIndex = Properties.Settings.Default.DefaultNumberAttempts;

            cbxAdditionAllowNegative.Checked = Properties.Settings.Default.DefaultNegAnswers;
            cbxDivisionWholeNumberAnswers.Checked = Properties.Settings.Default.DefaultWholeNumbers;
            cbxSubtractionAllowNegativeAnswers.Checked = Properties.Settings.Default.DefaultNegNumbers;

            txtNumberOfProblems.Text = Properties.Settings.Default.DefaultNumberOfProblems;
            txtGoal.Text = Properties.Settings.Default.DefaultGoal;
        }

        private bool AttemptProblemSetCreate(object sender)
        {
            if (ValidateFormData(sender)) // front-end data validation
            {
                ProblemSet newProblemSet = ConstructProblemSet(); // object construction
                MMControl.AddProblemSet(newProblemSet); // result returned to Control object
                return true;
            }
            else
                return false;

        }


        private void CloseThisForm()
        {
            this.Close();
        }

        #endregion
    }
}
