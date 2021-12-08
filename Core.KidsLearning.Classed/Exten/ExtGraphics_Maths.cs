using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TORServices.Drawings;
using static Core.KidsLearning.Classed.Maths;

namespace Core.KidsLearning.Classed.Exten
{
  public static  class ExtGraphics_Maths
    {


        #region ป.1

        #region  01_การบอกจำนวนของสิ่งต่าง ๆ และแสดงสิ่งต่าง ๆ ตามจำนวนที่กำหนด 1 ถึง 20  - การอ่าน การเขียนตัวเลขฮินดูอารบิก ตัวเลขไทย และตัวหนังสือแสดงจำนวน 1 ถึง 20 


        #endregion
        #region  02_การบอกจำนวนของสิ่งต่าง ๆ และสิ่งต่าง ๆ ตามจำนวนที่กำหนด 10 20 30 … 100 - การอ่าน การเขียนตัวเลขฮินดูอารบิก ตัวเลขไทย ตัวหนังสือแสดงจำนวน 10 20 30 … 100 


        #endregion
        #region  03_การบอกและแสดงจำนวนนับ 21 ถึง 30 - การเขียน การอ่าน ตัวเลขฮินดูอารบิก ตัวเลขไทย ตัวหนังสือแสดงจำนวนนับ 21 ถึง 30 


        #endregion
        #region  04_การบอกและแสดงจำนวนนับ 31 ถึง 50 - การเขียน การอ่าน ตัวเลขฮินดูอารบิก ตัวเลขไทย ตัวหนังสือ แสดงจำนวนนับ 31 ถึง 50 


        #endregion
        #region  05_การบอกและแสดงจำนวนนับ 51 ถึง 100 - การเขียน การอ่าน ตัวเลขฮินดูอารบิก ตัวเลขไทย ตัวหนังสือ แสดงจำนวนนับ 51 ถึง 100 


        #endregion
        #region  06_หลักและค่าของเลขโดดในแต่ละหลักของจำนวนนับไม่เกิน 100 


        #endregion
        #region  07_การเขียนตัวเลขแสดงจำนวนนับไม่เกิน 100 ในรูปกระจาย 


        #endregion
        #region  08_- การเปรียบเทียบจำนวนสองจำนวนที่มีจำนวนหลักไม่เท่ากัน และไม่เกิน 100 - การเปรียบเทียบจำนวนสองหลักกับจำนวนสองหลักที่เลขโดดในหลักสิบไม่เท่ากัน 


        #endregion
        #region  09_การเปรียบเทียบจำนวนสองหลักกับจำนวนสองหลักที่เลขโดดในหลักสิบเท่ากัน 


        #endregion
        #region  10_การเรียงลำดับจำนวนสามจำนวนที่ไม่เกิน 100 


        #endregion
        #region  11_การเรียงลำดับจำนวนนับไม่เกิน 100 สี่ถึงห้าจำนวน 


        #endregion
        #region  12_- การเขียน การอ่าน ตัวเลขฮินดูอารบิก ตัวเลขไทย ตัวหนังสือ แสดงจำนวนนับ 21 ถึง 100 - หลักและค่าของเลขโดดในแต่ละหลัก ของจำนวนนับไม่เกิน 100 


        #endregion
        #region  13_การบวกที่ผลบวกไม่เกิน 20 


        #endregion
        #region  14_การบวกจำนวนสองหลักกับหนึ่งหลักที่ผลบวกไม่เกิน 100 ไม่มีการทด 


        #endregion
        #region  15_การบวกจำนวนสองหลักกับสองหลักที่ผลบวกไม่เกิน 100 ไม่มีการทด 


        #endregion
        #region  16_การบวกจำนวนสองหลักกับหนึ่งหลักที่ผลบวกไม่เกิน 100 มีการทด 


        #endregion
        #region  17_การหาผลบวกโดยการตั้งบวกที่ผลบวกไม่เกิน 100 และไม่มีการทด 


        #endregion
        #region  18_การหาผลบวกโดยการตั้งบวกที่ผลบวกไม่เกิน 100 และมีการทด 


