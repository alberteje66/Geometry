using System;

namespace Geometry {
    class RightAngleQuads : Shape, IShape {
        private bool IsSquare; //differentiates between square and rectangles
        private double _dimensionX;
        private double _dimensionY;
        private bool RightAngle; //only squares and rectangles have right angles

        public RightAngleQuads (double dimensionX, double dimensionY) : base (dimensionX, dimensionY) {
            _dimensionX = dimensionX;
            _dimensionY = dimensionY;
        }

        protected override double GetPerimeter () {
            if (IsSquare) {
                Perimeter = _dimensionX * 4;
            } else if (!IsSquare) {
                Perimeter = (2 * _dimensionX) + (2 * _dimensionY);

            } else {
                base.GetPerimeter ();
            }

            return Perimeter;
        }

        protected override double GetArea () {
            if (IsSquare) {
                Area = Math.Pow (_dimensionX, 2);
            } else if (!IsSquare) {
                if (RightAngle) {
                    Area = (_dimensionX) + (_dimensionY);
                }
                Area = _dimensionX * _dimensionY;
            } else {
                //takes into account parallelograms
                double height = Math.Sqrt ((Math.Pow (_dimensionY, 2) - (Math.Pow (_dimensionX, 2))));
                Area = _dimensionX * height;
            }

            return Area;
        }
    }
}