namespace Geometry
{
    class Triangle : IShape
    {
        private double _a, _b, _c;
        private TriSides Sides;
        private Shape _triangle; //in this triangle HAS a shape, not it is a shape
        
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _triangle = new Shape(_a, _b, _c);
        }

        public double Area { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public double Perimeter { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool Is2D { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}