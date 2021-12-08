using Core.KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.KidsLearning.clss.plnt
{
   public  class prnMath_Geometry : prnClass
    {

        #region Variables

        int minValue, maxValue;
        int countC = 13;
        List<string> converts = new List<string>() { "1 วัน=24 ชั่วโมง", "1 ชั่วโมง=60 นาที", "1 นาที=60 วินาที" };
        #endregion
        public prnMath_Geometry()
        {

            _ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";//Please convert the following units to be correct. 
            _ReportToppic = "เขียนชื่อหน่วยนับ และ เลข อุปสรรค ต่อไปนี้ให้ถูกต้อง";
        }


        int ic = 0;
    }
}
