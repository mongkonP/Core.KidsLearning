
using Core.KidsLearning.Classed.Exten;
using Core.KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace Core.KidsLearning.Control.EngControl
{
  public   class Eng_Basic:Choie4Choie
    {
      List<string> wordFile;
      public Eng_Basic()
      {
          InitializeComponent();

        
         this.HeaderName = "Eng_Basic ";
      }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            // 
            // Eng_Basic
            // 
            this.Name = "Eng_Basic";
            this.Load += new System.EventHandler(this.Eng_Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        
        void RandomChoie()
        {
            if (wordFile == null || wordFile.Count <= 0) return;
            using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
            {
                _Choies = new List<string>();
                string Ans_file;  string str;
                System.Threading.Thread.Sleep(100);
                Ans_file = wordFile[ RandomNumberGenerator.GetInt32(0, wordFile.Count - 1)];
                List<string> lstc = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Ans_file), "*.*", System.IO.SearchOption.AllDirectories).ToList<string>();
                Ans = System.IO.Path.GetFileNameWithoutExtension(Ans_file).ToUpper();
                _Choies.Add(Ans);
                do
                {
                    System.Threading.Thread.Sleep(100);
                    str = System.IO.Path.GetFileNameWithoutExtension(lstc[ RandomNumberGenerator.GetInt32(0, lstc.Count - 1)]);
                    if (!_Choies.Contains(str)) _Choies.Add( str.ToUpper());
                } while (_Choies.Count <= 4);
                pictureBox1.Invoke(new Action(() => { pictureBox1.Image = Image.FromFile(Ans_file); }));

                SetButtonText();

            })))
            {
                f.ShowDialog(this);
            }


        }
        private void Eng_Animal_Load(object sender, EventArgs e)
        {
           /* wordFile = System.IO.Directory.GetFiles(Program.PathRun + @"\PIC\Eng_Basic", "*.*", System.IO.SearchOption.AllDirectories).ToList<string>();
            RandomChoie();*/
        }
        protected override void OnbuttonChoieClick(EventArgs e)
        {
            base.OnbuttonChoieClick(e);
            RandomChoie();

        }

  }
}
