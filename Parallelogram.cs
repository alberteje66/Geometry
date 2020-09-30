using System;
using System.Linq.Expressions;
using System.Numerics;

namespace Geometry
{
    public class Parallelogram : IQuadrilaterals
    {
        public double Line1 { get; set; }
        public double Line2 { get; set; }
        public double Line3 { get; set; }
        public double Line4 { get; set; }
        public bool RightAngles { get; set; } = false;
        private PythagoreanTheorem _pythagorean;


        private Area _area;
        private Perimeter _perimeter;

        public Parallelogram(double line1, double line2)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line1;
            Line4 = line2;
        }

        protected virtual void GetArea(double height, double _base)
        {
            height = _pythagorean.ALength(Line2, Line1);
            _base = Line2;
            _area = () => _base * height;
            Console.WriteLine(_area);
        }

        protected virtual void GetPerimeter(double line1, double line2)
        {
            _perimeter = () => (2 * Line1) + (2 * Line2);
            Console.WriteLine(_perimeter);
        }
    }
}