using System;

namespace OOP_MineExam.AnimalProject
{
    public class Meduza : Animal, IAnimal
    {
        public Meduza(string name, int age)
            : base(name, age)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("I am meduse i can only say ZZzzzzzzzzzzzz");
        }
    }
}