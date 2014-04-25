/* April 17, 2014 Jeff Bunce (Jonathan and Harvey created this file)
 * Filename: ReportPrinter.cs
 * Classname: ReportPrinter.cs
 * 
 * Description: Class is used to format data into a nice, ready-for-printing
 * format and then print of reports
 * CSUSM CS 441
 * 
 * 17 April, 2014 Jeff Bunce
 * Added a header (file was created by Jonathan and Harvey)
 * Implementation details from meeting added to description
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace Math_Monkeys
{
    class ReportPrinter
    {


        private Font documentFont;

        public Font DocumentFont
        {
            get { return documentFont; }
            set { documentFont = value; }
        }

        private PaperSize documentPaperSize;

        public PaperSize DocumentPaperSize
        {
            get { return documentPaperSize; }   
            set { documentPaperSize = value; }
        }

        private PrintDocument document;

        public PrintDocument Document
        {
            get { return document; }
            set { document = value; }
        }


        private void init()
        {
            DocumentPaperSize = new PaperSize();
            Document = new PrintDocument();
        }

        public ReportPrinter()
        {

        }

        private void PrintDocument(object sender, PrintPageEventArgs e)
        {

            
        }
        
        


      

    }
}
