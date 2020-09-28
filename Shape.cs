namespace Geometry
{
    public class Shape : IShape {
        /*
        * base class for Shapes. Will use some polymorhism to set things about 
        */

        //dimensions for a shape 
        private double _dimensionX;
        private double _dimensionY;

        private double _dimensionZ;

        public Shape(double dimensionX)
        {
            _dimensionX = dimensionX;
        }
        public Shape(double dimensionX, double dimensionY, double dimensionZ)
        {
             _dimensionX = dimensionX;
            _dimensionY = dimensionY;
            _dimensionZ = dimensionZ;
        }

        public Shape (double dimensionX, double dimensionY) {
            _dimensionX = dimensionX;
            _dimensionY = dimensionY;
        }

        public double GetPerimeter ()
        {
                //basics for getting a perimeter
                return _dimensionX + _dimensionY;
        }

        public  double GetArea () {
            //basic method for getting the area of a shape
            return _dimensionX * _dimensionY*_dimensionZ;
        }
    }
}