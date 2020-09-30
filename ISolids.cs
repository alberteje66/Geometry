namespace Geometry
{
    interface ISolids
    {
         double Height { get; set; }
         double Width { get; set; }
         double Depth { get; set; }
         bool Is3D { get; set; }
    }
}