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

    new Core.KidsLearning.Print.prnMath_Fraction().PrintFromLongDivision_1(30, Print.prnMath_Fraction.LongDivisionOption.MixedNum);
            Application.Run(new frm.Form2());
           // DataTable dt = new DataTable();
           // var v = dt.Compute("5-3+6", "");
         //  MessageBox.Show(Exts.ConvertMoney(75));
          //  Application.Run(new frmLoadFile());

           
        }
    }
}
