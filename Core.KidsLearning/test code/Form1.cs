using Core.KidsLearning.Classed;
using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.KidsLearning.test_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawFraction("10 x 25","5 x 25",100,100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ss = "";
            for (int a = 0; a < 20; a++)
            {
                for (int i = 0; i < 2; i++) ss += "_" + Maths.RandomOP_Add_Subt();
                ss += "***";
            }



            richTextBox1.Text = ss;
        }
    }
}
