using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.PolymorhpZoo.WildAnimals
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalName, string animalType, double animalWeight, int foodEaten)
            : base(animalName, animalType, animalWeight, foodEaten)
        {
        }
    }
}
