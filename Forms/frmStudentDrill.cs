/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Math_Problem_Screen
 * 
 * CSUSM CS 441 Spring 2014
 * The Code Monkeys
 * Project: Math Monkeys
 * Class Name: frmStudentDrill.cs
 * File Name: frmStudentDrill
 * UI Design: Arun Gopinath
 * 
 * 2 April 2014
 * Jonathan Sanborn
 * Made changes to support new class structure
 * 
 * 3 April 2014
 * Jonathan Sanborn
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated comments
 * Updated Flowerbox
 * 
 *  ********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Math_Monkeys.Forms;
using System.Collections.ObjectModel;

namespace Math_Monkeys
{

    // Coder of this - Mary Venegas
    public partial class frmStudentDrill : Form
    {
       
        private MMControl MMControl;
      
        /*
         * Time to ask users some Math Questions
         * 
         * */


        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Constructor
        /// </summary>
        /// <param name="mmControl">Controller Object</param>
        public frmStudentDrill(MMControl mmControl)
        {
            
            InitializeComponent();

            MMControl = mmControl;
           
            lblUsername.Text = MMControl.CurrentStudent.GetFullName;
            Assignment assign = MMControl.CurrentStudent.Assignments.Where(w => !w.IsCompleted).First();
            MMControl.AssignmentSession = new AssignmentSession(MMControl, ref assign);
            MMControl.AssignmentSession.StartSession();

            lblCurrentProblem.Text = MMControl.AssignmentSession.ProblemNumber.ToString();
            lblTotalProblems.Text = MMControl.AssignmentSession.TotalProblems.ToString();

           MMControl.AssignmentSession.Correct += new AssignmentSession.ProblemGradedEventHandler(AssignmentSession_Correct);
           MMControl.AssignmentSession.Incorrect += new AssignmentSession.ProblemGradedEventHandler(AssignmentSession_Incorrect);
           MMControl.AssignmentSession.IncorrectAttemptsRemaining += new AssignmentSession.ProblemGradedEventHandler(AssignmentSession_IncorrectAttemptsRemaining);

            DisplayProblem();

        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Responds to the OnCorrect Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignmentSession_Correct(object sender, EventArgs e)
        {
            DisplayCorrect();
            //System.Threading.Thread.Sleep(3000);
            DisplayProblem();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Responds to the OnIncorrect Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignmentSession_Incorrect(object sender, EventArgs e)
        {
            DisplayAnswer();
            //System.Threading.Thread.Sleep(3000);
            DisplayProblem();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Responds to the OnIncorrectAttemptsRemainging Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignmentSession_IncorrectAttemptsRemaining(object sender, EventArgs e)
        {
            DisplayIncorrect();
           // System.Threading.Thread.Sleep(3000);
            DisplayProblem();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Displays the current problem on the form
        /// </summary>
        private void DisplayProblem()
        {
            lblCurrentProblem.Text = MMControl.AssignmentSession.ProblemNumber.ToString();
            lblOperator.ImageIndex = (int) MMControl.AssignmentSession.CurrentProblem.Operation;
            lblOperand1.Text = MMControl.AssignmentSession.CurrentProblem.Operand1.Value.ToString(Properties.Settings.Default.ProblemOperandFormatString);
            lblOperand2.Text = MMControl.AssignmentSession.CurrentProblem.Operand2.Value.ToString(Properties.Settings.Default.ProblemOperandFormatString);
            txtAnswer.Text = string.Empty;
            txtAnswer.Focus();
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Displays "Correct" in the feedback label
        /// </summary>
        private void DisplayCorrect()
        {
            lblFeedback.Text = "Correct";

        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Displays "Incorrect Try Again" in the feedback label
        /// </summary>
        private void DisplayIncorrect()
        {
            lblFeedback.Text = "Incorrect Try Again";
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Displays the Correct Answer in the feedback Label
        /// </summary>
        private void DisplayAnswer()
        {
            lblFeedback.Text = "The Correct Answer is: " + MMControl.AssignmentSession.CurrentProblem.Answer().Value.ToString("####0.##");
        }

        /// <summary>
        /// This method take the keypresses in the txtInsertAnswer textbox and only allows [.-0-9] into the textbox.
        /// Created: 13 March 2014
        /// Author: Jonathan Sanborn
        /// </summary>
        /// 
        /// <param name="sender">the object that raised this event</param>
        /// <param name="e">the KeyPressEventArgs of the text box</param>
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            MMControl.DoubleNumberOnly(sender, e);
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// If there is text in the answer textbox submit the answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterAnswer_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length > 0)
            { SubmitAnswer(sender, e); }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Grades the answer and displays the next problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitAnswer(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length > 0 && MMControl.AssignmentSession.GetNextProblem(double.Parse(txtAnswer.Text)) != null)
            {
                DisplayProblem();
            }
            else
            {
                MMControl.AssignmentSession.EndSession();
                MMControl.DisplayResults(sender,  e);
            }
        }


        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Logs the current user out
        /// </summary>
        /// <param name="sender">the object that raised this event</param>
        /// <param name="e">the event arguments</param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logging out now will grade this assignment. \n\nLogout?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MMControl.AssignmentSession.EndSession();
                MMControl.UserLogout(sender, e);
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Responds to an enter key press in the answer text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if ( txtAnswer.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                SubmitAnswer(sender, e);
            }
        }


        #region DEPRACATED code

        ////Process of updating student report if necessary and closing this form. 
        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    //before closing we need to save the changes thre stuff needs to be save: assgmentComplete, date complete, and grade 
        //    //double calcGrade;
        //    //if (attempted == true)
        //    //{
        //    //    if (jungle == 1)
        //    //    {
        //    //        calcGrade = ((Convert.ToDouble(add1.CorrectSoFar) / Convert.ToDouble(add1.NumberOfProblems)) * 100.00);
        //    //        //System.Diagnostics.Debug.Write("Grade Calculation:::+> " + add1.CorrectSoFar + "div" + add1.NumberOfProblems +"Gives"+calcGrade);
        //    //        saveSetting.UpdateReport(_student, calcGrade, thisJungle, _stdReport);
        //    //    }
        //    //    else if (jungle == 2)
        //    //    {
        //    //        calcGrade = (sub1.CorrectSoFar / sub1.NumberOfProblems) * 100;
        //    //        //System.Diagnostics.Debug.Write("Grade Calculation:::+> " + sub1.CorrectSoFar + "div" + sub1.NumberOfProblems +"Gives"+ calcGrade);
        //    //        //System.Diagnostics.Debug.Write("Grade is handler " + calcGrade);
        //    //        saveSetting.UpdateReport(_student, calcGrade, thisJungle, _stdReport);
        //    //    }
        //    //    attempted = false;
        //    //}
        //    this.Close();
        //}

        //when inputing an answer we wan to make sure user entered number 

        //private int preceed=0;
        //private List<Report> ReportList = new List<Report>();
        //Jungle Selection removed at customer request
        //private int jungle;//helps determine which type of math operation we are following
        //private string[] number; //holds numbers will use a delimeter for '+' or '-', 
        //SubtractionProblemSet sub1 ;
        //AdditionProblemSet add1;
        //Jungle Selection removed at customer request
        //Jungle thisJungle= new Jungle();
        //List<AssignmentSet> handledAssigList = new List<AssignmentSet>();
        //AssignmentHandlers _handler= new AssignmentHandlers(); 
        //AssignmentSet _mathSetting=new AssignmentSet();
        //ListOfReportHandler saveSetting = new ListOfReportHandler(); 
        //User _student = new User();
        //Report _stdReport = new Report();
        //private bool attempted = false;


        //Jungle Selection removed at customer request
        //thisJungle = theJungle;
        //_student = student;
        //this.WindowState = FormWindowState.Maximized;
        //this.ControlBox = false;
        //handledAssigList= _handler.ReadFile();
        //Font databound and moved to settings
        //lblFeedbackAnswer.Font = new Font("Georgia", 40);
        //ProblemSetting(theJungle, reportList);
        //txtAnswer.Select();

        //public void GetUserReport(User student)
        //{
        //    //Report handler "ReadFile" could be implemented by taking the user as a parameter
        //    _fileNameReport = (student.ScreenName + student.ID + ".xml").Replace(" ", "");
        //    ReportList = StudentReport.ReadFile(_fileNameReport);
        //}
        //private void btnEnterAnswer_Click(object sender, EventArgs e)
        //{
        //    //attempted = true;
        //    //bool isNumber = false;
        //    //string theAnswer;
        //    //if (txtInsertAnswer.Text != "")
        //    //{
        //    //    theAnswer = txtInsertAnswer.Text.Replace(" ", "");

        //    //   double.Parse(theAnswer);


        //    //    if ((txtInsertAnswer.Text != "" && isNumber == true))
        //    //    {

        //    //        if (jungle == 1) { AddData(theAnswer); }
        //    //        if (jungle == 2) { SubDatas(theAnswer); }
        //    //    }
        //    //}

        //}

        ////Determines if the student has any problem sets to work on 
        ////public void ProblemSetting(Jungle theJungle, List<Report> reportList)
        ////{
        ////    bool foundFlag = false;
        ////    if (reportList.Count == 1 && reportList[0].AssignmentName == "Default")
        ////    {
        ////        for (int i = 0; i < handledAssigList.Count; i++)
        ////        {
        ////            if (handledAssigList[i].AssignmentName == "Default")
        ////            {
        ////                _stdReport = reportList[0];
        ////                MathSettings(thisJungle.MathOperation, handledAssigList[i]);
        ////                GetProblem();
        ////            }
        ////        }
        ////    }
        ////    else if (reportList.Count != 0)
        ////    {
        ////        for (int x = 0; x < reportList.Count; x++)
        ////        {
        ////            if (reportList[x].Completed == false)
        ////            {
        ////                for (int y = 0; y < handledAssigList.Count; y++)
        ////                {
        ////                    if (reportList[x].AssignmentName == handledAssigList[y].AssignmentName)
        ////                    {
        ////                        //System.Diagnostics.Debug.Write("New Math Problem setting are for for Bob");
        ////                        _stdReport = reportList[x];
        ////                        _mathSetting = handledAssigList[y];
        ////                        foundFlag = true;
        ////                        MathSettings(thisJungle.MathOperation, handledAssigList[y]);
        ////                        GetProblem();
        ////                    }

        ////                }
        ////            }
        ////        }
        ////    }
        ////    if (foundFlag == false)
        ////    {
        ////        MessageBox.Show("No Assigments are Set Now");
        ////        this.Close();
        ////    }

        ////}

        ////MathSetting funciton sets necessary information to get the math problem that the student determined to work on
        ////public void MathSettings(char MathOperation, AssignmentSet set)
        ////{
        ////    if (MathOperation == '-')
        ////    {
        ////        jungle = 2;
        ////        lblOperatorSymbol.Text = "-";
        ////        sub1 = new SubtractionProblemSet(set.BottomRange, set.TopRange, set.NumberofProblems, set.Goal, set.Attempts);

        ////    }
        ////    else if (MathOperation == '+')
        ////    {
        ////        jungle = 1;
        ////        lblOperatorSymbol.Text = "+";
        ////        add1 = new AdditionProblemSet(set.BottomRange, set.TopRange, set.NumberofProblems, set.Goal, set.Attempts);

        ////    }
        ////}
        ////AddData checks answer for additon
        ////private void AddData(string answer)
        ////{
        ////    if ((add1.CheckAnswer(answer) == true))
        ////    {
        ////        CorrectAnswer();
        ////    }
        ////    else
        ////    {
        ////        IncorrectAnswer();
        ////    }
        ////}
        //////SubDatas checks anwer for subtraction
        ////private void SubDatas(string answer)
        ////{
        ////    if ((sub1.CheckAnswer(answer) == true))
        ////    {
        ////        CorrectAnswer();
        ////    }
        ////    else
        ////    {
        ////        IncorrectAnswer();
        ////    }

        ////}
        ////continuing function are student feedback on their answer
        ////private void CorrectAnswer()
        ////{
        ////    lblFeedbackAnswer.Text = "Correct";
        ////    lblFeedbackAnswer.Font = new Font("Georgia", 35);
        ////    preceed += 1;
        ////    GetProblem();
        ////    txtInsertAnswer.Select();
        ////    txtInsertAnswer.Focus();
        ////}

        ////private void IncorrectAnswer()
        ////{
        ////    lblFeedbackAnswer.Text = "Good Try";
        ////    lblFeedbackAnswer.Font = new Font("Georgia", 35);
        ////    preceed += 1;
        ////    GetProblem();
        ////    txtInsertAnswer.Select();
        ////    txtInsertAnswer.Focus();
        ////}

        //// GetProble(): will go to get the next problem from the subtraction or additon class depending on user's choice using the GetNext() function
        ////private void GetProblem()
        ////{
        ////    if (jungle == 2 && preceed < sub1.NumberOfProblems)
        ////    {
        ////        txtInsertAnswer.Text = "";
        ////        sub1.GetNext();
        ////        number = sub1.CurrentProblem.Split('-');
        ////        lblNumberA.Text = number[0];
        ////        lblNumberB.Text = number[1];
        ////    }
        ////    else if (jungle == 1 && preceed < add1.NumberOfProblems)
        ////    {
        ////        txtInsertAnswer.Text = "";
        ////        add1.GetNext();
        ////        number = add1.CurrentProblem.Split('+');
        ////        lblNumberA.Text = number[0];
        ////        lblNumberB.Text = number[1];
        ////    }
        ////    if (jungle == 1)
        ////    {
        ////        if (preceed == add1.NumberOfProblems)
        ////        {
        ////            txtInsertAnswer.Enabled = false;
        ////            btnEnterAnswer.Enabled = false;
        ////        }
        ////    }
        ////    else if (jungle == 2)
        ////    {
        ////        if (preceed == sub1.NumberOfProblems)
        ////        {
        ////            txtInsertAnswer.Enabled = false;
        ////            btnEnterAnswer.Enabled = false;
        ////        }
        ////    }
        ////}

        ////private void txtInsertAnswer_TextChanged_1(object sender, EventArgs e)
        ////{
        ////    this.AcceptButton = btnEnterAnswer;
        ////}
        #endregion
    }
}
