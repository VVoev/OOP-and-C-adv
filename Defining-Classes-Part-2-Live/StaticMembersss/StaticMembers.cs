using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2_Live.StaticMembersss
{
    class StaticMembers
    {

        public static void TestStatic()
        {
            Console.WriteLine("Sqrt of your number is "+ SqrtPrecalculated.GetSqrt(800));
            Console.WriteLine("Sqrt of your number is " + SqrtPrecalculated.GetSqrt(400));
            Console.WriteLine("Sqrt of your number is " + SqrtPrecalculated.GetSqrt(2958));

        }
    }
    class SqrtPrecalculated
    {
        public const int maxValue = 10000;

        //Static field 
        private static int[] sqrtValues;

        //Static Constructor
        static SqrtPrecalculated()
        {
            sqrtValues = new int[maxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }

        //Static Method
        public static int GetSqrt(int value)
        {
            return sqrtValues[value];
        }
    }
}
