using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.Implementing_IEnumerable
{
    class ImplementingIEnumerable
    {
        public static void Go()
        {
            LinkedList<string> list =
            new LinkedList<string>("1st element",
            new LinkedList<string>("2nd element",
            new LinkedList<string>("3rd element")));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
