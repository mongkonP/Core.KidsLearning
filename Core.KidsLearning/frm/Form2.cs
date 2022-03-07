using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.KidsLearning.Classed.Exten;
namespace Core.KidsLearning.frm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Resize(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle to bound ellipse.
            Rectangle rect = new Rectangle(0, 0, 100, 200);

            // Create start and sweep angles on ellipse.
            float startAngle = 40;
            float sweepAngle = 45;

            // Draw arc to screen.
            e.Graphics.DrawArc(blackPen, rect, startAngle, sweepAngle);
        }
    }
}
