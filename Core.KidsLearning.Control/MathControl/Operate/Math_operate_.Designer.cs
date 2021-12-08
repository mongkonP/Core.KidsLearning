namespace Core.KidsLearning.Control.MathControl.Operate
{
    partial class Math_operate_
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
            this.txtNum_1 = new System.Windows.Forms.TextBox();
            this.txtNum_2 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum_1
            // 
            this.txtNum_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNum_1.Location = new System.Drawing.Point(23, 87);
            this.txtNum_1.Name = "txtNum_1";
            this.txtNum_1.Size = new System.Drawing.Size(221, 37);
            this.txtNum_1.TabIndex = 0;
            this.txtNum_1.Text = "9 9 9 9 9 9";
            this.txtNum_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNum_2
            // 
            this.txtNum_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNum_2.Location = new System.Drawing.Point(23, 147);
            this.txtNum_2.Name = "txtNum_2";
            this.txtNum_2.Size = new System.Drawing.Size(221, 37);
            this.txtNum_2.TabIndex = 1;
            this.txtNum_2.Text = "9 9 9 9 9 9";
            this.txtNum_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOperator
            // 
            this.txtOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtOperator.Location = new System.Drawing.Point(252, 107);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(39, 55);
            this.txtOperator.TabIndex = 2;
            this.txtOperator.Text = "+";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(44, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 3);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(44, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 5);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(44, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 5);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Math_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtNum_2);
            this.Controls.Add(this.txtNum_1);
            this.Name = "Math_Add";
            this.Size = new System.Drawing.Size(310, 258);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNum_1;
        public System.Windows.Forms.TextBox txtNum_2;
        public System.Windows.Forms.TextBox txtOperator;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
    }
}
