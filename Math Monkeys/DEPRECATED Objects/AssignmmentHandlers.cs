/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: AssignmentHandlers
 * stores existent assignments in that the Math Monkeys contains usually added by admin 
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
    /*
     * To Clarify: AssignmetnHandler creates a list of problem Names for the teacher assign
     * Names should be reusable and should only store ranges, problem numbers, attempts, and goal
     * */
    // Coder of this class - Mary Venegas
    public class AssignmentHandlers
    {
        //get a list of only admins
        public List<AssignmentSet> ListOfAssignment = new List<AssignmentSet>();
        //create the Default value
        FormDefaults defaultValue = new FormDefaults();
        XDocument ListOfAssgDoc;
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
        
        public AssignmentHandlers() //Constructor
        {
             xmlDocument = new XDocument();
                fileName = "Empty";
                fileIsOpen = false;
                fileIsValid = false;
            _fileName = "AssignmentCollection.xml";
            CreateNewAssg();
            //do nothing 
        }
        //When the program start ther will be not xml file existen therefore we create one with a default administrator
        public void WriteAssignments(AssignmentSet newAssgnment)
        {
            if (File.Exists(_fileName) == true)
            {
                if (fileIsOpen = OpenFile(_fileName))
                {
                    //make sure that count should be zero        
                    //as the first time we create a program we make a admin a default user
                    var newAssignmentNode = new XElement("Assignment",
                                   new XElement("AssignmentName", newAssgnment.AssignmentName),
                        //new XElement("JungleName", ""),
                                   new XElement("BottomRange", newAssgnment.BottomRange),
                                   new XElement("TopRange", newAssgnment.TopRange),
                                   new XElement("Problems", newAssgnment.NumberofProblems),
                                   new XElement("Goal", newAssgnment.Goal),
                                   new XElement("Attempts", newAssgnment.Attempts)
                                   );
                    xmlDocument.Element("Assignments").Add(newAssignmentNode);
                    xmlDocument.Save(_fileName);
                    RepNumber++;
                }
            }
            else
            {
                CreateNewAssg();
            }
        }
        //program automatically calls this file if it does not exist it creates a new one
        public void CreateNewAssg()
        {
            if (File.Exists(_fileName) == false)
            {
                ListOfAssgDoc = new XDocument(
                               new XElement("Assignments",
                                   new XElement("Assignment",
                                       new XElement("AssignmentName", "Default"),
                    //new XElement("JungleName",
                                       new XElement("BottomRange", defaultValue.RangeBottom),
                                       new XElement("TopRange", defaultValue.RangeTop),
                                       new XElement("Problems", defaultValue.NumberOfProblems),
                                       new XElement("Goal", defaultValue.Goal),
                                       new XElement("Attempts", defaultValue.AttemptsPerProblem)
                                       )));
                ListOfAssgDoc.Save(_fileName);
                RepNumber++;
            }
        }
        //after reading it return a list of assigmentsets 
        public List<AssignmentSet> ReadFile()
        {
            //making sure we are reading into an empty list
            ListOfAssignment.Clear();

            if (File.Exists(_fileName) == true)
            {
                //read in data, make a AssignmentSet with data, add to list assigment using a loop
                try
                {
                    xmlDocument = XDocument.Load(_fileName);
                    ListOfAssignment = xmlDocument.Descendants("Assignment").Select(d =>

                         new AssignmentSet
                         {
                             AssignmentName = d.Element("AssignmentName").Value,
                             BottomRange = int.Parse(d.Element("BottomRange").Value),
                             TopRange = int.Parse(d.Element("TopRange").Value),
                             NumberofProblems = int.Parse(d.Element("Problems").Value),
                             Goal = int.Parse(d.Element("Goal").Value),
                             Attempts = int.Parse(d.Element("Attempts").Value)
                         }).ToList();
                    System.Diagnostics.Debug.Write("In tryAssigment Collection");
                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    System.Diagnostics.Debug.Write("Out of range for read");
                }
                //System.Diagnostics.Debug.Write("ListOfAssignment: " + ListOfAssignment);
            }
            return ListOfAssignment;
        }

    }
}
