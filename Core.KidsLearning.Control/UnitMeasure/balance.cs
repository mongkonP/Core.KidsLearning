using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Core.KidsLearning.Control.Exten;

namespace Core.KidsLearning.Control.UnitMeasure
{
  public  class balance: UserControlPrint
    {
        public balance()
        {
            this.Paint += _Paint;
        }
        private void _Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            // Translate to center the drawing.
            e.Graphics.TranslateTransform(
                ClientSize.Width / 2,
                ClientSize.Height / 2);

            // Draw the face including tick marks.
            DrawClockFace(e.Graphics);
            // Draw the center.
            e.Graphics.FillEllipse(Brushes.Blue, -5, -5, 10, 10);
        }
        int clW;
        // Draw
        private void DrawClockFace(Graphics gr)
        {
            // Draw.
            using (Pen thick_pen = new Pen(Color.Blue, 4))
            {
                clW = ClientSize.Width;
                // Outline.
                gr.DrawEllipse(thick_pen, -clW / 2 + 2, -clW / 2 + 2, clW - 5, clW - 5);

                // Get scale factors.
                float outer_x_factor = 0.45f * clW;
                float outer_y_factor = 0.45f * clW;
                float inner_x_factor = 0.425f * clW;
                float inner_y_factor = 0.425f * clW;
                float big_x_factor = 0.4f * clW;
                float big_y_factor = 0.4f * clW;

                // Draw the tick marks.
                thick_pen.StartCap = LineCap.Triangle;
                for (int minute = 1; minute <= 80; minute++)
                {
                    double angle = Math.PI * minute / 40;
                    float cos_angle = (float)Math.Cos(angle);
                    float sin_angle = (float)Math.Sin(angle);
                    PointF outer_pt = new PointF(
                        outer_x_factor * cos_angle,
                        outer_y_factor * sin_angle);
                    if (minute % 10 == 0)
                    {
                        PointF inner_pt = new PointF(
                            big_x_factor * cos_angle,
                            big_y_factor * sin_angle);
                        gr.DrawLine(thick_pen, inner_pt, outer_pt);
                    }
                    else
                    {
                        PointF inner_pt = new PointF(
                            inner_x_factor * cos_angle,
                            inner_y_factor * sin_angle);
                        gr.DrawLine(Pens.Blue, inner_pt, outer_pt);
                    }
                }
            }
        }

    }
}
