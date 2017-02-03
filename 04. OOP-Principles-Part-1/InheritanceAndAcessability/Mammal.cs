using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.InheritanceAndAcessability
{
    public class Mammal:Creature
    {
        public int Age { get; set; }
        public Mammal(string name,int age)
            :base(name)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine($@"Shh {this.Name} is sleeping");
        }

        protected void Eat()
        {
            Console.WriteLine($@"{this.Name} like to eat a lot");
        }

    }
}
