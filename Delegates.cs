using System;
using System.Reflection.Metadata.Ecma335;

namespace Geometry
{
    public delegate double Area();

    //public delegate double Area(double x, double y, double z);

    public delegate double Perimeter();

    //public delegate double Perimeter(double x, double y, double z);

    public delegate double SurfaceArea();
    //Surface area and Volume are for solids
    
    public delegate double Volume();

}