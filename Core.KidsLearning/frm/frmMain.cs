using Core.KidsLearning.Classed.Exten;
using Core.KidsLearning.Control.EngControl;
using Core.KidsLearning.Control.Exten;
using Core.KidsLearning.Control.MathControl.Number;
using Core.KidsLearning.Control.MathControl.Operate;
using Core.KidsLearning.Control.ThaiControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Core.KidsLearning.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // string controlName;
        private void frmMain_Load(object sender, EventArgs e)
        {
         //  "Open Program".WriteLog();
            //  tbExit.Enabled = false;
         /*   List<int> ints = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 6; i++)
                ints.Add(random.Next());
         */
           // string _file = KidsLearning.Classed.Exten.ExtImage.ImageFromNumber(System.IO.Path.GetTempPath() + @"KidsLearning\image3 45121245124304462313" + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".jpg", ints);
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
          //  "Close Program".WriteLog();

            System.Threading.Thread.Sleep(500);

            frmAlert f = new  frmAlert(Core.KidsLearning.Properties.Resources.bye);
            f.ShowDialog();
            Close();
        }

        private void ตวเลขToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void ScoreChange(object sender, ScoreEvent e)
        {
            
        }

        private void การบวกเลขToolStripMenuItem_Click(object sender, EventArgs e)
        {

          /* _form.Math.frmAddition f = new _form.Math.frmAddition();
            panel1.Controls.Add(f);
            f.Show();*/
        }



        /*   private void choie4Choie1_ScoreChange(object sender, ScoreEvent e)
            {
             scorePanel1.AddCount(e.Right, e.Count);
            // choieMultiChoie1.RandomChoie();
            }
        */
        private void scorePanel1_ScoreClear(object sender, EventArgs e)
        {

            //choieMultiChoie1.RandomChoie();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                System.IO.Directory.GetFiles(System.IO.Path.GetTempPath() + @"KidsLearning\", "*.*", System.IO.SearchOption.AllDirectories)
                  .ToList<string>()
                  .ForEach(f => { System.IO.File.Delete(f); System.Threading.Thread.Sleep(50); });
            }
            catch { }
        }

        private void แบบงายToolStripMenuItem_Click(object sender, EventArgs e)
        {
          panel1.Controls.Clear();
            KorKaiChoie4Choie f = new  KorKaiChoie4Choie(Application.StartupPath + @"\TestPIC\SymbolThai");
            panel1.Controls.Add(f);

            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void แบบยากToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            KorKaiChoieMultiChoie f = new KorKaiChoieMultiChoie(Application.StartupPath + @"\TestPIC\SymbolThai");
            panel1.Controls.Add(f);

            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NumberOperater f = new NumberOperater("+");
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NumberOperater f = new NumberOperater("-");
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NumberOperater f = new NumberOperater("X");
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NumberOperater f = new  NumberOperater("÷");
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void scorePanel1_AllCountChanged(object sender, EventArgs e)
        {
          //  if (scorePanel1.AllCount > 10) MessageBox.Show("5555");
          //  tbExit.Enabled = (scorePanel1.AllCount < 10) ? false : true;
        }

        private void คำศพทToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Eng_Basic f = new   Eng_Basic();
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate(Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void scorePanel1_ScoreChanged(object sender, EventArgs e)
        {
           
        }

        private void ตวเลขทวไป150ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Math_Number1to50 f = new  Math_Number1to50();
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate (Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void ตวเลขอารบกและตวเลขไทยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Math_NumberArabicAndThai f = new  Math_NumberArabicAndThai();
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate (Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void ตวเลขเปนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Math_NumberToText f = new  Math_NumberToText();
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate (Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void บวกลบละคนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NumberOperater f = new NumberOperater();
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate (Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void ประโยคงายๆToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Math_NumberString f = new  Math_NumberString();
            panel1.Controls.Add(f);
            f.ScoreChange += new ScoreEventHandler(delegate (Object o, ScoreEvent ee)
            {
                scorePanel1.AddCount(ee.Right, ee.Count);
            });
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
