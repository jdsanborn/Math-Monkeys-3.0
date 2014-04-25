/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Problem_Select_Screen
 * Constains the drop down list of accessible jungle for student
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
    // Coder of this Mary Venegas
    public partial class Problem_Select_Screen : Form
    {
        protected List<Jungle> jungleList = new List<Jungle>();
        ListOfReportHandler StudentReport = new ListOfReportHandler();
        protected List<Report> ReportList = new List<Report>();
        User _student = new User();
        private string _fileNameReport;

        public Problem_Select_Screen(User student)
        {
            _student = student;
            string today;
            today = DateTime.Now.ToString(Properties.Settings.Default.dateFormat); 

            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.ControlBox = false;
            GetUserReport(student);
            PopulateJungleList();

                lblLastLoginDate.Text = "Last Login: " + student.LastLoginDate.ToString();
                if (lblLastLoginDate.Text == "Last Login: ") lblLastLoginDate.Text = today; 

        }

        //Button start lesson is invoked then we start a math problem is there exist one. 
        private void btnStartLesson_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < jungleList.Count; i++)
            {
                if (ddljungleNames.SelectedItem.ToString() == jungleList[i].JungleName)
                {
                    //try
                    //{
                   //     Math_Problem_Screen nextMathscreen = new Math_Problem_Screen(jungleList[i], ReportList, _student);
                   //     nextMathscreen.ShowDialog();
                        GetUserReport(_student);
                    //}
                    //catch (ObjectDisposedException ObjDisEx)
                    //{

                    //}
                }
            }
        }

        //Greet the Student 
        public string WelcomeLabel
        {
            get { return lblWelcomStudent.Text; }
            set { lblWelcomStudent.Text = value; }
        }

        //Populate the Jungle List with accesible jungle
        public void PopulateJungleList()
        {
            //ListOfJunglesHandler JungleHandler = new ListOfJunglesHandler();
            ddljungleNames.Items.Clear();
            //jungleList.Clear();
            //jungleList = JungleHandler.ReadFile();

            if (ReportList.Count == 1)
            {
                if (ReportList[0].Completed == false)
                {
                    try
                    {
                        ddljungleNames.Items.Insert(0, ReportList[0].JungleName);
                    }
                    catch (ArgumentOutOfRangeException x)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("No Assigments are Set Now");
                    //this.Close();
                }
            }
            else
            {
                for (int i = 0; i < jungleList.Count; i++)
                {
                    try
                    {
                        ddljungleNames.Items.Insert(i, jungleList[i].JungleName);
                    }
                    catch (ArgumentOutOfRangeException x)
                    {

                    }
                }
            }

        }
        //read in report to ReportList 
        public void GetUserReport(User student)
        {
            //Report handler "ReadFile" could be implemented by taking the user as a parameter
            _fileNameReport = (student.ScreenName + student.ID + ".xml").Replace(" ", "");
            ReportList = StudentReport.ReadFile(_fileNameReport);
        }

        private void Problem_Select_Screen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
