using Core.KidsLearning.Classed;
using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.KidsLearning.Print
{
   public  class prnMath_Money: prnClass
    {

        #region Variables

       
        int countC = 13;
        int MaxCount;
        #endregion
        public prnMath_Money()
        {

            _ReportHeader = "การทดสอบ เงินๆ ทองๆ ";//Please convert the following units to be correct. 
            
        }


        int ic = 0;
        List<string> lstMoney = new List<string>() { " เหรียญ 1 บาท ", " เหรียญ 2 บาท ", " เหรียญ 5 บาท ", " เหรียญ 10 บาท ", " แบงค์ 20 บาท ", " แบงค์ 50 บาท ", 
            " แบงค์ 100 บาท ", " แบงค์ 500 บาท ", " แบงค์ 1000 บาท " };
        List<string> lstMoneyBye = new List<string>() { " 50 บาท ", " 80 บาท ", " 100 บาท ", " 40 บาท ", " 60 บาท " };
        List<string> lstDetailBye = new List<string>() { " สาคูไส้หมู 15 บาท ", " ขนมเปียกปูน 15 บาท ", " วุ้นมะพร้าว 20 บาท " , " ทองหยอด 25 บาท "
        , " น้ำอัดลม 10 บาท "," ก๋วยเตี๋ยวคั่วไก่ 20 บาท "," แอปเปิ้ล 10 บาท "," สับปะรด 15 บาท "," เทมปุระ 20 บาท "," ราดหน้า 20 บาท ",
            " แกงจืดเต้าหู้ 20 บาท "," ไข่พะโล้ 15 บาท "," ก๋วยจั๊บน้ำข้น 20 บาท "," แกงจืดแตงกวา 20 บาท "," ไข่ลูกเขย 15 บาท "," เอแคลร์ 20 บาท ",
            " แยมโรล 15 บาท "," ผัดกะหล่ำปลี 20 บาท "," ซิฟฟ่อนเค้ก 20 บาท "," ขนมปังลูกเกด 15 บาท "," ฝรั่ง 10 บาท "," แตงโม 15 บาท "
        ," มะม่วง 10 บาท "," ข้าวโพด 15 บาท " ," น้ำอัดลม 10 บาท "," น้ำดื่ม 10 บาท "," น้ำแอปเปิ้ลปั่น 15 บาท "," น้ำส้มปั่น 15 บาท "," น้ำมะม่วงปั่น 15 บาท "," ช็อกโกแลต 20 บาท "};

        #region Print Page Money_1


        public void PrintFromMoney_1(int count = 10)
        {
  
            _ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";
  
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromMoney_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromMoney_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150, xC = 100;
            int w = 100, h = 35;


            // DrawTable
            for (int ip = 0; ip <= 13; ip++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC + 600, yC);
                yC += h;
            }

            yC = 150; xC = 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * 13);
           
            e.Graphics.DrawString("  รายการ   ", fontDetail, new SolidBrush(Color.Black), xC + 20 , yC + 5); xC += 120;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC , yC + h * 13);
            e.Graphics.DrawString("   จำนวน   ", fontDetail, new SolidBrush(Color.Black), xC +20, yC + 5); xC += 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC , yC + h * 13);
            e.Graphics.DrawString("            สมการ ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 220;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * 13);
            e.Graphics.DrawString("  รวมยอดเงิน  ", fontDetail, new SolidBrush(Color.Black), xC +20, yC + 5);
            xC = 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 600, yC, xC + 600, yC + h * 13);
            xC = 100;
            yC += h;
            for (int ip = 1; ip <= 12; ip++)
            {
                xC = 100;
                string m = lstMoney[RandomNumberGenerator.GetInt32(0, lstMoney.Count - 1)];
                e.Graphics.DrawString(m, fontDetail, new SolidBrush(Color.Black), xC , yC + 5);
                xC += 120;
                e.Graphics.DrawString(RandomNumberGenerator.GetInt32(1,10).ToString() + "  " + 
                    new Regex(@"(^.*?\s)\d+", RegexOptions.None).Match(m).Groups[1].Value, fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                
                yC += h;
            }

            /* for (int i = 0; i < 10; i++)
             {


                 string str =Core.KidsLearning.Exts.ManName() +  " มีเงิน ";
                 for (int ip = 1; ip <= RandomNumberGenerator.GetInt32(5,10); ip++)
                 {
                     string m = lstMoney[RandomNumberGenerator.GetInt32(0, lstMoney.Count - 1)];
                     str += m + " จำนวน " + RandomNumberGenerator.GetInt32(1, 10) + " " + new Regex(@"(^.*?\s)\d+", RegexOptions.None).Match(m).Value;
                 }
                 e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC, yC);

                 yC += 20;
                 e.Graphics.DrawString("วิธีทำ# ", fontDetail, new SolidBrush(Color.Black), xC, yC);
                 yC += h + 20;
                 e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 500, yC);
                 yC += h;
                 e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 500, yC);
                 yC += h;
                 e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 500, yC);
                 yC += h;
                 e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 500, yC);


                 yC += 2 * h;
             }*/

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

        #region Print Page Money_2

 
        public void PrintFromMoney_2(int count = 10)
        {

            _ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";

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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromMoney_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromMoney_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 3; i++)
            {


                string str = Exts.ManName() + " มีเงิน ";
                int ccc = 0;
                for (int ip = 1; ip <= RandomNumberGenerator.GetInt32(1, 5); ip++)
                {
                    string m = lstMoney[RandomNumberGenerator.GetInt32(0, lstMoney.Count - 1)];
                    str += m + " จำนวน " + RandomNumberGenerator.GetInt32(1, 10) + " " + new Regex(@"(^.*?\s)\d+", RegexOptions.None).Match(m).Groups[1].Value;
                    ccc++;
                    if (ccc > 2)
                    {
                        str += "\n";
                        ccc = 0;
                    }
                }
                str += "\n รวมมีเงินกี่บาท ?";
                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC, yC);

                yC += 100;
                e.Graphics.DrawString("วิธีทำ# ", fontDetail, new SolidBrush(Color.Black), xC, yC);
                yC += h + 20;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 700, yC);
                yC += h;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 700, yC);
                yC += h;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 700, yC);
                yC += h;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), xC, yC, xC + 700, yC);


                yC += 20;
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
       
        #region Print Page Money_3


        public void PrintFromMoney_3(int count = 10)
        {

            _ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";

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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromMoney_3PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromMoney_3PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 3; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.strType);
              //  System.Windows.Forms.MessageBox.Show(strType_.Count.ToString());
                int cAll = RandomNumberGenerator.GetInt32(0, 5);
                string name = Exts.ManName();
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง ";
                for (int cc = 0; cc <= cAll; cc++)
                {
                    int mc = 0;
                    int c = (strType_.Count - 1 >0)?RandomNumberGenerator.GetInt32(0, strType_.Count - 1):0;
                    string s = strType_[c];
                    int _mc = RandomNumberGenerator.GetInt32(1, 5);
                    _return +=  s + _mc + " ชาม ";
                    string smc;
                    try { smc = new Regex(@"(\d+)", RegexOptions.None).Match(s).Value.Trim(); }
                    catch { smc = ""; }
                    if (smc != "")
                        mc += int.Parse(smc) * _mc;                    strType_.Remove(s);

                }
                _return += name + " ต้องจ่ายตังค์เท่าใด ?";//\n  สมการ \n แสดงวิธีทำ# 
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), new RectangleF(xC-50, yC, 750, 80));
                yC += 75;
                /*e.Graphics.DrawString("สมการ ", fontDetail, new SolidBrush(Color.Black), xC-5, yC-25);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 50, yC, xC + 700, yC);*/

                yC += 35;
                e.Graphics.DrawString("แสดงวิธีทำ# ", fontDetail, new SolidBrush(Color.Black), xC - 10, yC - 25);
                yC -= 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                for (int ii = 0; ii < 6; ii++)
                {
                    yC += 30;
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC+80 , yC, xC + 700, yC);
                }
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC-30*6, xC + 80, yC);
                e.Graphics.DrawString("  รายการ ", fontDetail, new SolidBrush(Color.Black), xC + 80, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC - 30 * 6, xC + 250, yC);
                e.Graphics.DrawString(" จำนวน", fontDetail, new SolidBrush(Color.Black), xC + 250, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 320, yC - 30 * 6, xC + 320, yC);
                e.Graphics.DrawString(" สมการ ", fontDetail, new SolidBrush(Color.Black), xC + 380, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 600, yC - 30 * 6, xC + 600, yC);
                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 600, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 700, yC - 30 * 6, xC + 700, yC);

                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 500, yC  );
                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(xC + 600, yC  , 100, 40));
                yC += 40;

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

        #region Print Page Money_4


        public void PrintFromMoney_4(int count = 10)
        {

            _ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";

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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromMoney_4PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromMoney_4PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 3; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.strType);
                //  System.Windows.Forms.MessageBox.Show(strType_.Count.ToString());
                int cAll = RandomNumberGenerator.GetInt32(0, 5);
                string name = Exts.ManName();
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง ";
                int mc = 0;
                for (int cc = 0; cc <= cAll; cc++)
                {
                    
                    int c = (strType_.Count - 1 > 0) ? RandomNumberGenerator.GetInt32(0, strType_.Count - 1) : 0;
                    string s = strType_[c];
                    int _mc = RandomNumberGenerator.GetInt32(1, 5);
                    _return += s + _mc + " ชาม ";
                    string smc;
                    try { smc = new Regex(@"(\d+)", RegexOptions.None).Match(s).Value.Trim(); }
                    catch { smc = ""; }
                    if (smc != "")
                        mc += int.Parse(smc) * _mc;
                    strType_.Remove(s);

                }
           
                List<int> payM = new List<int>() { 2, 5, 10, 20, 50, 100, 500, 1000 };
                listNum_A_B listA_B = new listNum_A_B();
                //1 2 5 10  20 50 100 500 1000
                List<int> payAll = new List<int>();

               
                int __mc;
                payAll.Add(mc);
                payM.ForEach(mm =>
                {
                    __mc = ((mc / mm) + 1) * mm;
                    if (!payAll.Contains(__mc))
                        payAll.Add(__mc);
                });


                _return += $"  เมื่อ {name} จ่ายเงิน " + payAll[RandomNumberGenerator.GetInt32(0, payAll.Count - 1)] + " บาท แม่ค้าต้องทอนเงินเท่าไหร่ ?";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), new RectangleF(xC - 50, yC, 750, 80));
                yC += 75;
       

                yC += 35;
                e.Graphics.DrawString("แสดงวิธีทำ# ", fontDetail, new SolidBrush(Color.Black), xC - 10, yC - 25);
                yC -= 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                for (int ii = 0; ii < 6; ii++)
                {
                    yC += 30;
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                }
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC - 30 * 6, xC + 80, yC);
                e.Graphics.DrawString("  รายการ ", fontDetail, new SolidBrush(Color.Black), xC + 80, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC - 30 * 6, xC + 250, yC);
                e.Graphics.DrawString(" จำนวน", fontDetail, new SolidBrush(Color.Black), xC + 250, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 320, yC - 30 * 6, xC + 320, yC);
                e.Graphics.DrawString(" สมการ ", fontDetail, new SolidBrush(Color.Black), xC + 380, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 600, yC - 30 * 6, xC + 600, yC);
                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 600, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 700, yC - 30 * 6, xC + 700, yC);

                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 500, yC);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + 600, yC, 100, 30));
                e.Graphics.DrawString("แม่ค้าทอนเงิน                              -                              = ", fontDetail, new SolidBrush(Color.Black), xC + 5, yC + 20);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 20, 100, 30));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 210, yC + 20, 100, 30));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 330, yC + 20, 100, 30));
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

        #region Print Page Money_5


        public void PrintFromMoney_5(int count = 10)
        {

            _ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";

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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromMoney_5PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromMoney_5PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
 
            for (int i = 0; i < 3; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(lstDetailBye);
                //  System.Windows.Forms.MessageBox.Show(strType_.Count.ToString());
                int cAll = RandomNumberGenerator.GetInt32(0, 5);
                string name = Exts.ManName();
                string _return =  $"{name} นำเงินไปโรงเรียน {lstMoneyBye[RandomNumberGenerator.GetInt32(0, lstMoneyBye.Count-1)]} บาท ถ้า {name} ซื้อ " ;
                int mc = 0;
                for (int cc = 0; cc <= cAll; cc++)
                {

                    int c = (strType_.Count - 1 > 0) ? RandomNumberGenerator.GetInt32(0, strType_.Count - 1) : 0;
                    string s = strType_[c];
                    int _mc = RandomNumberGenerator.GetInt32(1, 5);
                    _return += s ;
                    string smc;
                    try { smc = new Regex(@"(\d+)", RegexOptions.None).Match(s).Value.Trim(); }
                    catch { smc = ""; }
                    if (smc != "")
                        mc += int.Parse(smc) * _mc;
                    strType_.Remove(s);

                }

                _return += $" {name} จะต้องจ่ายเงินเท่าไหร่ ? แล้ว  {name} จะเหลือเงินเท่าไหร่ หรือ ต้องยืมเพื่อนอีกเท่าไหร่";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), new RectangleF(xC - 50, yC, 750, 80));
                yC += 75;


                yC += 35;
                e.Graphics.DrawString("แสดงวิธีทำ# ", fontDetail, new SolidBrush(Color.Black), xC - 10, yC - 25);
                yC -= 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                for (int ii = 0; ii < 6; ii++)
                {
                    yC += 30;
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                }
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC - 30 * 6, xC + 80, yC);
                e.Graphics.DrawString("รายการ ", fontDetail, new SolidBrush(Color.Black), xC + 300, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 600, yC - 30 * 6, xC + 600, yC);
                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 600, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 700, yC - 30 * 6, xC + 700, yC);

                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 500, yC);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + 600, yC, 100, 30));
                e.Graphics.DrawString("เงินเหลือ                              -                              = ", fontDetail, new SolidBrush(Color.Black), xC + 5, yC + 20);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 20, 100, 30));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 210, yC + 20, 100, 30));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 330, yC + 20, 100, 30));
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
    }
}
