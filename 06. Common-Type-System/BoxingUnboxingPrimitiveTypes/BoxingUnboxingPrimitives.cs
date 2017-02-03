using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.BoxingUnboxingPrimitiveTypes
{
    class BoxingUnboxingPrimitives
    {
        public static void Go()
        {
            int value = 1;
            object obj = value; //boxing performed

            value = 12345; // only stack value is changed
            int value2 = (int)obj; // unboxing performed
            Console.WriteLine(value2);//prints 1

            long value3 = (long)(int)obj;//unboxing
            //long value4 = long(obj); //Invalid Cast Exception

            Console.WriteLine(value);
            Console.WriteLine(value2);
            Console.WriteLine(value3);



        }
    }
}
