/**********************************************************
 * Author: Jonathan Sanborn
 * Date: 30 March 2014
 * FileName: Login.cs
 * Struct: Login
 * Summary: An Interface for the various users types
 * 
 * ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
    /// <summary>
    /// Jonathan Sanborn
    /// 
    /// A Login Record for a user
    /// </summary>
    [XmlType("Login")]
    public struct Login
    {
  
        [XmlElement("Date")]
        public DateTime? Date;
        [XmlElement("Duration")]
        public TimeSpan? Duration;


        #region Constructors

        public Login(DateTime? date)
        {
            Date = date;
            Duration = TimeSpan.Zero;
        }

        public Login(DateTime? date, TimeSpan? duration)
        {
            Date = date;
            Duration = duration;
        }

        #endregion


    }
}
