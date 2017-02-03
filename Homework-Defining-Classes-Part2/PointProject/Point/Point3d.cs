using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.Point
{
   public struct Point3D
    {
        //Start of the system
        private static readonly Point3D EntryPoint = new Point3D(0, 0, 0);
        //Fields
        private double x;
        private double y;
        private double z;

        //Properties
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        //Constructor
        public Point3D (double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //Static Constructor
        public static Point3D DefaultStartingPoint
        {
            get { return EntryPoint; }
        }

        //Override
        public override string ToString()
        {
            var PointInfo = new StringBuilder();
            return PointInfo.AppendFormat(this.X + ", " + this.Y + ", " + this.Z).ToString();
        }
    }
}
