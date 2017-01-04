using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.DynamicTypes
{
    class DynamicTypesExample
    {
        public static void Go()
        {
            dynamic a = 5;
            dynamic b = 7.5;
            dynamic sum = a + b;
            Console.WriteLine(sum);

            dynamic s = "Vlado";
            dynamic newSum = sum + s;
            Console.WriteLine(newSum);

            // This will cause runtime error
            //dynamic val = sum . s; // "." (dot) operator
            //Console.WriteLine(val); 

            dynamic d = new { X = 5, Y = 10 };
            dynamic x = d.Y;
            Console.WriteLine(x);

            dynamic square = new Func<int,bool>(p => p * p>90);
            bool x2 = square(x);
            Console.WriteLine(x2);
            square = new Func<int, int>(z => z * z);
            dynamic lice = square(x);
            Console.WriteLine(lice);

            dynamic n = null;
            int? nullSum = lice + n;
            Console.WriteLine(nullSum);

            dynamic obj = new ExpandoObject();
            obj.Size = 5;
            obj.Sum = (Func<int, int, int>)((p1, p2) => p1 + p2);
            Console.WriteLine(obj.Sum(3, obj.Size));
        }
    }
}
