using System;
using System.Security.Cryptography.X509Certificates;

namespace Geometry {
    class Square : IQuadrilaterals {
        public Square(double squareLine)
        {
            Line1 = squareLine;
            Line2 = squareLine;
            Line3 = squareLine;
            Line4 = squareLine;
        }

        public double Line1 { get; set; }
        public double Line2 { get; set; }
        public double Line3 { get; set; } 
        public double Line4 { get; set; }
        public bool RightAngles { get; set; } = true;

        public double GetPerimeter(double squareline)
        {
            return 4 * squareline;
        }

        public double GetArea(double squareline)
        {
            return squareline*squareline;
            //area of a square
        }

        public double GetPerimeter(double line1, double line2)
        {
            return (2 * line1) + (2 * line2);
        }


    }

}
