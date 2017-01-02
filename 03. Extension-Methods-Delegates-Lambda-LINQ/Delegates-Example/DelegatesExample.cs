using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Delegates_Example
{
    public delegate void SimpleDelagate(string param);
    public delegate void CountBaby(int number);

    class DelegatesExample
    {
        public static void TestMethod(string param)
        {
            Console.WriteLine("I was called by Delegate");
            Console.WriteLine($@"I go parameter {param}");
        }

        public static void TestCounter(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void MultiPlyCounter(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i*10);
            }
        }
    }
}
