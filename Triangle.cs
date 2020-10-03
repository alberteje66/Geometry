using System;
using System.Reflection.Metadata.Ecma335;

namespace Geometry
{
    class Triangle
    {
        private double A, B, C;
        private PythagoreanTheorem _pythag;
        //private TriSides Sides;
        private Area _area;
        private Perimeter _perimeter;

        public bool Is2D { get; set; }= true;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }


        public void TriagProperties()
        {
            System.Console.WriteLine("A triangle is a plane of 3 sides meeting at 3 angles.");
        }

        public void TriagProperties(double a, double b, double c) {
            A= a;
            B = b;
            C = c;

            double height = _pythag.ALength(b, c);

            _area = () => (height*B)/2;
            _perimeter = () => A+B+C;
            System.Console.WriteLine(_perimeter);
            System.Console.WriteLine(_area);
        }

        public void TriagProperties(double a, double b){
            //for right triangles
            A = a;
            B = b;

            _area = () => (a*b)/2;
            _perimeter = () => A+B+C;
        }

    }
}