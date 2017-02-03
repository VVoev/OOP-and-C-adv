using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_OOP_Principles_Part_1._03.AnimalProject.Abstract;

namespace Homework_OOP_Principles_Part_1._03.AnimalProject.Animals
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name) :
            base(age, name, Sex.Male)
        {
        }

        public override string Sound()
        {
            return base.Sound();
        }

        public override string ToString()
        {
            return string.Format($"I am a {GetType().Name} my name is {this.Name} and i like to say {Sound()}");
        }
    }
}
