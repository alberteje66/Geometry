using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    partial class Solids : ISolids
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public bool Is3D { get; set; }
    }
}
