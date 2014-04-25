/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: ListOfReportHandler
 * //creates a report xml file for given studen using student name and id
 * formated as 
 * -<Reports>
        -<Report>

            <AssignmentName>Default</AssignmentName>

            <JungleName>The Addition Jungle</JungleName>

            <AssignmentComplete>true</AssignmentComplete>

            <DateAssg>03/02/2014</DateAssg>

            <DateComplete>03/02/2014</DateComplete>

            <Goal>100</Goal>

            <Grade>100</Grade>

        </Report>
 * -</Reports>
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Math_Monkeys
{
    //Programmer of this class - Mary Venegas
    public class ListOfReportHandler 
    {

        
        public List<Report> ListOfReports = new List<Report>();

        XDocument ListOfRepDoc;
        //an appropiate name for the file we will be using 
        private string _fileName;
        //NumberofReports available
        private int RepNumber = 0;
        private XDocument xmlDocument;
        private string fileName;
        private bool fileIsOpen = false;
        private bool fileIsValid;
        
        public string FileName
        {
            get
            {
                return FileName;
            }
            set
            {
                FileName = value;
            }
        }
       

      
       
        public bool OpenFile(string fileName)
        {
            
            if ((fileIsValid) == true)
            {
                try
                {
                    xmlDocument = XDocument.Load(fileName);
                    return true;
                }
                catch (IOException e)
                {
                    System.Diagnostics.Debug.Write("Error Opening File");
                    return false;
                }
            }
            return false;
        }
        public ListOfReportHandler() //Constructor
        {
                xmlDocument = new XDocument();
            fileName = "Empty";
            fileIsOpen = false;
            fileIsValid = false;

            //do nothing 
        }
        //When the program start ther will be not xml file existen therefore we create one with a default administrator
        public void WriteReport(User student, string AssName, int Goal)
        {
            string today;
            today = DateTime.Now.ToString(Properties.Settings.Default.dateFormat);
            DateTime? dt = null;
            _fileName = (student.ScreenName + student.ID.ToString() + ".xml").Replace(" ", "");
            if (File.Exists(_fileName) == true)
            {
                if (fileIsOpen = OpenFile(_fileName))
                {
                    //make sure that count should be zero        
                    //as the first time we create a program we make a admin a default user
                    var newReportNode = new XElement("Report",
                                   new XElement("AssignmentName", AssName),
                                   new XElement("JungleName", ""),
                                   new XElement("AssignmentComplete", false),
                                   new XElement("DateAssg", today),
                                   new XElement("DateComplete", dt),
                                   new XElement("Goal", Goal),
                                   new XElement("Grade", 0)
                                   );
                    xmlDocument.Element("Reports").Add(newReportNode);
                    xmlDocument.Save(_fileName);
                    RepNumber++;
                }
            }
            //need an alternative
        }
        //when addmin creates new student program need to create an xml report for the student with default values; 
        public void CreateNewXmlReport(string studentName, uint StdId, string JungleName)
        {
            string today;
            today = DateTime.Now.ToString(Properties.Settings.Default.dateFormat);
            //string unknownDate= "0/"
            DateTime? dt = null;
            _fileName = (studentName.ToString() + StdId.ToString() + ".xml").Replace(" ", "");

            ListOfRepDoc = new XDocument(
                               new XElement("Reports",
                                   new XElement("Report",
                                       new XElement("AssignmentName", "Default"),
                                       new XElement("JungleName", JungleName),
                                       new XElement("AssignmentComplete", false),
                                       new XElement("DateAssg", today),
                                       new XElement("DateComplete", dt),
                                       new XElement("Goal", 100),
                                       new XElement("Grade", 0)
                                       )));
            ListOfRepDoc.Save(_fileName);
            RepNumber++;
        }


        //Update file will be called after a student have completed a fiel certain fields wil be updated. 
        public void UpdateReport(User student, double grade, Report report) //  Jungle jungle,  //Adds just a student for now with  uniqueID=count and some userName
        {
            //System.Diagnostics.Debug.Write("Grade is handler " + grade);
            string today;
            today = DateTime.Now.ToString(Properties.Settings.Default.dateFormat);
            _fileName = (student.ScreenName + student.ID + ".xml").Replace(" ", "");

            if (File.Exists(_fileName) == true) // Checks if file exists
            {
                System.Diagnostics.Debug.Write("File Name " + report.AssignmentName);
                xmlDocument = XDocument.Load(_fileName);
                var query = from item in xmlDocument.Descendants("Report")
                            where (item.Element("AssignmentName").Value == report.AssignmentName &&
                            item.Element("AssignmentComplete").Value == "false")
                            select item;
                foreach (XElement itemE in query)
                {
                    //System.Diagnostics.Debug.Write("An item was selected");
                    //itemE.SetElementValue("JungleName", jungle.JungleName);
                    itemE.SetElementValue("AssignmentComplete", true);
                    itemE.SetElementValue("DateComplete", today);
                    itemE.SetElementValue("Grade", Math.Round(grade, 2));
                }
                xmlDocument.Save(_fileName);
            }
            else
            {
                System.Diagnostics.Debug.Write("File Is not Existent for Use: " + student.ScreenName + student.ID);
            }

        }

        //this will be generally be used by the administrator to view the student report
        //read file will allow to generate a list with report for a some student 
        public List<Report> ReadFile(string fileName)
        {
            //making sure we are reading into an empty list
            ListOfReports.Clear();
            _fileName = fileName;

            if (File.Exists(_fileName) == true)
            {
                try
                {
                    xmlDocument = XDocument.Load(_fileName);
                    ListOfReports = xmlDocument.Descendants("Report").Select(d =>

                         new Report
                         {
                             AssignmentName = d.Element("AssignmentName").Value,
                             JungleName = d.Element("JungleName").Value,
                             Completed = ToBoolean(d.Element("AssignmentComplete").Value),
                             DateAssigned = DateTime.ParseExact(d.Element("DateAssg").Value, Properties.Settings.Default.dateFormat, null),
                             DateAttempted = isDateSet(d.Element("DateComplete").Value),
                             AssignmentGoal = int.Parse(d.Element("Goal").Value),
                             AssignmentGrade = double.Parse(d.Element("Grade").Value)
                         }).ToList();

                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    System.Diagnostics.Debug.Write("Out of range for read");
                }
                // System.Diagnostics.Debug.Write("ListOfReports: " +ListOfReports);
            }
            return ListOfReports;
        }
        //created a function that will help dealing with nullable date 
        public DateTime? isDateSet(string tryDate)
        {
            try
            {
                return DateTime.ParseExact(tryDate, Properties.Settings.Default.dateFormat, null);

            }
            catch (FormatException e)
            {
                return null;
            }
        }
        //converting string value to boolean
        public static bool ToBoolean(string value)
        {
            if (value == "true") return true;
            else if (value == "false") return false;
            return false;
        }


    }

}
