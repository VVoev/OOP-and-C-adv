using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.InheritanceAndAcessability
{
    class Dog : Mammal
    {
        public string Breed { get; set; }
        public Dog(string name, int age,string breed)
            : base(name, age)
        {
            this.Breed = breed;
        }
        internal void WagTail()
        {
            Console.WriteLine($@"{this.Name} is {this.Breed} wagging his {this.Age}-aged tail....");
        }
        protected void Silence()
        {
            Console.WriteLine("Silence");
        }
        public void Smqtai()
        {
            Silence();
        }

      
    }
}
