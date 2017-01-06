using MineOOPProjects.StudentProject.Cats;
using MineOOPProjects.StudentProject.Person.Creature;
using MineOOPProjects.StudentProject.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.StudentProject
{
    class Test
    {
        public static void Go()
        {
            //1. Added five students
            var student1 = new Student(22, "Petar", 28542);
            var student2 = new Student(31, "Kiro", 33885);
            var student3 = new Student(19, "Maria", 44135);
            var student4 = new Student(21, "Galya", 33125, 3);
            var student5 = new Student(31, "Mario", 33126, 4);

            var listCreatures = new List<Creature>();
            listCreatures.Add(student1);
            listCreatures.Add(student2);
            listCreatures.Add(student3);
            listCreatures.Add(student4);
            listCreatures.Add(student5);

            //2. Added three cats
            var cat1 = new Cat(1, 30, 4, true, Breed.BritishShortHair);
            var cat2 = new Cat(3, 26, 4, false, Breed.Siam);
            var cat3 = new Cat(13, 12, 3, true, Breed.Persian);

            listCreatures.Add(cat1);
            listCreatures.Add(cat2);
            listCreatures.Add(cat3);

            foreach (var creature in listCreatures)
            {
                Console.WriteLine(creature);
                creature.Talk();
            }

        }
    }
}
