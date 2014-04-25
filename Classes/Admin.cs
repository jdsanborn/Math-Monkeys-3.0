/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Admin
 * FileName: Admin.cs
 * 
 * Modified
 * 22 March 2014
 *Jonathan Sanborn & Harvey Mercado
 *Updated class in inherit from User class
 *
 * 30 March 2014
 *Jonathan Sanborn
 * 
 * 9 April 2014
 * Jonathan Sanborn
 * Updated comments
 *
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Math_Monkeys
{
    /// <summary>
    /// A class for representing and admin user in the system
    /// </summary>
     [XmlType("User")]
    public class Admin : User, IXMLnode
    {


        #region Methods

        /// <summary>
         /// 30 March 2014
         /// Jonathan Sanborn 
         /// Returns the XML for the admin
         /// </summary>
         /// <returns>The XElement for the admin</returns>
        public new  XElement  GetXMLNode()
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

        #endregion


        #region Constructors

        /// <summary>
        /// 22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
        /// Init method for initializing Admin variables and objects
        /// </summary>
        private void init()
        { }

        /// <summary>
        /// Default constructor for the Admin class inherits from the default
        /// constructor of the user class
        /// </summary>
        public Admin()
            : base()
        {
            init();
        }

        /// <summary>
        ///  22 March 2014
        /// Jonathan Sanborn & Harvey Mercado
         /// Parameterized constructor for the Admin class inherits from the
         /// Parametrized constructor of the user class
         /// </summary>
         /// <param name="id">A unique ID among all users</param>
         /// <param name="fistName">The First name of the administrator</param>
         /// <param name="lastName">The Last name of the administrator</param>
         /// <param name="screenName">A unique name to identify the user</param>
         /// <param name="password">The password the user will use to login to the system</param>
         /// <param name="loginRecord">A List of the loginRecords of the admin</param>
         public Admin(string id, string fistName, string lastName, string screenName, string password, List<Login> loginRecord)
            :base(id, UserType.Administrator, fistName, lastName, screenName, password, loginRecord)
        {
            init();
        }

         /// <summary>
         ///  30 March 2014
         /// Jonathan Sanborn
         /// Parameterized constructor for the Admin class inherits from the
         /// Parametrized constructor of the user class
         /// </summary>
         /// <param name="id">A unique ID among all users</param>
         /// <param name="fistName">The First name of the administrator</param>
         /// <param name="lastName">The Last name of the administrator</param>
         /// <param name="screenName">A unique name to identify the user</param>
         /// <param name="password">The password the user will use to login to the system</param>
         public Admin(string id, string fistName, string lastName, string screenName, string password)
             : base(id, UserType.Administrator, fistName, lastName, screenName, password)
         {
             init();
         }

        /// <summary>
        /// 31 March 2014
        /// Jonathan Sanborn
        /// 
        /// Constructor takes a user XML node and creates a user object
        /// </summary>
        /// <param name="d"> An admin XML node</param>
        public Admin(XElement d):base(d)
        {
            init();
        }

         /// <summary>
         /// 22 March 2014
         /// Jonathan Sanborn & Harvey Mercado
         /// Copy constructor take the passed in user and copies the defining values 
         /// into a new instance of the Admin
         /// </summary>
         /// <param name="user">The user to with the set values to copy from.</param>
        public Admin(User user) : base()
        {
            init();
            
            this.ID = user.ID;
            this.UserType = user.UserType;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.ScreenName = user.ScreenName;
            this.Password = user.Password;
            this.LoginRecords = user.LoginRecords;
        }
        
        #endregion


        #region DEPRECATED CODE

        ///// <summary>
        ///// 30 March 2014
        ///// Jonathan Sanborn 
        ///// Returns the XML for the admin
        ///// </summary>
        ///// <returns>The XElement for the admin</returns>
        //public void GetXMLNode(ref XElement elem)
        //{

        //    XElement loginRecords = new XElement("LoginRecords");

        //    foreach (Login L in LoginRecords)
        //    {
        //        loginRecords.Add(
        //            new XElement("Login",
        //                new XElement("Date", L.Date.ToString()),
        //                new XElement("Duration", L.Duration.ToString())
        //            )
        //        );
        //    }


        //   elem = new XElement("User",
        //                     new XElement("ID", ID),
        //                     new XElement("Type", UserType),
        //                     new XElement("ScreenName", ScreenName),
        //                     new XElement("Name",
        //                         new XElement("First", FirstName),
        //                         new XElement("Last", LastName)),
        //                     new XElement("Password", Password),
        //                     loginRecords
        //                 );
        //}
        #endregion


    }
}
