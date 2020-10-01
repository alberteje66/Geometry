using System;

namespace Geometry
{
    public class Circle
    {
        private double _radius;
        private const double _pi = Math.PI;
        private Area _area;
        private Perimeter _perimeter;

        public Circle(double radius)
        {
            _radius = radius;

            //simpler versions of the methods, as circles are pretty straightforward
        }

        public void CProperties(double radius)
        {
            _radius = radius;
            _perimeter = () => (2 * _radius) * _pi;
            _area = () => Math.Pow(_radius, 2) * _pi;
            Console.WriteLine(_perimeter);
            Console.WriteLine(_area);

        }

    }
    }