using System;

namespace Geometry
{
    public sealed class PythagoreanTheorem
    {
        double _a, _b, _c;
        public TriSides _sides;

         PythagoreanTheorem(double a, double b, double c)
        {
            _a =a;
            _b = b;
            _c = c;
            _sides.A = _a;
            _sides.B = _b;
            _sides.C = _c;
        }

        public double CLength() {
            _c = Math.Sqrt((Math.Pow(_a, 2)+ Math.Pow(_b, 2)));
            return _c;
        }

        public double BLength() {
            _b = Math.Sqrt((Math.Pow(_c, 2)-Math.Pow(_a, 2)));
            return _b;
        }

        public double ALength() {
            _a = Math.Sqrt((Math.Pow(_c, 2)-Math.Pow(_b, 2)));
             return _a;
        }


    }
}