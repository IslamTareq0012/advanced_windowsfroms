using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Rectangles : Form
    {
        List<Point> lst = new List<Point>();
        public Rectangles()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var grfx = e.Graphics;
            for (int i = 0; i < lst?.Count; i++)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(lst[i].X % 255, lst[i].Y % 255, (lst[i].X + lst[i].Y) % 255));
                //Pen p = new Pen(Color.FromArgb(e.Location.X % 255, e.Location.Y % 255, (e.Location.X + e.Location.Y) % 255), 20);
                grfx.FillRectangle(sb, lst[i].X - 15, lst[i].Y - 15, 30, 30);

            }
        }

        private void Rectangles_MouseClick(object sender, MouseEventArgs e)
        {
            var grfx = CreateGraphics();

            SolidBrush sb = new SolidBrush(Color.FromArgb(e.Location.X % 255, e.Location.Y % 255, (e.Location.X + e.Location.Y) % 255));
            //Pen p = new Pen(Color.FromArgb(e.Location.X % 255, e.Location.Y % 255, (e.Location.X + e.Location.Y) % 255), 20);
            grfx.FillRectangle(sb, e.Location.X - 15, e.Location.Y - 15, 30, 30);

            if (!lst.Contains(e.Location))
            {
                lst.Add(e.Location);
            }
        }
    }
}
