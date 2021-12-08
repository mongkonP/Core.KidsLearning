﻿using System;
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

namespace Core.KidsLearning.Control.MathControl.Operate
{
    public partial class NumberOperater : UserControl
    {
        int n_1 = 1, n_2 = 10, n;

        #region Windows Form Designer generated code
        protected Button button3;
        protected Button button4;
        protected Button button2;
        protected Button button1;
        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private TextBox txtNumMax;
        private TextBox txtNumMin;
        private Label label2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Panel panel3;
        private TextBox txtAddDown;
        private TextBox txtAddUp;
        private Label lblOperater;
        private RadioButton radioButton7;
        private TextBox textBox1;
        private Label label1;
        private RadioButton radioButton8;
        private Panel panel2;
        public NumberOperater(string op = "+")
        {
            InitializeComponent();

            this.button1.Click += new System.EventHandler(this.buttonChoie_Click);
            this.button2.Click += new System.EventHandler(this.buttonChoie_Click);
            this.button3.Click += new System.EventHandler(this.buttonChoie_Click);
            this.button4.Click += new System.EventHandler(this.buttonChoie_Click);
            lblOperater.Text = op;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.txtNumMax = new System.Windows.Forms.TextBox();
            this.txtNumMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddDown = new System.Windows.Forms.TextBox();
            this.txtAddUp = new System.Windows.Forms.TextBox();
            this.lblOperater = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.txtNumMax);
            this.panel1.Controls.Add(this.txtNumMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 623);
            this.panel1.TabIndex = 0;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton8.Location = new System.Drawing.Point(551, 60);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(114, 35);
            this.radioButton8.TabIndex = 16;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "1 to 10";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton7.Location = new System.Drawing.Point(551, 314);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(144, 35);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.Text = "1 to 5000";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // txtNumMax
            // 
            this.txtNumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNumMax.Location = new System.Drawing.Point(790, 355);
            this.txtNumMax.Name = "txtNumMax";
            this.txtNumMax.Size = new System.Drawing.Size(96, 38);
            this.txtNumMax.TabIndex = 13;
            this.txtNumMax.Text = "10000";
            // 
            // txtNumMin
            // 
            this.txtNumMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNumMin.Location = new System.Drawing.Point(654, 355);
            this.txtNumMin.Name = "txtNumMin";
            this.txtNumMin.Size = new System.Drawing.Size(96, 38);
            this.txtNumMin.TabIndex = 12;
            this.txtNumMin.Text = "-1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(747, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton6.Location = new System.Drawing.Point(551, 355);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(112, 35);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.Text = "Range";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton5.Location = new System.Drawing.Point(551, 273);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(129, 35);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.Text = "1 to 500";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton4.Location = new System.Drawing.Point(551, 229);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(145, 35);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "-50  to 50";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtAddDown);
            this.panel3.Controls.Add(this.txtAddUp);
            this.panel3.Controls.Add(this.lblOperater);
            this.panel3.Location = new System.Drawing.Point(23, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 413);
            this.panel3.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(128, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // txtAddDown
            // 
            this.txtAddDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddDown.BackColor = System.Drawing.Color.Black;
            this.txtAddDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAddDown.ForeColor = System.Drawing.Color.White;
            this.txtAddDown.Location = new System.Drawing.Point(46, 210);
            this.txtAddDown.Name = "txtAddDown";
            this.txtAddDown.Size = new System.Drawing.Size(341, 109);
            this.txtAddDown.TabIndex = 14;
            this.txtAddDown.Text = "-1000";
            this.txtAddDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddUp
            // 
            this.txtAddUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddUp.BackColor = System.Drawing.Color.Black;
            this.txtAddUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAddUp.ForeColor = System.Drawing.Color.White;
            this.txtAddUp.Location = new System.Drawing.Point(46, 38);
            this.txtAddUp.Name = "txtAddUp";
            this.txtAddUp.Size = new System.Drawing.Size(341, 109);
            this.txtAddUp.TabIndex = 13;
            this.txtAddUp.Text = "-1000";
            this.txtAddUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperater
            // 
            this.lblOperater.AutoSize = true;
            this.lblOperater.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblOperater.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblOperater.Location = new System.Drawing.Point(359, 125);
            this.lblOperater.Name = "lblOperater";
            this.lblOperater.Size = new System.Drawing.Size(101, 108);
            this.lblOperater.TabIndex = 1;
            this.lblOperater.Text = "+";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton3.Location = new System.Drawing.Point(551, 188);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(114, 35);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "1 to 50";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton2.Location = new System.Drawing.Point(551, 142);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 35);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "20  to 50";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton1.Location = new System.Drawing.Point(551, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 35);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "1 to 20";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 409);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(415, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 86);
            this.button3.TabIndex = 7;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(44, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(352, 86);
            this.button4.TabIndex = 6;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(415, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(44, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NumberOperater
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NumberOperater";
            this.Size = new System.Drawing.Size(1113, 623);
            this.Load += new System.EventHandler(this.Math_1_Number1to50_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private void buttonChoie_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            frmAlert f = new frmAlert((btn.Text == Ans.ToString()) ? Properties.Resources.right : Properties.Resources.Wrong);
            f.ShowDialog();
            //ExtFile.WriteLog(this.Name+ " Ans:" + n_1 + " " + lblOperater.Text + " " + n_2 + " = " + Ans + "//" + ((btn.Text == Ans.ToString()) ? 1 : 0));
            this.OnScoreChange(new ScoreEvent(((btn.Text == Ans.ToString()) ? 1 : 0), 1));
            RandomChoie();
        }
        int Ans;// testChoie ck;
        public void RandomChoie()
        {

            int min = 1, max = 20;
            using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
            {
              
                if (radioButton1.Checked)
                {
                    min = 1; max = 20;
                }
                else if (radioButton2.Checked)
                {
                    min = 20; max = 50;
                }
                else if (radioButton3.Checked)
                {
                    min = 1; max = 50;
                }
                else if (radioButton4.Checked)
                {
                    min = -50; max = 50;
                }
                else if (radioButton5.Checked)
                {
                    min = 1; max = 500;
                }
                else if (radioButton6.Checked)
                {
                    min = int.Parse("" + txtNumMin.Text); max = int.Parse("" + txtNumMax.Text);
                }
                else if (radioButton7.Checked)
                {
                    min = 1; max = 5000;
                }
                else if (radioButton8.Checked)
                {
                    min = 1; max = 10;
                }

                int a = RandomNumberGenerator.GetInt32(min, max);
                int b=  RandomNumberGenerator.GetInt32(min, max);
                n_1 = Math.Max(a, b);
                txtAddUp.Invoke(new Action(() => txtAddUp.Text = n_1.ToString()));
                n_2 = Math.Min(a, b);
                txtAddDown.Invoke(new Action(() => txtAddDown.Text = n_2.ToString()));
                if (lblOperater.Text == "+")
                {
                    Ans = n_1 + n_2;
                }
                else if(lblOperater.Text == "-")
                {
                    Ans = n_1 - n_2;
                }
                else if (lblOperater.Text == "X")
                {
                    Ans = n_1 * n_2;
                }
                else if (lblOperater.Text == "÷")
                {
                    Ans = n_1 / n_2;
                }



                List<int> s = new List<int>();
                s.Add(Ans);
                int cc = 0;
                for (int c = 1; c < 4; c++)
                {
                    while (s.Contains(cc) || cc == 0)
                    {
                        n = (max - min) / 2;
                        cc =  RandomNumberGenerator.GetInt32(Ans - n, Ans + n);
                        System.Threading.Thread.Sleep(100);
                    }
                    s.Add(cc);

                }


                string str;
                for (int c = 1; c < 5; c++)
                {
                    Button btn = this.Controls.Find("button" + c, true).FirstOrDefault() as Button;
                    str = s[ RandomNumberGenerator.GetInt32(0, s.Count)].ToString();
                    btn.Invoke(new Action(() => { btn.Text = str; }));
                    s.Remove(int.Parse(str));
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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RandomChoie();
        }
        private void Math_1_Number1to50_Load(object sender, EventArgs e)
        {

          //  ExtFile.WriteLog(this.Name + "_Load");
            RandomChoie();
        }

    }
}
