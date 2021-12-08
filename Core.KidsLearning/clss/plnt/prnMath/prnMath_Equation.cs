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
using static Core.KidsLearning.Classed.Maths;

namespace Core.KidsLearning.clss.plnt
{
   public class prnMath_Equation:prnClass
    {
        #region Variables

        int minValue, maxValue;
        int countC = 13;
        // List<listNum_A_B> listNum_A_Bs = new List<listNum_A_B>();
        #endregion
        public prnMath_Equation()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ สมการ ";//Please convert the following units to be correct. 
    
        }

        OperatorSelect operatorSelect1;
        int ic = 0;
    private bool HaveGuideline;
        #region Print Page Equation_1

    
        public void PrintFromEquation_1(int count = 10,bool haveguideline = true)
        {

            _ReportToppic = "ให้เขียนสมการ พร้อมทั้งหาค่า จากประโยค ต่อไปนี้";
            HaveGuideline = haveguideline;
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromEquation_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromEquation_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 8; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.strType);
                
               // int cAll = RandomNumberGenerator.GetInt32(0, 5);
                string name = Exts.ManName();
                int c = (strType_.Count - 1 > 0) ? RandomNumberGenerator.GetInt32(0, strType_.Count - 1) : 0;
                string s = strType_[c];
                int _mc = RandomNumberGenerator.GetInt32(1, 5);
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง "+ s + _mc + " ชาม  คิดเป็นเงินเท่าใด ? \n     สมการ";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), xC + 10, yC );

