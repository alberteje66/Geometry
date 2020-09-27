using System;

namespace Geometry
{
    public class Circle : IShape
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public bool Is2D { get; set; } = true;
        private Shape _shape;
        

        private double _radius;
        private const double _pi = Math.PI;

        public Circle(double radius, Shape shape)
        {
            _radius = radius;
            _shape = shape;
        }

        public double GetArea() {
            Area = _pi * Math.Pow(_radius, 2);
            return Area;
        }
    }
}