namespace Geometry
{
    class Shape : IShape {
        /*
        * base class for Shapes. Will use some polymorhism to set things about 
        */
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public bool Is2D { get; set; } = true;

        //dimensions for a shape 
        private double _dimensionX;
        private double _dimensionY;

        private double _dimensionZ;

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

        protected virtual double GetPerimeter ()
        {
                //basics for getting a perimeter
                Perimeter = _dimensionX + _dimensionY;
                return Perimeter;
        }

        protected virtual double GetArea () {
            //basic method for getting the area of a shape
            Area = _dimensionX * _dimensionY*_dimensionZ;
            return Area;
        }
    }
}