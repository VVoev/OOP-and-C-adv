using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.AnimalProject
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine($@"{this.Name} says Meowwwwwww");
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat($@"I am Cat,my name is {this.Name} and i am {this.Age} year(s) old");
            return sb.ToString();
        }
    }
}
