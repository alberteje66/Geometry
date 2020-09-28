using System;

namespace Geometry {
    class Quads : IShape {
        private bool IsSquare; //differentiates between square and rectangles
        private double _dimensionX;
        private double _dimensionY;

        private PythagoreanTheorem pythagorean;

        public Quads(double dimensionY, double dimensionX)
        {
            _dimensionY = dimensionY;
            _dimensionX = dimensionX;
            pythagorean = new PythagoreanTheorem(0, _dimensionX, _dimensionY);
        }

        private bool RightAngle; //only squares and rectangles have right angles

        public double GetPerimeter () {
           double perimeter = 1;
            if (IsSquare) {
               perimeter = _dimensionX * 4; 
            }
             else if (!IsSquare) {
                perimeter = (2*_dimensionX) + (2*_dimensionY);
            }

            return perimeter;
        }

        public double GetArea () {
            double area = 1;
            if (IsSquare) {
                area = Math.Pow (_dimensionX, 2);
            } else if (!IsSquare) {
                if (RightAngle) {
                    area = (_dimensionX) + (_dimensionY);
                }
                area = _dimensionX * _dimensionY;
            } else {
                //takes into account parallelograms
                double height = pythagorean.ALength();
                area = _dimensionX * height;
            }

            return area;
        }
    }
}