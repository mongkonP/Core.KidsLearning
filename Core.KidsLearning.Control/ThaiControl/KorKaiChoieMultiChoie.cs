using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.KidsLearning.Control.Exten;
using Core.KidsLearning.Classed.Exten;
using System.Security.Cryptography;

namespace Core.KidsLearning.Control.ThaiControl
{
    public partial class KorKaiChoieMultiChoie : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 331);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(732, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 236);
            this.panel2.TabIndex = 3;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button16.ForeColor = System.Drawing.Color.Blue;
            this.button16.Location = new System.Drawing.Point(636, 88);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(65, 70);
            this.button16.TabIndex = 23;
            this.button16.Text = "A";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button11.ForeColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(494, 88);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 70);
            this.button11.TabIndex = 18;
            this.button11.Text = "A";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button12.ForeColor = System.Drawing.Color.Blue;
            this.button12.Location = new System.Drawing.Point(423, 88);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 70);
            this.button12.TabIndex = 17;
            this.button12.Text = "A";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button13.ForeColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(352, 88);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 70);
            this.button13.TabIndex = 16;
            this.button13.Text = "A";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button14.ForeColor = System.Drawing.Color.Blue;
            this.button14.Location = new System.Drawing.Point(281, 88);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(65, 70);
            this.button14.TabIndex = 15;
            this.button14.Text = "A";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button15.ForeColor = System.Drawing.Color.Blue;
            this.button15.Location = new System.Drawing.Point(565, 88);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(65, 70);
            this.button15.TabIndex = 14;
            this.button15.Text = "A";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(210, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 70);
            this.button6.TabIndex = 13;
            this.button6.Text = "A";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(139, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 70);
            this.button7.TabIndex = 12;
            this.button7.Text = "A";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(636, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 70);
            this.button8.TabIndex = 11;
            this.button8.Text = "A";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(565, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 70);
            this.button9.TabIndex = 10;
            this.button9.Text = "A";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button10.ForeColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(494, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 70);
            this.button10.TabIndex = 9;
            this.button10.Text = "A";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(423, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 70);
            this.button5.TabIndex = 8;
            this.button5.Text = "A";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(352, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 70);
            this.button4.TabIndex = 7;
            this.button4.Text = "A";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(281, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "A";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(210, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(139, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KorKaiChoieMultiChoie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "KorKaiChoieMultiChoie";
            this.Size = new System.Drawing.Size(1009, 567);
            this.Load += new System.EventHandler(this.KorKaiChoieMultiChoie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button button11;
        protected System.Windows.Forms.Button button12;
        protected System.Windows.Forms.Button button13;
        protected System.Windows.Forms.Button button14;
        protected System.Windows.Forms.Button button15;
        protected System.Windows.Forms.Button button6;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Button button8;
        protected System.Windows.Forms.Button button9;
        protected System.Windows.Forms.Button button10;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button4;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
        protected Button button16;
        private System.Windows.Forms.Label label1;
        public KorKaiChoieMultiChoie(string path)
        {
            InitializeComponent();
            for (int i = 1; i <= 16; i++)
            {
                Button btn = this.Controls.Find("button" + i, true).FirstOrDefault() as Button;
                btn.Click += new System.EventHandler(this.buttonChoie_Click);
            }
            SetPath(path);

        }
        /* public KorKaiChoieMultiChoie()
         {
             InitializeComponent();
             for (int i = 1; i < 16; i++)
             {
                 Button btn = this.Controls.Find("button" + i, true).FirstOrDefault() as Button;
                 btn.Click += new System.EventHandler(this.buttonChoie_Click);
             }
         }*/
        string _pathpic;
        int countAns = 0;
        int countright = 0;
        // int countWrong = 0;
        int countClick = 0;
        // int right = 0;
        public void SetPath(string path)
        {
            _pathpic = path;
            ck = new testChoie(path + "\\txt.txt");
            if (ck == null) return;
            // RandomChoie();
        }
        private void buttonChoie_Click(object sender, EventArgs e)
        {
            countClick++;
            Button btn = sender as Button;

            if (btn.Text.Trim() == Ans)
            {
                btn.BackColor = Color.Yellow; countright += 1;
            }
            else if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.Red; //countright -= 1; 
            }
            else
            {
                btn.BackColor = Color.Red; //countright -= 1;
            }

            label1.Text = countright + "/" + countAns;
            if (countClick >= countAns)
            {
                //ExtFile.WriteLog("KorKaiChoieMultiChoie " + countAns + "//" + countright);
                this.OnScoreChange(new ScoreEvent(countright, countAns));
                RandomChoie();
            }



        }
        string Ans = ""; testChoie ck;
        public void RandomChoie()
        {
            if (ck == null || ck.Choies == null || ck.Choies.Count <= 0) return;
            using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
            {
                countright = 0; countClick = 0;

                label1.Invoke(new Action(() => label1.Text = ""));
               List<string> s; int i;

                System.Threading.Thread.Sleep(100);
                do
                {
                    i = RandomNumberGenerator.GetInt32(0, ck.Choies.Count - 1);
                    Ans = ck.Choies[i].Answer;
                    s = ck.Choies[i].Choie;
                } while (string.IsNullOrEmpty(Ans) || s.Count <= 0);
                pictureBox1.Invoke(new Action(() => { pictureBox1.Image = Image.FromFile(_pathpic + "\\" + Ans + ".jpg"); }));

                for (int b = 1; b <= 16; b++)
                {
                    Button btn = this.Controls.Find("button" + b, true).FirstOrDefault() as Button;
                    btn.Invoke(new Action(() => { btn.Text = ""; btn.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))); }));
                    System.Threading.Thread.Sleep(50);

                }

                countAns =0 ;
                for (int b = 1; b <= RandomNumberGenerator.GetInt32(5, 10) ; b++)
                {
                    
                    Button btn = this.Controls.Find("button" +  RandomNumberGenerator.GetInt32(1, 16), true).FirstOrDefault() as Button;
                    if (btn.Text == "")
                    { 
                     btn.Invoke(new Action(() => { btn.Text = Ans; })); 
                        countAns += 1;                 
                    }

                    System.Threading.Thread.Sleep(50);
                }

                s.Remove(Ans);
                for (int b = 1; b <= 16; b++)
                {
                    Button btn = this.Controls.Find("button" + b, true).FirstOrDefault() as Button;
                    if (btn.Text == "")
                    {
                        btn.Invoke(new Action(() => { btn.Text = s[ RandomNumberGenerator.GetInt32(0, s.Count)]; }));
                       if (btn.Text == Ans) countAns += 1;
                    }

                    System.Threading.Thread.Sleep(50);

                }

            })))
            {
                f.ShowDialog(this);
            }
        }

        #region _ScoreChange
        private static readonly object _ScoreChange = new object();
        public event ScoreEventHandler ScoreChange
        {
            add
            {
                this.Events.AddHandler(_ScoreChange, value);
            }
            remove
            {
                this.Events.RemoveHandler(_ScoreChange, value);
            }
        }
        protected virtual void OnScoreChange(ScoreEvent e)
        {
            ScoreEventHandler handler = (ScoreEventHandler)Events[_ScoreChange];
            if (handler != null) handler(this, e);
        }
        #endregion

        private void KorKaiChoieMultiChoie_Load(object sender, EventArgs e)
        {
            //ExtFile.WriteLog("KorKaiChoieMultiChoie_Load" );
            RandomChoie();
        }

    }
}
