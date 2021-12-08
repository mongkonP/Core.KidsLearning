


using Core.KidsLearning.Classed.Exten;
using Core.KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace Core.KidsLearning.Control.ThaiControl
{
   public  class KorKaiChoie4Choie:Choie4Choie
    {
       public KorKaiChoie4Choie(string path)
       {
           InitializeComponent();
           _pathpic = path;
           ck = new testChoie(path + "\\txt.txt");
           if (ck == null) return;
           this.HeaderName = "KorKaiChoie4Choie ";
       
       }
       string _pathpic;testChoie ck;
       protected override void OnbuttonChoieClick(EventArgs e)
       {
           base.OnbuttonChoieClick(e);
           RandomChoie();

       }

       public void RandomChoie()
       {
           if (ck == null || ck.Choies == null || ck.Choies.Count <= 0) return;
           using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
           {
              
               int i;
               System.Threading.Thread.Sleep(100);
               do
               {
                   i = RandomNumberGenerator.GetInt32(0, ck.Choies.Count - 1);
                   Ans = ck.Choies[i].Answer;
                   _Choies = ck.Choies[i].Choie;
               } while (string.IsNullOrEmpty(Ans) || _Choies.Count <= 0);
               pictureBox1.Invoke(new Action(() => { pictureBox1.Image = Image.FromFile(_pathpic + "\\" + Ans + ".jpg"); }));
               SetButtonText();

           })))
           {
               f.ShowDialog(this);
           }
       }

       private void InitializeComponent()
       {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KorKaiChoie4Choie
            // 
            this.Name = "KorKaiChoie4Choie";
            this.Load += new System.EventHandler(this.KorKaiChoie4Choie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

       }

       private void KorKaiChoie4Choie_Load(object sender, EventArgs e)
       {
          // ExtFile.WriteLog(HeaderName + ":Load");
           RandomChoie();
       }

    }
}
