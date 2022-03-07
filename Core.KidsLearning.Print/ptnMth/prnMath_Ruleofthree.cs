using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.Print
{
  public  class prnMath_Ruleofthree : prnClass
    {

        #region Variables

        int minValue, maxValue;
        int countC = 13;
        // List<listNum_A_B> listNum_A_Bs = new List<listNum_A_B>();
        #endregion
        public prnMath_Ruleofthree()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ บัญญัติไตรยางศ์ ";

        }


        int ic = 0;
        #region Print Page Ruleofthree_1


        public void PrintFromRuleofthree_1(int count = 10)
        {

            _ReportToppic = "ให้เขียนเศษส่วนให้เป็น สมการ และ หาค่าตัวแปร";
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;

            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromRuleofthree_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromRuleofthree_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 8; i++)
            {

                int a = RandomNumberGenerator.GetInt32(1, 10);
                int b = a* RandomNumberGenerator.GetInt32(1, 5);
                int _e = RandomNumberGenerator.GetInt32(1, 5);
                int d = _e*b;
                int c = a * _e;
                string _a ="", _b = "", _c = "", _d = "";
                int f = RandomNumberGenerator.GetInt32(1, 1000);
                if (f <= 250)
                {
                    _a = "A"; _b = b.ToString();_c = c.ToString();_d = d.ToString();
                }
                else if (f > 250 && f<=500)
                {
                    _a = a.ToString(); _b = "B"; _c = c.ToString(); _d = d.ToString();
                }
                else if (f > 500 && f <= 750)
                {
                    _a = a.ToString(); _b = b.ToString(); _c ="C"; _d = d.ToString();
                }
                else if (f > 750)
                {
                    _a = a.ToString(); _b = b.ToString(); _c = c.ToString(); _d = "D";
                }
                e.Graphics.DrawFraction( _a, _b, xC + 10, yC);
                e.Graphics.DrawString(" = ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 80, yC + 15);
                e.Graphics.DrawFraction( _c, _d, xC + 80, yC);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC +200, yC+25, 700, yC+ 25);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 200, yC+55, 700, yC+55);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 200, yC+85, 700, yC+85);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 200, yC + 115, 700, yC + 115);
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
