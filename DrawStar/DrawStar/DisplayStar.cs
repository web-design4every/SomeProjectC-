using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class DisplayStar : UserControl
    {
        int numberStar;
        int value;
        double size;
        public DisplayStar(int numberStar)
        {
            InitializeComponent();
            this.numberStar = numberStar;           // get value for number star
            value = this.numberStar;
        }

        private void DisplayStar_Paint(object sender, PaintEventArgs e)
        {
            int space = 0;
            int width = this.Width;
            size = (double)(width - 20) / (numberStar * 170);
            for (int i = 0; i < value; i++)
            {
                //Create array of points for curve.
                Point point1 = new Point((int)(100 * size) + (int)(space * size), (int)(0 * size));
                Point point2 = new Point((int)(80 * size) + (int)(space * size), (int)(50 * size));
                Point point3 = new Point((int)(25 * size) + (int)(space * size), (int)(50 * size));
                Point point4 = new Point((int)(70 * size) + (int)(space * size), (int)(75 * size));
                Point point5 = new Point((int)(50 * size) + (int)(space * size), (int)(125 * size));
                Point point6 = new Point((int)(100 * size) + (int)(space * size), (int)(100 * size));
                Point point7 = new Point((int)(150 * size) + (int)(space * size), (int)(125 * size));
                Point point8 = new Point((int)(130 * size) + (int)(space * size), (int)(75 * size));
                Point point9 = new Point((int)(175 * size) + (int)(space * size), (int)(50 * size));
                Point point10 = new Point((int)(120 * size) + (int)(space * size), (int)(50 * size));

                Point[] points = { point1, point2, point3, point4, point5, point6,
                point7, point8, point9, point10};
                e.Graphics.FillPolygon(Brushes.Yellow, points);

                space += 170;
            }

            space = 0;

            for (int i = 0; i < numberStar; i++)
            {
                //Create array of points for curve.
                Point point1 = new Point((int)(100 * size) + (int)(space * size), (int)(0 * size));
                Point point2 = new Point((int)(80 * size) + (int)(space * size), (int)(50 * size));
                Point point3 = new Point((int)(25 * size) + (int)(space * size), (int)(50 * size));
                Point point4 = new Point((int)(70 * size) + (int)(space * size), (int)(75 * size));
                Point point5 = new Point((int)(50 * size) + (int)(space * size), (int)(125 * size));
                Point point6 = new Point((int)(100 * size) + (int)(space * size), (int)(100 * size));
                Point point7 = new Point((int)(150 * size) + (int)(space * size), (int)(125 * size));
                Point point8 = new Point((int)(130 * size) + (int)(space * size), (int)(75 * size));
                Point point9 = new Point((int)(175 * size) + (int)(space * size), (int)(50 * size));
                Point point10 = new Point((int)(120 * size) + (int)(space * size), (int)(50 * size));

                Point[] points = { point1, point2, point3, point4, point5, point6,
                point7, point8, point9, point10};
                e.Graphics.DrawPolygon(new Pen(Color.Black, 2), points);

                space += 170;
            }
        }

        private void DisplayStar_Load(object sender, EventArgs e)
        {

        }

        private void DisplayStar_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
