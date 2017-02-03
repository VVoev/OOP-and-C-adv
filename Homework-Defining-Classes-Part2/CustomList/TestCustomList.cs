using Homework_Defining_Classes_Part2.PointProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.CustomList
{
    class TestCustomList
    {
        public static void Test()
        {
            //Start 
            NewLine.ProgramStart("Custom List");
            Stopwatch watch = NewLine.StartProgram();
            CustomList<int> numbers = new CustomList<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
            }
            numbers.Remove(13);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbers.Contains(10));


            numbers.Swap(5, 10);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int number= numbers.GreaterThan(5);
            Console.WriteLine("Total numbers greater than 5 are : {0}",number);

            Console.WriteLine("Nai malkiq element e )");
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());






            //Finish
            NewLine.ProgramFinish("Custom List");
            NewLine.EndProgram(watch);
            NewLine.MakeThreeNewLines();
        }
    }
}
