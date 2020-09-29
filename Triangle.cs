namespace Geometry
{
    class Triangle : IShape
    {
        private double A, B, C;
        private PythagoreanTheorem _pythag;
        //private TriSides Sides;
        private Shape _triangle; //in this triangle HAS a shape, not it is a shape
        public double area;
         public double perimeter;
        
        public bool Is2D { get; set; }= true;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetArea() {
            //area of a triangle is base x height divided by two
            double height = _pythag.ALength();
           area = ((B*height)/2);
           return area;
        }

        public double GetPerimeter() {
            perimeter = A+B+C;
            return perimeter;
        }
       
    }
}