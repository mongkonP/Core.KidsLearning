using Core.KidsLearning.Classed;
using Core.KidsLearning.frm;
using Core.KidsLearning.test_code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.KidsLearning
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

      //  new prnMath_Equation().PrintFromEquation_AddSub_1(2,100,1000, Maths.OperatorSelect.AddSub);
            Application.Run(new frmMain());
           // DataTable dt = new DataTable();
           // var v = dt.Compute("5-3+6", "");
         //  MessageBox.Show(Exts.ConvertMoney(75));
          //  Application.Run(new frmLoadFile());

           
        }
    }
}
