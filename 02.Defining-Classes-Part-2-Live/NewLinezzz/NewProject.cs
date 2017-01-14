using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2_Live.NewLinezzz
{
    public  class Lines
    {
        public static void MakeNewLines(string name,int number)
        {
            Console.WriteLine("[]--------------Your {0} Project starts here--------------[]".ToUpper(), name);
            Console.WriteLine();
            Console.WriteLine("Number of the Project {0}", number);
            Console.WriteLine();

        }
        public static void MakeFinishLines(string name)
        {
            Console.WriteLine();
            Console.WriteLine("[]--------------Your {0} Project end here--------------[]".ToUpper(), name);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
