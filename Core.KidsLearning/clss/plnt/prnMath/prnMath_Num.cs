using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using TORServices.Maths;
using TORServices.Ext;
using Core.KidsLearning.Classed.Exten;
using static TORServices.Maths.extMath;
using TORServices.Drawings;
namespace Core.KidsLearning.clss.plnt
{

    public class prnMath_Num : prnClass
    {
        #region Variables

        int minValue, maxValue;
        int countC = 13;
        List<listNum_A_B> listNum_A_Bs = new List<listNum_A_B>();
        #endregion
        public prnMath_Num()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";//Please convert the following units to be correct. 
           // _ReportToppic = "เขียนชื่อหน่วยนับ และ เลข อุปสรรค ต่อไปนี้ให้ถูกต้อง";
        }
       
       
        int ic = 0;

        #region Print Page PrintFromByNum
        public void PrintFromByNumOneToThousand(int count = 10, int min = 1, int max = 50)
        {
            _ReportToppic = "เลขไทย อารบิก ตัวหนังสือ";
            minValue = min; maxValue = max;
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = min;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;

                iPageAll = count;

                //  System.Windows.Forms.MessageBox.Show(ic + "");
                if (maxValue > 1000)
                    _printDocument.DefaultPageSettings.Landscape = true;
                else
                    _printDocument.DefaultPageSettings.Landscape = false;
                iPage = 1;
                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromByNumOneToThousandPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }
        }
        protected override void printDocumentNewPage(object sender, PrintPageEventArgs e)
        {
           

            base.printDocumentNewPage(sender, e);

        }
        protected void PrintFromByNumOneToThousandPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);
           

            do
            {

                
                if (ic > 1900)
                {
                    e.Graphics.DrawFillRectangleString(ic.ToString(), fontDetail, solidBrush, pen, new Rectangle(xC, yC, w, h));
                    e.Graphics.DrawFillRectangleString("More then 1900", fontDetail, solidBrush, pen, new Rectangle(xC + w, yC, w*2, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicAndThai(ArabicAndThaiObtion.ArabicToThai), fontDetail, solidBrush, pen, new Rectangle(xC + 3 * w, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicToThaiText(false), fontDetail, solidBrush, pen, new Rectangle(xC + 4 * w, yC, w * 4, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicToEngText(), fontDetail, solidBrush, pen, new Rectangle(xC + 8 * w, yC, w * 4, h));

                }
                else
                {
                    e.Graphics.DrawFillRectangleString(ic.ToString(), fontDetail, solidBrush, pen, new Rectangle(xC, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToRomanNumber(), fontDetail, solidBrush, pen, new Rectangle(xC + w, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicAndThai(ArabicAndThaiObtion.ArabicToThai), fontDetail, solidBrush, pen, new Rectangle(xC + 2 * w, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicToThaiText(false), fontDetail, solidBrush, pen, new Rectangle(xC + 3 * w, yC, w * 3, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicToEngText(), fontDetail, solidBrush, pen, new Rectangle(xC + 6 * w, yC, w * 3, h));
                }
               
               
                ic++;
                yC += h;
            }
            while (yC < e.MarginBounds.Bottom -h &&  ic<= maxValue);
            if (ic > maxValue)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
                _printDocument.DefaultPageSettings.Landscape = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }
     
       /* protected void PrintFromByNumThousandUpPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            int xC = 100;
            int w = 100, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            do
            {
                e.Graphics.DrawFillRectangleString(ic.ToString(), fontDetail, solidBrush, pen, new Rectangle(xC, yC, w, h));
                e.Graphics.DrawFillRectangleString(ic.ToRomanNumber(), fontDetail, solidBrush, pen, new Rectangle(xC + w, yC, w, h));
                e.Graphics.DrawFillRectangleString(ic.ToArabicAndThai(ExtMath_Number.ArabicAndThaiObtion.ArabicToThai), fontDetail, solidBrush, pen, new Rectangle(xC + 2 * w, yC, w, h));
                e.Graphics.DrawFillRectangleString(ic.ToArabicToThaiText(false), fontDetail, solidBrush, pen, new Rectangle(xC + 3 * w, yC, w * 2, h));
                e.Graphics.DrawFillRectangleString(ic.ToArabicToEngText(), fontDetail, solidBrush, pen, new Rectangle(xC + 5 * w, yC, w * 4, h));
                ic++;
                yC += h;
            }
            while (yC < e.MarginBounds.Bottom - h && ic <= maxValue);
            if (ic > maxValue)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
                _printDocument.DefaultPageSettings.Landscape = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }*/
        #endregion

        #region Print Page MorethanLess


        public void PrintFromMorethanLess(int count = 10, int min = 1, int max = 50)
        {
      
            _ReportToppic = "เติม >(มากกว่า) หรือ < (น้อยกว่า) ในช่องว่าง";
            minValue = min; maxValue = max;
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
               /* listNum_A_Bs = new List<listNum_A_B>();
                List<Task> tasks = new List<Task>();

                for (int i = 0; i <= iPageAll + 1; i++)
                {
                    tasks.Add(Task.Factory.StartNew(() =>
                    {
                        for (int p = 0; p <= countC; p++)
                        {
                            int a = RandomNumberGenerator.GetInt32(minValue, maxValue);
                            //System.Threading.Thread.Sleep(200);
                            int b = RandomNumberGenerator.GetInt32(minValue, maxValue);

                            listNum_A_Bs.Add(new listNum_A_B(a, b));
                        }
                    }));
                }
                Task.WaitAll(tasks.ToArray());*/
                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromMorethanLessPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromMorethanLessPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            for (int i = 0; i <= 10; i++)
            {

               
                   e.Graphics.DrawTOR_MorethanLess(fontDetail, RandomNumberGenerator.GetInt32(minValue, maxValue), RandomNumberGenerator.GetInt32(minValue, maxValue), 250, yC);
             
                   e.Graphics.DrawTOR_MorethanLess(fontDetail, RandomNumberGenerator.GetInt32(minValue, maxValue), RandomNumberGenerator.GetInt32(minValue, maxValue), 500, yC);

              //  e.Graphics.DrawTOR_MorethanLess(fontDetail, this.listNum_A_Bs[ic].A, this.listNum_A_Bs[ic].A, 250, yC);

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

        #region Print Page AddDifNumber
        public void PrintFromAddDifNumber(int count = 10, int min = 1, int max = 50)
        {
            _ReportToppic = "การตั้ง บวก ลบ ตัวเลข";
            minValue = min; maxValue = max;
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = min;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;
                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromAddDifNumberPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }
        }
        
        protected void PrintFromAddDifNumberPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);


            do
            {

                int a = (RandomNumberGenerator.GetInt32(minValue, minValue) % 10) + 1;
                int b = (RandomNumberGenerator.GetInt32(minValue, minValue) % 10) + 1;
                if (a < b)
                {
                    int d = a;
                    a = b;
                    b = d;
                }
                string op = (RandomNumberGenerator.GetInt32(0, 1000) > 500) ? " + " : " - ";
               
                    e.Graphics.DrawString(a + "  " + op + " " + b + "  =  ?",fontDetail,solidBrush, xC, yC);
                    e.Graphics.DrawFillRectangleString(ic.ToString(), fontDetail, solidBrush, pen, new Rectangle(xC, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToRomanNumber(), fontDetail, solidBrush, pen, new Rectangle(xC + w, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicAndThai(ArabicAndThaiObtion.ArabicToThai), fontDetail, solidBrush, pen, new Rectangle(xC + 2 * w, yC, w, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicToThaiText(false), fontDetail, solidBrush, pen, new Rectangle(xC + 3 * w, yC, w * 3, h));
                    e.Graphics.DrawFillRectangleString(ic.ToArabicToEngText(), fontDetail, solidBrush, pen, new Rectangle(xC + 6 * w, yC, w * 3, h));
                


           
                yC += h;
            }
            while (yC < e.MarginBounds.Bottom - h && ic <= maxValue);
            if (ic > maxValue)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
                _printDocument.DefaultPageSettings.Landscape = false;
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

        #region Print Page EvenOddNumber


        public void PrintFromEvenOddNumber(int count = 10, int min = 1, int max = 50)
        {

            _ReportToppic = "เติมคำว่าคู่ หรือ คี่ ในช่องว่าง ตามจำนวนคู่ หรือ จำนวนคี่";
            minValue = min; maxValue = max;
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromEvenOddNumberPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromEvenOddNumberPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150,xC = 100;
            int w = 100, h = 50;
            for (int i = 0; i <= countC; i++)
            {

                xC = 100;
                e.Graphics.DrawFillRectangleString(RandomNumberGenerator.GetInt32(minValue, maxValue).ToString(), fontDetail,new SolidBrush(Color.White),new Pen(Color.Black, 2), new Rectangle(xC, yC, w+30,h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + w + 30, yC, w , h));
                ic++;
                xC = xC + 2*w + 60;
                e.Graphics.DrawFillRectangleString(RandomNumberGenerator.GetInt32(minValue, maxValue).ToString(), fontDetail, new SolidBrush(Color.White), new Pen(Color.Black, 2), new Rectangle(xC, yC, w + 30, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + w + 30, yC, w , h));

                yC += 55;
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

        #region Print Page SortNumber

        int MaxCount;
        public void PrintFromSortNumber(int count = 10,int maxCount = 10, int min = 1, int max = 50)
        {
          //  _ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข เรียงลำดับตัวเลข และ บอกค่าต่ำสุด ค่าสูงสุด และ ค่ากลาง";
            _ReportToppic = "เรียงลำดับตัวเลขจากมากไปหาน้อย พร้อมทั้ง บอกค่าต่ำสุด ค่าสูงสุด และ ค่ากลาง\n *** ค่ากลาง หาก ข้อมูลมีจำนวนคี่ จะมีค่ากลางตัวเดียว หากข้อมูลมีจำนวนคู่ จะมีค่ากลาง 2 ตัว";
            minValue = min; maxValue = max;MaxCount = maxCount;
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromSortNumberPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromSortNumberPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 3; i++)
            {


                string str = " จากข้อมูลตัวเลข ";
                for (int ip = 1; ip <= RandomNumberGenerator.GetInt32(Convert.ToInt32(MaxCount * 0.5), MaxCount) ;ip++)
                    {
                    str += RandomNumberGenerator.GetInt32(minValue, maxValue) + "  "; 
                   }
                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC, yC);

                yC += 20;
                e.Graphics.DrawString("เรียงลำดับได้ ดังนี้ ", fontDetail, new SolidBrush(Color.Black), xC, yC);
                yC += h+20;
                e.Graphics.DrawLine(new Pen(Color.Black,2),xC,yC,xC+500,yC);
                yC += h;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 500, yC);
                yC += 20;

                e.Graphics.DrawFillRectangleStringRectangle("ค่าต่ำสุด", fontDetail, new SolidBrush(Color.White), new Pen(Color.Black, 2), new Rectangle(xC, yC, w + 30, h),200);
                yC += h;
                e.Graphics.DrawFillRectangleStringRectangle("ค่าต่ำสุด", fontDetail, new SolidBrush(Color.White), new Pen(Color.Black, 2), new Rectangle(xC, yC, w + 30, h), 200);
                yC += h;
                e.Graphics.DrawFillRectangleStringRectangle("ค่าต่ำสุด", fontDetail, new SolidBrush(Color.White), new Pen(Color.Black, 2), new Rectangle(xC, yC, w + 30, h), 200);
                yC += 2*h;
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
