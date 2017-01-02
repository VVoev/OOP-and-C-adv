using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.Simple_Inheritance
{
    class Mammal
    {
        public int Age { get; set; }

        public Mammal(int age)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine($@"{GetType().Name} go to sleep");
        }
        private void Strange()
        {

        }
    }
}
