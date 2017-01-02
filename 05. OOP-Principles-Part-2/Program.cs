using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.OOP_Principles_Part_2.PolymorphismDemo;
using _05.OOP_Principles_Part_2.User_Defined_Exception;
using _05.OOP_Principles_Part_2.VirtualMethods;

namespace _05.OOP_Principles_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Polymorphism 
            Separate("Polymorphism");
            Polymorphism.Go();

            //2. Simple exception class
            Separate("Exception");
            ExceptionDemo.Exception.Go();

            //3. Simple exception class
            Separate("Used Defined Exception");
            SumOfLines.Go();

            //4. Test Virtual Methods
            Separate("Virtual Methods");
            TestVirtual.Go();
            Console.WriteLine("Hello");
        }

        private static void Separate(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"----------------Your Project {name} Stars here");
            Console.WriteLine();
        }
    }
}
