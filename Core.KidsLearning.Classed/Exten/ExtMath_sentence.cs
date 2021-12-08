using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.KidsLearning.Classed.Exten
{
    public class ExtMath_sentence
    {
        private static Random r = new Random();
        public static void setsentence_1()
        {


            string fileBlank = @"D:\Math\blank.png";
            int mc = 0;
            for (int i = 0; i < 20; i++)
            {

                
                System.Threading.Thread.Sleep(1000);
                string file = @"D:\Math\test " + i + ".png";
                File.Copy(fileBlank, file);
                System.Threading.Thread.Sleep(1000);
                Bitmap cloneImage = null;
                using (Bitmap bitMapImage = new Bitmap(file))
                {
                    cloneImage = new Bitmap(bitMapImage);
                }

                int cAll = r.Next(0, 4);
                List<string> strType_  = new List<string> {
                "เส้นเล็ก น้ำ ชามละ 20 บาท", "เส้นเล็ก น้ำ ชามละ 30 บาท",
                "เส้นเล็ก แห้ง ชามละ 20 บาท", "เส้นเล็ก แห้ง ชามละ 30 บาท",
                "เส้นใหญ่ น้ำ ชามละ 20 บาท", "เส้นใหญ่ น้ำ ชามละ 30 บาท",
                "เส้นใหญ่ แห้ง ชามละ 20 บาท", "เส้นใหญ่ แห้ง ชามละ 30 บาท",
                "บะหมี่ น้ำ ชามละ 20 บาท", "บะหมี่ น้ำ ชามละ 30 บาท",
                "บะหมี่ แห้ง ชามละ 20 บาท", "บะหมี่ แห้ง ชามละ 30 บาท",
                "มาม่า น้ำ ชามละ 20 บาท", "มาม่า น้ำ ชามละ 30 บาท",
                "มาม่า แห้ง ชามละ 20 บาท", "มาม่า แห้ง ชามละ 30 บาท",
                "วุ้นเส้น น้ำ ชามละ 20 บาท", "วุ้นเส้น น้ำ ชามละ 30 บาท",
                "วุ้นเส้น แห้ง ชามละ 20 บาท", "วุ้นเส้น แห้ง ชามละ 30 บาท" ,
                "เกาเหลา 40 บาท","เกาเหลา 60 บาท"}; 

                string _return = "ไตเติ้ลกินก๊วยเตี๋ยว โดยสั่ง ";
                for (int cc = 0; cc <= cAll; cc++)
                {
                    int c = r.Next(0, strType_.Count - 1);
                    string s = strType_[c];
                    int _mc = r.Next(1, 5);
                    _return += " \n " + s + _mc + " ชาม ";
                    string smc;
                    try { smc = new Regex(@"(\d+)", RegexOptions.None).Match(s).Value.Trim(); }
                    catch { smc = ""; }
                    if (smc != "")
                        mc += int.Parse(smc) * _mc;
                    strType_.Remove(s);
                   
                }
                List<int> payM = new List<int>() {  2 ,5 ,10 , 20, 50, 100, 500, 1000 };
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
                

              


                _return += " \n เมื่อไตเติ้ลจ่ายเงิน " + payAll[r.Next(0,payAll.Count-1)] + " บาท แม่ค้าต้องทอนเงินเท่าไหร่ ?";
                using (cloneImage)
                {
                    Graphics graphicImage = Graphics.FromImage(cloneImage);
                    graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
                    graphicImage.DrawString(_return, new Font("Arial", 18, FontStyle.Bold), SystemBrushes.WindowText, new Point(10, 10));


                    System.IO.File.Delete(file);

                    cloneImage.Save(file, ImageFormat.Jpeg);
                }


            }

        }
    }
}
