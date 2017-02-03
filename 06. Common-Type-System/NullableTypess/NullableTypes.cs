using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.NullableTypess
{
    class NullableTypes
    {
        public static void Go()
        {
            int? x = 5;
            Console.WriteLine(x);

            x = 55;
            Console.WriteLine(x);

            //int i = x; This will not compile
            int i = x.Value;
            Console.WriteLine(i);

            x = null;
            Console.WriteLine(x);

            //i = x.Value; // InvalidOperationException
            //Console.WriteLine(i);

            int y = 20;

            int? sum = x + y;
            Console.WriteLine(sum);

            int intSum = x.GetValueOrDefault() + y;
            Console.WriteLine(intSum);
        }
    }
}
