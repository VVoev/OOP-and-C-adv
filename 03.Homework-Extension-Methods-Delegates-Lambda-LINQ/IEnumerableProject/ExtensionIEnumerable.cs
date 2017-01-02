using _03.Homework_Extension_Methods_Delegates_Lambda_LINQ.IEnumerableProject;
using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionIenumerable
{
    class ExtensionIEnumerable
    {
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("IEnumerable");
            int[] numbers = { 10, 20, 30, 40, 55 };
            var totalSum = numbers.CalculateSum();
            Console.WriteLine($@"Total sum of the numbers is {totalSum}");
            Custom.MakeFreeLines(2);

            totalSum = numbers.CalculateProduct();
            Console.WriteLine($@"Total product of the numbers is {totalSum}");
            Custom.MakeFreeLines(2);

            totalSum = numbers.MinNumber();
            Console.WriteLine($@"The Smallest of the numbers is {totalSum}");
            Custom.MakeFreeLines(2);

            totalSum = numbers.MaxNumber();
            Console.WriteLine($@"The Biggest of the numbers is {totalSum}");
            Custom.MakeFreeLines(2);

            totalSum = numbers.AverageOfAll();
            Console.WriteLine($@"The Average of the numbers is {totalSum}");
            Custom.MakeFreeLines(2);

            Custom.ProgramEnd("IEnumerable");
            Custom.End(watch);
        }
    }
}
