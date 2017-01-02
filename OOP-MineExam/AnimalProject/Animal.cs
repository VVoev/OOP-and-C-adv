using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.AnimalProject
{
    public abstract class Animal : IAnimal
    {
        private List<Animal> animals;

        public string Name { get; set; }
        public int Age { get; set; }
        public List<Animal> Animals
        {
            get { return this.animals; }
            set { this.animals = value; }
        }

        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Animals = new List<Animal>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat($@"I am ,my name is {this.Name} and i am {this.Age} year(s) old");
            return sb.ToString();
        }

        public  virtual void SayHello()
        {
            Console.WriteLine($@"Sasasa");
        }
    }
}
