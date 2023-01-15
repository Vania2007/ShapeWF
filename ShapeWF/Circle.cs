using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapeWF
{
    public class Circle: Shape
    {
        Graphics g;
        Brush Brush = Brushes.Blue;
        public Point O { get;set;}
        public double Width { get; set; }
        public double  Height { get; set; }

        public override void Draw() => g.FillEllipse(Brush, O, Width, Height);
    }
}
