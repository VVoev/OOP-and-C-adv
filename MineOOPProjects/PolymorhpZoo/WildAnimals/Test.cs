using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.PolymorhpZoo.WildAnimals
{
    public class Test
    {
        public static void Go()
        {
            var cat = new Cat("Penko", "Kotka", 15.2, 2, "siamka");
            var mouse = new Mouse("Kiril", "mishka", 1, 1);
            var tiger = new Tiger("Subzero", "Tigur", 2, 2);
            var zebra = new Zebra("Siro", "Zebra", 100, 100);

            var animalLists = new List<Animal> { cat, mouse, tiger, zebra };
            foreach (var animal in animalLists)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
