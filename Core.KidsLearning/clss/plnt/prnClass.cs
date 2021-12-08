using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.clss.plnt
{
    public class prnClass
    {
        #region Variables

        protected PrintDocument _printDocument = new PrintDocument();
        protected  string _ReportHeader;
        protected  string _ReportToppic;

        protected Font fontHeader = new Font("Angsana New", 16, FontStyle.Bold);
        protected Font fontDetail = new Font("Angsana New", 16);


        protected System.Drawing.StringFormat strFormat = new StringFormat()
        { 
        Alignment = StringAlignment.Near,LineAlignment= StringAlignment.Center,Trimming = StringTrimming.EllipsisCharacter
        }; //Used to format the grid rows.

        protected int iPage = 1;
        protected int iPageAll = 10;
        protected bool bFirstPage = false; //Used to check whether we are printing first page
        protected bool bNewPage = false;// Used to check whether we are printing a new page
        //Whether more pages have to print or not
        protected bool bMorePagesToPrint = false;

        #endregion


      //  protected Random r = new Random();
        public virtual void PrintForm(int count = 10)
        {
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
        
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;
               
                _printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }


        protected virtual void printDocumentNewPage(object sender, PrintPageEventArgs e)
        {
           // System.Windows.Forms.MessageBox.Show(_ReportHeader);
            //Draw Header
            //  string strToppic = "แปลงหน่วยนับ ต่อไปนี้ให้ถูกต้อง";
            e.Graphics.DrawString(_ReportHeader, fontHeader, Brushes.Black, 300, e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader, fontHeader, e.MarginBounds.Width).Height - 13);
            e.Graphics.DrawString(_ReportToppic, fontHeader, Brushes.Black, 100, 90);
            //Draw Footer
            e.Graphics.DrawString("test date ......./......./..........   by............................................", fontHeader, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 40);

        }

        #region Print Page Event
        protected virtual void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
           /* if (bFirstPage) printDocumentNewPage(sender, e);

            System.Windows.Forms.MessageBox.Show(_ReportHeader);

            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;
            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;*/
        }
        #endregion


    }
}
