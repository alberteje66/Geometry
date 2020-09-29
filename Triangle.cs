namespace Geometry
{
    class Triangle : IShape
    {
        private double _a, _b, _c;
        private PythagoreanTheorem _pythag;
        private TriSides Sides;
        private Shape _triangle; //in this triangle HAS a shape, not it is a shape
        public double area;
         public double perimeter;
        
        public bool Is2D { get; set; }= true;
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _triangle = new Shape(_a, _b, _c);
            Sides.A = _a;
            Sides.B = _b;
            Sides.C = _c;
            _pythag = new PythagoreanTheorem(_a, _b, _c);
        }

        public double GetArea() {
            //area of a triangle is base x height divided by two
            double height = _pythag.ALength();
            double _base = _b;
           area = ((_base*height)/2);
           return area;
        }

        public double GetPerimeter() {
            perimeter = _a+_b+_c;
            return perimeter;
        }
       
    }
}