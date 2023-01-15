using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapeWF
{
    public class Rectangle:Shape
    {
        Graphics g;
        Brush Brush = Brushes.Red; 
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public override void Draw() => g.FillPolygon(Brush, A, B, C, D);
    }
}
