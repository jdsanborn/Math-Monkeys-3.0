/* *
 * Author: Jonathan Sanborn & Harvey Mercado
 * Date: 22 March 2014
 * FileName: UserType.cs
 * Enumeration: UserType
 * Summary: Enumeration for Containing possible user types
 * 
 * 9 April 2014 Harvey Mercado
 * Updated Comments
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
    /// <summary>
    /// Jonathan Sanborn & Harvey Mercado
    /// 
    /// Class that defines the user type
    /// </summary>
    [XmlType("Type")]
    public enum UserType
    {
        [XmlEnum(Name = "None")]
        None = 0,

        [XmlEnum(Name = "Administrator")]
        Administrator = 1,

        [XmlEnum(Name = "Student")]
        Student = 2
    };
}
