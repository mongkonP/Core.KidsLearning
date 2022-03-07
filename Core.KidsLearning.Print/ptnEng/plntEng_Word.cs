using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.KidsLearning.Classed.Exten;
using OfficeOpenXml;
using TORServices.Drawings;
using TORServices.Systems;

namespace Core.KidsLearning.Print
{
    public class plntEng_Word : prnClass
    {
        List<string> lst_1 = new List<string>() { "b=บ", "bl=บล", "br=บร", "c=ค", "ch=ช", "cl=คล", "cr=คร", "d=ด", "dr=ดร", "f=ฟ", "fl=ฟล", "fr=ฟร", "g=ก", "gh=ก", "gl=กล", "gr=กร", "h=ฮ", "j=จ", "k=ค/ก", "kl=คล/กล", "kn=น", "kr=คร/กร", "l=ล", "m=ม", "n=น", "p=พ", "ph=ฟ", "pl=พล", "pr=พร", "q=คว", "r=ร", "s=ซ/ส", "sc=สค/ส", "sch=สค/ช", "scr=สคร", "sh=ช", "sk=สค", "sl=สล", "sm=สม", "sn=สน", "sp=สพ", "spl=สพล", "spr=สพร", "sq=สคว", "st=สท", "str=สทร", "sw=สว", "t=ท/ต", "th=ด/ตซ", "tr=ทร", "v=วฟ", "w=ว", "wh=ฮ/ว", "wr=ร", "x=ซ", "y=ย", "z=ส", "ng=ง" };
        List<string> lst_2 = new List<string>() { "a=แอะ,แอ,อะ,อา","ai=ไอ","au=เอา","ao=เอา","ar=อาร์/ออร์","al=อาล์/ออล์","a-e=เอ","au=ออ","aw = ออa", "y=เอย์","e=เอะ / อี","ea=อี/เอ","ear=เอีย/แอ","ee=อี","ew=อิว","ey=อี/เอ","er=เออร์","ere=เอีย/แอ","i = อิ","ia = เอีย", "ir=เออ","i-e=ไอ","o = โอ/เอาะ/อัน","oo = อู","oa=โอ","oi=ออย","or=เออ/ออ","oor=ออ/อัว","ou=เอา/อู","ow =เอา/โอ","oy = ออย","o-e = โอ/อัน","u=อุ/อัua=อัว","ur = เออร์","uy = ไอ","y=ไอ/อี","ye=ไอ", "u-e=ยู/อู", "ue=อู" };
        List<string> lst_3 = new List<string>() { "b=บ", "bt=บท์", "c=ค", "ch=ช", "ck=ค", "ct=คท์", "d=ด", "dge=ดจ์", "f=ฟ", "ff=ฟ", "ft=ฟท์", "g=ก", "ge=จ", "ght=ท", "k=ค", "l=ล", "ll=ลล์", "ld=ลด์", "lf=ลฟ์", "lt=ลท์", "mpt=มพท์", "m=ม", "mb=มบ์", "mf=มฟ์", "mp=มพ์", "n=น", "nd=นด์", "ng=ง", "nx,nk=งค์", "nce=นส์", "nse=นส์", "nt=นท์", "nz=นส์", "p=พ", "pf=พฟ์", "ph=ฟ", "pt=มท์", "q=ค", "que=ค", "pth=พตซ์", "s=ซ/ส", "sk=สค์", "sp=สพ", "s=ส", "st=สท์", "t=ท", "th=ตซ", "the=ด", "v=ฟ", "ve=ฟ", "w=ว", "x=กซ์", "xt=คซท์", "y=ย", "ye=ย", "z=ส" };
        List<string> wordsAll;

        List<string> words;
        #region Variables
        public enum CountWordForSpell { Str_1,Str_2,Str_3};

        int countC = 13;
    
