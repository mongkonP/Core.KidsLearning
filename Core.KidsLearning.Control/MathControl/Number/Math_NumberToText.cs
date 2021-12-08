


using Core.KidsLearning.Classed.Exten;
using Core.KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TORServices.Maths;
namespace Core.KidsLearning.Control.MathControl.Number
{
   public class Math_NumberToText:Choie4Choie
    {
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public Math_NumberToText()
        {
            InitializeComponent();


            this.HeaderName = "Math_Number1to50 ";
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton5.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton6.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton7.Click += new System.EventHandler(this.radioButton1_Click);
            this.Load += new EventHandler(this._Load);


        }

 

        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(892, 375);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Size = new System.Drawing.Size(892, 281);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(892, 375);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(17, 205);
            this.button3.Size = new System.Drawing.Size(833, 53);
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(17, 146);
            this.button4.Size = new System.Drawing.Size(833, 53);
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(17, 87);
            this.button2.Size = new System.Drawing.Size(833, 53);
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(17, 28);
            this.button1.Size = new System.Drawing.Size(833, 53);
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(25, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 35);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1-100";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(25, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 35);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "1-1000";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(25, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(131, 35);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "1-10000";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(25, 132);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(146, 35);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "1-100000";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton5.Location = new System.Drawing.Point(25, 173);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(161, 35);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.Text = "1-1000000";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton6.Location = new System.Drawing.Point(25, 214);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(176, 35);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.Text = "1-10000000";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton7.Location = new System.Drawing.Point(25, 255);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(191, 35);
            this.radioButton7.TabIndex = 11;
            this.radioButton7.Text = "1-100000000";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // Math_NumberToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "Math_NumberToText";
            this.Size = new System.Drawing.Size(892, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void RandomChoie()
        {

            pictureBox1.Invoke(new Action(() => { pictureBox1.Image = null; }));
            int min = 1, max = 20;
            using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
            {
                _Choies = new List<string>();
                if (radioButton1.Checked)
                {
                    min = 1; max = 100;
                }
                else if (radioButton2.Checked)
                {
                    min = 1; max = 1000;
                }
                else if (radioButton3.Checked)
                {
                    min = 1; max = 10000;
                }
                else if (radioButton4.Checked)
                {
                    min = 1; max = 100000;
                }
                else if (radioButton5.Checked)
                {
                    min = 1; max = 1000000;
                }
                else if (radioButton6.Checked)
                {
                    min = 1; max = 10000000;
                }
                else if (radioButton7.Checked)
                {
                    min = 1; max = 100000000;
                }
                int _Ans =  RandomNumberGenerator.GetInt32(min, max);

                Ans = _Ans.ToArabicToThaiText();
                _Choies.Add(Ans);
                int cc = 0;
                for (int b = 1; b < 4; b++)
                {
                    while (_Choies.Contains(cc.ToString().ToArabicToThaiText()) || cc == 0)
                    {
                        int _a = Convert.ToInt32(0.25 * _Ans);
                        cc =  RandomNumberGenerator.GetInt32((_Ans - _a < min) ? min : _Ans - _a, (_Ans + _a > max) ? max : _Ans + _a);
                        System.Threading.Thread.Sleep(100);
                    }
                    _Choies.Add(cc.ToString().ToArabicToThaiText());

                }
                
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                 g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
                  g.DrawString(_Ans + "", new Font("Times New Roman", 100), Brushes.Black, pictureBox1.Width / 2, pictureBox1.Height / 2);

                pictureBox1.Invoke(new Action(() => {  pictureBox1.Image = bmp; }));
                SetButtonText();
               


            })))
            {
                f.ShowDialog(this);
            }
        }

        private void _Load(object sender, EventArgs e)
        {
            RandomChoie();
        }
        protected override void OnbuttonChoieClick(EventArgs e)
        {
            base.OnbuttonChoieClick(e);
            RandomChoie();

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RandomChoie();
        }

    }
}
