using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TORServices.PathFile;
namespace Core.KidsLearning.Classed.Exten
{
    public class TokenTestChoie
    {
        public string Answer { get; set; }
        public List<string> Choie { get; set; }
    }
    public class testChoie
    {
        public List<TokenTestChoie> Choies;
        public testChoie(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("พบข้อผิดพลาด \n" + "ไม่พบข้อมูลของ " + path);
                return;
            }
            Choies = new List<TokenTestChoie>();
            string[] lst;
        TORServices.PathFile.textFile.textFileReader(path).Result.Split('\n').ToList<string>()
                .ForEach(l =>
                {
                    lst = l.Split('|');
                    if (lst.Length > 1)
                        Choies.Add(new TokenTestChoie() { Answer = lst[0], Choie = new List<string>() { lst[0], lst[1], lst[2], lst[3] } });
                });

        }
    }
}
