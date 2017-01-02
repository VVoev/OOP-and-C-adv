using Homework_OOP_Principles_Part_1._03.AnimalProject.Abstract;
using Homework_OOP_Principles_Part_1._03.AnimalProject.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1
{
    class AnimalTest
    {
        public static void Go()
        {
            //Create few dogs
            var germanShepherd = new Dog(14, "Sharo", Sex.Male);
            var putbill = new Dog(5, "Rex", Sex.Male);
            var pincher = new Dog(2, "July", Sex.Female);
            var huskey = new Dog(8, "Blueeeeee", Sex.Male);
            var dogs = new List<Dog> { germanShepherd, putbill, pincher, huskey };

            //Create few frowgs
            var frog1 = new Frog(1, "Kermeta", Sex.Female);
            var frog2 = new Frog(2, "Ganeta", Sex.Female);
            var frog3 = new Frog(3, "Soleta", Sex.Female);
            var frog4 = new Frog(4, "Anka", Sex.Female);
            var frogs = new List<Frog> { frog1, frog2, frog3, frog4 };

            //Create few tomcats
            var tomcat1 = new Tomcat(12, "Tom");
            var tomcat2 = new Tomcat(8, "Garfield");
            var tomcat3 = new Tomcat(4, "Mafiotko");
            var tomcat4 = new Tomcat(7, "Ris");
            var tomcats = new List<Tomcat> { tomcat1, tomcat2, tomcat3, tomcat4 };

            //Create kittens
            var kitten1 = new Kitten(12, "Tom");
            var kitten2 = new Kitten(8, "Garfield");
            var kitten3 = new Kitten(4, "Mafiotko");
            var kitten4 = new Kitten(7, "Ris");
            var kittens = new List<Kitten> { kitten1, kitten2, kitten3, kitten4 };

            //add all animals in one list
            var animals = new List<Animal>();
            animals.AddRange(dogs);
            animals.AddRange(frogs);
            animals.AddRange(tomcats);
            animals.AddRange(kittens);
            var animalsAverage = animals.Average(x => x.Age);
            Console.WriteLine(germanShepherd);
            Console.WriteLine(frog1);
            Console.WriteLine(tomcat1);
            Console.WriteLine(kitten2);
            Console.WriteLine($"Average year of all animals is {animalsAverage:f2} years");


        }
    }
}
