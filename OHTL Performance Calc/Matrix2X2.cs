using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    class Matrix2X2
    {
        public Complex M00 { get;}
        public Complex M01 { get;}
        public Complex M10 { get;}
        public Complex M11 { get;}

        public Matrix2X2(Complex m00, Complex m01, Complex m10, Complex m11)
        {
            M00 = m00;
            M01 = m01;
            M10 = m10;
            M11 = m11;
        }

        public static Matrix2X2 operator *(Matrix2X2 left, Matrix2X2 right)
        {
            return new Matrix2X2(left.M00*right.M00 + left.M01*right.M10
                ,left.M00*right.M01 + left.M01*right.M11
                ,left.M10*right.M00 + left.M11*right.M10
                ,left.M10*right.M01 + left.M11*right.M11);
        }
    }
}
