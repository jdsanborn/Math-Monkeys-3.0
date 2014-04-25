/* *
 * Author: Jonathan Sanborn
 * Date: 28 March 2014
 * FileName: Operation.cs
 * Enumeration: Operation
 * Summary: Enumeration for Operations in Math Monkeys
 *
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{

    [XmlType("Operation")]
    public enum Operation
    {
        [XmlEnum(Name = "None")]
        None = 0,
        [XmlEnum(Name = "Addition")]
        Addition = 1,
        [XmlEnum(Name = "Subtraction")]
        Subtraction = 2,
        [XmlEnum(Name = "Multiplication")]
        Multiplication = 3,
        [XmlEnum(Name = "Division")]
        Division = 4
    }

    
   
}
