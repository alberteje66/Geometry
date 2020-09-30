using System;
using System.Reflection.Metadata.Ecma335;

namespace Geometry
{
    class Triangle
    {
        private double A, B, C;
        private PythagoreanTheorem _pythag;
        //private TriSides Sides;
        private TriangleType _type;
        private Area _area;
        private Perimeter _perimeter;

        public bool Is2D { get; set; }= true;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void GetArea() {
            //area of a triangle is base x height divided by two
            double height = _pythag.ALength(B, C);
            _area = () => ((height*B)/2);
            Console.WriteLine(_area);
        }


        public void GetPerimeter()
        {
            _perimeter = () => A + B + C;
            Console.WriteLine(_perimeter);
        }

        public void GetType()
        {
            if ((A + B + C) % 3 == 0)
            {
                _type = TriangleType.Equilateral;
            } else if (((A + B) % 2 == 0) || ((B + C) % 2 == 0) || ((A + C) % 2 == 0))
            {
                _type = TriangleType.Isosoles;
            }

            Console.WriteLine($"Triangle is {_type}");
        }

    }
}