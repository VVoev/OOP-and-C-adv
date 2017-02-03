using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.PointProject
{
    class NewLine
    {   
        public static void MakeOneLine()
        {
            Console.WriteLine();
        }
        public static void MakeThreeNewLines()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ProgramStart(string name)
        {
            Console.WriteLine("Your Program {0} Start Succesfully", name);
        }
        public static void ProgramFinish(string name)
        {
            Console.WriteLine("Your Program {0} Finish Succesfully",name);
        }
        public static Stopwatch StartProgram()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            return watch;
        }
        public static void EndProgram(Stopwatch watch)
        {
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            Console.WriteLine(ts + " miliseconds");
        }
    }
}
