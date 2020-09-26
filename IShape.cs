namespace Geometry
{
    interface IShape
    {
        double Area { get; set; }
        double Perimeter { get; set; }
        bool Is2D { get; set; }
    }
}
