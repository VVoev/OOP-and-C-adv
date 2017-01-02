using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.EncapsulationDemo
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Person Name");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Person Age");
                }
                this.age = value;
            }
        }
        public Person(string name ,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format($"Person\nName:{this.Name}\nAge:{this.Age}");
        }

    }
    class Encapsulation
    {
        public static void Go()
        {
            var pesho = new Person("Petar", 13);
            Console.WriteLine(pesho);
        }
    }
}
