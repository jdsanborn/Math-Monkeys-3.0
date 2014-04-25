/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Admin_Control
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;

namespace Math_Monkeys
{

    // Coders of this class - Mary Venegas + Jeff Cribben
    public partial class Admin_Control : Form
    {
        private string AdminName;
        private List<User> EndUserList = new List<User>();


        public Admin_Control(User Admin)
        {
            AdminName = Admin.GetFullName;
            InitializeComponent();
            lblWelcomAdmin.Text = "Welcome " + AdminName;
            this.WindowState = FormWindowState.Maximized;

            MyCheckBox cb = new MyCheckBox();
            this.Controls.Add(cb);

            //populate dropdownList
            updateDdlist();
            lblLastAdminLogin.Text = "Last Login: " + Admin.LastLoginDate.ToString();
        }

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1Login. 
        }

        private void btnChangeProblem_Click(object sender, EventArgs e)
        {
            // we add a new problem set to the selected student for them  
            for (int i = 0; i < EndUserList.Count; i++)
            {
                try
                {
                    if (ddlAdminSelects.SelectedItem.ToString() == EndUserList[i].ScreenName)
                    {
                        if (EndUserList[i].UserType == UserType.Student)
                        {
                            Problem_Setting_Screen_add confgProblems = new Problem_Setting_Screen_add(EndUserList[i]);
                            confgProblems.ShowDialog();

                        }
                    }
                }
                catch (NullReferenceException x)
                {
                    //do nothing
                }
            }
        }

        private void btnAssignNew_Click(object sender, EventArgs e)
        {
            //assigns new problem set and writes it into the assigment xml
            for (int i = 0; i < EndUserList.Count; i++)
            {
                try
                {
                    if (ddlAdminSelects.SelectedItem.ToString() == EndUserList[i].ScreenName)
                    {
                        if (EndUserList[i].UserType == UserType.Student)
                        {
                            AddNewProblemSet NewSet = new AddNewProblemSet(EndUserList[i]);
                            NewSet.ShowDialog();

                        }
                    }
                }
                catch (NullReferenceException x)
                {
                    //do nothig
                }
            }
        }
        //when remove button is pressed we would like to remove selected student therefore the Remove Student form is shown
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            Form3Remove RemoveStudent = new Form3Remove();
            RemoveStudent.ShowDialog();
            updateDdlist();
        }
        //when create new student is button is pressed the form NewUserForm (form) is shown. 
        private void btnCreateNewStudent_Click(object sender, EventArgs e)
        {
            //send an object user this will be useful to name the file
            NewUserForm AddNewStudent = new NewUserForm();
            AddNewStudent.ShowDialog();
            updateDdlist();
        }
        //process to determine which student was selected and then called the viewReport of a selected student. 
        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            //Dislay the selected student report in Grid
            for (int i = 0; i < EndUserList.Count; i++)
            {
                try
                {
                    if (EndUserList[i].ScreenName == ddlAdminSelects.SelectedItem.ToString())
                    {

                        if (EndUserList[i].UserType == UserType.Student)
                        {
                            ViewReport(EndUserList[i]);
                        }
                    }
                }
                catch (NullReferenceException x)
                {
                    //return; 
                }
            }
        }
        private void dtgAdministrator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //ViewReport reads into xml file and display the report for selected student 
        public void ViewReport(User student)
        {
            try
            {
                //dtgAdministrator.Rows.Clear();
                dtgAdministrator.Columns.Clear();
                string fileName = (student.ScreenName + student.ID.ToString() + ".xml").Replace(" ", "");
                try
                {
                    XmlDataDocument xmldata = new XmlDataDocument();
                    xmldata.DataSet.ReadXml(fileName);
                    dtgAdministrator.DataSource = xmldata.DataSet;
                    dtgAdministrator.DataMember = "Report";

                }
                catch
                {
                    MessageBox.Show("Error Opening file");
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error displaying");
            }

        }

        //populate the drop down list of user of type EndUser
        public void updateDdlist()
        {
            ddlAdminSelects.Items.Clear();
            EndUserList.Clear();

            ListOfUsersXMLHandler userHandler = new ListOfUsersXMLHandler();
            string filename = "ListOfUsers.xml"; // FILENAME OF LIST OF USERS XML
            EndUserList = userHandler.ReadFile(filename);
            //reload the drop down list with student names
            for (int i = 0; i < EndUserList.Count; i++)
            {
                try
                {
                    ddlAdminSelects.Items.Insert(i, EndUserList[i + 1].ScreenName);
                }
                catch (ArgumentOutOfRangeException x)
                {
                    //do nothing if no user exits
                }
            }

        }
        //set focus when loading
        private void Admin_Control_Load(object sender, EventArgs e)
        {
            ddlAdminSelects.Select();
            ddlAdminSelects.Focus();
        }
    }
}
