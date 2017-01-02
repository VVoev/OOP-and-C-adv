using Homework_OOP_Principles_Part_1._03.AnimalProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1._03.AnimalProject.Animals
{
    public class Dog : Animal
    {
        public Dog(int age, string name, Sex sex) : base(age, name, sex)
        {
        }

        public override string Sound()
        {
            return "Bauuuuuuuuuu";
        }

        public override string ToString()
        {
            return string.Format($"I am a {GetType().Name} my name is {this.Name} and i like to say {Sound()}");
        }
    }
}
