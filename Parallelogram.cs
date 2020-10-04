using System;
using System.Linq.Expressions;
using System.Numerics;

namespace Geometry
{
    public class Parallelogram : IQuadrilaterals
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        
        private PythagoreanTheorem _pythagorean;


        private Area _area;
        private Perimeter _perimeter;

        public Parallelogram(double a, double b)
        {
           A = a;
           B = b;
           C = A;
           D = B;
        }

        public void QuadProperties(){ 
            System.Console.WriteLine("A parallelogram has two sets of parallel sides, and both are equal./r/n Rectangles and Squares are TYPES of Parallelograms.");
        }

        public virtual void QuadProperties (double height, double _base) {
            _base = B;
            height = _pythagorean.ALength(_base, A);
            _area = () => _base * height;
            _perimeter = ()=> (2*Line1) + (2*_base);
        }
    }
}