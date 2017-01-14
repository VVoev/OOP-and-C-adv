using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CustomSettings
{
    public class Custom
    {
        public static void Separate()
        {
            Console.WriteLine("---------------------");
        }
        public static void ProgramStart(string name)
        {
            Console.WriteLine($@"Your program {name} start here");
            Console.WriteLine();
        }
        public static void ProgramEnd(string name)
        {
            Console.WriteLine($@"Your program {name} end here");
            Console.WriteLine();
        }

        public static void MakeFreeLines(int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
            }
        }

        public static void End()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
        }
        public static void End(Stopwatch watch)
        {
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            Console.WriteLine("Time Taken      {0}", ts);
            Console.WriteLine("-------------------------END----------------------", ts);
        }
        public static long RandomNumber2to6()
        {
            var random = new Random();
            long exam = random.Next(2, 7);
            return exam;
            
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
