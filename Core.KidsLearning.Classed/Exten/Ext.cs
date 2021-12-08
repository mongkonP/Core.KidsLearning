using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.Classed
{
   public static class Exts
    {


        private static List<string> name = new List<string>() { " ไตเติ้ล "," คุณยาย "," คุณตา "," คุณพ่อ "," คุณแม่ "," คุณปู่ "," คุณย่า "," ข้าวฝ่าง ", " คุณลุง ", " คุณอา ", " คุณน้า "
        , " ต้นกล้า ", " ภูผา ", " ปอร์เช่ ", " กัปตัน ", " คอปเตอร์ ", " เพื่อน ", " เฟย ", " ภูมิ ", " หมอก ", " ม่อน ", " ราม ", " โรม ", " ยอดรัก ", " ว่าน ",
            " วิทย์ ", " เอื้อ ", " กวิน ", " กองพล ", " กองทัพ ", " ขุนเขา ", " ขอบฟ้า ", " เจ้านาย ", " เจ้าขุน ", " จิรา ", " จิระ ", " ดาวเหนือ ", " ตะวัน ", " ตั้งเต ",
            " ต้นน้ำ ", " ไต้ฝุ่น ", " แทนไท ", " แทนคุณ ", " ธนู ", " นาวา "
        , " พะเพื่อน ", " ภาคิน ", " ม่านหมอก ", " ม่อนไม้ ", " มาวิน ", " ราชัน ", " เรวิน ", " ศิระ ", " ศิลา ", " วาโย ", " วาวี ", " วาที ", " วายุ ", " สิงโต ", " อาทิตย์ ", " ไออุ่น ", " ไอหมอก "};
        public static string ManName()
        {
            return name[RandomNumberGenerator.GetInt32(0,name.Count-1)];
        }
      public static  List<string> strType = new List<string> {
                "เส้นเล็ก น้ำ 20 บาท", "เส้นเล็ก น้ำ 30 บาท",
                "เส้นเล็ก แห้ง 20 บาท", "เส้นเล็ก แห้ง 30 บาท",
                "เส้นใหญ่ น้ำ 20 บาท", "เส้นใหญ่ น้ำ 30 บาท",
                "เส้นใหญ่ แห้ง 20 บาท", "เส้นใหญ่ แห้ง 30 บาท",
                "บะหมี่ น้ำ 20 บาท", "บะหมี่ น้ำ 30 บาท",
                "บะหมี่ แห้ง 20 บาท", "บะหมี่ แห้ง 30 บาท",
                "มาม่า น้ำ 20 บาท", "มาม่า น้ำ 30 บาท",
                "มาม่า แห้ง 20 บาท", "มาม่า แห้ง 30 บาท",
                "วุ้นเส้น น้ำ 20 บาท", "วุ้นเส้น น้ำ 30 บาท",
                "วุ้นเส้น แห้ง 20 บาท", "วุ้นเส้น แห้ง 30 บาท" ,
                "เกาเหลา 40 บาท","เกาเหลา 60 บาท"};


        public static string ConvertMoney(int mc)
        {
            /*  List<int> payM = new List<int>() { 2, 5, 10, 20, 50, 100, 500, 1000 };

             List<int> payAll = new List<int>();
             string ssss = " " + mc;
             payAll.Add(mc);
             for (int a = 0; a < payM.Count - 1; a++)
             {
                 int mm = payM[a];

                 if (!payAll.Contains(mm) && mm >= mc)  // ถ้า mm ไม่มีใน payAll และ mm มากกว่า mc 
                 {
                     ssss += "," + mc;
                     payAll.Add(mc); 
                 }
                 else if (mm < mc && payM[a + 1] > mc) 
                 {

                             for (int b = a; b >= 0; b--)
                             {

                                 int _b = payM[a] + payM[b];
                        // System.Windows.Forms.MessageBox.Show("_b = " + _b + "\n" +  payAll.Contains(_b).ToString() + "\n" + ssss);
                                 if (_b > mc && _b < payM[a + 1] && !payAll.Contains(_b))
                                 {
                             ssss += "," + _b;
                             payAll.Add(_b);
                                 }
                                 else
                                 {
                                     for (int c = a; c >= 0; c--)
                                     {
                                         int _c = payM[a] + payM[b] + payM[b];
                                // System.Windows.Forms.MessageBox.Show("_c = " + _c + "\n" + payAll.Contains(_c).ToString() + "\n" + ssss);
                                 if (_c > mc && _c < payM[a + 1] && !payAll.Contains(_c))
                                         {
                                     ssss += "," + _c;
                                     payAll.Add(_c);
                                         }
                                         else
                                         {
                                             for (int d = a; d >= 0; d--)
                                             {
                                                 int _d = payM[a] + payM[b] + payM[b] + payM[d];

                                        // System.Windows.Forms.MessageBox.Show("_d = " + _d + "\n" + payAll.Contains(_d).ToString() + "\n" + ssss);

                                         if (_d > mc && _d < payM[a + 1] && !payAll.Contains(_d))
                                                 {
                                             ssss += "," + _d;
                                             payAll.Add(_d);
                                                 }

                                             }
                                         }
                                     }
                                 }
                             }

                 }



             }

           var s1 = new StringBuilder();
             var results = payAll.Where(x => x != 0).OrderBy(x => x);
             foreach (int s in results)
             {
                 s1.Append(s + " , ");
             }*/

            List<int> payM = new List<int>() { 2, 5, 10, 20, 50, 100, 500, 1000 };
            List<int> payAll = new List<int>();
            int __mc;
            payAll.Add(mc);
            payM.ForEach(mm =>
            {
                __mc = ((mc / mm) + 1) * mm;
                if (!payAll.Contains(__mc))
                    payAll.Add(__mc);
            });

            string ssss = "";
            payAll.ForEach(m => ssss += " " + m);

            return ssss;

        }
    }
}
