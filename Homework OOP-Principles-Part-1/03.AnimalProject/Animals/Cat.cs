using Homework_OOP_Principles_Part_1._03.AnimalProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1._03.AnimalProject.Animals
{
    class Cat : Animal
    {
        public Cat(int age, string name, Sex sex) : base(age, name, sex)
        {

        }
        public override string Sound()
        {
            return "Meowwwwwwwwww";
        }
    }
}
