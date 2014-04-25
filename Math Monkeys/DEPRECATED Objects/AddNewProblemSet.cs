/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name:AddNewProblemSet 
 * 
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
    //Coder of this class - Mary Venegas
    public partial class AddNewProblemSet : Form
    {
        User _Student = new User();
        AssignmentSet Assg = new AssignmentSet();
        AssignmentHandlers AssgHandler = new AssignmentHandlers();
        ListOfReportHandler StudentRep = new ListOfReportHandler();

        //personalise label for the student we are currently working on. 
        public AddNewProblemSet(User student)
        {
            _Student = student;
            InitializeComponent();
            lblUserNameDisplay.Text = "Student Name: " + _Student.ScreenName;
        }

        private void AddNewProblemSet_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            //save new information if possible
            SaveSettings();
        }

        //Admin called savesetting when hitting the save button, Math Monkeys should check all entered fields are entered correctly, 
        //if entries are incorrect we handle the exeption 
        public void SaveSettings()
        {
            //when saving we open the student report file and save new information, but we have to check all field are filled
            if (txtAssignmentName.Text != "" && txtAttempts.Text != "" && txtGoal.Text != "" && txtProblemNumbers.Text != "" && txtRangeBottom.Text != "" && txtRangeTop.Text != "")
            {
                //pre-condition to saving:  attempts, goal problem number, ranges are all integers, 
                //bottom range is less than top range
                //Goal should not exceed more than the problems in the set
                try
                {
                    Assg.Attempts = int.Parse(txtAttempts.Text);
                    Assg.Goal = int.Parse(txtGoal.Text);
                    Assg.NumberofProblems = int.Parse(txtProblemNumbers.Text);
                    Assg.BottomRange = int.Parse(txtRangeBottom.Text);
                    Assg.TopRange = int.Parse(txtRangeTop.Text);
                    if (Assg.Attempts <= 0) throw new Exception("Attempt Can Not Be Less than Or Equal To Zero");
                    if (Assg.Goal < 0 || Assg.Goal > Assg.NumberofProblems) throw new Exception("Goal is less than zero or greater than number of problems");
                    if (Assg.NumberofProblems <= 0) throw new Exception("Number of problems should be at least 1");
                    if ((Assg.BottomRange > Assg.TopRange) || (Assg.BottomRange == Assg.TopRange)) throw new Exception("Choose different ranges, bottom range should be less than top range");

                    //if done succesfully we save the new assigment to assignment_list and new settings for student_report; 
                    Assg.AssignmentName = txtAssignmentName.Text;
                    AssgHandler.WriteAssignments(Assg);
                    StudentRep.WriteReport(_Student, Assg.AssignmentName, Assg.Goal);
                    this.Close();
                }
                catch (FormatException fEx)
                {
                    MessageBox.Show("Make suere all fields have appropiate value");
                }
                catch (Exception rangeEx)
                {
                    MessageBox.Show(rangeEx.Message);
                }
            }
        }

        private void txtAttempts_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
