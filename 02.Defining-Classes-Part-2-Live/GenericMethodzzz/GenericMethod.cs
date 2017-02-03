using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2_Live.GenericMethodzzz
{
    class GenericMethod
    {
        public static T Min<T>(T first,T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static void Test()
        {
            int I = 5;
            int Y = 7;

            int min = Min<int>(I, Y);
            Console.WriteLine("Min({0}, {1}) = {2}", I, Y, min);

            string first = "Kotka";
            string second = "Kuche";
            string minS = Min(first, second);
            Console.WriteLine("Min({0}, {1}) = {2}", first, second, minS);

            //Point p1 = new Point();
            //Point p2 = new Point();
            //Point minPoint = Min(p1, p2); // This will not compile


        }
    }
}
