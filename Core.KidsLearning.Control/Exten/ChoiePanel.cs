
using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Core.KidsLearning.Control.Exten
{
    public partial class ChoiePanel : Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(38, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 164);
            this.button1.TabIndex = 0;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(506, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 164);
            this.button2.TabIndex = 1;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(506, 235);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 164);
            this.button3.TabIndex = 3;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(38, 235);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(369, 164);
            this.button4.TabIndex = 2;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ChoiePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 434);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChoiePanel";
            this.Load += new System.EventHandler(this.ChoiePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected Button button1;
        protected Button button2;
        protected Button button3;
        protected Button button4;

        public ChoiePanel()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.buttonChoie_Click);
            this.button2.Click += new System.EventHandler(this.buttonChoie_Click);
            this.button3.Click += new System.EventHandler(this.buttonChoie_Click);
            this.button4.Click += new System.EventHandler(this.buttonChoie_Click);
        }
        public string Ans = "";

        public void SetChoie(List<string> _s)
        {
            if (_s == null || _s.Count <= 0) return;
            string str;
            string ss = "";

            Ans = _s[ RandomNumberGenerator.GetInt32(0, _s.Count)];

            str = _s[ RandomNumberGenerator.GetInt32(0, _s.Count)];
            this.button1.Text = str;
            ss += str;
            _s.Remove(str);
            System.Threading.Thread.Sleep(50);
            str = _s[ RandomNumberGenerator.GetInt32(0, _s.Count)];
            this.button2.Text = str;
            ss += str;
            _s.Remove(str);
            System.Threading.Thread.Sleep(50);
            str = _s[ RandomNumberGenerator.GetInt32(0, _s.Count)];
            this.button3.Text = str;
            ss += str;
            _s.Remove(str);
            System.Threading.Thread.Sleep(50);
            str = _s[0];
            this.button4.Text = str;
            ss += str;
            _s.Remove(str);
            System.Threading.Thread.Sleep(50);


        }
        public string button1Text { get { return this.button1.Text; } set { this.button1.Text = value; } }
        public string button2Text { get { return this.button2.Text; } set { this.button2.Text = value; } }
        public string button3Text { get { return this.button3.Text; } set { this.button3.Text = value; } }
        public string button4Text { get { return this.button4.Text; } set { this.button4.Text = value; } }
        public bool CheckAns = false;
        public event EventHandler ButtonClick
        {
            add
            {
                button1.Click += value;
                button2.Click += value;
                button3.Click += value;
                button4.Click += value;
            }
            remove
            {
                button1.Click -= value;
                button2.Click -= value;
                button3.Click -= value;
                button4.Click -= value;
            }
        }


        private void buttonChoie_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            CheckAns = (btn.Text.Trim() == Ans);
        }

        private void ChoiePanel_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        /* #region _Property
         [System.ComponentModel.Browsable(true)]
         [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
         [System.ComponentModel.DefaultValue(5)]
         [System.ComponentModel.Category("TOR Setting")]
         [System.ComponentModel.Description("จำนวนปุ่ม ที่ต้องการใช้")]
         public int CountButton
         {
             set
             {

             }
         }
         #endregion*/
    }
}
