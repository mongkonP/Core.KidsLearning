using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.KidsLearning.Classed.Exten
{
 public static   class Exteaphics
    {
        public static void DrawClock(this Graphics e, int x, int y)
        {
            DrawClock(e, Convert.ToDateTime("01/01/9999 00:00:00"), x, y);
        }
        public static void DrawClock(this Graphics e, int hr,int min,int sec, int x, int y)
        {
            DrawClock(e,Convert.ToDateTime("05/01/2009 " + hr + ":" + min + ":" + sec), x, y);
        }
        public static void DrawClock(this Graphics e,DateTime time , int x, int y)
        {
            e.DrawImage(ImageClock(time), x, y);
        }

        public static Image ImageClock(DateTime time)
        {
            Bitmap bitmap = new Bitmap(200,200);

            using (Graphics e = Graphics.FromImage(bitmap))
            {
                e.SmoothingMode = SmoothingMode.AntiAlias;
                e.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                // Translate to center the drawing.
                e.TranslateTransform(90, 90);

                // Draw the face including tick marks.

                int clW;
                using (Pen thick_pen = new Pen(Color.Blue, 4))
                {
                    clW = 150;
                    // Outline.
                    e.DrawEllipse(thick_pen,
                         -clW / 2 + 2, -clW / 2 + 2,
                         clW - 5, clW - 5);

                    // Get scale factors.
                    float outer_x_factor = 0.45f * clW;
                    float outer_y_factor = 0.45f * clW;
                    float inner_x_factor = 0.425f * clW;
                    float inner_y_factor = 0.425f * clW;
                    float big_x_factor = 0.4f * clW;
                    float big_y_factor = 0.4f * clW;


                    // Draw the tick marks.
                    thick_pen.StartCap = LineCap.Triangle;
                    for (int minute = 1; minute <= 60; minute++)
                    {
                        double angle = Math.PI * minute / 30.0;
                        float cos_angle = (float)Math.Cos(angle);
                        float sin_angle = (float)Math.Sin(angle);
                        PointF outer_pt = new PointF(
                            outer_x_factor * cos_angle,
                            outer_y_factor * sin_angle);
                        if (minute % 5 == 0)
                        {
                            PointF inner_pt = new PointF(
                                big_x_factor * cos_angle,
                                big_y_factor * sin_angle);
                            e.DrawLine(thick_pen, inner_pt, outer_pt);
                        }
                        else
                        {
                            PointF inner_pt = new PointF(
                                inner_x_factor * cos_angle,
                                inner_y_factor * sin_angle);
                            e.DrawLine(Pens.Blue, inner_pt, outer_pt);
                        }
                    }
                }
                
                  if (time.Year <3999)
                  {
                   // System.Windows.Forms.MessageBox.Show(time.Year.ToString());
                      // Draw the hands.
                      DateTime _time = time;
                      using (Pen thick_pen = new Pen(Color.Red, 4))
                      {
                          // Get the hour and minute plus any fraction that has elapsed.
                          clW = 150;
                          float hour = _time.Hour +
                              _time.Minute / 60f +      // Plus 60th of hours.
                              _time.Second / 3600f;     // Plus 3600th of hours.
                          float minute = _time.Minute +
                              _time.Second / 60f;       // Plus 60th of minutes.

                          // Draw the hour hand.
                          PointF center = new PointF(0, 0);
                          float hour_x_factor = 0.2f * clW;
                          float hour_y_factor = 0.2f * clW;
                          double hour_angle = -Math.PI / 2 + 2 * Math.PI * hour / 12.0;
                          PointF hour_pt = new PointF(
                              (float)(hour_x_factor * Math.Cos(hour_angle)),
                              (float)(hour_y_factor * Math.Sin(hour_angle)));
                          thick_pen.Color = Color.Red;
                          e.DrawLine(thick_pen, hour_pt, center);

                          // Draw the minute hand.
                          float minute_x_factor = 0.3f * clW;
                          float minute_y_factor = 0.3f * clW;
                          double minute_angle = -Math.PI / 2 + 2 * Math.PI * minute / 60.0;
                          PointF minute_pt = new PointF(
                              (float)(minute_x_factor * Math.Cos(minute_angle)),
                              (float)(minute_y_factor * Math.Sin(minute_angle)));
                          thick_pen.Width = 2;
                          e.DrawLine(thick_pen, minute_pt, center);

                          // Draw the second hand.
                          float second_x_factor = 0.4f * clW;
                          float second_y_factor = 0.4f * clW;
                          double second_angle = -Math.PI / 2 +
                              2 * Math.PI * (int)(_time.Second) / 60.0;
                          PointF second_pt = new PointF(
                              (float)(second_x_factor * Math.Cos(second_angle)),
                              (float)(second_y_factor * Math.Sin(second_angle)));
                          e.DrawLine(Pens.Red, second_pt, center);
                      }
                  }
               

                // Draw the center.
                e.FillEllipse(Brushes.Blue, -5, -5, 10, 10);
            }

            return bitmap;
        
        }


        public static void DrawFraction(this Graphics e, int excfraction, int numerator, int denominator, int x, int y,
            bool numeratorRec = false,bool excfractionRec = false, bool denominatorRec = false,bool excfractionShow = true )
        {
            // Measure string.
           
            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator =  e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);
            SizeF stringSize_excfraction = e.MeasureString(excfraction.ToString() + "   ", stringFont);

           float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y,_w,_h;
            _x =x+5 +  Convert.ToInt32(w);
            _y = y + 2;
            _w = 33;
            _h = 30;
            if (numeratorRec)
            {

                e.DrawRectangle(Pens.Black, new Rectangle(_x,_y ,_w , _h));
            }
            else
            {
                e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }

            e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x+ _w , y + stringSize_numerator.Height - 5);

            _y = y +  _h;

            if (denominatorRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y + 10 , _w, _h));
            }
            else
            {
                e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });

            }



            _x = x ;
            _y = y + _h/2 + 5;
          
            if (excfractionRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x-18, _y, _w, _h));
            }
            else if (excfractionShow)
            {
                e.DrawString(excfraction.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }
            

        }


        public static void DrawFraction(this Graphics e, string numerator, string denominator, int x, int y, bool numeratorRec = false, bool denominatorRec = false)
        {
            // Measure string.

            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);

            float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y, _w, _h;
            _x = x + 5 + Convert.ToInt32(w);
            _y = y + 2;
            _w = Convert.ToInt32(w) + 5;
            _h = 30;
            if (numeratorRec)
            {

                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y, _w, _h));
            }
            else
            {
                e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }

            e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

            _y = y + _h;

            if (denominatorRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y + 10, _w, _h));
            }
            else
            {
                e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });

            }




        }


    }
}
