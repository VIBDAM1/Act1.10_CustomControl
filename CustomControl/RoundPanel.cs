using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    internal class RoundedPanel : Panel
    {
        private int borderRadius = 20;
        private Color borderColor = Color.Black;
        private int borderSize = 2;
        private bool showBorder = true;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Radi de les cantonades.")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Color de la vora.")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Gruix de la vora.")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Mostra o oculta la vora.")]
        public bool ShowBorder
        {
            get => showBorder;
            set { showBorder = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
                g.FillPath(new SolidBrush(this.BackColor), path);

                if (showBorder && borderSize > 0)
                {
                    using (Pen pen = new Pen(borderColor, borderSize))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }
    }
}