        int ic = 0;
        #endregion
        public plntEng_Word()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ การสะกดอ่านภาษาอังกฤษเบื้องต้น ";//Please convert the following units to be correct. 
          //  _ReportToppic = "เขียนชื่อหน่วยนับ และ เลข อุปสรรค ต่อไปนี้ให้ถูกต้อง";
        }
        string GetWord(List<string> lst, int c = 0)
        {
            return lst[RandomNumberGenerator.GetInt32(0, lst.Count - 1)].Split('=')[c];

        }
        bool CompareTh_En = false;
        public void PrintCompareTh_En(int Pagecount = 10,bool th_en = false)
        {
            _ReportToppic = "เปรียบเทียบ พยัญชนะ สระ  ต่อไปนี้";

            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = Pagecount;
               
                iPage = 1;
                words = new List<string>();
                
                wordsAll = new List<string>();
                wordsAll.AddRange(lst_1);
                wordsAll.AddRange(lst_2);
                wordsAll.AddRange(lst_3);

                List<Task> tasks = new List<Task>();

                for (int i = 0; i <= iPageAll + 1; i++)
                {
                    tasks.Add(Task.Factory.StartNew(() =>
                    {
                        for (int p = 0; p <= (countC*2) + 5; p++)
                        {
                          words.Add(GetWord(wordsAll));
                        }
                    }));
                }
                Task.WaitAll(tasks.ToArray());
                _printDocument.PrintPage += new PrintPageEventHandler(PrintCompareTh_EnPrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });


                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }
        }
        public void PrintSpellingWord(int Pagecount = 10,int Rowcount = 10, CountWordForSpell countWordForSpell = CountWordForSpell.Str_2)
        {
           
            _ReportToppic = "เปรียบเทียบ พยัญชนะ สระ พร้อมคำอ่าน ต่อไปนี้";
            
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.Document = _printDocument;
            printDialog.UseEXDialog = true;
            ic = 0;
            //Get the document
            if (System.Windows.Forms.DialogResult.OK == printDialog.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;
                iPageAll = Pagecount;
                countC = Rowcount;
                iPage = 1;
                words = new List<string>();
                List<Task> tasks = new List<Task>();

                for (int i = 0; i <= iPageAll + 1; i++)
                {
                    tasks.Add(Task.Factory.StartNew(() =>
                    {
                        for (int p = 0; p <= countC+5; p++)
                        {
                            if (countWordForSpell == CountWordForSpell.Str_1)
                            {
                                words.Add(GetWord(lst_1));
                            }
                            else if (countWordForSpell == CountWordForSpell.Str_2)
                            {
                                words.Add(GetWord(lst_1) + "_" + GetWord(lst_2));
                          
                            }
                            else if (countWordForSpell == CountWordForSpell.Str_3)
                            {
                                words.Add(GetWord(lst_1) + "_" + GetWord(lst_2) + "_" + GetWord(lst_3));
 
                            }

                        }
                    }));
                }
                Task.WaitAll(tasks.ToArray());
                _printDocument.PrintPage += new PrintPageEventHandler(PrintSpellingWordPrintPage);
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
     
        protected void PrintSpellingWordPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120;
         //   System.Windows.Forms.MessageBox.Show(countC + "");
            for (int i = 0; i < countC; i++)
            {

                e.Graphics.DrawSpellWord(words[i].Split('_').ToList<string>(), fontDetail, 100, yC);
                ic++;
               
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
        protected void PrintCompareTh_EnPrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            int yC = 150;
            int xC = 100;
            int w = 100, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            e.Graphics.DrawFillRectangleString("อักษร อังกฤษ", fontDetail, solidBrush,pen,new Rectangle(xC, yC, w,h));
            e.Graphics.DrawFillRectangleString("อักษร/สระ ไทย", fontDetail, solidBrush, pen, new Rectangle(xC + w, yC, w,h));
            e.Graphics.DrawFillRectangleString("อักษร อังกฤษ", fontDetail, solidBrush, pen, new Rectangle(xC + 3 * w, yC, w, h));
            e.Graphics.DrawFillRectangleString("อักษร/สระ ไทย", fontDetail, solidBrush, pen, new Rectangle(xC + 4 * w, yC, w, h));


            yC += h;
            for (int i = 0; i < countC; i++)
            {

                e.Graphics.DrawFillRectangleString(words[ic], fontDetail, solidBrush, pen, new Rectangle(xC, yC, w, h));
                e.Graphics.DrawFillRectangleString("  ", fontDetail, solidBrush, pen, new Rectangle(xC + w, yC, w, h));
                ic++;
                e.Graphics.DrawFillRectangleString(words[ic], fontDetail, solidBrush, pen, new Rectangle(xC + 3 * w, yC, w, h));
                e.Graphics.DrawFillRectangleString("  ", fontDetail, solidBrush, pen, new Rectangle(xC + 4 * w, yC, w, h));
                ic++;

                yC += h;
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


        #region Print Page EngWord_1

        List<string> lstWord;
        public void PrintFromEngWord_1(int count = 10)
        {

            _ReportToppic =  "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้"; ;
     

            


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

                FileInfo existingFile = new FileInfo(@"D:\T_MEGA\เรียนรู้ เติ้ล\Eng คำศัพท์ 1.xlsx");
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int colCount = worksheet.Dimension.End.Column;  //get Column Count
                    int rowCount = worksheet.Dimension.End.Row;     //get row count
                    lstWord = new List<string>();
                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                            lstWord.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                    }

                };


                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromEngWord_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromEngWord_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150, xC = 100;
            int w = 100, h = 35;

            int count = 14;
            // DrawTable
            for (int ip = 0; ip <= count; ip++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC + 620, yC);
                yC += h;
            }

            yC = 150; xC = 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            e.Graphics.DrawString("  คำศัพท์   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 200;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);
            e.Graphics.DrawString("   คำอ่าน   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 200;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);
            e.Graphics.DrawString("คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 220;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            yC += h; xC = 100;
            for (int ip = 1; ip <= count-1; ip++)
             {

             
                 e.Graphics.DrawString(lstWord[RandomNumberGenerator.GetInt32(0, lstWord.Count-1)] , fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                 yC += h;
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



        #region Print Page EngWord_2


        public void PrintFromEngWord_2(int count = 10)
        {

            _ReportToppic = "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้"; ;


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

                FileInfo existingFile = new FileInfo(@"D:\T_MEGA\เรียนรู้ เติ้ล\Eng คำศัพท์ 1.xlsx");
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int colCount = worksheet.Dimension.End.Column;  //get Column Count
                    int rowCount = worksheet.Dimension.End.Row;     //get row count
                    lstWord = new List<string>();
                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                            lstWord.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                    }

                };


                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromEngWord_2PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromEngWord_2PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150, xC = 100;
            int w = 100, h = 35;

            int count = 14;
            // DrawTable
            for (int ip = 0; ip <= count; ip++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC + 620, yC);
                yC += h;
            }

            yC = 150; xC = 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            e.Graphics.DrawString("  คำศัพท์   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            e.Graphics.DrawString("พยัญชนะต้น", fontDetail, new SolidBrush(Color.Black), xC , yC + 5); xC += 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            e.Graphics.DrawString(" สระ ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            e.Graphics.DrawString(" ตัวสะกด ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 220;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

            yC += h; xC = 100;
            for (int ip = 1; ip <= count - 1; ip++)
            {


                e.Graphics.DrawString(lstWord[RandomNumberGenerator.GetInt32(0, lstWord.Count - 1)], fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                yC += h;
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


        #region Print Page Sentences_1
        //  ...........  Like/give/need/see/want ...........
        //  ...........  eat ...........
        // that/this is ................
        //............ is ...............
        //have has
        //play
        //live at
        List<string> n_1 = new List<string>() { "I","You", "We","They","She", "He","It", "Mother", "Father", "Child", "Wife", "Daughter", "Son" ,
            "Brother", "Daddy","Granddaughter","Grandchild","Grandfather","Grandmother","Grandson","Sister","Baby"};

        List<string> lstLike ;
        List<string> lstEat;
        List<string> lstThatThis;
        List<string> lstIsAmAre;
        List<string> lstPlay;
        List<string> lstHaveHas;
        List<string> vLike = new List<string>() { "like","see","give","need","want"};
        List<string> ttLike = new List<string>() { "This","That","These" ,"Those" };
        public void PrintFromSentences_1(int count = 10)
        {

            _ReportToppic = "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้"; 


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

                FileInfo existingFile = new FileInfo(@"D:\T_MEGA\เรียนรู้ เติ้ล\Sentences_1.xlsx");
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    //get the first worksheet in the workbook
                    lstLike = new List<string>();
                    lstEat = new List<string>();
                    lstThatThis = new List<string>();
                    lstIsAmAre = new List<string>();
                    lstPlay = new List<string>();
                    lstHaveHas = new List<string>();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];//EAT
                    int colCount = worksheet.Dimension.End.Column;  //get Column Count
                    int rowCount = worksheet.Dimension.End.Row;     //get row count
                    
                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        {
                            if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                            {
                                lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstEat.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstThatThis.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstHaveHas.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                              
                            }
                        
                        }
                    }
                    worksheet = package.Workbook.Worksheets[1];//ห้องต่างๆ ในโรงเรียน
                    colCount = worksheet.Dimension.End.Column;  //get Column Count
                    rowCount = worksheet.Dimension.End.Row;     //get row count

                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        {
                            if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                            {
                                lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstThatThis.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            }

                        }
                    }

                    worksheet = package.Workbook.Worksheets[2];//อาชีพ
                    colCount = worksheet.Dimension.End.Column;  //get Column Count
                    rowCount = worksheet.Dimension.End.Row;     //get row count

                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        {
                            if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                            {
                                lstIsAmAre.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());

                            }

                        }
                    }

                    worksheet = package.Workbook.Worksheets[3];//สัตว์
                    colCount = worksheet.Dimension.End.Column;  //get Column Count
                    rowCount = worksheet.Dimension.End.Row;     //get row count

                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        {
                            if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                            {

                                lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstEat.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstThatThis.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstHaveHas.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            }

                        }
                    }

                    worksheet = package.Workbook.Worksheets[4];//กีฬา
                    colCount = worksheet.Dimension.End.Column;  //get Column Count
                    rowCount = worksheet.Dimension.End.Row;     //get row count

                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        {
                            if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                            {
                                lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                                lstPlay.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            }

                        }
                    }

                    worksheet = package.Workbook.Worksheets[5];//สี
                    colCount = worksheet.Dimension.End.Column;  //get Column Count
                    rowCount = worksheet.Dimension.End.Row;     //get row count

                    for (int row = 2; row <= rowCount; row++)
                    {


                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        {
                            if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                            {
                                lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            }

                        }
                    }
                    
                };


                _printDocument.PrintPage += new PrintPageEventHandler(PrintFromSentences_1PrintPage);
                _printDocument.BeginPrint += new PrintEventHandler((o, s) =>
                {

                    bFirstPage = true;
                    bNewPage = true;
                });

                _printDocument.DocumentName = _ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                _printDocument.Print();
            }

        }

        protected void PrintFromSentences_1PrintPage(object sender, PrintPageEventArgs e)
        {

            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 150, xC = 100;
            int w = 100, h = 35;

            int count = 14;
            // DrawTable


            yC = 150; xC = 100;
            int rr;
            string s = "";
            for (int ip = 0; ip < 8; ip++)
            {
                xC = 100;
                rr = RandomNumberGenerator.GetInt32(0, 5);
                
                //live at

                if (rr == 0)//  ...........  Like/give/need/see/want ...........
                {
                    s = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)] + "    "+vLike[RandomNumberGenerator.GetInt32(0, vLike.Count - 1)] +"      " + lstLike[RandomNumberGenerator.GetInt32(0, lstLike.Count - 1)];
                }
                else if(rr == 1)//  ...........  eat ...........
                {
                    s = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)] + "    eat      " + lstEat [RandomNumberGenerator.GetInt32(0, lstEat.Count - 1)];
                }
                else if (rr == 2)//............ is/am/are ...............
                {
                    string ss = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)];

                    if (ss == "I")
                    {
                        s = ss + "   am     " + lstIsAmAre[RandomNumberGenerator.GetInt32(0, lstIsAmAre.Count - 1)];
                    }
                    else if (ss == "We" || ss == "They")
                    {
                        s = ss + "   are     " + lstIsAmAre[RandomNumberGenerator.GetInt32(0, lstIsAmAre.Count - 1)];
                    }
                    else
                    {
                        s = ss + "    is      " + lstIsAmAre[RandomNumberGenerator.GetInt32(0, lstIsAmAre.Count - 1)];
                    }
                    
                }
                else if (rr == 3) // that/this/These / Those is ................
                {
                    
                        s = ttLike[RandomNumberGenerator.GetInt32(0, ttLike.Count-1)] + "    is      " + lstEat[RandomNumberGenerator.GetInt32(0, lstEat.Count - 1)];
                    
                }
                else if (rr == 4)  //have has
                {
                    string ss = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)];
                    if (ss == "I" || ss ==  "You" || ss == "We" || ss == "They")
                    {
                        s = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)] + "    have      " + lstHaveHas[RandomNumberGenerator.GetInt32(0, lstHaveHas.Count - 1)];
                    }
                    else
                    {
                        s = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)] + "    has      " + lstHaveHas[RandomNumberGenerator.GetInt32(0, lstHaveHas.Count - 1)];
                    }

                }
                else if (rr == 5)  //play
                {
                    s = n_1[RandomNumberGenerator.GetInt32(0, n_1.Count - 1)] + "  play     " + lstPlay[RandomNumberGenerator.GetInt32(0, lstPlay.Count - 1)];

                }
                e.Graphics.DrawString(" ประโยค ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, 25));
                e.Graphics.DrawString("   " + s, fontDetail, new SolidBrush(Color.Black), xC + 100, yC + 8);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, 25));

                yC += 25;
                e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, 25));
                yC += 25;
                e.Graphics.DrawString(" คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, 25));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, 25));

                yC += 35;
            }


            yC += h; xC = 100;


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
