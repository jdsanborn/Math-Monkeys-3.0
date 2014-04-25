/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: ListOfJunglesHandler
 * -created automatically when called this will display current jungles supported by the Math Monkeys application
 * in our case it supports the addition and subtraction only for now. 
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
    // * To Clarify: LisOfJunglesHandler creates a list of Jungles supported by the program for now
    // * */

    ////Coder of this class - Mary Venegas
    //class ListOfJunglesHandler : XMLHandler
    //{
    //    //get a list of only admins
    //    //public List<Jungle> ListOfJungle = new List<Jungle>();

    //    //XDocument ListOfJungleDoc;
    //    //an appropiate name for the file we will be using 
    //    //private string _fileName = "Jungles.xml";
    //    //NumberofReports available

    //    public ListOfJunglesHandler() //Constructor
    //    {
    //        WriteJungleDoc();
    //    }
    //    //When the program start ther will be not xml file existen therefore we create one with a default administrator
    //    public void WriteJungleDoc()
    //    {
    //        ListOfJungleDoc = new XDocument(
    //                       new XElement("Jungles",
    //                           new XElement("Jungle",
    //                               new XElement("JungleName", "The Addition Jungle"),
    //                               new XElement("Operation", "+")),
    //                            new XElement("Jungle",
    //                               new XElement("JungleName", "The Subtraction Jungle"),
    //                               new XElement("Operation", "-"))
    //                               ));
    //        ListOfJungleDoc.Save(_fileName);
    //    }
    //    // }

    //    public List<Jungle> ReadFile()
    //    {
    //        //making sure we are reading into an empty list
    //        ListOfJungle.Clear();

    //        if (File.Exists(_fileName) == true)
    //        {
    //            //System.Diagnostics.Debug.Write("JungleList Exists");
    //            try
    //            {
    //                xmlDocument = XDocument.Load(_fileName);
    //                ListOfJungle = xmlDocument.Descendants("Jungle").Select(d =>

    //                     new Jungle
    //                     {
    //                         JungleName = d.Element("JungleName").Value,
    //                         MathOperation = Convert.ToChar(d.Element("Operation").Value)
    //                     }).ToList();
    //            }
    //            catch (System.ArgumentOutOfRangeException e)
    //            {
    //                //System.Diagnostics.Debug.Write("Out of range for read");
    //            }
    //        }
    //        // System.Diagnostics.Debug.Write("This Jungle has "+ ListOfJungle.Count);
    //        return ListOfJungle;
    //    }

    //}
}
