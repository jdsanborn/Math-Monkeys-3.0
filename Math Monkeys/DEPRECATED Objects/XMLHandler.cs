/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name:
 * 
 * 
 * Modified 
 * 15 March 2014 Jonathan Sanborn
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace Math_Monkeys
{
    public class XMLHandler
    {
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
       

        

        public XMLHandler() // constructor
        {
            xmlDocument = new XDocument();
            fileName = "Empty";
            fileIsOpen = false;
            fileIsValid = false;
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
    }
}
