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

        public void QuadProperties(){ 
            System.Console.WriteLine("A parallelogram has two sets of parallel sides, and both are equal./r/n Rectangles and Squares are TYPES of Parallelograms.");
        }

        public virtual void QuadProperties (double height, double _base) {
            _base = Line2;
            height = _pythagorean.ALength(_base, Line2);
            _area = () => _base * height;
            _perimeter = ()=> (2*Line1) + (2*_base);
        }
    }
}