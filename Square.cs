using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Geometry {
    class Square : Parallelogram {
        private Perimeter _perimeter;
        private Area _area;
        public Square(double squareLine)
        {
            Line1 = squareLine;
        }

          public void QuadProperties() {
            base.QuadProperties();
        }
        public bool RightAngles { get; set; } = true;

        public void QuadProperties (double x){
            x = Line1;
            _perimeter= () => x*4;
            _area = () => x*x;
            
        }

        public void QuadProperties() {
            base.QuadProperties();
            Console.WriteLine("A square is a regular lateral with 4 equal sides that meet at right angles.");
        }

    }

}
