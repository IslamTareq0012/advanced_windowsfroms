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
    public partial class DrawingLines : Form
    {
        List<Point> lstOfXCoordinates = new List<Point>();
        List<Point> lstOfYCoordinates = new List<Point>();
        Boolean getX = true;
        int clicks = 2;
        public DrawingLines()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var grfx = e.Graphics;
            if (lstOfXCoordinates.Count > 0) {
                for (int i = 0; i < lstOfYCoordinates.Count; i++)
                {
                    Pen p1 = new Pen(Color.FromArgb(lstOfYCoordinates[i].X % 255, lstOfYCoordinates[i].Y % 255, (lstOfYCoordinates[i].X + lstOfYCoordinates[i].Y) % 255), 10);
                    grfx.DrawLine(p1, lstOfXCoordinates[i], lstOfYCoordinates[i]);
                }
            }
        }

        private void DrawingLines_MouseDown(object sender, MouseEventArgs e)
        {
            if (getX)
            {
                lstOfXCoordinates.Add(e.Location);
                getX = false;
                clicks--;
            }
            else if (!getX) {
                lstOfYCoordinates.Add(e.Location);
                getX = true;
                clicks--;
            }
        }

        private void DrawingLines_MouseUp(object sender, MouseEventArgs e)
        {
            if (clicks == 0) {
                var grfx = CreateGraphics();
                Pen p1 = new Pen(Color.FromArgb(e.Location.X % 255, e.Location.Y % 255, (e.Location.X + e.Location.Y) % 255) , 10);
                grfx.DrawLine(p1, lstOfXCoordinates.Last(), lstOfYCoordinates.Last());
                clicks = 2;
            }
        }
    }
}