        #endregion
        #region  19_การหาผลบวกของจำนวนสามจำนวน 


        #endregion
        #region  20_การหาค่าของตัวไม่ทราบค่าในประโยคสัญลักษณ์การบวก 


        #endregion
        #region  21_ทบทวนความรู้เรื่องการบวกจำนวนที่ผลบวกไม่เกิน 100 


        #endregion
        #region  22_ทบทวนการลบที่ตัวตั้งไม่เกิน 20 


        #endregion
        #region  23_การลบจำนวนสองหลักกับจำนวนหนึ่งหลักไม่มีการกระจาย 


        #endregion
        #region  25_การลบจำนวนสองหลักกับจำนวนหนึ่งหลักที่ตัวตั้งไม่เกิน 100 มีการกระจาย 


        #endregion
        #region  26_การลบจำนวนสองหลักกับจำนวนสองหลักที่ตัวตั้งไม่เกิน 100 มีการกระจาย 


        #endregion
        #region  27_การลบจำนวนสองหลักกับจำนวนไม่เกินสองหลักที่ตัวตั้งไม่เกิน 100 ไม่มีการกระจาย โดยการตั้งลบ 


        #endregion
        #region  28_การลบจำนวนสองหลักกับจำนวนไม่เกินสองหลักที่ตัวตั้งไม่เกิน 100 มีการกระจาย โดยการตั้งลบ 


        #endregion
        #region  29_ความสัมพันธ์ของการบวกและการลบ 


        #endregion
        #region  30_การหาค่าของตัวไม่ทราบค่าประโยคสัญลักษณ์การบวกและประโยคสัญลักษณ์การลบของจำนวนสองหลักกับจำนวนหนึ่งหลัก 


        #endregion


        #endregion


        public static void DrawAddDifNumberSol(this Graphics e, OperatorSelect typeOperator, listNum_A_B listNum_A_B, Font fontDetail,  int x, int y)
        {
            // Measure string.
            SizeF stringSize = new SizeF();

            string op = "";
            int b = listNum_A_B.MinValue;
            int a = listNum_A_B.MaxValue;
            int c = 0;
            int ipp = RandomNumberGenerator.GetInt32(1, 2000);
            if (typeOperator == OperatorSelect.Addition ||(typeOperator == OperatorSelect.AddSub && (ipp < 1000)))
            {
                op = " + ";
                
            }
           
            else if (typeOperator == OperatorSelect.Subtraction || (typeOperator == OperatorSelect.AddSub && (ipp >= 1000)))
            {
                op = " - ";
                
            }
            string EQ = a + " " + op + " " + b + " = ?";
            stringSize = e.MeasureString(EQ, fontDetail);

         //   e.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(x, y, w, 140));

            e.DrawString(EQ, fontDetail, Brushes.Black, x , y +10);

           
            string _a = string.Join("  ", a.ToString().ToArray());
            string _b = string.Join("  ", b.ToString().ToArray());

            int _w = (Math.Max((int)e.MeasureString(_a, fontDetail).Width*2, (int)e.MeasureString(_b, fontDetail).Width*2)) + 20;
         

            e.DrawString(_a,fontDetail, Brushes.Black,x+ _w - 20-(int)e.MeasureString(_a, fontDetail).Width,y+70);
            e.DrawString(op, fontDetail, Brushes.Black, x + _w - 10, y + 80);
            e.DrawString(_b, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_b, fontDetail).Width, y + 100);

