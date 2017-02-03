using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.Point
{
    static class Distance
    {
        public static double CalculateDistance(Point3D first,Point3D second)
        {
            double distanceX = first.X - second.X;
            double distanceY = first.Y - second.Y;
            double distanceZ = first.Z - second.Z;
            double distancePow = distanceX * distanceX +
                                 distanceY * distanceY +
                                 distanceZ * distanceZ;
            return Math.Sqrt(distancePow);
        }
    }
}
