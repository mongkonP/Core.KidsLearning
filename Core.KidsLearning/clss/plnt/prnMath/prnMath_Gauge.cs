using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.KidsLearning.clss.plnt
{
   public  class prnMath_Gauge:prnClass
    {

        #region Variables

        int minValue, maxValue;
        int countC = 13;
        List<string> converts = new List<string>() { "1 วัน=24 ชั่วโมง", "1 ชั่วโมง=60 นาที", "1 นาที=60 วินาที" };
        #endregion
        public prnMath_Gauge()
        {
            _ReportHeader = "การทดสอบ เกี่ยวกับ มาตรวัด ";//Please convert the following units to be correct. 

        }


        int ic = 0;
      private bool RandomDregee ;
       
        #region Print Page Gauge_1

  
        public void PrintFromGauge_1(int count = 10,bool randomDregee = false)
        {
            RandomDregee = randomDregee;
            _ReportToppic = "วัดความยาว ต่อไปนี้ ";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromGauge_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromGauge_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 5; i++)
            {
               
               // e.Graphics.DrawString("วัดความยาว ต่อไปนี้ ", fontDetail, new SolidBrush(Color.Black), new RectangleF(xC - 50, yC, 750, 80));
                yC += 50;

                using (Pen pen = new Pen(Color.Black, 3))
                {

                    pen.StartCap =LineCap.RoundAnchor;
                    pen.EndCap = LineCap.RoundAnchor;
                    int x, y;
                    if (!RandomDregee)
                    {
                        x = xC + RandomNumberGenerator.GetInt32(150, 600);
                        e.Graphics.DrawLine(pen, xC + 80, yC,x , yC);
                        e.Graphics.DrawString("A", fontDetail, new SolidBrush(Color.Black), xC + 60, yC - 20);
                        e.Graphics.DrawString("B", fontDetail, new SolidBrush(Color.Black), x, yC-20);
                    }
                    else
                    {
                        x = xC + RandomNumberGenerator.GetInt32(150, 600);
                        y = yC + RandomNumberGenerator.GetInt32(-40, 40);
                        e.Graphics.DrawLine(pen, xC + 80, yC, x, y);
                        e.Graphics.DrawString("A", fontDetail, new SolidBrush(Color.Black), xC + 60, yC - 20);
                        e.Graphics.DrawString("B", fontDetail, new SolidBrush(Color.Black), x, y-20);

                    }

                }
                yC += 50;
                e.Graphics.DrawString("ความยาว ___________ เซนติเมตร __________ มิลลิเมตร", fontDetail, new SolidBrush(Color.Black), xC + 80, yC);
                  
               
                yC += 60;

            }

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
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

        #endregion


        #region Print Page Gauge_Degree_1


        public void PrintFromGauge_Degree_1(int count = 10)
        {
         
            _ReportToppic = "วัดมุม ต่อไปนี้ ";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromGauge_Degree_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromGauge_Degree_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 5; i++)
            {

                yC += 100;


                using (Pen pen = new Pen(Color.Black, 3))
                {

                    pen.StartCap = LineCap.RoundAnchor;
                    pen.EndCap = LineCap.ArrowAnchor;

                   
                    e.Graphics.DrawLine(pen, xC + 200, yC, 600, yC);
                    e.Graphics.DrawLine(pen, xC + 200, yC, xC + 200 + RandomNumberGenerator.GetInt32(-150, 200), yC + -100);


                }

               
                yC += 20;
                e.Graphics.DrawString("มุม ___________ องศา ", fontDetail, new SolidBrush(Color.Black), xC + 180, yC);


                yC += 80;

            }

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
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

        #endregion

        #region Print Page Gauge_Degree_2


        public void PrintFromGauge_Degree_2(int count = 10)
        {

            _ReportToppic = "ลากเส้นตามมุม ต่อไปนี้ และทำลูกศรทิศทาง";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromGauge_Degree_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromGauge_Degree_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 5; i++)
            {

                yC += 80;
                

                using (Pen pen = new Pen(Color.Black, 3))
                {

                    pen.StartCap = LineCap.RoundAnchor;
                    pen.EndCap = LineCap.ArrowAnchor;
                    e.Graphics.DrawLine(pen, xC + 200, yC, 600, yC);
                }
                e.Graphics.DrawString($"มุม {RandomNumberGenerator.GetInt32(30, 170)} องศา ", fontDetail, new SolidBrush(Color.Black), xC + 200, yC);





                yC += 80;

            }

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
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

        #endregion
    }
}
