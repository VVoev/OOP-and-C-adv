using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.Implementing_IComparable
{
    class Point : IComparable<Point>
    {
        public int X;
        public int Y;

        public int CompareTo(Point other)
        {
            if (this.X != other.X )
            {
                return this.X - other.X;
            }
            if(this.Y != other.Y)
            {
                return this.Y - other.Y;
            }
            return 0;
        }
    }
    class ImplementingIComparable
    {
        public static void Go()
        {
            Point firstPoint = new Point { X = 3, Y = 10 };
            Point secondPoint = new Point { X = 7, Y = 14 };
            Point thirdPoint = new Point { X = 10, Y = 15 };

            //Comparing Points
            Console.WriteLine(firstPoint.CompareTo(secondPoint));
            Console.WriteLine(firstPoint.CompareTo(thirdPoint));
            Console.WriteLine(firstPoint.CompareTo(firstPoint));

            //sorting Points
            Point[] points = new Point[] 
            {
              firstPoint, secondPoint, thirdPoint, firstPoint, firstPoint,
              secondPoint,thirdPoint,secondPoint,  firstPoint, thirdPoint
            };
            Array.Sort(points);
            foreach (var p in points)
		    {
		    	Console.WriteLine("({0}, {1})", p.X, p.Y);
            }                                          
        }
    }
}
