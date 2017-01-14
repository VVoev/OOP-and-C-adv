using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.AnimalProject
{
    class Dog : Animal,IAnimal
    {
        public Dog(string name, int age)
            : base(name, age)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($@"{this.Name} says Bayyyyyyyy");
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat($@"I am Dog,my name is {this.Name} and i am {this.Age} year(s) old");
            return sb.ToString();
        }
    }
}
