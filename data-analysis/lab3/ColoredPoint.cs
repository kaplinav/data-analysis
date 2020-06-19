using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace lab3
{
    class ColoredPoint
    {
        public static List<ColoredPoint> points = new List<ColoredPoint>();

        public int X { get; private set; }
        public int Y { get; private set; }
        public SolidBrush brush { get; private set; }

        public ColoredPoint(int X, int Y, SolidBrush brush)
        {
            this.X = X;
            this.Y = Y;
            this.brush = brush;
        }
    }
}
