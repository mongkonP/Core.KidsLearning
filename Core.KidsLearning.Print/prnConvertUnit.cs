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
    public  class prnConvertUnit:prnClass
    {
        #region Variables


        private static List<string> _unit = new List<string>() { "m", "g", "s", "A", "K", "cd", "mol", "Hz", "N", "J", "W", "Pa", "V", "Ω", "F", "", "", "", "" };
        private static List<string> _prefix = new List<string>() { "E", "P", "T", "B", "M", "k", "da", "d", "c", "m", "n", "p" };

        #endregion
        public prnConvertUnit()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับค่าของหน่วยนับ ";//Please convert the following units to be correct. 
            _ReportToppic = "เขียนชื่อหน่วยนับ และ เลข อุปสรรค ต่อไปนี้ให้ถูกต้อง";
        }
        protected override  void printDocumentNewPage(object sender, PrintPageEventArgs e)
        {
            base.printDocumentNewPage(sender,e);

            int xgf = e.MarginBounds.Right + 30;

            //เส้นแนวตั้ง
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(120, 150), new Point(120, 900));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(220, 150), new Point(220, 900));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(470, 150), new Point(470, 900));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(720, 150), new Point(720, 900));
            //แนวนอน


        }

        #region Print Page Event
        protected override void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150;
            for (int i = 0; i < 15; i++)
            {

                if (i == 0)
                {
                    e.Graphics.DrawString("Value ", fontHeader, Brushes.Black, 130, yC + 20);
                    e.Graphics.DrawString("คำอ่าน/ความหมาย ", fontHeader, Brushes.Black, 250, yC + 20);
                    e.Graphics.DrawString("ค่าที่ได้ ", fontHeader, Brushes.Black, 530, yC + 20);

                }
                else
                {
                    e.Graphics.DrawString(_prefix[RandomNumberGenerator.GetInt32(0, _prefix.Count - 1)] + " " + _unit[RandomNumberGenerator.GetInt32(0, _unit.Count - 1)], fontHeader, Brushes.Black, 130, yC + 20);
                }
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(120, yC), new Point(720, yC));

                yC += 50;
            }
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(120, yC), new Point(720, yC));

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
