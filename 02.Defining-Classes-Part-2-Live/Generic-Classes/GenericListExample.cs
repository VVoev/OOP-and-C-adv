using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2_Live.Generic_Classes
{
    class GenericListExample
    {
       public static void TestGeneric()
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            Console.WriteLine("In your list you have total of "+intList.Count+" Elements");
            for (int i = 0; i < intList.Count; i++)
            {
                int elem = intList[i];
                Console.WriteLine($@"Intlist[{i}] = {elem}");
            }
            Console.WriteLine();
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("C#");
            stringList.Add("Java");
            stringList.Add("PHP");
            stringList.Add("SQL");
            Console.WriteLine("Number of elements: {0}", stringList.Count);
            for (int i = 0; i < stringList.Count; i++)
            {
                string element = stringList[i];
                Console.WriteLine($@"stringList[{i}] = {element}");
            }
        }
    }
}
