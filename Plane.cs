namespace Geometry
{
   public class Plane : IPlane {
    
        /* base class for Shapes. Will use some polymorhism to set things about 
        */

        //dimensions for a shape 
        private double _dimensionX;
        private double _dimensionY;

        private double _dimensionZ;

        public Plane(double dimensionX)
        {
            _dimensionX = dimensionX;
        }
        public Plane(double dimensionX, double dimensionY, double dimensionZ, double @base)
        {
             _dimensionX = dimensionX;
            _dimensionY = dimensionY;
            _dimensionZ = dimensionZ;
        }

        public Plane (double dimensionX, double dimensionY) {
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

        public bool Is2D { get; set; } = true;
   }
}