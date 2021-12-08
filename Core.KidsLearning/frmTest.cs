using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Core.KidsLearning
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            string dir = @"D:\DLTV\คณิตศาสตร์_1\สื่อ";
            Directory.GetFiles(dir, "*.pdf").ToList<string>()
                .ForEach(f =>
                {
                    richTextBox1.Text += $"\n  #region  {Path.GetFileNameWithoutExtension(f)} \n\n\n  #endregion";

                });
        }
    }
}
