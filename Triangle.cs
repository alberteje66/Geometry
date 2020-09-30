namespace Geometry
{
    class Triangle : IPlane
    {
        private double A, B, C;
        private PythagoreanTheorem _pythag;
        //private TriSides Sides;
        private Plane _triangle; //in this triangle HAS a shape, not it is a shape
        private TriangleType _type;

        public bool Is2D { get; set; }= true;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetArea() {
            //area of a triangle is base x height divided by two
            double height = _pythag.ALength(B, C);
           return (B*height)/2;
        }


        public double GetPerimeter() {
            return A+B+C;
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
        }

    }
}