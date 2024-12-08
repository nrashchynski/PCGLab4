namespace PCGLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            start = new Point(0, 0);
            end = new Point(0, 0);
            center = new Point(0, 0);
            radius = 0;
            bruh = new Pen(Color.FromArgb(80, 80, 80), 4);
            rasterizer = new Rasterizer();
        }

        private System.Diagnostics.Stopwatch watch;
        private Point start, end, center;
        private int radius;
        Pen bruh;
        Rasterizer rasterizer;


        int scale = 14;
        int shift = 7;

        public enum rasterization
        {
            Bresenham = 1,
            BresenhamCircle,
            DDA,
            Wu,
            Naive,
            CastlePitway,
        };

        public void drawMarkup(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb)
        {
            Pen pen_digits = new Pen(Color.Red, 1);
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            int cur_x = 0, cur_y = 0;
            Font font = new Font("Arial", shift - 1);
            int counter = 0;
            gr.DrawString(counter.ToString(), font, pen_digits.Brush, new PointF(cx, cy));
            if (cx <= panel.Width / 2)
            {
                while (cx + cur_x <= panel.Width)
                {
                    counter++;
                    cur_x += scale;
                    PointF pr = new PointF(cx + cur_x, cy);
                    PointF pl = new PointF(cx - cur_x, cy);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);
                }
            }
            else
            {
                while (cx - cur_x >= 0)
                {
                    counter++;
                    cur_x += scale;
                    PointF pr = new PointF(cx + cur_x, cy);
                    PointF pl = new PointF(cx - cur_x, cy);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);
                }
            }
            counter = 0;
            if (cy <= panel.Height / 2)
            {
                while (cy + cur_y <= panel.Height)
                {
                    counter++;
                    cur_y += scale;
                    PointF pl = new PointF(cx, cy + cur_y);
                    PointF pr = new PointF(cx, cy - cur_y);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);

                }
            }
            else
            {
                while (cy - cur_y >= 0)
                {
                    counter++;
                    cur_y += scale;
                    PointF pl = new PointF(cx, cy + cur_y);
                    PointF pr = new PointF(cx, cy - cur_y);
                    gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                    gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);

                }
            }
            while (cx - cur_x >= 0)
            {
                counter++;
                cur_x += scale;
                PointF pr = new PointF(cx + cur_x, cy);
                PointF pl = new PointF(cx - cur_x, cy);
                gr.DrawString(counter.ToString(), font, pen_digits.Brush, pr);
                gr.DrawString("-" + counter.ToString(), font, pen_digits.Brush, pl);
            }

            Pen penR = new Pen(Color.Red, 2);
            gr.DrawLine(penR, cx, 0, cx, panel.Height);
            gr.DrawLine(penR, 0, cy, panel.Width, cy);
            PointF[] x_vec = new PointF[] { new PointF(cx, 0), new PointF(cx - 2, 5), new PointF(cx + 2, 5) };
            PointF[] y_vec = new PointF[] { new PointF(bresenhampanel.Width - 1, cy), new PointF(bresenhampanel.Width - 6, cy - 2), new PointF(bresenhampanel.Width - 6, cy + 2) };
            gr.DrawPolygon(penR, x_vec);
            gr.DrawPolygon(penR, y_vec);
            gr.DrawString("x", new Font("Arial", scale / 2), penR.Brush, new PointF(bresenhampanel.Width - 20, cy - 20));
            gr.DrawString("y", new Font("Arial", scale / 2), penR.Brush, new PointF(cx - 15, 0));

        }

        public void drawPlot(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb)
        {
            Pen pen = new Pen(Color.Gray, 1);
            Pen pen_dash = new Pen(Color.LightGray, 1);
            pen_dash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            gr.DrawRectangle(pen, 0, 0, panel.Width-1, panel.Height-1);
            var cx = panel.Width/2 + hsb.Value*shift;
            var cy = panel.Height/2 - vsb.Value*shift;
            int cur_x = 0, cur_y = 0;
            if (cx <= panel.Width / 2)
            {
                while (cx + cur_x <= panel.Width)
                {
                    gr.DrawLine(pen, cx - cur_x, 0, cx - cur_x, panel.Height);
                    gr.DrawLine(pen, cx + cur_x, 0, cx + cur_x, panel.Height);
                    gr.DrawLine(pen_dash, cx - cur_x + shift, 0, cx - cur_x + shift, panel.Height);
                    gr.DrawLine(pen_dash, cx + cur_x - shift, 0, cx + cur_x - shift, panel.Height);
                    cur_x += scale;
                }
            }
            else
            {
                while (cx - cur_x >= 0)
                {
                    gr.DrawLine(pen, cx - cur_x, 0, cx - cur_x, panel.Height);
                    gr.DrawLine(pen, cx + cur_x, 0, cx + cur_x, panel.Height);
                    gr.DrawLine(pen_dash, cx - cur_x + shift, 0, cx - cur_x + shift, panel.Height);
                    gr.DrawLine(pen_dash, cx + cur_x - shift, 0, cx + cur_x - shift, panel.Height);
                    cur_x += scale;
                }
            }
            if (cy <= panel.Height / 2)
            {
                while (cy + cur_y <= panel.Height)
                {
                    gr.DrawLine(pen, 0, cy - cur_y, panel.Width, cy - cur_y);
                    gr.DrawLine(pen, 0, cy + cur_y, panel.Width, cy + cur_y);
                    gr.DrawLine(pen_dash, 0, cy - cur_y + shift, panel.Width, cy - cur_y + shift);
                    gr.DrawLine(pen_dash, 0, cy + cur_y - shift, panel.Width, cy + cur_y - shift);
                    cur_y += scale;

                }
            }
            else
            {
                while (cy - cur_y >= 0)
                {
                    gr.DrawLine(pen, 0, cy - cur_y, panel.Width, cy - cur_y);
                    gr.DrawLine(pen, 0, cy + cur_y, panel.Width, cy + cur_y);
                    gr.DrawLine(pen_dash, 0, cy - cur_y + shift, panel.Width, cy - cur_y + shift);
                    gr.DrawLine(pen_dash, 0, cy + cur_y - shift, panel.Width, cy + cur_y - shift);
                    cur_y += scale;

                }
            }
        }

        public void drawRasterization(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF begin, int radius)
        {
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var points = rasterizer.CircleBresenham(begin, radius);
            watch.Stop();
            circletime_label.Text = watch.Elapsed.TotalMilliseconds.ToString();
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < points.Length; i++)
            {
                Point p = new Point(points[i].X * scale + cx - shift, -points[i].Y * scale + cy - shift);
                var rect = new Rectangle(p, new Size(scale, scale));
                gr.DrawRectangle(pen, rect);
                gr.FillRectangle(bruh.Brush, rect);
            }
        }

        public void drawRasterization(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF begin, PointF end)
        {
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var points = rasterizer.Wu(begin, end);
            watch.Stop();
            bresenhamtime_label.Text = watch.Elapsed.TotalMilliseconds.ToString();
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            Pen pen;
            for (int i = 0; i < points.Count; i++)
            {
                pen = new Pen(Color.FromArgb((int)Math.Round(255*points[i].Value), 0, 0, 0));
                int x, y;

                Point p = new Point((int)points[i].Key.X * scale + cx - shift, -(int)points[i].Key.Y * scale + cy - shift);
                var rect = new Rectangle(p, new Size(scale, scale));
                gr.DrawRectangle(pen, rect);
                gr.FillRectangle(pen.Brush, rect);
            }
        }

        public void drawRasterization(rasterization r, Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF begin, PointF end)
        {
            Point[] points;
            switch (r)
            {
                case (rasterization.Bresenham):
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.Bresenham(begin, end);
                        watch.Stop();
                        bresenhamtime_label.Text = watch.Elapsed.TotalMilliseconds.ToString();
                        break;
                    }
                case (rasterization.DDA):
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.DDA(begin, end);
                        watch.Stop();
                        ddatime_label.Text = watch.Elapsed.TotalMilliseconds.ToString();
                        break;
                    }
                case (rasterization.Naive):
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.Naive(begin, end);
                        watch.Stop();
                        naivetime_label.Text = watch.Elapsed.TotalMilliseconds.ToString();
                        break;
                    }
                default:
                    {
                        watch = new System.Diagnostics.Stopwatch();
                        watch.Start();
                        points = rasterizer.DDA(begin, end);
                        break;
                    }
            }
            var cx = panel.Width / 2 + hsb.Value * shift;
            var cy = panel.Height / 2 - vsb.Value * shift;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < points.Length; i++)
            {
                Point p = new Point(points[i].X*scale + cx - shift, -points[i].Y* scale + cy - shift);
                var rect = new Rectangle(p, new Size(scale, scale));
                gr.DrawRectangle(pen, rect);
                gr.FillRectangle(bruh.Brush, rect);
            }
        }



        public void drawLine(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, PointF start, PointF end, Color color)
        {
            int cx = (int)panel.Width/2 + hsb.Value * shift;
            int cy = (int)panel.Height/2 - vsb.Value * shift;
            PointF s = new PointF(start.X * scale + cx, -start.Y * scale + cy);
            PointF e = new PointF(end.X * scale + cx, -end.Y * scale + cy);
            Pen p = new Pen(color, (int)Math.Floor((decimal)shift / 2));
            gr.DrawLine(p, s, e);
        }
        public void drawCircle(Graphics gr, Panel panel, VScrollBar vsb, HScrollBar hsb, Point center, int radius, Color color)
        {
            int cx = (int)panel.Width/2 + hsb.Value * shift;
            int cy = (int)panel.Height/2 - vsb.Value * shift;
            gr.DrawEllipse(new Pen(color, (int)Math.Floor((decimal)shift/2)), (center.X * scale) + cx - radius * scale, -center.Y*scale + cy- radius * scale, 2 * radius * scale, 2 * radius * scale);
        }



        private void clear(Panel panel)
        {
            panel.Invalidate();
        }

        private void clearAll()
        {
            clear(bresenhampanel);
            clear(ddapanel);
            clear(circlepanel);
            clear(naivepanel);
        }

        private void clearLinePanels()
        {
            clear(bresenhampanel);
            clear(ddapanel);
            clear(naivepanel);
        }


        private void bresenhampanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, bresenhampanel, bresenham_vScrollBar, bresenham_hScrollBar);
            drawRasterization(rasterization.Bresenham, gr, bresenhampanel, bresenham_vScrollBar, bresenham_hScrollBar, start, end);
            drawMarkup(gr, bresenhampanel, bresenham_vScrollBar, bresenham_hScrollBar);
            drawLine(gr, bresenhampanel, bresenham_vScrollBar, bresenham_hScrollBar, start, end, Color.OrangeRed);
        }

        private void circlepanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, circlepanel, circle_vScrollBar, circle_hScrollBar);
            drawRasterization(gr, circlepanel, circle_vScrollBar, circle_hScrollBar, center, radius);
            drawMarkup(gr, circlepanel, circle_vScrollBar, circle_hScrollBar);
            drawCircle(gr, circlepanel, circle_vScrollBar, circle_hScrollBar, center, radius, Color.OrangeRed);
        }

        private void naivepanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, naivepanel, naive_vScrollBar, naive_hScrollBar);
            drawRasterization(rasterization.Naive, gr, naivepanel, naive_vScrollBar, naive_hScrollBar, start, end);
            drawMarkup(gr, naivepanel, naive_vScrollBar, naive_hScrollBar);
            drawLine(gr, naivepanel, naive_vScrollBar, naive_hScrollBar, start, end, Color.OrangeRed);
        }

        private void ddapanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            drawPlot(gr, ddapanel, dda_vScrollBar, dda_hScrollBar);
            drawRasterization(rasterization.DDA, gr, ddapanel, dda_vScrollBar, dda_hScrollBar, start, end);
            drawMarkup(gr, ddapanel, dda_vScrollBar, dda_hScrollBar);
            drawLine(gr, ddapanel, dda_vScrollBar, dda_hScrollBar, start, end, Color.OrangeRed);
        }

        private void rastLineButton_Click(object sender, EventArgs e)
        {
            start = new Point((int)x1num.Value, (int)y1num.Value);
            end = new Point((int)x2num.Value, (int)y2num.Value);
            clearLinePanels();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    scale = (int)scalenum.Value;
        //    shift = scale / 2;
        //    clearAll();
        //}

        private void rastCircleButton_Click(object sender, EventArgs e)
        {
            center = new Point((int)x0num.Value, (int)y0num.Value);
            radius = (int)radiusnum.Value;
            clear(circlepanel);
        }

        private void bresenham_vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            bresenhampanel.Invalidate();
        }

        private void bresenham_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            bresenhampanel.Invalidate();
        }

        private void naive_vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            naivepanel.Invalidate();
        }

        private void naive_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            naivepanel.Invalidate();
        }

        private void circle_vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            circlepanel.Invalidate();
        }

        private void circle_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            circlepanel.Invalidate();
        }

        private void dda_vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ddapanel.Invalidate();
        }

        private void dda_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ddapanel.Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bresenhamtime_label_Click(object sender, EventArgs e)
        {

        }
    }
}

