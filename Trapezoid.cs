namespace Geometry
{
    public class Trapezoid : IQuadrilaterals
    {
        public double Line1 { get; set; }
        public double Line2 { get; set; }
        public double Line3 { get; set; }
        public double Line4 { get; set; }
        public bool RightAngles { get; set; } = false;
        private double _Base;
        private PythagoreanTheorem pythagorean;
        private Plane _shape;

        public Trapezoid(double line1, double line2, double line3, double line4)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Line4 = line4;

            _Base = Line4;
            _shape = new Plane(Line1, Line2, Line3, _Base);
        }

        public double GetPerimeter()
        {
            return Line1 + Line2 + Line3 + Line4;
        }

        public double GetArea()
        {
            double height = pythagorean.ALength(_Base, Line3);
            return (height *( Line2 + _Base))/2;

        }
    }
}