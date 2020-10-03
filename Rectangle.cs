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

        public void QuadProperties() {
            base.QuadProperties();
        }

        public override void QuadProperties(double length, double width)
        {
            length = Line1;
            width = Line2;

            _area = () => length*width;
            _perimeter = () => (2*length) + (2*width);
        }

    }
}