using System;

namespace Geometry
{
    public sealed class PythagoreanTheorem
    {
        double _a, _b, _c;
        // public TriSides _sides;

        public PythagoreanTheorem()
        {
            
        }

         public PythagoreanTheorem(double a, double b, double c)
        {
            _a =a;
            _b = b;
            _c = c;
            /* _sides.A = _a;
            _sides.B = _b;
            _sides.C = _c; 
            don't need these anymore, changed the RightTriangle part*/
        }

        public double CLength(double a, double b)
        {
            return Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
        }

        public double BLength(double a, double c) {
            return Math.Sqrt((Math.Pow(a, 2)-Math.Pow(c, 2)));
        }

        public double ALength(double b, double c)
        {
            return Math.Sqrt((Math.Pow(c, 2) - Math.Pow(b, 2)));
        }


    }
}