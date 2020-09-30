using System;

namespace Geometry
{
    public class Rectangle : Parallelogram
    {
        public double Length { get; set; }
        public double Width { get; set; }

        private bool _rightangle;
        private Area _area;
        private Perimeter _perimeter;

        public Rectangle(double length, double width) : base(length, width)
        {
            Length = length;
            Width = width;
            Line1 = length;
            Line2 = width;
            _rightangle = true;
        }

        protected void GetPerimeter()
        {
            base.GetPerimeter(Length, Width);
        }

        protected void GetArea()
        {
            _area = () => Length * Width;
            Console.WriteLine(_area);

        }

    }
}