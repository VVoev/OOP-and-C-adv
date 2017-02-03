using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.Simple_Inheritance
{
    class Dog : Mammal
    {

        public string Breed { get; set; }



        public Dog(int age,string breed)
            : base(age)
        {
            this.Breed = breed;
        }

        public void WagTail()
        {
            Console.WriteLine("Tail wagging...");
        }
        
    }
}
