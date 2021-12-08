using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.Classed.Exten
{
   public class listNum_A_B
    {
     
        public int A, B;
        public listNum_A_B()
        {
           
        }
        public listNum_A_B(int a, int b)
        {
            A = a;B = b;
        }
        public int MinValue
        {
            get { return Math.Min(A, B); }
          
        }
        public int MaxValue
        {
            get { return Math.Max(A, B); }
        }
    }
}
