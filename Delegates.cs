using System;
using System.Reflection.Metadata.Ecma335;

namespace Geometry
{
     #region Delegates
     public delegate double GetArea(double x, double y);

     public delegate double Areas(double dimension);


     public delegate double Perimeters(double dimension);

     public delegate double GetPerimeter(double x, double y);


     #endregion
}