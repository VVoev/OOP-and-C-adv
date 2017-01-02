using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.Simple_Inheritance
{
    class Cat : Mammal
    {
        public Cat(int age)
            : base(age)
        {
        }

        public void SayMeow()
        {
            Console.WriteLine($@"Meowwwwwwwwwwwww");
        }
    }
}
