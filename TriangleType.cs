using System;

namespace Geometry {
    public enum TriangleType {

        #region triangles defined by line lengths
        Equilateral = 0,
        Isosoles = 1,
        Scalene = 2,
        #endregion

        #region triangles defined by angles
        Right_Triangle = 3,
        Acute_Triangle = 4,
        Obtuse_Triangle = 5,
        Equiangular = 6

        #endregion
        
        
    }
}