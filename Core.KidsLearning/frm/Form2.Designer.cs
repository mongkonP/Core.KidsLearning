
namespace Core.KidsLearning.frm
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choie4Choie1 = new Core.KidsLearning.Control.Exten.Choie4Choie();
            this.SuspendLayout();
            // 
            // choie4Choie1
            // 
            this.choie4Choie1.Location = new System.Drawing.Point(56, -12);
            this.choie4Choie1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.choie4Choie1.Name = "choie4Choie1";
            this.choie4Choie1.Size = new System.Drawing.Size(1272, 622);
            this.choie4Choie1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 568);
            this.Controls.Add(this.choie4Choie1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Exten.Choie4Choie choie4Choie1;
    }
}