/**********************************************************
 * Author: Jonathan Sanborn
 * Date: 14 March 2014
 * FileName: FileHandler.cs
 * ClassName: FileHandler
 * Summary: Class is to handle all interaction between the
 * XML data files and the application.
 * 
 * Modified
 * 29 March 2014
 * Jonathan Sanborn 
 * Made changes to use XML schema verification and
 * made updates to support changes in the student class
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated comments
 * 
 * ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;
using System.Diagnostics;
using System.Collections.ObjectModel;


namespace Math_Monkeys
{
    /// <summary>
    /// Class is to handle all interaction between the XML data files and the application.
    /// </summary>
    public class FileHandler
    {


        #region Member Variables

            private string filePath;
            private enum MMFileType {None, User, ProblemSet, Assignment, AssignmentAttempt};
            private XmlSchemaSet schemas;
            private string[] schemaFiles;
            private MMControl MMControl;

        #endregion


        #region FileHandler Methods

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Creates the Parent node files for the xml data
        /// </summary>
        /// <param name="fileName">the name of the file to create</param>
        /// <param name="fileType">the type of file to create</param>
        private void CreateFile(string fileName, MMFileType fileType)
        {
            XDocument xFile = new XDocument( );

            switch (fileType)
            {

                case MMFileType.User:
                    xFile.Add(
                        new XElement("Users",
                            new XElement("User",
                                new XElement("ID", Guid.NewGuid().ToString()),
                                new XElement("Type", UserType.Administrator),
                                new XElement("ScreenName", Properties.Settings.Default.DefaltAdminName),
                                new XElement("Name",
                                    new XElement("First", Properties.Settings.Default.DefaltAdminName),
                                    new XElement("Last", Properties.Settings.Default.DefaltAdminName)
                                ),
                                new XElement("Password", Properties.Settings.Default.DefaltAdminName),
                                new XElement("LoginRecords", string.Empty)
                            )
                        )
                    );
                    break;
                case MMFileType.ProblemSet:
                    xFile.Add(new XElement("ProblemSets", string.Empty));
                    break;
                case MMFileType.Assignment:
                    xFile.Add(new XElement("Assignments", string.Empty));
                    break;
                case MMFileType.AssignmentAttempt:
                    xFile.Add(new XElement("AssignmentAttempts", string.Empty));
                    break;
                case MMFileType.None:
                default:
                    break;
            }
            xFile.Save(fileName);
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Opens the passed in XML filename
        /// </summary>
        /// <param name="fileName">The name of the file to open</param>
        /// <param name="fileType">The type that the file is</param>
        /// <returns>The opened files</returns>
        private XDocument OpenFile(string fileName, MMFileType fileType)
        {
            XDocument doc;
            bool schemaError = false;

            if (!File.Exists(fileName))
            {
                CreateFile(fileName, fileType);
            }
           
            try
            {
                doc = XDocument.Load(fileName);
                doc.Validate(schemas, (o,e) => { schemaError = true; } );

                if (schemaError)
                {
                    MessageBox.Show("XML data file has been altered or corrupted.\n" 
                            + "Please correct the file errors or delete the files from the system.\n" 
                            + "CAUTION: Deletion of file will result in data loss.\n"
                            + "Filename: " + fileName + "\n"
                            + "Date: " + DateTime.Now.ToString(),
                            "XML Schema Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return null;
                }
                else
                {
                    return XDocument.Load(fileName);
                }
            }
            catch (System.IO.IOException ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                return null;
            }

        }

        /// <summary>
        /// 29 March 2014
        /// Jonathan Sanborn
        /// 
        /// Gets the schema from embedded schema file passed is
        /// </summary>
        /// <param name="fileName">the name of the embedded schema file</param>
        private void getSchema(string fileName)
        {
            XmlSchema schema = new XmlSchema();

            try
            {
                var assembley = System.Reflection.Assembly.GetExecutingAssembly();
                using (var stream = assembley.GetManifestResourceStream(fileName))
                using (var reader = XmlReader.Create(stream))
                {
                    schema = XmlSchema.Read(reader, new ValidationEventHandler(this.ShowErrors));
                    stream.Dispose();
                }
               
                schemas.Add(schema);
            }
            catch (ArgumentNullException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString() + " The filename of getSchema method is null. \n" + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString() 
                    + " The filename argument of the getSchema method is invalid. \n" 
                    + " fileName = " + fileName + "\n"
                    + ex.Message);
            }
            catch (FileLoadException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString()
                    + " The schema file  is unable to be loaded in the getSchema method. \n"
                    + " fileName = " + fileName + "\n"
                    + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString()
                   + " The schema file is unable to be found in the getSchema method. \n"
                   + " fileName = " + fileName + "\n"
                   + ex.Message);
            }
            catch (BadImageFormatException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString()
                   + " The dll file is unable to be loaded in the getSchema method. \n"
                   + " fileName = " + fileName + "\n"
                   + ex.Message);
            }
            catch (NotImplementedException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString()
                   + " The XML Reader Create could not be implemened in the getSchema method. \n"
                   + ex.Message);
            }
            catch (System.Security.SecurityException ex)
            {
                Debug.WriteLine(DateTime.Now.ToString()
                   + " Security error in the getSchema method. \n"
                   + " fileName = " + fileName + "\n"
                   + ex.Message);
            }

        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// Throws up a message box when on a schema error
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="args">the v=event arguments</param>
        public void ShowErrors(object sender, ValidationEventArgs args)
        {
            MessageBox.Show("XML Schema File failed to load.",
                           "XML Schema Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        #endregion


        #region User Methods

            /// <summary>
            /// Jonathan Sanborn
            /// Get the user with the passed in id or null if the user
            /// does not exists
            /// </summary>
            /// <param name="id">The id of the user</param>
            /// <returns>The user with the id</returns>
            public User GetUserByID(string id)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                User user = null;
                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);
                    if (userFile != null)
                    {
                        XElement elem = userFile.Descendants("User").First(s => s.Element("ID").Value == id );
                        user = new User(elem);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                return user;
            }

            /// <summary>
            /// 1 April 2014
            /// Jonathan Sanborn
            /// 
            /// Gets the Student with the passed ID
            /// </summary>
            /// <param name="id">The id of the student to get from the xml</param>
            /// <returns>Student with the passed in ID or null</returns>
            public Student GetStudentByID(string id)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                Student student = null;
                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);
                    if (userFile != null)
                    {
                       XElement elem = userFile.Descendants("User").First(s => s.Element("ID").Value == id && s.Element("Type").Value == UserType.Student.ToString());
                       student = new Student(MMControl, elem);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                return student;
            }

            /// <summary>
            /// 1 Admin 2014
            /// Jonathan Sanborn
            /// 
            /// Gets the Admin with the passed in id
            /// </summary>
            /// <param name="id">The id of the admin to retrive</param>
            /// <returns>The Admin with the passed in id or null</returns>
            public Admin GetAdminByID(string id)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                Admin admin = null;
                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);
                    if (userFile != null)
                    {
                        XElement elem = userFile.Descendants("User").First(s => s.Element("ID").Value == id && s.Element("Type").Value == UserType.Administrator.ToString());
                        admin = new Admin(elem);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                return admin;
            }

            /// <summary>
            /// Jonathan Sanborn
            /// Get all the users of a type
            /// </summary>
            /// <param name="userType">The type of users to return</param>
            /// <returns>A List of all users with the passed in type</returns>
            public List<User> GetUsersByType(UserType userType)
            {
                var userList = from user in GetAllUsers()
                        where user.UserType == userType
                        select user;
               
                return new List<User>(userList);
            }

            /// <summary>
            /// 1 April 2014
            /// Jonathan Sanborn
            /// 
            /// Gets All the admin in the xml files
            /// </summary>
            /// <returns>All the Admin</returns>
            public List<Admin> GetAllAdmins()
            {

                XDocument usersDocument;

                List<Admin> adminList = new List<Admin>();

                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);

                try
                {
                    usersDocument = OpenFile(fileName, MMFileType.User);

                    if (usersDocument != null)
                    {
                        adminList = usersDocument.Descendants("User").Where(w => w.Element("Type").Value == UserType.Administrator.ToString()).Select(d => new Admin(d)).ToList();
                    }
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }

                return adminList;
            }

            /// <summary>
            /// 1 April 2014
            /// Jonathan Sanborn
            /// 
            /// Gets All the Students in the xml files
            /// </summary>
            /// <returns>All the students</returns>
            public List<Student> GetAllStudents()
            {

                XDocument usersDocument;

                List<Student> studentList = new List<Student>();

                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);

                try
                {
                    usersDocument = OpenFile(fileName, MMFileType.User);

                    if (usersDocument != null)
                    {
                        studentList = usersDocument.Descendants("User").Where(w => w.Element("Type").Value ==  UserType.Student.ToString()).Select(d =>  new Student(MMControl, d)).ToList();
                    }
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }

                return studentList;
            }

            /// <summary>
            /// 1 April 2014
            /// Jonathan Sanborn
            /// 
            /// Gets All the users in the xml files
            /// </summary>
            /// <returns>All the the users</returns>
            public List<User> GetAllUsers()
            {

                XDocument usersDocument;
                
                List<User> userList = new List<User>();

                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                               
                try
                {
                    usersDocument = OpenFile(fileName, MMFileType.User);
                    
                    if (usersDocument != null)
                    {
                        userList = usersDocument.Descendants("User").Select(d => new User(d) ).ToList();
                    }
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
             
                return userList;
            }

            /// <summary>
            /// 29 March 2014
            /// Jonathan Sanborn
            /// Saves the passed in student to the users.xml file
            /// 
            /// 30 March 2014
            /// moved xml generation to the user object
            /// </summary>
            /// <param name="user">The new user to create in the xml file</param>
            public void SaveNewUser(IXMLnode user)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);

                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);
                    if (userFile != null)
                    {
                        userFile.Element("Users").Add(user.GetXMLNode());
                        userFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            
            }

            /// <summary>
            /// 30 March 2014
            /// Jonathan Sanborn
            /// 
            /// Updates the passed in user in the xml file
            /// </summary>
            /// <param name="user">the user to update</param>
            public void UpdateUser(IXMLnode user)
            { 
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);

                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);

                    if (userFile != null)
                    {
                        try
                        {
                            userFile.Descendants("User").First(s => s.Element("ID").Value == user.ID).ReplaceWith(user.GetXMLNode());
                            userFile.Save(fileName);
                        }
                        catch (ArgumentNullException ex)
                        {
                            System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateUser failed null referance.\n" + ex.Message); 
                        }
                        catch (InvalidOperationException ex)
                        {
                            System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateUser failed Invalid Operation.\n" + ex.Message); 
                        }
                    }  
                
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Deletes the passed in user from the XML files
            /// </summary>
            /// <param name="user"></param>
            public void DeleteUser(IXMLnode user)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.usersFilename);
                try
                {
                    XDocument userFile = OpenFile(fileName, MMFileType.User);

                    if (userFile != null)
                    {
                        userFile.Descendants("User").First(s => s.Element("ID").Value == user.ID).Remove();
                        userFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion


        #region Assignment Methods

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Gets the Assignments assigned to the Student
            /// </summary>
            /// <param name="student">The Students to get the assignments</param>
            /// <returns>The Assignments for the student</returns>
            public List<Assignment> GetAssignmentsByStudent(Student student)
            {
                List<Assignment> assignmentList = new List<Assignment>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);
                 XDocument AssignmentDocument;

                    try
                    {
                        AssignmentDocument = OpenFile(fileName, MMFileType.Assignment);

                        if (AssignmentDocument != null)
                        {
                            assignmentList = AssignmentDocument.Descendants("Assignment").Where( w => w.Element("UserID").Value == student.ID).Select(d => new Assignment(MMControl,student, d)).ToList();
                        }
                    }
                    catch (System.ArgumentOutOfRangeException ex)
                    {
                        System.Diagnostics.Debug.Write(ex.Message);
                    }

                    return assignmentList;
            }

            /// <summary>
            /// 31 March 2014
            /// Jonathan Sanborn
            /// Decoupled Assignments and FileHandler
            /// 
            /// </summary>
            /// <param name="assignment">The Assignment to be saved in XMl file</param>
            public void SaveNewAssignment(Assignment assignment)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);

                try
                {
                    XDocument assignmentFile = OpenFile(fileName, MMFileType.Assignment);

                    if (assignmentFile != null)
                    {                        
                        assignmentFile.Element("Assignments").Add(assignment.GetXMLNode());
                        assignmentFile.Save(fileName);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Updates the XML of the passed in assignment
            /// </summary>
            /// <param name="assignment">The assignment to update</param>
            public void UpdateAssignment(Assignment assignment)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);

                try
                {
                    XDocument assignmentFile = OpenFile(fileName, MMFileType.Assignment);

                    if (assignmentFile != null)
                    {
                        assignmentFile.Descendants("Assignment").First(s => s.Element("ID").Value == assignment.ID).ReplaceWith(assignment.GetXMLNode());
                        assignmentFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
        
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Deletes the passed in assignment from the XML
            /// </summary>
            /// <param name="assignment">The assignment to delete</param>
            public void DeleteAssignment(Assignment assignment)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);
                try
                {
                    XDocument assignmentFile = OpenFile(fileName, MMFileType.Assignment);

                    if (assignmentFile != null)
                    {
                        XElement elem = assignmentFile.Descendants("Assignment").First(s => s.Element("ID").Value == assignment.ID);
                        
                        if (elem != null)
                        {elem.Remove();}

                        assignmentFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion


        #region ProblemSet Methods

            /// <summary>
            /// 
            /// 31 March 2014
            /// Jonathan Sanborn
            /// Updated to decouple from problem set
            /// 
            /// Returns all the problem sets in the Xml files
            /// </summary>
            /// <returns></returns>
            public List<ProblemSet> GetAllProblemSets()
            {

                List<ProblemSet> problemSetsList = new List<ProblemSet>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);
                XDocument problemSetsDocument;

                try
                {

                    problemSetsDocument = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetsDocument != null)
                    {
                        problemSetsList = problemSetsDocument.Descendants("ProblemSet").Select(d => new ProblemSet(d)).ToList();
                    }           
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " " + ex.Message);
                }
                
                return problemSetsList;
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Gets the Problem set with the passed in ID
            /// </summary>
            /// <param name="id">The problem set id to get</param>
            /// <returns>The Problem set with passed in id</returns>
            public ProblemSet GetProblemSetByID(string id)
            {
                var problemsSets = from problemSet in GetAllProblemSets()
                                   where problemSet.ID == id
                                   select problemSet;
                List<ProblemSet> ProblemSetList = new List<ProblemSet>(problemsSets);
                return ProblemSetList.Count > 0 ? ProblemSetList[0] : null;
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Gets the ProblemSets with the passed in operation
            /// </summary>
            /// <param name="operation">The Operation of the Problem sets to retrieve</param>
            /// <returns>The Problem sets with passed in operation</returns>
            public List<ProblemSet> GetProblemSetByOperation(Operation operation)
            {

                var ProblemSetList = from problemSet in GetAllProblemSets()
                               where problemSet.Operation == operation
                               select problemSet;
                return new List<ProblemSet>(ProblemSetList);
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Saves the passed in Problem set to the XML
            /// </summary>
            /// <param name="problemSet">The Problem set to save</param>
            public void SaveNewProblemSet(ProblemSet problemSet)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);

                try
                {
                    XDocument problemSetFile = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetFile != null)
                    {
                        problemSetFile.Element("ProblemSets").Add(problemSet.GetXMLNode());
                        problemSetFile.Save(fileName);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Updates the XML of the passed in problem Set
            /// </summary>
            /// <param name="problemSet">The problem set to update</param>
            public void UpdateProblemSet(ProblemSet problemSet)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);

                try
                {
                    XDocument problemSetFile = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetFile != null)
                    {
                        try
                        {
                            problemSetFile.Descendants("ProblemSet").First(s => s.Element("ID").Value == problemSet.ID).ReplaceWith(problemSet.GetXMLNode());
                            problemSetFile.Save(fileName);
                        }
                        catch (ArgumentNullException ex)
                        {
                            System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateUser failed null referance.\n" + ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateUser failed Invalid Operation.\n" + ex.Message);
                        }
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Delete the passed in problem set from the XML
            /// </summary>
            /// <param name="problemSet">The Problem to delete</param>
            public void DeleteProblemSet(ProblemSet problemSet)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.problemSetsFilename);

                try
                {
                    XDocument problemSetFile = OpenFile(fileName, MMFileType.ProblemSet);

                    if (problemSetFile != null)
                    {
                        try
                        {
                            problemSetFile.Descendants("ProblemSet").First(s => s.Element("ID").Value == problemSet.ID).Remove();
                            problemSetFile.Save(fileName);
                        }
                        catch (ArgumentNullException ex)
                        {
                            System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateUser failed null referance.\n" + ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateUser failed Invalid Operation.\n" + ex.Message);
                        }
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            }

        #endregion


        #region AssignmentAttempt Methods

            //public List<AssignmentAttempt> GetAllAssignmentAttempts()
            //{
            //    List<AssignmentAttempt> assignmentAttempsList = new List<AssignmentAttempt>();
            //    string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);
            //    XDocument assignmentAttempsDocument;

            //    try
            //    {
            //        assignmentAttempsDocument = OpenFile(fileName, MMFileType.AssignmentAttempt);
            //        if (assignmentAttempsDocument != null)
            //        {
            //            assignmentAttempsList = assignmentAttempsDocument.Descendants("AssignmentAttempt").Select(d => new AssignmentAttempt(MMControl, d)).ToList();
            //        }
            //    }
            //    catch (System.ArgumentOutOfRangeException ex)
            //    {
            //        System.Diagnostics.Debug.Write(ex.Message);
            //    }

            //    return assignmentAttempsList;
            //}

            //public AssignmentAttempt GetAssignmentAttemptByID(string id)
            //{
            //    var assignmentAttempts = from assignmentAttempt in GetAllAssignmentAttempts()
            //                             where assignmentAttempt.ID == id
            //                             select assignmentAttempt;
            //    List<AssignmentAttempt> assignmentAttemptList = new List<AssignmentAttempt>(assignmentAttempts);
            //    return assignmentAttemptList.Count > 0 ? assignmentAttemptList[0] : null;
            //}

            public List<AssignmentAttempt> GetAssignmentAttemptsByAssignment(Assignment assign)
            {
                List<AssignmentAttempt> assignmentAttempsList = new List<AssignmentAttempt>();
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);
                XDocument assignmentAttempsDocument;


                 try
                 {
                     assignmentAttempsDocument = OpenFile(fileName, MMFileType.AssignmentAttempt);
                     if (assignmentAttempsDocument != null)
                     {
                         assignmentAttempsList = assignmentAttempsDocument.Descendants("AssignmentAttempt").Where(w => assign.ID == w.Element("AssignmentID").Value).Select(d => new AssignmentAttempt(assign, d)).ToList();
                     }
                 }
                 catch (System.ArgumentOutOfRangeException ex)
                 {
                     System.Diagnostics.Debug.Write(ex.Message);
                 }

                 return assignmentAttempsList;
            }

            //public List<AssignmentAttempt> GetAssignmentAttemptsByDateRange(DateTime startDate, DateTime endDate)
            //{
            //    var assignmentAttempts = from assignmentAttempt in GetAllAssignmentAttempts()
            //                             where assignmentAttempt.Date >= startDate
            //                                && assignmentAttempt.Date <= endDate
            //                             select assignmentAttempt;

            //    return new List<AssignmentAttempt>(assignmentAttempts);
            //}

            public void SaveNewAssignmentAttempt(AssignmentAttempt assignmentAttempt)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);

                try
                {
                    XDocument assignmentAttemptFile = OpenFile(fileName, MMFileType.AssignmentAttempt);

                    if (assignmentAttemptFile != null)
                    {
                        assignmentAttemptFile.Element("AssignmentAttempts").Add(assignmentAttempt.GetXMLNode());
                        assignmentAttemptFile.Save(fileName);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            
            }

            public void UpdateAssignmentAttempt(AssignmentAttempt assignmentAttempt)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);

                try
                {
                    XDocument assignmentAttemptFile = OpenFile(fileName, MMFileType.AssignmentAttempt);

                    if (assignmentAttemptFile != null)
                    {
                        assignmentAttemptFile.Descendants("AssignmentAttempt").First(s => s.Element("ID").Value == assignmentAttempt.ID).ReplaceWith(assignmentAttempt.GetXMLNode());
                        assignmentAttemptFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateAssignmentAttempt failed null referance.\n" + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateAssignmentAttempt failed Invalid Operation.\n" + ex.Message);
                }   
            }

            public void DeleteAssignmentAttempt(AssignmentAttempt assignmentAttempt)
            {
                string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentAttempsFilename);

                try
                {
                    XDocument assignmentAttemptFile = OpenFile(fileName, MMFileType.AssignmentAttempt);

                    if (assignmentAttemptFile != null)
                    {
                        assignmentAttemptFile.Descendants("AssignmentAttempt").First(s => s.Element("ID").Value == assignmentAttempt.ID).Remove();
                        assignmentAttemptFile.Save(fileName);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateAssignmentAttempt failed null referance.\n" + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    System.Diagnostics.Debug.Write(DateTime.Now.ToString() + " UpdateAssignmentAttempt failed Invalid Operation.\n" + ex.Message);
                }   
            }

        #endregion


            #region constructors

            /// <summary>
            /// 14 March 2014
            /// Jonathan Sanborn
            /// Initializes the FileHandler class variables.
            /// Creates a Math Monkeys directory if one does not exist
            /// 
            /// 29 March 2014
            /// Jonathan Sanborn
            /// Added schemaFiles array
            /// Added some exception handling
            /// </summary>
            private void init()
            {
                try
                {
                    filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Properties.Settings.Default.mmFolder);

                    if (!Directory.Exists(filePath))
                    { Directory.CreateDirectory(filePath); }

                    if (!Directory.Exists(filePath + "\\backup"))
                    { Directory.CreateDirectory(filePath + "\\backup"); }
                }
                catch (ArgumentNullException ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString()
                   + " The argument of the init method of the FileHandler is Null. \n"
                   + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString()
                  + " The argument of the init method of the FileHandler is Invalid. \n"
                  + ex.Message);
                }
                catch (PlatformNotSupportedException ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString()
                  + " The GetFolderPath method in the init method of the FileHandler will not run on this platform. \n"
                  + ex.Message);
                }

                schemas = new XmlSchemaSet();

                schemaFiles = new string[] { "Math_Monkeys.XML.User.xsd", 
                                                "Math_Monkeys.XML.ProblemSet.xsd", 
                                                "Math_Monkeys.XML.Assignment.xsd", 
                                                "Math_Monkeys.XML.AssignmentAttempt.xsd" 
                                            };

                foreach (string s in schemaFiles)
                {
                    getSchema(s);
                }
            }

            /// <summary>
            /// Jonathan Sanborn
            /// 
            /// Default Constructor for file handler
            /// </summary>
            /// <param name="mmControl">The Control Object</param>
            public FileHandler(MMControl mmControl)
            {
                init();
                MMControl = mmControl;
            }

            #endregion


        #region DEPRECATED Code

        //public Assignment GetAssignmentByID(string id)
        //{
        //    var assignments = from assign in GetAllAssignments()
        //                      where assign.ID == id
        //                      select assign;
        //    List<Assignment> assignmentsList = new List<Assignment>(assignments);
        //    return assignmentsList.Count > 0 ? assignmentsList[0] : null;
        //}

        ///// <summary>
        ///// 31 March 2014
        ///// Jonathan Sanborn
        ///// Decoupled FileHandler from Assignments
        ///// 
        ///// Gets All the Assignments in the XML File
        ///// </summary>
        ///// <returns>All the Assignments</returns>
        //public List<Assignment> GetAllAssignments()
        //{

        //    List<Assignment> assignmentList = new List<Assignment>();
        //    string fileName = Path.Combine(filePath, Properties.Settings.Default.assignmentFilename);
        //    XDocument AssignmentDocument;

        //    try
        //    {
        //        AssignmentDocument = OpenFile(fileName, MMFileType.Assignment);

        //        if (AssignmentDocument != null)
        //        {
        //            assignmentList = AssignmentDocument.Descendants("Assignment").Select(d => new Assignment(MMControl, d)).ToList();
        //        }
        //    }
        //    catch (System.ArgumentOutOfRangeException ex)
        //    {
        //        System.Diagnostics.Debug.Write(ex.Message);
        //    }

        //    return assignmentList;
        //}

        //public List<Assignment> GetAssignmentsByProblemSet(ProblemSet problemSet)
        //{
        //    var assignments = from assign in GetAllAssignments()
        //                      where assign.ProblemSetID == problemSet.ID
        //                      select assign;
        //    return new List<Assignment>(assignments);
        //}

        #endregion


    }
}
