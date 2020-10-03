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

        public Trapezoid(double a, double b, double c, double B)
        {
            Line1 = a;
            Line2 = b;
            Line3 = c;
            Line4 = B;
        }

        public void QuadProperties() {
            double height;
            height = _pythagorean.ALength(Line4, Line3);
            System.Console.WriteLine("A trapezoid is a quadrilateral where one pair of sides are parallel.");
            System.Console.WriteLine($"Trapezoid's Height = {height}");
        }

        public void QuadProperties (double b, double B) {
            b = Line2;
            B = Line4;
            double height = _pythagorean.ALength(B, Line3);

            _perimeter = () => Line1+b+Line3+B;
            _area = () => ((Line1+b)/2)*height;

        }
    }
}