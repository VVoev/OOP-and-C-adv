using MineOOPProjects.StudentProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects
{
    class OOPTestingVlado
    {
        static void Main()
        {
            Test.Go();
            Console.WriteLine(RecursiveCatalan(5));
            MineOOPProjects.PolymorhpZoo.WildAnimals.Test.Go();
            
           
        }
        public static int RecursiveCatalan(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n*RecursiveCatalan(n - 1);
            }
        }



    }
}
