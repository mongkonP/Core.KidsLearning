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

namespace Core.KidsLearning.Control
{
    public partial class clock : UserControlPrint
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "clock";
            this.Size = new System.Drawing.Size(158, 154);
            this.Resize += new System.EventHandler(this.clock_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        public clock()
        {
            InitializeComponent();
            this.Paint += _Paint;
        }
        public bool ShowClockHand = true;
        private void clock_Resize(object sender, EventArgs e)
        {
           // this.Size = new Size(120, 120);
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

            // Show the time digitally.
            // ShowDigitalTime(e.Graphics);

            // Draw the hands.
            if(ShowClockHand)
            DrawClockHands(e.Graphics);

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
                gr.DrawEllipse(thick_pen,
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
        public void Settime(DateTime dt)
        {
            _time = dt;
            Refresh();

        }
        public void Settime(string hh, string mm, string ss)
        {
            _time = Convert.ToDateTime("05/01/2009 " + hh + ":" + mm + ":" + ss);
            Refresh();

        }
        DateTime _time = DateTime.Now;

        // Draw the clock's hands.
        private void DrawClockHands(Graphics gr)
        {
            using (Pen thick_pen = new Pen(Color.Red, 4))
            {
                // Get the hour and minute plus any fraction that has elapsed.
                clW = ClientSize.Width;
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
                gr.DrawLine(thick_pen, hour_pt, center);

                // Draw the minute hand.
                float minute_x_factor = 0.3f * clW;
                float minute_y_factor = 0.3f * clW;
                double minute_angle = -Math.PI / 2 + 2 * Math.PI * minute / 60.0;
                PointF minute_pt = new PointF(
                    (float)(minute_x_factor * Math.Cos(minute_angle)),
                    (float)(minute_y_factor * Math.Sin(minute_angle)));
                thick_pen.Width = 2;
                gr.DrawLine(thick_pen, minute_pt, center);

                // Draw the second hand.
                float second_x_factor = 0.4f * clW;
                float second_y_factor = 0.4f * clW;
                double second_angle = -Math.PI / 2 +
                    2 * Math.PI * (int)(_time.Second) / 60.0;
                PointF second_pt = new PointF(
                    (float)(second_x_factor * Math.Cos(second_angle)),
                    (float)(second_y_factor * Math.Sin(second_angle)));
                gr.DrawLine(Pens.Red, second_pt, center);
            }
        }
    }
}
