using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.Classed.Exten
{
  public static  class ExtGraphics_Eng
    {

        public static void DrawSpellWord(this Graphics e, List<string> lstWord, Font fontDetail, int x, int y)
        {
            //  DrawFillRectangle(e, new SolidBrush(Color.White), new Pen(Color.Black, 2), x, y);
            for (int i = 0; i < lstWord.Count; i++)
            {
                e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x, y, 80, 35));
                e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x, y + 35, 80, 35));

                e.DrawString(lstWord[i], fontDetail, Brushes.Black, x + 20, y, new StringFormat());
                x += 80;
            }

            x += 100;
            e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x, y, 300, 35));
            e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x, y + 35, 300, 35));

        }
    }
}
