using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Extension_Methods
{
   public class ExtensionTest
    {
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("Extension Methods");
            Custom.MakeFreeLines(2);

            //1
            var str = "Hello Extension Methods";
            Console.WriteLine(str.WordCount());
            Custom.MakeFreeLines(2);

            //2
            var ints = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ints.ToString());
            Console.WriteLine(ints.ToString<int>());

            ints.IncreaseWith(5);
            Console.WriteLine(ints.ToString<int>());
            Custom.MakeFreeLines(2);
            //-1566986918





            Custom.EndProgram(watch);
            Custom.ProgramEnd("Extensions Methods");
            Custom.End();
        }
    }
}
