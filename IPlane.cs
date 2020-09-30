namespace Geometry
{
    interface IPlane    
    {
        double GetPerimeter();
        double GetArea();

        bool Is2D { get; set; }
    }
}
