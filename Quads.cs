using System;

namespace Geometry {
    class Quads : IShape {
        private bool IsSquare; //differentiates between square and rectangles
        private double _width;        
        private double _length;
        private double _height;
        private bool _rightAngles;
        private Shape _quads;
        private PythagoreanTheorem pythagorean;

        public Quads(double length, double width)
        {
            _length = length;
            _width = width;
            pythagorean = new PythagoreanTheorem(_height, _length, _width);
            _quads = new Shape(_height, _length, _width);
        }

        private bool RightAngle; //only squares and rectangles have right angles

        public double GetPerimeter () {
           double perimeter = 1;
           if (!IsSquare)
           {
               perimeter = (2 * _length) + (2 * _width);
           }
           else
           {
               perimeter = _width * 4;
           }

           return perimeter;
        }

        public double GetArea () {
            double area = 1;
            if (IsSquare) {
                area = Math.Pow (_width, 2);
            } else if (!IsSquare) {
                if (RightAngle)
                {
                    area = _length * _width;
                }
            } else {
                //takes into account parallelograms
                double height = pythagorean.ALength();
                area = _width * _height;
            }

            return area;
        }
    }

}