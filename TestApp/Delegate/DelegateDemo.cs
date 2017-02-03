using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Delegate
{
    public delegate void CountMe(int number);
    public delegate void Result(string number);
    public delegate int Rezil(int number);
    public delegate string ConcatName(string firstname, string secondname);
    class DelegateDemo
    {
        public static void Start()
        {
            CountMe x = DelegateExample.MultiPlyByThree;
            x += DelegateExample.MultiPlyFive;
            x(40);
            x(100);
            
            CountMe d = DelegateExample.MultiPlyFive;
            d += DelegateExample.MultiPlyFive;
            d += DelegateExample.DeductByTwo;
            d(50);

            Result res = DelegateExample.SayAsText;
            res("2");
            Rezil rezil = DelegateExample.MultiPly;
            rezil += DelegateExample.MultiPlyTen;
            var finalRezult = rezil(10);
            Console.WriteLine(finalRezult);
            ConcatName full = DelegateExample.MakeFullName;
            var name = full("Vladimir", "Voev");
            Console.WriteLine(name);
            
            
        }
    }

    public class DelegateExample
    {
        public static void DeductByTwo(int number)
        {
            Console.WriteLine(number/2);
        }
        public static string MakeFullName(string first,string second)
        {
            var fullname = first + " " + second;
            return fullname;
        }
        public static int MultiPly(int number)
        {
            var res = number * 3;
            return res;
        }
        public static int MultiPlyTen(int number)
        {
            var res = number * 10;
            return res;
        }
        public static void MultiPlyFive(int number)
        {
            Console.WriteLine(number*5);
        }

        public static void SayAsText(string text)
        {
            switch (text)
            {
                case "1": Console.WriteLine("One"); break;
                case "2": Console.WriteLine("Two"); break;
                case "3": Console.WriteLine("Three"); break;
                case "4": Console.WriteLine("Four"); break;
                default:
                    break;
            }
        }

        public static void MultiPlyByThree(int number)
        {
            Console.WriteLine(number*3);
        }
    }
}
