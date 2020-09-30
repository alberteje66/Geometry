using System;

namespace Geometry
{
    public class Circle : IPlane
    {
        private Plane _shape;
        private double _radius;
        private const double _pi = Math.PI;

        public Circle(double radius, Plane shape)
        {
            _radius = radius;
            _shape = shape;
        }

        public double GetArea() {
           return _pi * Math.Pow(_radius, 2);
           //simpler versions of the methods, as circles are pretty straightforward
        }

        public bool Is2D { get; set; } = true;

        public double GetPerimeter() {
            return _pi * (_radius*2);
        }
    }
}