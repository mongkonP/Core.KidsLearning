using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Ext;
using Core.KidsLearning.Classed.Exten;
using System.Security.Cryptography;
using TORServices.Forms.Forms;
using TORServices.Systems;
using TORServices.Forms;

namespace Core.KidsLearning
{
    public partial class frmLoadFile : Form
    {
        public frmLoadFile()
        {
            InitializeComponent();
        }

        string returnFile(string s)
        {

            return (WebUtility.UrlDecode(WebUtility.UrlDecode(s)));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => loadFiledltv());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => loadexercise_examfile());
        }
        string MakeValidFileName( string file)
        {
            string _file;

            _file = file.Replace("/", "_").Replace(@"\", "_").Replace("'", "")
                .Replace("\"", "").Replace("*", "").Replace(":", "").Replace(";", "")
                .Replace("[", "").Replace("]", "").Replace("(", "").Replace(")", "")
                .Replace("~", "").Replace("+", "").Replace("@", "").Replace("$", "")
                .Replace("%", "").Replace("^", "").Replace("฿", "").Replace("|", "")
                .Replace("{", "").Replace("}", "").Replace("?", "").Replace("<", "")
                .Replace(">", "").Replace("?", "");

            return _file;
        }
       void  LoadByWebClient(string link, string file)
        {
           

                using (WebClient webClient = new WebClient())
                {

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler((s, e) =>
                 {
                     lblStatus.Write("load file complete :" + file);
                 });
                    try
                    {
                        if (!Directory.Exists(Path.GetDirectoryName(file)))
                            Directory.CreateDirectory(Path.GetDirectoryName(file));
                        if (!File.Exists(file))
                        {
                            webClient.DownloadFile(new Uri(link), file);
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                    catch { }

                }





          

        }
        void loadfiledltvAll(string _url, string _code, string _dir)
        {
            string code = _code.Trim();
            string dir = _dir.Trim();
            string url = _url.Trim();
            string dir_1 = dir + "\\สื่อ";
            string dir_2 = dir + "\\ใบงาน";
            string strRegex = @"<a href=""(https://dltv.ac.th/utils/files/download/.*?)"">[\s\n]+<div class=""download-item m-t-10"">[\s\n]+<img src=""/upload/data/icon/\d+.png"">[\s\n]+(.*?)</div>";
            Task.Factory.StartNew(() =>
            {
                int cp = 1;
                List<Task> tasks = new List<Task>();

                foreach (Match myMatch in new Regex(strRegex, RegexOptions.Compiled).Matches(TORServices.Network.WebHelper.getHTML(_url).Result))
                {
                    string _f = MakeValidFileName(myMatch.Groups[2].Value.Trim());
                    if (_f.Length > 200)
                        _f = $"temp_{DateTime.Now.ToString("yyyyyMMdd hhmmss fffff")}";
                    string file = dir + "\\" + _f + ".pdf";

                    lblStatus.Write("load file:" + file);

                    tasks.Add(Task.Factory.StartNew(()=> LoadByWebClient(myMatch.Groups[1].Value.Trim(), file)));

                   // LoadByWebClient(myMatch.Groups[1].Value.Trim(), file);
                }
                TORServices.Network.WebHelper.GetLinkByURL(url, @"href=""(https://dltv.ac.th/teachplan/episode/\d+)"">").Result
                             .ForEach(url3 =>
                             {



                                 string html = TORServices.Network.WebHelper.getHTML(url3).Result;
                                 string unit = TORServices.Network.WebHelper.GetValueBystring(html, @"<strong>หน่วย</strong> <span>(.*?)</span>").Result;
                                 

                                 MatchCollection maths = new Regex(strRegex, RegexOptions.Compiled).Matches(html);
                                 //  lblStatus.Write( "link:" + url3 + "\nfiles:" + maths.Count);
                               //  List<Task> tasks = new List<Task>();
                                 int i = 1;
                                 foreach (Match myMatch in maths)
                                 {
                                     string _f = MakeValidFileName(myMatch.Groups[2].Value.Trim().Replace("ใบงานประกอบการสอน เรื่อง", "").Replace("สื่อประกอบการสอน เรื่อง", "").Trim());
                                     if (_f.Length > 200)
                                         _f = $"temp_{DateTime.Now.ToString("yyyyyMMdd hhmmss fffff")}";
                                     // string file = TORServices.PathFile.FileTor.RenameFileDup( (myMatch.Groups[2].Value.Trim().Contains("สื่อประกอบการสอน") ? dir_1 : dir_2) + "\\" +cp + "_"+ _f + ".pdf");
                                     string file = (myMatch.Groups[2].Value.Trim().Contains("สื่อประกอบการสอน") ? dir_1 : dir_2) + "\\" + cp + "_" + _f + ".pdf";

                                     lblStatus.Write("load file:" + file);
                                 // tasks.Add(LoadByWebClient(myMatch.Groups[1].Value.Trim(), file));
                                  tasks.Add(Task.Factory.StartNew(() => LoadByWebClient(myMatch.Groups[1].Value.Trim(), file)));
                                //  LoadByWebClient(myMatch.Groups[1].Value.Trim(), file);
            i++;

                                 }
                                 cp++;
                                 // Wait for the tasks to complete before displaying a completion message.
                               //  Task.WaitAll(tasks.ToArray());

                             });

                Task.WaitAll(tasks.ToArray());
            }).Wait();
            lblStatus.Write("URL complete :" + _url);

        }
        void loadFiledltv()
        {
             List<string> lst = new List<string>() { "ภาษาไทย_1000", "คณิตศาสตร์_2000", "สังคมศึกษา ศาสนาและวัฒนธรรม_4000",
             "สุขศึกษาและพลศึกษา_5000","ศิลปะ_6000","ภาษาอังกฤษ_8000","วิทยาศาสตร์และเทคโนโลยี_34554345","วิทยาศาสตร์และเทคโนโลยี (วิทยาการคำนวณ)_80000"
         ,"การงานอาชีพ_3418"};

           // List<string> lst = new List<string>() { "คณิตศาสตร์_2000", "ภาษาอังกฤษ_8000","วิทยาศาสตร์และเทคโนโลยี_34554345","วิทยาศาสตร์และเทคโนโลยี (วิทยาการคำนวณ)_80000"};

            // Create a scheduler that uses two threads.
            LimitedConcurrencyLevelTaskScheduler lcts = new LimitedConcurrencyLevelTaskScheduler(5);
            List<Task> tasks = new List<Task>();

            // Create a TaskFactory and pass it our custom scheduler.
            TaskFactory factory = new TaskFactory(lcts);
            CancellationTokenSource cts = new CancellationTokenSource();

            lst.ForEach(c =>
            {
                if (!string.IsNullOrEmpty(c.Trim()))
                {
                    string code = c.Split('_')[1].Trim();
                    string dir = @"D:\DLTV\" + c.Split('_')[0].Trim();
                  //  string strRegex = @"<a href=""(https://dltv.ac.th/utils/files/download/.*?)"">[\s\n]+<div class=""download-item m-t-10"">[\s\n]+<img src=""/upload/data/icon/\d+.png"">[\s\n]+(.*?)</div>";
                    for (int i = 1; i <= 9; i++)
                    {
                        

                        //  tasks.Add(Task.Factory.StartNew(() => loadfiledltvAll($"https://dltv.ac.th/teachplan/lists/{i}/{code}", code, dir + "_" + i)));
                       loadfiledltvAll($"https://dltv.ac.th/teachplan/lists/{i}/{code}", code, dir + "_" + i);
                    }

                }


            });
            // Wait for the tasks to complete before displaying a completion message.
            Task.WaitAll(tasks.ToArray());
            cts.Dispose();

            lblStatus.Write(" load file complete");


        }

        void loadexercise_examfile()
        {

            //<a href="(https://exercise-exam.blogspot.com/\d+/\d+/.+.html)" target="_blank">



            Task.Factory.StartNew(() =>
            {
                List<string> lstP = new List<string>();
                lblStatus.Write("list page:");
                foreach (Match myMatch in new Regex(@"<li><a href=""(https?://exercise-exam.blogspot.com/.+/.*?.html)"">", RegexOptions.None).Matches(TORServices.Network.WebHelper.getHTML("http://exercise-exam.blogspot.com").Result))
                {
                    // richTextBox1.Write(myMatch.Groups[1].Value);
                    if (!lstP.Contains(myMatch.Groups[1].Value))
                        lstP.Add(myMatch.Groups[1].Value);
                    List<Task> tasks0 = new List<Task>();
                    tasks0.Add(Task.Run(() =>
                    {
                        foreach (Match myMatch_0 in new Regex(@"<a href=""(https?://exercise-exam.blogspot.com/\d+/\d+/.+.html)"" target=""_blank"">", RegexOptions.None).Matches(TORServices.Network.WebHelper.getHTML(myMatch.Groups[1].Value).Result))
                        {

                            if (!lstP.Contains(myMatch_0.Groups[1].Value))
                                lstP.Add(myMatch_0.Groups[1].Value);

                        }

                    }));
                    Task.WaitAll(tasks0.ToArray());

                }

                if (lstP.Count > 0)
                {
                    lblStatus.Write("All page:" + lstP.Count);
                    List<Task> tasks = new List<Task>();
                    lstP.ForEach(p =>
                    {
                        foreach (Match myMatch_1 in new Regex(@"<a href=""(https?://\d+.bp.blogspot.com/.*?.jpg)"" imageanchor=""1""", RegexOptions.None).Matches(TORServices.Network.WebHelper.getHTML(p).Result))
                        {
                            tasks.Add(TORServices.Network.WebHelper.LoadByWebClient(myMatch_1.Groups[1].Value, @"D:\exercise-exam\" + Path.GetFileNameWithoutExtension(p) + "\\" + returnFile(Path.GetFileName(myMatch_1.Groups[1].Value))));
                        }
                        Task.WaitAll(tasks.ToArray());
                        lblStatus.Write(p);
                    });



                    for (int i = 1; i <= 6; i++)
                    {
                        Directory.CreateDirectory(@"D:\exercise-exam_\P" + i);
                        Directory.GetDirectories(@"D:\exercise-exam", "*p" + i + "*", SearchOption.TopDirectoryOnly).ToList<string>()
                           .ForEach(fol =>
                           {

                               Directory.Move(fol, @"D:\exercise-exam_\P" + i + "\\" + Path.GetFileName(fol));
                           });
                    }
                }
                lblStatus.Write("complete:");

            });

        }

        private void frmLoadFile_Load(object sender, EventArgs e)
        {

        }

       
    }
}
