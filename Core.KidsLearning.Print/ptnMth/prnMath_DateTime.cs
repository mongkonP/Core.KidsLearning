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
   public  class prnMath_DateTime:prnClass
    {

        #region Variables

        int minValue, maxValue;
        int countC = 13;
        List<string> converts = new List<string>() { "1 วัน=24 ชั่วโมง", "1 ชั่วโมง=60 นาที", "1 นาที=60 วินาที" };
        #endregion
        public prnMath_DateTime()
        {
            _ReportHeader = "การทดสอบ เกี่ยวกับ วัน เวลา ";//Please convert the following units to be correct. 

        }


        int ic = 0;

        #region Print Page DateTime_1


        public void PrintFromDateTime_1(int count = 10)
        {

            _ReportToppic = "ให้ตอบคำถาม ต่อไปนี้";

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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromDateTime_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromDateTime_1PrintPage(object sender, PrintPageEventArgs e)
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
                string name =Exts.ManName();
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

                payAll.Add(mc);
                for (int a = 0; a < payM.Count - 1; a++)
                {
                    int mm = payM[a];
                    if (!payAll.Contains(mm) && mm > mc)
                        payAll.Add(mc);
                    /* if (a < payM.Count)
                     {
                         if (mm < mc & payM[a + 1] > mc)
                         {

                         }
                     }*/

                }


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

        #region Print Page DateTime_2

        int Leval;
        public void PrintFromDateTime_2(int count = 10,int level = 3)
        {

            _ReportToppic = "ให้วาดเข็มนาฬิกาด้วยไม้บรรทัด และ ตอบคำถาม ต่อไป นี้ ต่อไปนี้";
            Leval = level;
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromDateTime_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromDateTime_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            int yC = 120, xC = 100;
            for (int i = 0; i < 5; i++)
            {

                e.Graphics.DrawClock(RandomNumberGenerator.GetInt32(0, 12), RandomNumberGenerator.GetInt32(0, 60), RandomNumberGenerator.GetInt32(0, 60), xC, yC);
                e.Graphics.DrawClock(xC + 450, yC);
                string str = "นาฬิกาบอกเวลา ____:____:____";
                string t  = "";
                if (Leval == 0)
                {
                    t = $"{RandomNumberGenerator.GetInt32(1, 30)} ชั่วโมง ";
                }
                else if (Leval == 1)
                {
                    t = $"{ RandomNumberGenerator.GetInt32(1, 30)} ชั่วโมง {RandomNumberGenerator.GetInt32(1, 60)} นาที ";
                }
                else if (Leval == 2)
                {
                    t = $"{RandomNumberGenerator.GetInt32(1, 30)} ชั่วโมง {RandomNumberGenerator.GetInt32(1, 60)} นาที {RandomNumberGenerator.GetInt32(1, 60)} วินาที ";
                }
                else if (Leval == 3)
                {
                    int a = RandomNumberGenerator.GetInt32(1, 3000);
                    if (a > 0 && a < 1000)
                    {
                        t = $"{RandomNumberGenerator.GetInt32(1, 30)} ชั่วโมง ";
                    }
                    else if (a >= 1000 && a < 2000)
                    {
                        t = $"{ RandomNumberGenerator.GetInt32(1, 30)} ชั่วโมง {RandomNumberGenerator.GetInt32(1, 60)} นาที ";
                    }
                    else
                    { 
                       t = $"{RandomNumberGenerator.GetInt32(1, 30)} ชั่วโมง {RandomNumberGenerator.GetInt32(1, 60)} นาที {RandomNumberGenerator.GetInt32(1, 60)} วินาที ";
                    }
                 
                }
                str += "\n" + ((RandomNumberGenerator.GetInt32(0, 1000) > 500) ?  "ย้อนกลับไปอีก " + t  : $"อีก {t } ข้างหน้า");
                str += "\nจะเป็นเวลา ____:____:____";
                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC + 200, yC+50);


                yC += 170;

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

        #region Print Page DateTime_AD_BE


        public void PrintFromDateTime_AD_BE(int count = 10)
        {

            _ReportToppic = "การแปลง พ.ศ. (พุทธศักราช) กับ ค.ศ. (คริสต์ศักราช) \n *** พ.ศ. = ค.ศ. + 543 ";

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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromDateTime_AD_BEPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromDateTime_AD_BEPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            int yC = 100, xC = 100;
            for (int i = 0; i < 6; i++)
            {
                string str = "";
                string s = (RandomNumberGenerator.GetInt32(0, 1000)<500)?"พ.ศ.":"ค.ศ.";
                int c = (s == "พ.ศ.") ? RandomNumberGenerator.GetInt32(2525, 2570) : RandomNumberGenerator.GetInt32(1981, 2030);
                str = $" ในปี {s} {c} ตรงกับ {((s == "พ.ศ.") ? "ค.ศ." : "พ.ศ.")} ใด  " +
                    $"\n วิธีทำ ___________________________________________________________________________" +
                    $"\n ________________________________________________________________________________" +
                    $"\n                         ตอบ_______________ #";

                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC + 50, yC + 50);

                yC += 150;

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

        #region Print Page DateTime_AD_BE_1


        public void PrintFromDateTime_AD_BE_1(int count = 10, int level = 3)
        {

            _ReportToppic = $"การนับปีเกิด และ อายุ ";
            Leval = level;
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromDateTime_AD_BE_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromDateTime_AD_BE_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            int yC = 100, xC = 100;
            for (int i = 0; i < 6; i++)
            {
                string str = "";
                string s = (RandomNumberGenerator.GetInt32(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.";
                int c = (s == "พ.ศ.") ? RandomNumberGenerator.GetInt32(2540, 2570) : RandomNumberGenerator.GetInt32(2000, 2030);
                string name = Exts.ManName();
                if (Leval == 0)
                {
                    str = $" ในปี {s} {c} {name} อายุ {RandomNumberGenerator.GetInt32(5, 20)} ปี { name } เกิด ปี {((RandomNumberGenerator.GetInt32(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.")}  ใด ";
                }
                else if (Leval == 1)
                {
                    str = $"{ name } เกิด ปี {s} {c}  ในปี {s} {RandomNumberGenerator.GetInt32(c+2, c+30)} {name} จะอายุเท่าใด ";
                }
                else
                {
                    int ccc = RandomNumberGenerator.GetInt32(0, 1000) ;
                    if (ccc > 500)
                    {
                        str = $" ในปี {s} {c} {name} อายุ {RandomNumberGenerator.GetInt32(5, 20)} ปี { name } เกิด ปี {((RandomNumberGenerator.GetInt32(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.")}  ใด ";
                    }
                   else
                    {
                        str = $"{ name } เกิด ปี {s} {c}  ในปี {s} {RandomNumberGenerator.GetInt32(c + 2, c + 30)} {name} จะอายุเท่าใด ";
                    }
                    
                }


                   str+= $"\n วิธีทำ ___________________________________________________________________________" +
                    $"\n ________________________________________________________________________________" +
                    $"\n                         ตอบ_______________ #";

                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC + 50, yC + 50);

                yC += 150;

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
