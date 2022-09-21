using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2DGraphicsWeek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Red);
            g.DrawRectangle(pen, 10, 10, 600, 64);
            g.DrawString("Game: the game", new System.Drawing.Font("Arial", 16), brush, new PointF(192,26));
            g.DrawEllipse(pen, 10, 10, 600, 64);
            g.DrawEllipse(pen, 32, 128, 16, 16);
            g.DrawString("Play", new System.Drawing.Font("Arial", 9), brush, new PointF(64, 128));
            g.DrawRectangle(pen, 32, 158, 16, 16);
            g.DrawString("Options", new System.Drawing.Font("Arial", 9), brush, new PointF(64, 158));
            g.DrawPie(pen, new Rectangle(32, 188, 16, 16), 0f, 270f);
            g.DrawString("Quit", new System.Drawing.Font("Arial", 9), brush, new PointF(64, 188));
            g.DrawArc(pen, new Rectangle(10, 350, 128, 64), 0, 90f);
            
            PointF[] pts;
            pts = new PointF[]
            {
                new PointF(258, 64),
                new PointF(292, 128),
                new PointF(232, 128)
            };
            g.FillPolygon(brush, pts);
            pts = new PointF[]
            {
                new PointF(1,1),
                new PointF(2,1),
                new PointF(3,2),
                new PointF(2,3),
                new PointF(1,3),
                new PointF(0,2)
            };
            for(int i = 0; i < pts.Length; i++)
            {
                pts[i].X *= 32;
                pts[i].Y *= 32;
                pts[i].X += 32;
                pts[i].Y += 250;
            }
            g.FillPolygon(brush, pts);

            pen.Dispose();
        }
    }
}
