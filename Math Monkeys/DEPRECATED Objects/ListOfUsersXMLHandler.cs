/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: ListOfUsersXMLHandler
 * Purpose: we have the ability to create a file name for end users
 * -we are able to read in the existent users, and add new user of EndUser type, no admin addition is supported
 * 
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
    // Coder of this class - Jeff Cribben
    public class ListOfUsersXMLHandler
    {


        private XDocument xmlDocument;
        private string fileName;
        private bool fileIsOpen = false;
        private bool fileIsValid;
        //get a list of only admins
        public static List<string> adminList = new List<string>();
        //get a list of only endUser/students
        public static List<string> endUserList = new List<string>();
        //get a list of all users
        public static List<User> listOfUsers = new List<User>(); // List of Users
        //an XML document is created and referenced 
        XDocument ListOfUsersDoc;
        //an appropiate name for the file we will be using 
        private string _fileName;
        //making sure no messing up with IDs
        private uint count = 0; // count for giving  unique ID to users
        
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
       

        public bool ValidateFile(ref XDocument xmlDocument)
        {
            return true;
        }

        public bool OpenFile(string fileName)
        {
            fileIsValid = ValidateFile(ref xmlDocument);
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

        public ListOfUsersXMLHandler() //Constructor
        {
            xmlDocument = new XDocument();
            fileName = "Empty";
            fileIsOpen = false;
            fileIsValid = false;
        }

        //When the program start ther will be not xml file existen therefore we create one with a default administrator
        public void WriteNewFile(string fName)
        {
            string today;
            today = DateTime.Now.ToString(Properties.Settings.Default.dateFormat);
            //make sure that count should be zero 
            if (count == 0)
            {
                _fileName = fName;
                //as the first time we create a program we make a admin a default user
                ListOfUsersDoc = new XDocument(
                       new XElement("Users",
                           new XElement("User",
                               new XElement("Type", UserType.Administrator),
                               new XElement("UniqueID", count),
                               new XElement("Name", "Administrator"),
                               new XElement("LoginDate",today))));
                ListOfUsersDoc.Save(_fileName);
                count++;
            }
        }

        //write we file will require a file name and a userName ID will be computed as a count
        public void WriteFile(string fName, string userName) // Adds just a student for now with  uniqueID=count and some userName
        {
            _fileName = fName;
            //count = getCount(_fileName);

            if (File.Exists("ListOfUsers.xml") == true) // Checks if file exists
            {
                DateTime? dt = null;
                fileIsOpen = OpenFile(_fileName);
                if (fileIsOpen == true)
                {
                    var newUserNode = new XElement("User", // Adds a single user 
                            new XElement("Type",  UserType.Student),
                            new XElement("UniqueID", count),
                            new XElement("Name", userName),
                            new XElement("LoginDate", dt));
                    xmlDocument.Element("Users").Add(newUserNode); // This is error
                    xmlDocument.Save(_fileName);
                    count++;                                // Increases count (uniqueID)
                }
                else
                    System.Diagnostics.Debug.Write("File is not opened");
            }
            else
            { // if file does not exist -> assume we need to make one
                WriteNewFile(_fileName); // Makes default file structure
            }
        }
        //reads given file name and existent it return a list of user of type(object) user
        public List<User> ReadFile(string fileName)
        {
            //making sure we are reading into an empty list
            listOfUsers.Clear();
            _fileName = fileName;
            if (File.Exists(_fileName) == true)
            {
                //OpenFile(_fileName);
                System.Diagnostics.Debug.Write("about to read");
                //read in data, make a user with data, add to list of users, loop
                try
                {
                    xmlDocument = XDocument.Load(_fileName);

                    listOfUsers = xmlDocument.Descendants("User").Select(d =>
                        
                         new User
                         {
                             ID = d.Element("UniqueID").Value,
                             ScreenName = d.Element("Name").Value,
                             UserType = (UserType) Enum.Parse(typeof(UserType), d.Element("Type").Value, true),  //hmmm
                             LastLoginDate = isDateSet(d.Element("LoginDate").Value),
                         }).ToList();
                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    System.Diagnostics.Debug.Write("Out of range for read");
                }
                //System.Diagnostics.Debug.Write("ListOfUsers: " +listOfUsers);
            }
            else
            {
                WriteNewFile(_fileName);
                ReadFile(_fileName);
            }
            return listOfUsers;
        }

        //Return a list of all endUser in the application 
        public List<string> GetUserNames(string fileName) // if usernames is empty it's fine, but must read file first
        {
            //making sure we read into an empty list 
            endUserList.Clear();

            _fileName = fileName;

            ReadFile(_fileName);

            string userName;
            // System.Diagnostics.Debug.Write("Number0fElementinList" + listOfUsers.Count);
            for (int i = 0; i < listOfUsers.Count; i++)
            {
                try
                {
                    userName = listOfUsers[i].ScreenName;
                    //userType = listOfUsers[i].UserType;
                    endUserList.Add(userName);
                    //System.Diagnostics.Debug.Write("IN LOOP" + endUserList[i]);
                }
                catch (System.ArgumentOutOfRangeException x)
                {
                    return endUserList;

                }
            }
            return endUserList;
        }

        /*      public List<string> GetAdminList()
              {
                  //reading into an empty list
                  adminList.Clear();
               //we needed to test it    
                  if (fileIsOpen)
                  {
                      try
                      {
                          var Set = (from User in xmlDocument.Descendants("Users").Descendants("User")
                                     where User.Element("Type").Value == "Admin"
                                     select User)
                                     .Elements("Name")
                                     .Select(d => d.Value)
                                     .ToList();
                      }
                      catch (IOException E)
                      {
                          System.Diagnostics.Debug.Write("Could not write list");
                      }
                  }
                  //Scan through file, if Xelement == "EndUser", add userName to list
                  return endUserList;
              }*/

        //handleling nullable date
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
        
        //this will allow us to determine what ID to assign to a new user
        //public uint getCount(string fName)
        //{
        //    ReadFile(fName);
        //    int index = listOfUsers.Count;
        //    if (index == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return (listOfUsers[index - 1].ID + 1);
        //    }
        //}

        //Process of removing an User from XML file
        public void RemoveUserFromXML(string UserName, string fileName)
        {
            //System.Diagnostics.Debug.Write("\n RemoveUserXML " + UserName + " " + fileName);
            OpenFile(fileName);
            // xmlDocument = XDocument.Load(fileName);

            xmlDocument.Descendants("Users")
                .Elements("User")
                .Where(x => x.Element("Name").Value == UserName)
                .Remove();
            xmlDocument.Save(fileName);
        }
        //we need to set a date for whent he last time the user had login to the Math Monkeys
        public void updateLoginDate(User student, string fileName)
        {
            string today;
            today = DateTime.Now.ToString(Properties.Settings.Default.dateFormat);

            if (File.Exists(fileName) == true) // Checks if file exists
            {
                xmlDocument = XDocument.Load(fileName);
                var query = from item in xmlDocument.Descendants("User")
                            where (item.Element("Name").Value == student.ScreenName &&
                            item.Element("UniqueID").Value == student.ID.ToString())
                            select item;
                foreach (XElement itemE in query)
                {
                    //System.Diagnostics.Debug.Write("An item was selected");
                    itemE.SetElementValue("LoginDate", today);
                }
                xmlDocument.Save(fileName);
            }
        }
    }
}
