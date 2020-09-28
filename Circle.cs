using System;

namespace Geometry
{
    public class Circle : IShape
    {
        private Shape _shape;
        private double _radius;
        private const double _pi = Math.PI;

        public Circle(double radius, Shape shape)
        {
            _radius = radius;
            _shape = shape;
        }

        public double GetArea() {
           return _pi * Math.Pow(_radius, 2);
        }

        public double GetPerimeter() {
            return _pi * (_radius*2);
        }
    }
}