using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

//FOR REFACTORING
using System.IO;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Xps.Packaging;
using System.Windows.Documents;

    
namespace Math_Monkeys.Forms
{
    public partial class frmParentReport : System.Windows.Forms.Form
    {
        public frmParentReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //REFACTOR ME
            dtgParentReport.Update();
            System.Windows.Controls.PrintDialog printDialog = new System.Windows.Controls.PrintDialog();
            Nullable<bool> print = printDialog.ShowDialog();
            if (print == true)
            {
                try
                {
                    XpsDocument xpsDocument = new XpsDocument("C:\\FixedDocumentSequence.xps", FileAccess.ReadWrite);
                    FixedDocumentSequence fixedDocSeq = xpsDocument.GetFixedDocumentSequence();
                    printDialog.PrintDocument(fixedDocSeq.DocumentPaginator, "Test print job");
                }
                catch (UnauthorizedAccessException e1)
                {
                    const string message =
                        "Unauthoried to access that printer.";
                    const string caption = "Unauthoried Access";
                    var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                }
                catch (PrintDialogException e2)
                {
                    const string message =
                        "Unknow error occurred.";
                    const string caption = "Error Printing";
                    var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                }
            }
        }

        private void frmParentReport_Load(object sender, EventArgs e)
        {
            //dtgParentReport.Update();
        }

        private void printDocumentParentReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            //this.InvokePaint(dtgParentReport, myPaintArgs);
        }
    }
}
