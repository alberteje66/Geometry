using System;
using System.Numerics;

namespace Geometry
{
    public class Trapezoid : IQuadrilaterals
    {
        public double Line1 { get; set; }
        public double Line2 { get; set; }
        public double Line3 { get; set; }
        public double Line4 { get; set; }
        public bool RightAngles { get; set; } = false;
        private PythagoreanTheorem _pythagorean;
        private Perimeter _perimeter;
        private Area _area;

        public Trapezoid(double line1, double line2, double line3, double line4)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Line4 = line4;
        }

        public void GetPerimeter()
        {
            _perimeter = () => Line1 + Line2 + Line3 + Line4;
        }

        public void GetArea()
        {
            double a = Line1;
            double b = Line4;
            double height = _pythagorean.ALength(b, Line3);
            _area = () => ((a+b) / 2) * height;
            Console.WriteLine(_area);

        }
    }
}