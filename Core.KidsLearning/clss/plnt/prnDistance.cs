using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.clss.plnt
{
    public static class prnDistance
    {
        #region Variables

        private static PrintDocument _printDocument = new PrintDocument();
        private static string _ReportHeader = "การทดสอบ เกี่ยวกับการใช้ ไม้บรรทัด";

        private static Font fontHeader = new Font("Angsana New", 14, FontStyle.Bold);
        private static Font fontDetail = new Font("Angsana New", 14);


        private static System.Drawing.StringFormat strFormat = new System.Drawing.StringFormat()
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
            Trimming = System.Drawing.StringTrimming.EllipsisCharacter
        }; //Used to format the grid rows.

        private static int iPage = 1;
        private static int iPageAll = 10;
        private static bool bFirstPage = false; //Used to check whether we are printing first page
        private static bool bNewPage = false;// Used to check whether we are printing a new page
        private static List<string> _unit = new List<string>() { "m", "g", "s", "A", "K", "cd", "mol", "Hz", "N", "J", "W", "Pa", "V", "Ω", "F", "", "", "", "" };
        private static List<string> _prefix = new List<string>() { "E", "P", "T", "B", "M", "k", "da", "d", "c", "m", "n", "p" };
        //Whether more pages have to print or not
        private static bool bMorePagesToPrint = false;
        #endregion


        private static Random r = new Random();
        public static void Print_1(int count = 10)
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
                _printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage_1);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }
        public static void Print_2(int count = 10)
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
                _printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage_2);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }
        public static void Print_3(int count = 10)
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
                _printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage_3);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }
        #region Print Page Event

        private static void printDocument_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage || bNewPage)// printDocumentNewPage(sender, e);
            {

                int xgf = e.MarginBounds.Right + 30;
                //Draw Header
                e.Graphics.DrawString(_ReportHeader, fontHeader, Brushes.Black, 300, e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader, fontHeader, e.MarginBounds.Width).Height - 13);

                string strToppic = "เขียนระยะวัดในหน่วย เซนติเมตรให้ถูกต้อง";
                e.Graphics.DrawString(strToppic, fontHeader, Brushes.Black, 100, 90);


                //Draw Footer
                e.Graphics.DrawString("test date ......./......./..........   by............................................", fontHeader, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 50);

            }
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            int v = 50;
            for (int i = 0; i < 6; i++)
            {

                e.Graphics.DrawString(".................................. ", fontHeader, Brushes.Black, 600, yC + 70);
                // e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0), 1), 50, yC, 750, 150);
                e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(r.Next(55, 100), r.Next(yC + 10, yC + 140)), new Point(r.Next(200, 500), r.Next(yC + 10, yC + 140)));

                yC += 150;
            }


            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            // if (bNewPage) printDocumentNewPage(sender, e);



            iPage++;





            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

        private static void printDocument_PrintPage_2(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage || bNewPage)// printDocumentNewPage(sender, e);
            {

                int xgf = e.MarginBounds.Right + 30;
                //Draw Header
                e.Graphics.DrawString(_ReportHeader, fontHeader, Brushes.Black, 300, e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader, fontHeader, e.MarginBounds.Width).Height - 13);

                string strToppic = "วัดระยะตามที่กำหนด โดยกำหนดจุด A เป็นจุดเริ่มต้น และ B เป็นจุดสิ้นสุด";
                e.Graphics.DrawString(strToppic, fontHeader, Brushes.Black, 100, 90);


                //Draw Footer
                e.Graphics.DrawString("test date ......./......./..........   by............................................", fontHeader, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 50);

            }
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            int v = 50;
            for (int i = 0; i < 6; i++)
            {

                e.Graphics.DrawString(r.Next(1, 10) + " เซนติเมตร ", fontHeader, Brushes.Black, 600, yC + 70);
                // e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0), 1), 50, yC, 750, 150);
                e.Graphics.DrawLine(new Pen(Color.Black, 3), new Point(r.Next(55, 100), r.Next(yC + 10, yC + 140)), new Point(r.Next(200, 500), r.Next(yC + 10, yC + 140)));

                yC += 150;
            }


            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            // if (bNewPage) printDocumentNewPage(sender, e);



            iPage++;





            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }
        private static void printDocument_PrintPage_3(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage || bNewPage)// printDocumentNewPage(sender, e);
            {

                int xgf = e.MarginBounds.Right + 30;
                //Draw Header
                e.Graphics.DrawString(_ReportHeader, fontHeader, Brushes.Black, 300, e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader, fontHeader, e.MarginBounds.Width).Height - 13);

                string strToppic = "วัดมุม";
                e.Graphics.DrawString(strToppic, fontHeader, Brushes.Black, 100, 90);


                //Draw Footer
                e.Graphics.DrawString("test date ......./......./..........   by............................................", fontHeader, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 50);

            }
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            int v = 50;
            for (int i = 0; i < 6; i++)
            {

                e.Graphics.DrawString(".........................", fontHeader, Brushes.Black, 480, yC + 70);
                // e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0), 1), 50, yC, 750, 150);
                e.Graphics.DrawLine(new Pen(Color.Black, 3) { EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor }, new Point(220, yC + 120), new Point(400, yC + 120));
                e.Graphics.DrawLine(new Pen(Color.Black, 3) { EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor }, new Point(220, yC + 120), new Point(r.Next(60, 300), yC + 5));

                yC += 150;
            }


            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            // if (bNewPage) printDocumentNewPage(sender, e);



            iPage++;





            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }
        #endregion


    }
}
