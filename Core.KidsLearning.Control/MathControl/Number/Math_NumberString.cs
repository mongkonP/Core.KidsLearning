
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using Core.KidsLearning.Control.Exten;

using Core.KidsLearning.Classed.Exten;

using System.Security.Cryptography;
using static TORServices.Maths.extMath;

namespace Core.KidsLearning.Control.MathControl.Number
{
  public   class Math_NumberString:Choie4Choie
    {
        List<string> Files;
        public Math_NumberString()
        {
            InitializeComponent();


            this.HeaderName = "Math_NumberString ";
            this.Load += new EventHandler(this._Load);


        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(1104, 471);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Size = new System.Drawing.Size(1104, 151);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1104, 471);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(544, 72);
            this.button3.Size = new System.Drawing.Size(512, 54);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(15, 72);
            this.button4.Size = new System.Drawing.Size(512, 54);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(544, 12);
            this.button2.Size = new System.Drawing.Size(512, 54);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Size = new System.Drawing.Size(512, 54);
            // 
            // Math_NumberString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "Math_NumberString";
            this.Size = new System.Drawing.Size(1104, 622);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void RandomChoie()
        {

            pictureBox1.Invoke(new Action(() => { pictureBox1.Image = null; }));
            int min = 1, max = 15;
            using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
            {
                _Choies = new List<string>();
                //สุ่มตัวเลข
                int _Ans =  RandomNumberGenerator.GetInt32(min, max);

                System.Threading.Thread.Sleep(100);
                //สุ่มเพื่อให้แสดงค่าเป็น เลข อารบิก เลขไทย ตัวหนังสือ
                NumberFormatObtion _numberFormatObtion;
                int a =  RandomNumberGenerator.GetInt32(0, 1000);
                if (a > 0 && a <= 350)
                    _numberFormatObtion = NumberFormatObtion.toArabic;  
                else if (a > 350 && a <= 750)
                    _numberFormatObtion = NumberFormatObtion.toThai;
                else
                    _numberFormatObtion = NumberFormatObtion.toText;


               //สร้างรูปแบบ 
               //สุ่มไฟลืมาก่อน
                System.Threading.Thread.Sleep(100);
                string imag_1 = Files[ RandomNumberGenerator.GetInt32(0,Files.Count-1)];

                string[] temp = System.IO.Path.GetFileNameWithoutExtension(imag_1).Split('-');
                //แยกชื่อ กับ หน่วยนับด้วย split("-")
                string _name = temp[0];
                string _unit = temp[1];


                //เพิ่ม คำตอบ เข้าใน list
                Ans = _name + "  " + _Ans.ToNumberFormat(_numberFormatObtion) + " " + _unit;
                _Choies.Add(Ans);


                int cc = _Ans-3;
                List<int> l = new List<int>();
                l.Add(_Ans);
                for (int b = 1; b < 4; b++)
                {
                    while (l.Contains(cc) || cc == 0)
                    {
                        cc++;
                    }
                    
                    _Choies.Add(_name + "  " + cc.ToNumberFormat(_numberFormatObtion) + " " + _unit);
                    l.Add(cc);

                }


                
                pictureBox1.Invoke(new Action(() =>  pictureBox1.Image = TORServices.Drawings.exImage.ImageFromNumber(_Ans,"")));
                SetButtonText();



            })))
            {
                f.ShowDialog(this);
            }
        }

        private void _Load(object sender, EventArgs e)
        {
           /* Files = System.IO.Directory.GetFiles(Program.PathRun + @"\TestPIC\Math_1", "*.*", System.IO.SearchOption.AllDirectories).ToList<string>();
            RandomChoie();*/
        }
        protected override void OnbuttonChoieClick(EventArgs e)
        {
            base.OnbuttonChoieClick(e);
            RandomChoie();

        }

    }
}
