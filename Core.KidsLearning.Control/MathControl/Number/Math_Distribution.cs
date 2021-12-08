using Core.KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Core.KidsLearning.Control.MathControl.Number
{
   public  class Math_Distribution : Choie4Choie
    {
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        public Math_Distribution()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(671, 313);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Size = new System.Drawing.Size(671, 226);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_B);
            this.panel1.Controls.Add(this.txt_A);
            this.panel1.Controls.Add(this.txt_C);
            this.panel1.Size = new System.Drawing.Size(671, 313);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.txt_C, 0);
            this.panel1.Controls.SetChildIndex(this.txt_A, 0);
            this.panel1.Controls.SetChildIndex(this.txt_B, 0);
            // 
            // txt_C
            // 
            this.txt_C.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_C.Location = new System.Drawing.Point(258, 47);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(130, 57);
            this.txt_C.TabIndex = 1;
            this.txt_C.Text = "123";
            this.txt_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_A
            // 
            this.txt_A.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_A.Location = new System.Drawing.Point(115, 196);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(130, 57);
            this.txt_A.TabIndex = 2;
            this.txt_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_B
            // 
            this.txt_B.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_B.Location = new System.Drawing.Point(380, 196);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(130, 57);
            this.txt_B.TabIndex = 3;
            this.txt_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Math_Distribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "Math_Distribution";
            this.Size = new System.Drawing.Size(671, 539);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

           // MessageBox.Show("555");
            e.Graphics.DrawLine(new Pen(Color.Black, 4), txt_C.Location.X + txt_C.Width / 2, txt_C.Location.Y + txt_C.Height, txt_A.Location.X + txt_A.Width / 2, txt_A.Location.Y);
            e.Graphics.DrawLine(new Pen(Color.Black, 4), txt_C.Location.X + txt_C.Width / 2, txt_C.Location.Y + txt_C.Height, txt_B.Location.X + txt_B.Width / 2, txt_B.Location.Y);
        }


    }
}
