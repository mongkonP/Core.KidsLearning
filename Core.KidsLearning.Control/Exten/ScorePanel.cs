
using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace Core.KidsLearning.Control.Exten
{
    


    public partial class ScorePanel : UserControl
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
            this.lblscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblscore.Location = new System.Drawing.Point(51, 224);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(125, 73);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "0/0\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(51, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "คะแนน/Score";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(108, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear Score";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAllCount
            // 
            this.lblAllCount.AutoSize = true;
            this.lblAllCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAllCount.Location = new System.Drawing.Point(51, 520);
            this.lblAllCount.Name = "lblAllCount";
            this.lblAllCount.Size = new System.Drawing.Size(159, 73);
            this.lblAllCount.TabIndex = 5;
            this.lblAllCount.Text = "0 ข้อ";
            // 
            // ScorePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAllCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label1);
            this.Name = "ScorePanel";
            this.Size = new System.Drawing.Size(597, 627);
            this.Load += new System.EventHandler(this.CountPanel_Load);
            this.FontChanged += new System.EventHandler(this.ScorePanel_FontChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscore;
        private Button button1;
        private Label lblAllCount;
        private System.Windows.Forms.Label label1;
        public event EventHandler AllCountChanged;
        public event EventHandler ScoreChanged;
        public ScorePanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Right;
        }
        int _c = 0; int _r = 0;
        public int AllCount = 0;
        
        public void AddCount(int right, int Count)
        {
            // _c++;
            _r += right;
            _c += Count;
            AllCount++;
            RefreshCout();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

        }
        public void RefreshCout()
        {
            //if (_c == 0) return;
            lblscore.Text = "ถูก:" + _r + "\nทั้งหมด:" + _c + "\n" + ((double)_r / (double)_c * 100.00).ToString("0.00") + "  %";
            lblAllCount.Text = AllCount + " ข้อ";
            if (AllCountChanged != null)
                AllCountChanged(this, new EventArgs());
            

        }

        private void CountPanel_Load(object sender, EventArgs e)
        {

        }

        private void ScorePanel_FontChanged(object sender, EventArgs e)
        {
            lblscore.Font = this.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _c = 0; _r = 0; AllCount = 0;
          //  ExtFile.WriteLog("ScoreClear");
            RefreshCout();
            OnScoreClear(e);

        }

        #region _ScoreClear
        private static readonly object _ScoreClear = new object();
        public event EventHandler ScoreClear
        {
            add
            {
                this.Events.AddHandler(_ScoreClear, value);
            }
            remove
            {
                this.Events.RemoveHandler(_ScoreClear, value);
            }
        }
        protected virtual void OnScoreClear(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[_ScoreClear];
            if (handler != null) handler(this, e);
        }
        #endregion

    }
}
