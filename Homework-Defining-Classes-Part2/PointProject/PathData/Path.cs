using Homework_Defining_Classes_Part2.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.PathData
{
    class Path
    {
        //Fields
        private List<Point3D> points = new List<Point3D>();

        //Property
        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public Point3D this[int index]
        {
            get { return this.Points[index]; }
            set { this.Points[index] = value; }
        }
        public int Count
        {
            get { return points.Count; }
        }

        //Constructor
        public Path()
        {
            this.Points = new List<Point3D>();
        }

        //Methods
        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePooint(Point3D point)
        {
            this.points.Remove(point);
        }
        public void RemovePointAt(int index)
        {
            this.points.RemoveAt(index);
        }

        //Override Tostring
        public override string ToString()
        {
            return string.Join("\r\n", this.Points);
        }
    }
}
