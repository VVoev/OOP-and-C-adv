using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Homework_Extension_Methods_Delegates_Lambda_LINQ.StringBuilderProject;

namespace ExtensionSB
{
    class ExtensionStringBuilder
    {
        public const string programming = "I love to code with C# from time to time";
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("Extension Stringbuilder");
            var sb = new StringBuilder();
            sb.Append(programming);
            var res =sb.Substring(2, 20);
            Console.WriteLine(res);
            Custom.MakeFreeLines(1);
            Custom.ProgramEnd("Extension Stringbuilder");
            Custom.End(watch);
        }
    }
}
