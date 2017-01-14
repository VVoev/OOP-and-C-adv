using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.PolymorhpZoo.WildAnimals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;
        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten)
            : base(animalName, animalType, animalWeight, foodEaten)
        {
        }
        public string LivingRegion { get; set; }
    }
}
