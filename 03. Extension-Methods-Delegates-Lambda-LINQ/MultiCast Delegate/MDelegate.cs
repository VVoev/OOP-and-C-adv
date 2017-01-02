using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.MultiCast_Delegate
{
    public delegate int StringDelegate<T>(T value);

    class MDelegate
    {
        public const string cSharp = "Hello Do you like C#?";
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("MultiCast Delegates");
            StringDelegate<string> d = Program.PrintString;
            d("Hello");
            Custom.Separate();
            Program instance = new Program();
            d += instance.PrintStringLenght;
            d(cSharp);

            Custom.Separate();
            d += delegate (string str)
             {
                 Console.WriteLine($@"Uppercase: {str.ToUpper()}");
                 return 3;
             };
            d(cSharp);

            Custom.Separate();

            int result = d("Some string value");
            Console.WriteLine($@"Returned result is {result}");
            Custom.Separate();

            Func<string, int> predefined = int.Parse;
            int number = predefined("24");
            Console.WriteLine(number);
            Custom.MakeFreeLines(2);

            Action<object> predefinedObject = Console.WriteLine;
            predefinedObject("I am your new Console.WriteLine");
            predefinedObject(predefined);

            Custom.ProgramEnd("MultiCast Delegates");
            Custom.EndProgram(watch);
            Custom.End();

        }


    }
}
