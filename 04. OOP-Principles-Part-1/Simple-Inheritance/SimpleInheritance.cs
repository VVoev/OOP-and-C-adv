using _04.OOP_Principles_Part_1.Simple_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles_Part_1.Simple_Inheritance
{
    class SimpleInheritance 
    {

        public static void Go()
        {
            Dog joe = new Dog(8, "Pudel");
            Console.WriteLine($@"Joe is {joe.Age} years old of breed {joe.Breed}");
            joe.Sleep();
            joe.WagTail();

            Cat dolly = new Cat(3);
            Console.WriteLine($@"Dolly is {dolly.Age} years old");
            dolly.Sleep();
            dolly.SayMeow();

        }
    }
}
