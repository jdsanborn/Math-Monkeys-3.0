/**********************************************************
 * Author: Jonathan Sanborn
 * Date: 30 March 2014
 * FileName: IXMLnode.cs
 * Interface: IXMLnode
 * Summary: An Interface for the various users types
 * 
 * ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Math_Monkeys
{
    public interface IXMLnode
    {
        XElement GetXMLNode();
        string ID{get; set;}
    }
}
