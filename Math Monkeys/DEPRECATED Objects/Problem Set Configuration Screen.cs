/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Problem_Setting_Screen_add
 * Allows the user to assign an existen set to selected student 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Monkeys
{
    // Coder of this class - Mary Venegas
    public partial class Problem_Setting_Screen_add : Form
    {
        protected List<AssignmentSet> handledAssigList = new List<AssignmentSet>(); //CONTAINS LIST OF ASSIGNMENTS
        protected AssignmentHandlers _handler = new AssignmentHandlers(); //ASSIGNMENT HANDLER TO MAKE PROCESS EASIER
        protected AssignmentSet _mathSetting = new AssignmentSet(); //ASSIGNMENTSET OBJECT TO ACCESS AN SPECIFIED OBJECT MEMBERS
        protected ListOfReportHandler saveSetting = new ListOfReportHandler(); //REPORT HANDLER TO SAVE NEW ASSIGMENT TO STUDENT RECORDS
        protected User _student = new User(); //USER WE WILL BE WORKING ON
        protected Report _stdReport = new Report();//REPORT OBJECT TO BE SENT TO TE REPORT HANDLER. 

        public Problem_Setting_Screen_add(User student)
        {
            _student = student;
            InitializeComponent();
            //display student
            lblUserNameDisplay.Text = "Student: " + student.ScreenName;

            //read from assignment list
            handledAssigList = _handler.ReadFile();
            PopulateDdList();

        }

        private void btnConf_Setting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet");
        }
        //if user decides do to defaul we fill out the content with this data. 
        private void btnResetToDefault_Click(object sender, EventArgs e)
        {
            FormDefaults def = new FormDefaults();
            ddlProblemSelect.Text = "Default";
            txtRangeStart.Text = def.RangeBottom.ToString();
            txtRangeEnd.Text = def.RangeTop.ToString();
            txtProblemNumbers.Text = def.NumberOfProblems.ToString();
            txtGoal.Text = def.Goal.ToString();
            txtAttempts.Text = def.AttemptsPerProblem.ToString();

        }
        //When hitting cancel we want to close
        private void btnCancelConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //call AssignmentSetting() to do the saving process
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            AssignmentSetting();
        }

        //Dislpay the assiment properties choosen by the teacher  and save it to selected student report. 
        public void AssignmentSetting()
        {
            for (int y = 0; y < handledAssigList.Count; y++)
            {
                //find the matching assignment Display to teacher and save it to the student report 
                if (handledAssigList[y].AssignmentName == ddlProblemSelect.SelectedItem.ToString())
                {
                    txtRangeStart.Text = handledAssigList[y].BottomRange.ToString();
                    txtRangeEnd.Text = handledAssigList[y].TopRange.ToString();
                    txtAttempts.Text = handledAssigList[y].Attempts.ToString();
                    txtGoal.Text = handledAssigList[y].Goal.ToString();
                    txtProblemNumbers.Text = handledAssigList[y].NumberofProblems.ToString();

                    saveSetting.WriteReport(_student, handledAssigList[y].AssignmentName, handledAssigList[y].Goal);
                }

            }
        }
        //Populate the drop Down list with the existing users. 
        public void PopulateDdList()
        {
            for (int i = 0; i < handledAssigList.Count; i++)
            {
                try
                {
                    ddlProblemSelect.Items.Insert(i, handledAssigList[i].AssignmentName);
                }
                catch (ArgumentOutOfRangeException x)
                {

                }
            }
        }

        private void Problem_Setting_Screen_add_Load(object sender, EventArgs e)
        {
            ddlProblemSelect.SelectedIndex = 0;
        }
    }
}
