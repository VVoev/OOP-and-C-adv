using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Action;
using TestApp.Delegate;
using TestApp.Func;

namespace TestApp
{
    class Startup
    {
        static void Main()
        {
            //1 Delegate
            StartNewDemo("Delegate");
            DelegateDemo.Start();
            Separate();

            //2 Action
            StartNewDemo("Action");
            ActionDemo.Start();
            Separate();

            //3 Func
            StartNewDemo("Func");
            FuncDemo.Start();
            Separate();

        }

        private static void StartNewDemo(string v)
        {
            Console.WriteLine($"Your new project {v} stars here");
        }

        private static void Separate()
        {
            Console.WriteLine($"Your project end here");
            Console.WriteLine("----------------------");
            Console.WriteLine();
        }
    }
}
