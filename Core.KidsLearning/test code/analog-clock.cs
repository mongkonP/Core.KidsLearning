using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//http://csharphelper.com/blog/2016/08/draw-an-analog-clock-in-c/
namespace Core.KidsLearning.test_code
{
   public partial class analog_clock : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.ctxOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize100x100 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize150x150 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize200x200 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSize100x150 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDigital = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxKeepOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 250;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // ctxOptions
            // 
            this.ctxOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ctxDigital,
            this.ctxKeepOnTop,
            this.toolStripSeparator1,
            this.ctxExit});
            this.ctxOptions.Name = "contextMenuStrip1";
            this.ctxOptions.Size = new System.Drawing.Size(143, 98);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSize100x100,
            this.ctxSize150x150,
            this.ctxSize200x200,
            this.ctxSize100x150});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "&Size";
            // 
            // ctxSize100x100
            // 
            this.ctxSize100x100.Name = "ctxSize100x100";
            this.ctxSize100x100.Size = new System.Drawing.Size(152, 22);
            this.ctxSize100x100.Tag = "";
            this.ctxSize100x100.Text = "&100x100";
            this.ctxSize100x100.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize150x150
            // 
            this.ctxSize150x150.Name = "ctxSize150x150";
            this.ctxSize150x150.Size = new System.Drawing.Size(152, 22);
            this.ctxSize150x150.Tag = "";
            this.ctxSize150x150.Text = "1&50x150";
            this.ctxSize150x150.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize200x200
            // 
            this.ctxSize200x200.Checked = true;
            this.ctxSize200x200.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctxSize200x200.Name = "ctxSize200x200";
            this.ctxSize200x200.Size = new System.Drawing.Size(152, 22);
            this.ctxSize200x200.Tag = "";
            this.ctxSize200x200.Text = "&200x200";
            this.ctxSize200x200.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxSize100x150
            // 
            this.ctxSize100x150.Name = "ctxSize100x150";
            this.ctxSize100x150.Size = new System.Drawing.Size(152, 22);
            this.ctxSize100x150.Tag = "";
            this.ctxSize100x150.Text = "100x150";
            this.ctxSize100x150.Click += new System.EventHandler(this.mnuSize_Click);
            // 
            // ctxDigital
            // 
            this.ctxDigital.Name = "ctxDigital";
            this.ctxDigital.Size = new System.Drawing.Size(152, 22);
            this.ctxDigital.Text = "&Digital";
            this.ctxDigital.Click += new System.EventHandler(this.ctxDigital_Click);
            // 
            // ctxKeepOnTop
            // 
            this.ctxKeepOnTop.Name = "ctxKeepOnTop";
            this.ctxKeepOnTop.Size = new System.Drawing.Size(152, 22);
            this.ctxKeepOnTop.Text = "&Keep On Top";
            this.ctxKeepOnTop.Click += new System.EventHandler(this.ctxKeepOnTop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(152, 22);
            this.ctxExit.Text = "E&xit";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // analog_clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "analog_clock";
            this.Load += new System.EventHandler(this.analog_clock_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.analog_clock_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.analog_clock_MouseDown);
            this.ctxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ContextMenuStrip ctxOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctxSize100x100;
        private System.Windows.Forms.ToolStripMenuItem ctxSize150x150;
        private System.Windows.Forms.ToolStripMenuItem ctxSize200x200;
        private System.Windows.Forms.ToolStripMenuItem ctxSize100x150;
        private System.Windows.Forms.ToolStripMenuItem ctxDigital;
        private System.Windows.Forms.ToolStripMenuItem ctxKeepOnTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;


        public analog_clock()
        {
            InitializeComponent();
        }

        // True to show the digital time.
        private bool ShowDigital = false;

        // Prepare the form.
        private void analog_clock_Load(object sender, EventArgs e)
        {
            // Attach the context menu.
            // (You could do this at design time.)
            ContextMenuStrip = ctxOptions;

            // Set the size to 200x200.
            SetSize(ctxSize200x200);

            // Use double-buffering.
            DoubleBuffered = true;

            // Don't show in the task bar.
            ShowInTaskbar = false;

            // Set focus to the form. If you don't do this,
            // then Alt+F4 doesn't close the clock properly.
            Focus();
        }

        private void analog_clock_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                this.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        // Draw the clock.
        private void analog_clock_Paint(object sender, PaintEventArgs e)
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
            ShowDigitalTime(e.Graphics);

            // Draw the hands.
            DrawClockHands(e.Graphics);

            // Draw the center.
            e.Graphics.FillEllipse(Brushes.Blue, -5, -5, 10, 10);
        }

        // Draw
        private void DrawClockFace(Graphics gr)
        {
            // Draw.
            using (Pen thick_pen = new Pen(Color.Blue, 4))
            {
                // Outline.
                gr.DrawEllipse(thick_pen,
                    -ClientSize.Width / 2, -ClientSize.Height / 2,
                    ClientSize.Width, ClientSize.Height);

                // Get scale factors.
                float outer_x_factor = 0.45f * ClientSize.Width;
                float outer_y_factor = 0.45f * ClientSize.Height;
                float inner_x_factor = 0.425f * ClientSize.Width;
                float inner_y_factor = 0.425f * ClientSize.Height;
                float big_x_factor = 0.4f * ClientSize.Width;
                float big_y_factor = 0.4f * ClientSize.Height;

                //draw clock numbers
                /* gr.DrawString("12", new Font("Ariel", 12), Brushes.Black, new PointF(-12, -120));
                 gr.DrawString("1", new Font("Ariel", 12), Brushes.Black, new PointF(45, -100));
                 gr.DrawString("2", new Font("Ariel", 12), Brushes.Black, new PointF(90, -65));
                 gr.DrawString("3", new Font("Ariel", 12), Brushes.Black, new PointF(100, -10));
                 gr.DrawString("4", new Font("Ariel", 12), Brushes.Black, new PointF(85, 40));
                 gr.DrawString("5", new Font("Ariel", 12), Brushes.Black, new PointF(40, 80));
                 gr.DrawString("6", new Font("Ariel", 12), Brushes.Black, new PointF(-7, 100));
                 gr.DrawString("7", new Font("Ariel", 12), Brushes.Black, new PointF(-62, 88));
                 gr.DrawString("8", new Font("Ariel", 12), Brushes.Black, new PointF(-100, 48));
                 gr.DrawString("9", new Font("Ariel", 12), Brushes.Black, new PointF(-115, -10));
                 gr.DrawString("10", new Font("Ariel", 12), Brushes.Black, new PointF(-100, -60));
                 gr.DrawString("11", new Font("Ariel", 12), Brushes.Black, new PointF(-60, -100));*/


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

        // Show the time digitally.
        private void ShowDigitalTime(Graphics gr)
        {
            // Display the time digitally.
            if (ShowDigital)
            {
                using (Font font = new Font("Times New Roman",
                    ClientSize.Height / 10, GraphicsUnit.Pixel))
                {
                    using (StringFormat string_format = new StringFormat())
                    {
                        string_format.Alignment = StringAlignment.Center;
                        string_format.LineAlignment = StringAlignment.Center;
                        gr.DrawString(DateTime.Now.ToLongTimeString(),
                            font, Brushes.Blue, 0, -font.Height,
                            string_format);
                    }
                }
            }
        }

        // Draw the clock's hands.
        private void DrawClockHands(Graphics gr)
        {
            using (Pen thick_pen = new Pen(Color.Red, 4))
            {
                // Get the hour and minute plus any fraction that has elapsed.
                DateTime now = DateTime.Now;
                float hour = now.Hour +
                    now.Minute / 60f +      // Plus 60th of hours.
                    now.Second / 3600f;     // Plus 3600th of hours.
                float minute = now.Minute +
                    now.Second / 60f;       // Plus 60th of minutes.

                // Draw the hour hand.
                PointF center = new PointF(0, 0);
                float hour_x_factor = 0.2f * ClientSize.Width;
                float hour_y_factor = 0.2f * ClientSize.Height;
                double hour_angle = -Math.PI / 2 + 2 * Math.PI * hour / 12.0;
                PointF hour_pt = new PointF(
                    (float)(hour_x_factor * Math.Cos(hour_angle)),
                    (float)(hour_y_factor * Math.Sin(hour_angle)));
                thick_pen.Color = Color.Red;
                gr.DrawLine(thick_pen, hour_pt, center);

                // Draw the minute hand.
                float minute_x_factor = 0.3f * ClientSize.Width;
                float minute_y_factor = 0.3f * ClientSize.Height;
                double minute_angle = -Math.PI / 2 + 2 * Math.PI * minute / 60.0;
                PointF minute_pt = new PointF(
                    (float)(minute_x_factor * Math.Cos(minute_angle)),
                    (float)(minute_y_factor * Math.Sin(minute_angle)));
                thick_pen.Width = 2;
                gr.DrawLine(thick_pen, minute_pt, center);

                // Draw the second hand.
                float second_x_factor = 0.4f * ClientSize.Width;
                float second_y_factor = 0.4f * ClientSize.Height;
                double second_angle = -Math.PI / 2 +
                    2 * Math.PI * (int)(now.Second) / 60.0;
                PointF second_pt = new PointF(
                    (float)(second_x_factor * Math.Cos(second_angle)),
                    (float)(second_y_factor * Math.Sin(second_angle)));
                gr.DrawLine(Pens.Red, second_pt, center);
            }
        }

        // Redraw to show the current hand position.
        private void tmrTick_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        // Resize the form.
        private void mnuSize_Click(object sender, EventArgs e)
        {
            // Resize the form.
            SetSize(sender as ToolStripMenuItem);
        }

        // Set the form's size according to the menu item's caption.
        private void SetSize(ToolStripMenuItem menu_item)
        {
            // Resize the form.
            string text = menu_item.Text.Replace("&", "");
            int width = int.Parse(text.Split('x')[0]);
            int height = int.Parse(text.Split('x')[1]);
            ClientSize = new Size(width, height);

            // Set the form's region.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(this.ClientRectangle);
            this.Region = new Region(path);

            // Redraw.
            Refresh();

            // Check the correct menu item.
            ToolStripMenuItem[] items =
            {
                ctxSize100x100,
                ctxSize150x150,
                ctxSize100x150,
                ctxSize200x200
            };
            foreach (ToolStripMenuItem item in items)
                item.Checked = (item == menu_item);
        }

        // Exit.
        private void ctxExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Show or hide the digital clock.
        private void ctxDigital_Click(object sender, EventArgs e)
        {
            ShowDigital = !ShowDigital;
            ctxDigital.Checked = ShowDigital;
        }

        // Toggle Keep On Top.
        private void ctxKeepOnTop_Click(object sender, EventArgs e)
        {
            ctxKeepOnTop.Checked = !ctxKeepOnTop.Checked;
            this.TopMost = ctxKeepOnTop.Checked;
        }


    }
}
