using System;
using System.Linq.Expressions;

namespace Geometry
{
    public class Parallelogram : IQuadrilaterals
    {
        public double Line1 { get; set; }
        public double Line2 { get; set; }
        public double Line3 { get; set; }
        public double Line4 { get; set; }
        public bool RightAngles { get; set; } = false;

        private Plane _shape;
       // public delegate double GetHeight(double b, double c);


        //private double _height;

        //private PythagoreanTheorem _pythagorean = new PythagoreanTheorem(double a, double b, double c);

        public Parallelogram(double line1, double line2)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line1;
            Line4 = line2;
            _shape = new Plane(Line1, Line2);
        }

        public double GetArea(double height, double baseLine1)
        {
            var pythag = new PythagoreanTheorem();
            height = pythag.ALength(Line1, Line2);
            baseLine1 = Line1;
            return height * baseLine1;
        }

        public double GetPerimeter(double line1, double line2)
        {
            return (2 * line1) + (2 * line2);
        }
    }
}