                if (HaveGuideline)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 30, 100, 30));
                    e.Graphics.DrawString(" x ", fontDetail, new SolidBrush(Color.Black), xC + 195, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 220, yC + 30, 100, 30));
                    e.Graphics.DrawString(" = ", fontDetail, new SolidBrush(Color.Black), xC + 320, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 350, yC + 30, 100, 30));
                }
                else
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 90, yC +60, xC + 700, yC + 60);
                }
                
                yC += 100;

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

        #region Print Page Equation_2

        public void PrintFromEquation_2(int count = 10, bool haveguideline = true)
        {

            _ReportToppic = "ให้เขียนสมการ พร้อมทั้งหาค่า จากประโยค ต่อไปนี้";
            HaveGuideline = haveguideline;
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromEquation_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromEquation_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 8; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.strType);

                // int cAll = RandomNumberGenerator.GetInt32(0, 5);
                string name = Exts.ManName();
                int c = (strType_.Count - 1 > 0) ? RandomNumberGenerator.GetInt32(0, strType_.Count - 1) : 0;
                string s = strType_[c];
                int _mc = RandomNumberGenerator.GetInt32(1, 5);
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง " + s + _mc + " ชาม  คิดเป็นเงินเท่าใด ? \n     สมการ";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                if (HaveGuideline)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 30, 100, 30));
                    e.Graphics.DrawString(" x ", fontDetail, new SolidBrush(Color.Black), xC + 195, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 220, yC + 30, 100, 30));
                    e.Graphics.DrawString(" = ", fontDetail, new SolidBrush(Color.Black), xC + 320, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 350, yC + 30, 100, 30));
                }
                else
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 90, yC + 60, xC + 700, yC + 60);
                }

                yC += 100;

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

        #region Print Page Equation_AddSub_1

        public void PrintFromEquation_AddSub_1(int count = 10,int min = 1,int max = 20, OperatorSelect operatorSelect= OperatorSelect.Addition)
        {

            _ReportToppic = "ให้หาค่าต่อไปนี้";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                operatorSelect1 = operatorSelect;
                minValue = min;maxValue = max;
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = count;
                iPage = 1;

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromEquation_AddSub_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromEquation_AddSub_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 60, h = 35;
            for (int i = 0; i < 10; i++)
            {

                string s = Equation_AddSub(minValue, maxValue, operatorSelect1);
                e.Graphics.DrawString(s, fontDetail, new SolidBrush(Color.Black), xC + 10, yC);
                e.Graphics.DrawRectangle(new Pen(Color.Black,2), xC + 15+ e.Graphics.MeasureString(s, fontDetail).Width, yC-3, w, h);


                 s = Equation_AddSub(minValue, maxValue, operatorSelect1);
                e.Graphics.DrawString(s, fontDetail, new SolidBrush(Color.Black), xC + 400, yC);
                e.Graphics.DrawRectangle(new Pen(Color.Black,2), xC + 405 + e.Graphics.MeasureString(s, fontDetail).Width, yC - 3, w, h);
                yC += 50;

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

        #region Print Page PEMDAS_1

        public void PrintFromPEMDAS_1(int count = 10)
        {

            _ReportToppic = "ให้เติมวงเล็บให้ถูกต้อง และ คำนวณคำตอบ ";
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromPEMDAS_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }
        List<string> lstOP_1 = new List<string>() { "+_x", "x_+", "-_x", "x_-", "+_÷", "÷_+", "-_÷", "÷_-" };
        string GetPEMDAS_1()
        {
            string op = lstOP_1[RandomNumberGenerator.GetInt32(0, lstOP_1.Count - 1)];
            int a = RandomNumberGenerator.GetInt32(1, 10);
            int b = RandomNumberGenerator.GetInt32(1, 10);
            int c = RandomNumberGenerator.GetInt32(1, 10);
            int d = b * c;
            string str = "";
            if (op == "+_x")
            {
                str = $"{a} + {b} x {c} = ?";
            }
            else if (op == "x_+")
            {
                str = $"{b} x {c} + {a} =? ";
            }
            else if (op == "-_x")
            {
                str = $"{a} - {b} x {c} = ? ";
            }
            else if (op == "x_-")
            {
                str = $"{b} x {c} - {a} = ? ";
            }
            else if (op == "+_÷")
            {
                str = $"{a} + {d} ÷ {c} = ?";
            }
            else if (op == "÷_+")
            {
                str = $"{d} ÷ {c} + {a} =? ";
            }
            else if (op == "-_÷")
            {
                str = $"{a} - {d} ÷ {c} = ?";
            }
            else if (op == "÷_-")
            {
                str = $"{d} ÷ {c} - {a} =? ";
            }

            str += "\nวิธีทำ ______________________________" +
                    "\n_________________________________" +
                    "\n_________________________________" +
                    "\n_________________________________";

            return str;

        }
        protected void PrintFromPEMDAS_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
    
            int yC = 150, xC = 100;
            
            for (int i = 0; i < 4; i++)
            {

                
               
                e.Graphics.DrawString(GetPEMDAS_1(), fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                e.Graphics.DrawString(GetPEMDAS_1(), fontDetail, new SolidBrush(Color.Black), xC + 400, yC);

                yC += 210;

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


        #region Print Page PEMDAS_2

        public void PrintFromPEMDAS_2(int count = 10)
        {

            _ReportToppic = "ให้เติมวงเล็บให้ถูกต้อง และ คำนวณคำตอบ ";
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

                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromPEMDAS_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }
        List<string> lstOP_2 = 
            new List<string>() { "+_+_x", "+_x_+", "x_+_+",
                                 "+_-_x", "+_x_-", "x_+_-",
                                 "-_+_x", "-_x_+", "x_-_+",
                                "+_+_÷", "+_÷_+", "÷_+_+",
                                 "+_-_÷", "+_÷_-", "÷_+_-",
                                 "-_+_÷", "-_÷_+", "÷_-_+"};
        string GetPEMDAS_2()
        {
            string op = lstOP_2[RandomNumberGenerator.GetInt32(0, lstOP_2.Count - 1)];
            int a = RandomNumberGenerator.GetInt32(1, 10);
            int b = RandomNumberGenerator.GetInt32(1, 10);
            int c = RandomNumberGenerator.GetInt32(1, 10);
            int d = b * c;
            string str = "";
            if (op == "+_x")
            {
                str = $"{a} + {b} x {c} = ?";
            }
            else if (op == "x_+")
            {
                str = $"{b} x {c} + {a} =? ";
            }
            else if (op == "-_x")
            {
                str = $"{a} - {b} x {c} = ? ";
            }
            else if (op == "x_-")
            {
                str = $"{b} x {c} - {a} = ? ";
            }
            else if (op == "+_÷")
            {
                str = $"{a} + {d} ÷ {c} = ?";
            }
            else if (op == "÷_+")
            {
                str = $"{d} ÷ {c} + {a} =? ";
            }
            else if (op == "-_÷")
            {
                str = $"{a} - {d} ÷ {c} = ?";
            }
            else if (op == "÷_-")
            {
                str = $"{d} ÷ {c} - {a} =? ";
            }

            str += "\nวิธีทำ ______________________________" +
                    "\n_________________________________" +
                    "\n_________________________________" +
                    "\n_________________________________";

            return str;

        }
        protected void PrintFromPEMDAS_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            int yC = 150, xC = 100;

            for (int i = 0; i < 4; i++)
            {



                e.Graphics.DrawString(GetPEMDAS_2(), fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                e.Graphics.DrawString(GetPEMDAS_2(), fontDetail, new SolidBrush(Color.Black), xC + 400, yC);

                yC += 210;

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



        #region Print Page Addition_and_Subtraction_1

        /*
         - เลือกเอา + - x ÷ ได้
         - เลือก + - หรือ x ÷
         
         */
        int countAddition_and_Subtraction;
        bool Negative_Integer;
        public void PrintFromAddition_and_Subtraction_1(int count = 10,int min = 1,int max = 10,int countA_S = 2, 
           OperatorSelect operatorSelect= OperatorSelect.Addition  ,bool negative_integer = false )
        {

            _ReportToppic = "ให้หาคำตอบ ต่อไปนี้";
            Negative_Integer = negative_integer;
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
                countAddition_and_Subtraction = countA_S;
                _printDocument.PrintPage += new PrintPageEventHandler((o, e) =>
                {

                    //Loop till all the grid rows not get printed
                    if (bFirstPage) printDocumentNewPage(o, e);
                    // System.Windows.Forms.MessageBox.Show("page " + iPage);
                    int yC = 120, xC = 100;
                    int w = 100, h = 40;
                    for (int i = 0; i < 10; i++)
                    {
                        List<string> strType_ = new List<string>();
                        strType_.AddRange(Exts.strType);

                        // int cAll = RandomNumberGenerator.GetInt32(0, 5);
                        string name = Exts.ManName();
                        int c = (strType_.Count - 1 > 0) ? RandomNumberGenerator.GetInt32(0, strType_.Count - 1) : 0;
                        string s = strType_[c];
                        int _mc = RandomNumberGenerator.GetInt32(1, 5);
                        string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง " + s + _mc + " ชาม  คิดเป็นเงินเท่าใด ? \n     สมการ";
                        e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                        if (HaveGuideline)
                        {
                            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 30, 100, 30));
                            e.Graphics.DrawString(" x ", fontDetail, new SolidBrush(Color.Black), xC + 195, yC + 30);
                            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 220, yC + 30, 100, 30));
                            e.Graphics.DrawString(" = ", fontDetail, new SolidBrush(Color.Black), xC + 320, yC + 30);
                            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 350, yC + 30, 100, 30));
                        }
                        else
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 90, yC + 60, xC + 700, yC + 60);
                        }

                        yC += 100;

                    }

                    if (iPage > iPageAll - 1)
                    {
                        bNewPage = false;
                        bMorePagesToPrint = false;
                    }

                    if (bNewPage)
                    {
                        printDocumentNewPage(o, e);
                    }

                    iPage++;

                    //If more lines exist, print another page.
                    e.HasMorePages = (bMorePagesToPrint) ? true : false;


                });




                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

       /* protected void PrintFromAddition_and_Subtraction_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 10; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.strType);

                // int cAll = RandomNumberGenerator.GetInt32(0, 5);
                string name = Core.KidsLearning.Exts.ManName();
                int c = (strType_.Count - 1 > 0) ? RandomNumberGenerator.GetInt32(0, strType_.Count - 1) : 0;
                string s = strType_[c];
                int _mc = RandomNumberGenerator.GetInt32(1, 5);
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง " + s + _mc + " ชาม  คิดเป็นเงินเท่าใด ? \n     สมการ";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                if (HaveGuideline)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 30, 100, 30));
                    e.Graphics.DrawString(" x ", fontDetail, new SolidBrush(Color.Black), xC + 195, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 220, yC + 30, 100, 30));
                    e.Graphics.DrawString(" = ", fontDetail, new SolidBrush(Color.Black), xC + 320, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 350, yC + 30, 100, 30));
                }
                else
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 90, yC + 60, xC + 700, yC + 60);
                }

                yC += 100;

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
        }*/

        #endregion
    }


}
