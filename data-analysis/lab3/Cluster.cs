using System.Drawing;
using System.Collections.Generic;
using System;

namespace lab3
{
    class Cluster
    {
        public static List<Cluster> clusters = new List<Cluster>();

        public int centerX;
        public int centerY;
        public List<ColoredPoint> points = new List<ColoredPoint>();
        public Color color;
        
        public Cluster(int X, int Y, Color color)
        {
            this.centerX = X;
            this.centerY = Y;
            this.color = color;
        }
    }
}
