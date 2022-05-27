using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
            protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sb = new SolidBrush(Color.GhostWhite);
            SolidBrush sblack = new SolidBrush(Color.Black);
            SolidBrush sborange = new SolidBrush(Color.Orange);
            SolidBrush sbred = new SolidBrush(Color.IndianRed);
            SolidBrush sbdred = new SolidBrush(Color.DarkRed);
            Pen penline = new Pen(Color.Black, 5);
            g.FillPolygon(sbdred, new Point[]{
                new Point(418,160),
                new Point(445,165),
                new Point(550,180),
                new Point(575,190),
                new Point(575,167),
                new Point(550,160),
                new Point(445,140),
                new Point(418,150),
            });
            g.FillEllipse(sb, 350, 250, 200, 200);
            g.FillEllipse(sb, 387, 150, 125, 125);
            g.FillEllipse(sb, 407, 75, 85, 85);
            g.FillEllipse(sblack, 440, 170, 15, 15);
            g.FillEllipse(sblack, 440, 190, 15, 15);
            g.FillEllipse(sblack, 440, 210, 15, 15);
            g.FillEllipse(sblack, 430, 100, 15, 15);
            g.FillEllipse(sblack, 450, 100, 15, 15);
            g.FillRectangle(sblack, 425, 10, 50, 75);
            g.FillPolygon(sbred, new Point[]{
                new Point(418,160),
                new Point(445,167),
                new Point(550,160),
                new Point(590,165),
                new Point(590,145),
                new Point(550,140),
                new Point(445,152),
                new Point(418,150),
            });
            g.DrawLine(penline, 400, 85, 500, 85);
            g.FillPolygon(sborange, new Point[]{
                new Point(445,110),
                new Point(500,120),
                new Point(445,130),
            });
            penline.Dispose();
            sblack.Dispose();
            sborange.Dispose();
            sb.Dispose();
            g.Dispose();
        }
    
    }

}
