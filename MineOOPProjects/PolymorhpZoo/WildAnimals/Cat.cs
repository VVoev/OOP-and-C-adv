using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.PolymorhpZoo.WildAnimals
{
    class Cat : Felime
    {
        public string breed { get; set; }
        public Cat(string animalName, string animalType, double animalWeight, int foodEaten,string breed) : base(animalName, animalType, animalWeight, foodEaten)
        {
            this.breed = breed;
        }



        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat go to eat");
        }
    }
}
