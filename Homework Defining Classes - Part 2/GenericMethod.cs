using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2_Live
{
   public class GenericMethod
    {
        public static T Min<T>(T first, T second)
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
    }
}
