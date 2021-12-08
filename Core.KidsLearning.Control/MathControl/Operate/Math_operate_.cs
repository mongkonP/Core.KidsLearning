using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.KidsLearning.Control.Exten;
using Core.KidsLearning.Classed.Exten;
using System.Security.Cryptography;

namespace Core.KidsLearning.Control.MathControl.Operate
{
    public partial class Math_operate_ : UserControlPrint
    {
        public int Min = 100;
        public int Max = 100000;
        public Math_operate_()
        {
            InitializeComponent();
          //  randomNumber();
        }
        public string OP= "+_-_X_÷";
        public Bitmap GetImage(int min, int max)
        {
            Min = min; Max = max;
            randomNumber();
            return GetImage();
        }

        public  void  randomNumber(int min, int max)
        {
            Min = min; Max = max;
          randomNumber();
        }
        public void randomNumber(int min, int max,string op)
        {
            Min = min; Max = max;OP = op;
            randomNumber();
        }
        // Random _randomNumber = new Random();
        public  void randomNumber()
        {

           
                // System.Threading.Thread.Sleep(1000);
                int a = RandomNumberGenerator.GetInt32(Min, Max);
                // System.Threading.Thread.Sleep(1000);
                int b = RandomNumberGenerator.GetInt32(Min, Max);
                int _a = Math.Max(a, b);
                int _b = Math.Min(a, b);

                txtNum_1.Invoke(new Action(() => txtNum_1.Text = string.Join(" ", _a.ToString().ToCharArray())));
                txtNum_2.Invoke(new Action(() => txtNum_2.Text = string.Join(" ", _b.ToString().ToCharArray())));
                System.Threading.Thread.Sleep(1000);
            string s1 = OP.Split('_')[0];
            string s2 = (OP.Split('_').Length<=0)?OP.Split('_')[0]: OP.Split('_')[1];
            txtOperator.Invoke(new Action(() => txtOperator.Text = (RandomNumberGenerator.GetInt32(1, 1000) > 500) ? s1: s2));
            

        }
    }
}