            int _y = y + (int)e.MeasureString(_b, fontDetail).Height + 110;
            e.DrawLine(new Pen(Brushes.Black, 2), x,_y , x + _w - 20, _y);
            _y += (int)e.MeasureString(_b, fontDetail).Height + 20;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y+5, x + _w - 20, _y+5);



        }

        public static void DrawMultiNumberSol(this Graphics e, listNum_A_B listNum_A_B, Font fontDetail, int x, int y)
        {
            // Measure string.
            SizeF stringSize = new SizeF();

            string op = " x ";
            int b = listNum_A_B.MinValue;
            int a = listNum_A_B.MaxValue;
            int c = 0;
            
            string EQ = a + " " + op + " " + b + " = ?";
            stringSize = e.MeasureString(EQ, fontDetail);

            //   e.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(x, y, w, 140));

            e.DrawString(EQ, fontDetail, Brushes.Black, x, y + 10);


            string _a = string.Join("  ", a.ToString().ToArray());
            string _b = string.Join("  ", b.ToString().ToArray());

            int _w = (Math.Max((int)e.MeasureString(_a, fontDetail).Width * 2, (int)e.MeasureString(_b, fontDetail).Width * 2)) + 20;

            e.DrawString(_a, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_a, fontDetail).Width, y + 70);
            e.DrawString(op, fontDetail, Brushes.Black, x + _w - 10, y + 80);
            e.DrawString(_b, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_b, fontDetail).Width, y + 100);

            int _y = y + (int)e.MeasureString(_b, fontDetail).Height + 140;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            if (b >= 10 )
            {
              //  System.Windows.Forms.MessageBox.Show(b.ToString());
                
                _y += (int)e.MeasureString(_b, fontDetail).Height+20 ;
                e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            }

            if (b >= 100 )
            {
               // System.Windows.Forms.MessageBox.Show(b.ToString());
                _y += (int)e.MeasureString(_b, fontDetail).Height + 20;
                e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            }

            _y += (int)e.MeasureString(_b, fontDetail).Height + 40;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
           // e.DrawString("Ans.", fontDetail, Brushes.Black, x+_w-20 ,_y-40);
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y + 5, x + _w - 20, _y + 5);



        }

        public static void DrawAddDifMultiDivNum(this Graphics e, OperatorSelect typeOperator, listNum_A_B listNum_A_B,Font fontDetail, int min, int max, int x, int y, bool random)
        {

            // Measure string.
            SizeF stringSize = new SizeF();
            
            string op = "";
            int b = listNum_A_B.MinValue;
            int a = listNum_A_B.MaxValue;
            int c = 0;
            if (typeOperator == OperatorSelect.Addition)
            {
                op = " + ";
                c = a + b;
            }
            else if (typeOperator == OperatorSelect.Division)
            {
                op = " ÷ ";

                c = a;
                a = (int)(c / RandomNumberGenerator.GetInt32(1, 50));
                b = (int)(c / a);
                c = a * b;
            }
            else if (typeOperator == OperatorSelect.Subtraction)
            {
                op = " - ";
                c = a - b;
            }
            else if (typeOperator == OperatorSelect.Multiplication)
            {
                op = " x ";
                c = a;
                a = (int)(c / RandomNumberGenerator.GetInt32(1, 50));
                b = (int)(c / a);
                c = a * b;

            }
            else if (typeOperator == OperatorSelect.All)
            {
                int ipp = RandomNumberGenerator.GetInt32(1, 4000);
                if (ipp < 1000)
                {
                    op = " + ";
                    c = a + b;
                }
                else if (ipp >= 1000 && ipp < 2000)
                {
                    op = " - ";
                    c = a - b;
                }
                else if (ipp >= 2000 && ipp < 3000)
                {
                    op = " ÷ ";
                    c = a;
                    a = (int)(c / RandomNumberGenerator.GetInt32(1, 50));
                    b = (int)(c / a);
                    c = a * b;
                }
                else if (ipp >= 3000)
                {
                    op = " x ";
                    c = a;
                    a = (int)(c / RandomNumberGenerator.GetInt32(1, 50));
                    b = (int)(c / a);
                    c = a * b;
                }
            }

            //  System.Windows.Forms.MessageBox.Show(a+ "  "  + b + "  "  + c + "  " + op);

            e.DrawString(" " + op + " ", fontDetail, Brushes.Black, x + 130, y + 10);
            e.DrawString(" = ", fontDetail, Brushes.Black, x + 290, y + 10);

            e.DrawString(a.ToString("n0"), fontDetail, Brushes.Black, x + 120 - e.MeasureString(a.ToString("n0") + " ", fontDetail).Width, y + 10);
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 170, y + 10);
            e.DrawString(c.ToString("n0") + " ", fontDetail, Brushes.Black, x + 350, y + 10);

            if (!random)
            {

                e.DrawFillRectangle(x + 320, y, 120, 40);
            }
            else
            {
                int ipp = RandomNumberGenerator.GetInt32(1, 3000);
                if (ipp < 1000)
                {

                    e.DrawFillRectangle(x, y, 120, 40);

                }
                else if (ipp >= 1000 && ipp < 2000)
                {
                    e.DrawFillRectangle(x + 170, y, 120, 40);
                }
                else if (ipp >= 2000)
                {
                    e.DrawFillRectangle(x + 320, y, 120, 40);
                }

            }


        }


        public static void DrawTOR_MorethanLess(this Graphics e, Font fontDetail, float a, float b, int x, int y)
        {
            // int _x = (int)(x -e.MeasureString(a + " ", fontDetail).Width);
            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = e.MeasureString(a.ToString("n0") + " ", fontDetail);


            e.DrawString(a.ToString("n0") + " ", fontDetail, Brushes.Black, x - stringSize.Width, y);
            e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x + 20, y, 30, 30));
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 70, y);


        }
        public enum operater_AddDifTwo { one, two, three, All }
        public static void DrawAddDifTwo(this Graphics e, Font fontDetail, int min, int max, int x, int y, bool random = false, operater_AddDifTwo operater_AddDifTwo = operater_AddDifTwo.one)
        {

            // Measure string.
            List<string> operater_1 = new List<string>() { "+_+", "+_-", "-_+", "-_-" };
            List<string> operater_2 = new List<string>() { "+_+_+", "+_+_-", "+_-_+", "+_-_-", "-_+_+", "-_+_-", "-_-_+", "-_-_-" };
            List<string> operater_3 = new List<string>() { "+_+_+_+", "+_+_+_-", "+_+_-_+", "+_+_-_-", "+_-_+_+", "+_-_+_-", "+_-_-_+", "+_-_-_-", "-_+_+_+", "-_+_+_-", "-_+_-_+", "-_+_-_-", "-_-_+_+", "-_-_+_-", "-_-_-_+", "-_-_-_-" };


            SizeF stringSize = new SizeF();
            int _a = RandomNumberGenerator.GetInt32(min, max);
            int _b = RandomNumberGenerator.GetInt32(min, max);
            int _c = RandomNumberGenerator.GetInt32(min, max);



            string op = "";
            int b = Math.Min(_a, _b);
            int a = Math.Max(_a, _b);

            int c = 0;

            int ipp = RandomNumberGenerator.GetInt32(1, 2000);
            if (ipp < 1000)
            {
                op = "+_-";
            }
            else
            {
                op = "-_+";
            }

            e.DrawString(" " + op + " ", fontDetail, Brushes.Black, x + 130, y + 10);
            e.DrawString(" = ", fontDetail, Brushes.Black, x + 290, y + 10);

            e.DrawString(a.ToString("n0"), fontDetail, Brushes.Black, x + 120 - e.MeasureString(a.ToString("n0") + " ", fontDetail).Width, y + 10);
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 170, y + 10);
            e.DrawString(c.ToString("n0") + " ", fontDetail, Brushes.Black, x + 350, y + 10);

            if (!random)
            {

                e.DrawFillRectangle(x + 320, y, 120, 40);
            }
            else
            {
                ipp = RandomNumberGenerator.GetInt32(1, 3000);
                if (ipp < 1000)
                {

                    e.DrawFillRectangle(x, y, 120, 40);

                }
                else if (ipp >= 1000 && ipp < 2000)
                {
                    e.DrawFillRectangle(x + 170, y, 120, 40);
                }
                else if (ipp >= 2000)
                {
                    e.DrawFillRectangle(x + 320, y, 120, 40);
                }

            }


        }



    }
}
