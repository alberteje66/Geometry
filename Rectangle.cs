namespace Geometry
{
    public class Rectangle : IQuadrilaterals
    {
        public double Line1 { get; set; }
        public double Line2 { get; set; }
        public double Line3 { get; set; }
        public double Line4 { get; set; }
        public bool RightAngles { get; set; } = true;

        public Rectangle(double length, double width)
        {
            Line1 = length;
            Line2 = width;
        }

        public double GetPerimeter(double length, double width)
        {
            return (2 * length) + (2 * width);
        }

        public double GetArea(double length, double width)
        {
            return length * width;
        }

    }
}