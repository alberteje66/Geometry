using System;
using System.Reflection.Metadata.Ecma335;

namespace Geometry
{
    public class Area(){
      private Shape _shape;
      //simplifying the code with method overloads
      
      public Area(){
        _shape = new Shape(); //place hold for now
      }
      public double GetArea(double x){
        return Math.Pow(x, 2)
      }
      public double GetArea(double x, double y){
        return x*y;
      }
     
    }

    //public delegate double Area(double x, double y, double z);

    public delegate double Perimeter();

    //public delegate double Perimeter(double x, double y, double z);

    public delegate double SurfaceArea();
    //Surface area and Volume are for solids
    
    public delegate double Volume();

}