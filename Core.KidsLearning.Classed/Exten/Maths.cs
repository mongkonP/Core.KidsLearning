using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.Classed
{
 public static   class Maths
    {
        public  enum OperatorSelect { Addition, Subtraction, Multiplication, Division, Exponential,AddSub,MultiDiv,All };
        public static string RandomOP_Add_Subt()
        {
            return (RandomNumberGenerator.GetInt32(0, 1000) > 500) ? "+" : "-";
        }
        public static string RandomOP_Mul_Div()
        {
            return (RandomNumberGenerator.GetInt32(0, 1000) > 500) ? "x" : "÷";
        }
        public static string RandomOP_Add_Subt2(bool unique = true)
        {
            string ss = RandomOP_Add_Subt();
            ss += (unique)?( (ss.Contains("+")) ? "_-" : "_+"):"_" + RandomOP_Add_Subt();
            return ss;
        }
        public static string RandomOP_Mul_Div2(bool unique = true)
        {
            string ss = RandomOP_Mul_Div();
            ss += (unique) ? ((ss.Contains("x")) ? "_÷" : "_x") : "_" + RandomOP_Mul_Div();
            return ss;
        }
        public static string RandomOP_Add_Subt(int count = 2 )
        {
            string ss = "";
            for (int i = 0; i < count; i++)
            {
                ss += "_" + RandomOP_Add_Subt();
            }

            return ss;
        }
        public static string RandomOP_Mul_Div(int count = 2)
        {
            string ss = "";
            for (int i = 0; i < count; i++)
            {
                ss += "_" + RandomOP_Mul_Div();
            }

            return ss;
        }
        public static string RandomOP_All()
        {

            string op = "";
            int c = RandomNumberGenerator.GetInt32(0, 4000);
            if (c < 1000)
            {
                op = "+";
            }
            else if (c >= 1000 && c < 2000)
            {
                op = "-";
            }
            else if (c >= 2000 && c < 3000)
            {
                op = "x";
            }
            else if (c >= 3000 )
            {
                op = "÷";
            }
            return op;
        }

        public static string RandomOP_All(int count = 2)
        {
            string ss = "";
            for (int i = 0; i < count; i++)
            {
                ss += "_" + RandomOP_All();
            }

            return ss;
        }
        public static int RandomNumber(int min, int max)
        {
            return RandomNumberGenerator.GetInt32(min, max);
        }
        public static string Equation_AddSub(int minValue, int maxValue, OperatorSelect operatorSelect1 = OperatorSelect.Addition)
        {
            
            listNum_A_B _A_B = new listNum_A_B(RandomNumberGenerator.GetInt32(minValue, maxValue), RandomNumberGenerator.GetInt32(minValue, maxValue));
            string op;
            if (operatorSelect1 == OperatorSelect.Addition)
            {
                op = " + ";
            }
            else if (operatorSelect1 == OperatorSelect.Subtraction)
            {
                op = " - ";
            }
            else
            {
                op = Maths.RandomOP_Add_Subt();
            }

            return $" { _A_B.MaxValue} {op} {_A_B.MinValue } = ";
        }

    }
}
