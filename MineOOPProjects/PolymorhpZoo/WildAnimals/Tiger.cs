using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.PolymorhpZoo.WildAnimals
{
    class Tiger : Animal
    {
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten) : base(animalName, animalType, animalWeight, foodEaten)
        {
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roarrr");
        }
    }
}
