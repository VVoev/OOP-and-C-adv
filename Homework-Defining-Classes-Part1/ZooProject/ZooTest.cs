using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part1.ZooProject
{
    class ZooTest
    {
        public static void TestPets()
        {
            Dog penko = new Dog(2, 2, "Brown","Pepi");
            Cat djingul = new Cat(2, 2, "Green");
            Rabbit bunny = new Rabbit(2, 2, "Blue");
           // List<Dog> dogs = new List<Dog>();
            List<Zoo> animals = new List<Zoo>();
            penko.SayHello();
            djingul.SayHello();
            bunny.SayHello();
            penko.SayBauuuu(penko.Name);
            Dog.SayBauuuuu(penko.Name);

        }
    }
}
