


using Core.KidsLearning.Classed.Exten;
using Core.KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TORServices.Drawings;
using static TORServices.Maths.extMath;

namespace Core.KidsLearning.Control.MathControl.Number
{
   public class Math_NumberArabicAndThai:Choie4Choie
    {
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;

        public Math_NumberArabicAndThai()
        {
            InitializeComponent();


            this.HeaderName = "Math_NumberArabicAndThai ";
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton5.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton6.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton7.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton8.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton9.Click += new System.EventHandler(this.radioButton1_Click);
            this.Load += new EventHandler(this._Load);


        }


        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();

            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 0);
            this.pictureBox1.Size = new System.Drawing.Size(623, 404);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton7.Location = new System.Drawing.Point(24, 254);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(191, 35);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.Text = "1-100000000";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton6.Location = new System.Drawing.Point(24, 213);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(176, 35);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.Text = "1-10000000";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton5.Location = new System.Drawing.Point(24, 172);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(161, 35);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.Text = "1-1000000";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton4.Location = new System.Drawing.Point(24, 131);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(146, 35);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.Text = "1-100000";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton3.Location = new System.Drawing.Point(24, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(131, 35);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "1-10000";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton2.Location = new System.Drawing.Point(24, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 35);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1-1000";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton1.Location = new System.Drawing.Point(24, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 35);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "1-100";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Location = new System.Drawing.Point(14, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton8.Location = new System.Drawing.Point(222, 29);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(210, 35);
            this.radioButton8.TabIndex = 15;
            this.radioButton8.Text = "ไทย เป็น อาราบิก";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton9.Location = new System.Drawing.Point(6, 29);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(210, 35);
            this.radioButton9.TabIndex = 14;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "อาราบิก เป็น ไทย";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // Math_NumberArabicAndThai
            // 
            this.Name = "Math_NumberArabicAndThai";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
                Ans = GetNum(_Ans.ToString());
                _Choies.Add(Ans);
                int cc = 0;
                for (int b = 1; b < 4; b++)
                {
                    while (_Choies.Contains(GetNum(cc.ToString())) || cc == 0)
                    {
                        int _a = Convert.ToInt32(0.25 * _Ans);
                        cc =  RandomNumberGenerator.GetInt32((_Ans - _a < min) ? min : _Ans - _a, (_Ans + _a > max) ? max : _Ans + _a);
                        System.Threading.Thread.Sleep(100);
                    }
                    _Choies.Add(GetNum(cc.ToString()));

                }

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
                if (radioButton8.Checked)
                    g.DrawString( _Ans.ToArabicAndThai(ArabicAndThaiObtion.ArabicToThai), new Font("Times New Roman", 50), Brushes.Black, pictureBox1.Width/2, pictureBox1.Height/2);
                else if (radioButton9.Checked)
                    g.DrawString( _Ans.ToArabicAndThai(ArabicAndThaiObtion.ThaiToArobic), new Font("Times New Roman", 50), Brushes.Black, pictureBox1.Width / 2, pictureBox1.Height / 2);

                

                pictureBox1.Invoke(new Action(() => { pictureBox1.Image = bmp; }));
                SetButtonText();



            })))
            {
                f.ShowDialog(this);
            }
        }
        private string GetNum(string input)
        {
            string s = "";
            if (radioButton8.Checked)
                s = input.ToArabicAndThai(ArabicAndThaiObtion.ThaiToArobic);
            else if(radioButton9.Checked)
                s = input.ToArabicAndThai(ArabicAndThaiObtion.ArabicToThai);
            return s;
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
