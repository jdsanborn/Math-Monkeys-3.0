/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: User

 * MODIFIED
 * 
 * 13 March 2014  Jonathan Sanborn
 * Added enumeration
 * Made changes to prepare for altered XML files that include new fields
 * 
 * 15 March 2014 Harvey Mercado & Jonathan Sanborn
 * Updated user class to match changes made to XML structure
 * 
 * 30 March 2014 Jonathan Sanborn
 * Restructured Login
 * 
 * 30 March 2014 Jonathan Sanborn
 * 
 * Moved XML node creation from FileHandler
 * into user class
 * 
 * 
 * 1 April 2014 Jonathan Sanborn
 * updated get user methods
 * 
 * 9 April 2014 Jonathan Sanborn & Harvey Mercado
 * Updated Comments
 * 
 * * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;

namespace Math_Monkeys
{
    /// <summary>
    /// Jonathan Sanborn
    /// 
    /// Class that represents a system user
    /// </summary>
    [XmlType("User")]
    public class User : IComparable, IXMLnode
    {
       
        
        #region Member Variables

        private string id;
        private List<Login> loginRecords;
        private UserType type;
        private string firstName;
        private string lastName;
        private string screenName;
        private string password;
        private Login currentSession;

        #endregion


        #region Properties

        /// <summary>
        /// Jonathan Sanborn 
        /// A unique ID for the user
        /// </summary>
        [XmlElement("ID")]
        public string ID 
        { 
            get
            { 
                return id;
            }
            set
            {  
                id = value;
                
            }
        }

        /// <summary>
        /// Jonathan Sanborn 
        /// The records of the users login history
        /// </summary>
        [XmlElement("LoginRecords")]
        public List<Login> LoginRecords
        {
            get 
            {
                return loginRecords;
            }
            set
            {
                loginRecords = value;
            }
        }
        

        /// <summary>
        /// Jonathan Sanborn
        /// The user type of user this object represents
        /// </summary>
        [XmlElement("Type")]
        public UserType UserType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

       /// <summary>
       /// Jonathan Sanborn
       /// A String of the user type
       /// </summary>
        public string GetUserTypeString
        {
            get
            {
                 return Enum.GetName(typeof(UserType),type);
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// The First name of the user
        /// </summary>
        [XmlElement("First")]
        public string FirstName
        {
            get { return firstName; }
            set {
                if (value.Length <= 0 || value == null)
                {
                    firstName = string.Empty;
                }
                else
                {
                    firstName = value; 
                }
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// The last name of the user
        /// </summary>
        [XmlElement("Last")]
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    lastName = string.Empty;
                }
                else
                {
                    lastName = value;
                }
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// A unique screen name for the user
        /// </summary>
        [XmlElement("ScreenName")]
        public string ScreenName
        {
            get { return screenName; }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    screenName = string.Empty;
                }
                else if (value.Length > Properties.Settings.Default.ScreenNameMax)
                {
                    value = value.Trim();
                    value = value.Substring(0, Properties.Settings.Default.ScreenNameMax);
                    screenName = value;
                }
                else if (value.Length < Properties.Settings.Default.ScreenNameMin)
                {
                    throw new FormatException("Value Screen Name is too short. Screen Name value must be at least "
                        + Properties.Settings.Default.ScreenNameMin.ToString() + " characters long.");
                }
                else
                {
                    screenName = value;
                }
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// The password of the user
        /// </summary>
        [XmlElement("Password")]
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    password = string.Empty;
                }
                else
                {
                    password = value;
                }
            }
        }

        /// <summary>
        /// Jonathan Sanborn
        /// The full name of the user first and last seperated by a space
        /// </summary>
        public string GetFullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// This method will compare two user objects for sorting.
        /// Jonathan Sanborn & Harvey Mercado
        /// 22 March 2014
        /// </summary>
        /// <param name="obj"> A user object to compare with this one. </param>
        /// <returns> int value based on user comparison</returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            User otherUser = obj as User;

            if (otherUser != null)
            {
                if (otherUser.UserType != this.UserType)
                {
                    return this.UserType.CompareTo(otherUser.UserType);
                }

                else
                {
                    return this.ScreenName.CompareTo(otherUser.ScreenName);
                }

            }

            else
            {
                throw new ArgumentException("Object is not a user");
            }
        }

        /// <summary>
        /// 30 March 2014
        /// Jonathan Sanborn
        /// 
        /// returns the user properties as an XElement 
        /// </summary>
        /// <returns>XElement of the user</returns>
        /// 
        public virtual XElement GetXMLNode()
        {
            XElement loginRecords = new XElement("LoginRecords");

            foreach (Login L in LoginRecords)
            {
                loginRecords.Add(
                    new XElement("Login",
                        new XElement("Date", L.Date),
                        new XElement("Duration", L.Duration)
                    )
                );
            }


            XElement newUserNode = new XElement("User",
                             new XElement("ID", ID),
                             new XElement("Type", UserType),
                             new XElement("ScreenName", ScreenName),
                             new XElement("Name",
                                 new XElement("First", FirstName),
                                 new XElement("Last", LastName)),
                             new XElement("Password", Password),
                             loginRecords
                         );
            return newUserNode;
        }

