using System;
using System.Numerics;

namespace Geometry
{
    public class Trapezoid : IQuadrilaterals
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        //public bool RightAngles { get; set; } = false;
        private PythagoreanTheorem _pythagorean;
        private Perimeter _perimeter;
        private Area _area;

        public Trapezoid(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = B;
        }

        public void QuadProperties() {
            double height;
            height = _pythagorean.ALength(D, C);
            System.Console.WriteLine("A trapezoid is a quadrilateral where one pair of sides are parallel.");
            System.Console.WriteLine($"Trapezoid's Height = {height}");
        }

        public void QuadProperties () {
            double height = _pythagorean.ALength(D, C);

            _perimeter = () => A+B+C+D;
            _area = () => ((B+D)/2)*height;

        }
    }
}