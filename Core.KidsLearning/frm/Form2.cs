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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           

            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(Color.White);

            // Create rectangle.
            Rectangle rect = new Rectangle(30, 30, 200, 200);

            int a = RandomNumberGenerator.GetInt32(100, 1000);
            int b = RandomNumberGenerator.GetInt32(100, 1000);
            e.Graphics.DrawMultiNumberSol(new listNum_A_B(a,b), new Font("Arial", 16), 30, 30);


             a = RandomNumberGenerator.GetInt32(100, 1000);
             b = RandomNumberGenerator.GetInt32(100, 1000);
            e.Graphics.DrawMultiNumberSol( new listNum_A_B(a, b), new Font("Arial", 16), 300, 30);

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
    }
}