        /// <summary>
        /// Jonathan Sanborn 
        /// The last Login of the user
        /// </summary>
        /// <returns>The Login object of the users last login</returns>
        public Login LastLogin()
        {
            Login login = new Login(DateTime.MinValue);

            foreach (Login l in LoginRecords)
            {
                if (l.Date > login.Date)
                { login = l; }
            }
            return login;
        }

        /// <summary>
        /// Jonathan Sanborn
        /// Called when a user logs in to the system
        /// </summary>
        public void Login()
        {
            currentSession.Date = DateTime.Now;
        }

        /// <summary>
        /// Jonathan Sanborn
        /// Called when a user logs out of the system
        /// </summary>
        public void Logout(MMControl mmControl)
        {
            currentSession.Duration = DateTime.Now - currentSession.Date;
            LoginRecords.Add(currentSession);

            mmControl.FileHandler.UpdateUser((IXMLnode)this);
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Jonathan Sanborn
        /// Initialization method for the user class
        /// </summary>
        private void init()
        {
            ID = string.Empty;
            loginRecords = new List<Login>();
            UserType = UserType.None;
            FirstName = string.Empty;
            LastName = string.Empty;
            ScreenName = string.Empty;
            Password = string.Empty;
        }

        /// <summary>
        /// Jonathan Sanborn
        /// 
        /// The default constructor for the user class
        /// </summary>
        public User()
        {
            init();
        }

        /// <summary>
        /// 30 March 2014
        /// Jonathan Sanborn
        /// 
        /// The parameterized constructor for the user class
        /// </summary>
        /// <param name="id">A unique id for the user</param>
        /// <param name="userType">The UserType of the user</param>
        /// <param name="fistName">The users first name</param>
        /// <param name="lastName">The users last name</param>
        /// <param name="screenName">A unique screen name for the user</param>
        /// <param name="password">The users password</param>
        public User(string id, UserType userType, string fistName, string lastName, string screenName, string password)
        {
            init();

            this.ID = id;
            this.UserType = userType;
            this.FirstName = fistName;
            this.LastName = lastName;
            this.ScreenName = screenName;
            this.Password = password;
        }

        /// <summary>
        /// Jonathan Sanborn & Harvey Mercado
        /// 
        /// The parameterized constructor for the user class
        /// </summary>
        /// <param name="id">A unique id for the user</param>
        /// <param name="userType">The UserType of the user</param>
        /// <param name="fistName">The users first name</param>
        /// <param name="lastName">The users last name</param>
        /// <param name="screenName">A unique screen name for the user</param>
        /// <param name="password">The users password</param>
        /// <param name="loginRecord">A list of the user login records</param>
        public User(string id, UserType userType, string fistName, string lastName, string screenName, string password, List<Login> loginRecord)
        {
            init();

            this.ID = id;
            this.UserType = userType;
            this.FirstName = fistName;
            this.LastName = lastName;
			this.ScreenName = screenName;
            this.Password = password;
            this.LoginRecords = loginRecord;
            
        }

        /// <summary>
        /// 31 March 2014
        /// Jonathan Sanborn
        /// 
        /// Constructor takes a user XML node and creates a user object
        /// </summary>
        /// <param name="d"></param>
        public User(XElement d)
        {
            init();

            ID = d.Element("ID").Value;
            UserType = (UserType)Enum.Parse(typeof(UserType), d.Element("Type").Value, true);
            ScreenName = d.Element("ScreenName").Value;
            FirstName = d.Element("Name").Element("First").Value;
            LastName = d.Element("Name").Element("Last").Value;
            Password = d.Element("Password").Value;
            LoginRecords = d.Element("LoginRecords").Descendants("Login").Select(l =>
                new Login
                {
                    Date = DateTime.Parse(l.Element("Date").Value),
                    Duration  = System.Xml.XmlConvert.ToTimeSpan(l.Element("Duration").Value)
                }).ToList();

        }
        
        #endregion


        #region DEPRECATED code

        //private int _uniqueId;
        //private string _fullName;
        //private string _userType;
        //private DateTime? _LoginDate;


            //Name needs to be first and last
			//_fullName = fullName;
						
			//userType changed to enumeration
            
        //_userType = userType;
        //Replaced by first and last names
        //// Fields
        //// ListOfUsersXMLHandler userFile { get; set; }
        //[XmlElement("UserName")]
        //public string UserName
        //{
        //    get
        //    {
        //        return _fullName;
        //    }
        //    set
        //    {
        //        _fullName = value;
        //    }
        //}

        //Replaced by id and the unsigned int type
        //[XmlElement("UniqueID")]
        //public int UniqueID
        //{
        //    get
        //    {
        //        return _uniqueId;
        //    }
        //    set
        //    {
        //        _uniqueId = value;
        //    }
        //}

        /*
        // Methods
        // public bool GetFileData(); // get user data using UserXMLHandler
        // public bool StoreToFile(); // store user data using UserXMLHandler
        */
        //[XmlElement("UserType")]
        //public string UserType
        //{
        //    get
        //    {
        //        return _userType;
        //    }
        //    set
        //    {
        //        _userType = value;
        //    }// return "A" for Admin or "E" for EndUser
        //}

        #endregion


    }
}
