using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DayTradingApp
{
    public class SimpleScrollBar : Control
    {
        public int Maximum { get; set; } = 100;
        public int Value { get; set; } = 0;
        public int ThumbSize { get; set; } = 120; 

        bool dragging = false;
        int dragOffset = 0;

        private readonly Color trackColor = Color.PaleTurquoise;
        private readonly Color thumbColor = Color.DarkCyan;

        public SimpleScrollBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            Width = 15;
            Height = 500;  
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Track
            using (var track = new SolidBrush(trackColor))
                g.FillRectangle(track, 0, 0, Width, Height);

            // Compute thumb position
            int available = Math.Max(1, Height - ThumbSize);
            int max = Math.Max(1, Maximum);
            int y = (int)((Value / (float)max) * available);
            y = Math.Max(0, Math.Min(available, y));

            // Rounded thumb 
            using (var thumb = new SolidBrush(thumbColor))
            using (var path = RoundedRect(new Rectangle(0, y, Width, ThumbSize), Width / 2))
            {
                g.FillPath(thumb, path);
            }
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            int available = Height - ThumbSize;
            int y = (int)((Value / (float)Maximum) * available);

            if (e.Y >= y && e.Y <= y + ThumbSize)
            {
                dragging = true;
                dragOffset = e.Y - y;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e) => dragging = false;

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (dragging)
            {
                int available = Height - ThumbSize;
                int newY = Math.Max(0, Math.Min(available, e.Y - dragOffset));

                Value = (int)((newY / (float)available) * Maximum);
                Invalidate();

                Scroll?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler Scroll;

        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            radius = Math.Max(0, Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2));
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}