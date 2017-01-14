using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_MineExam.CustomSettings;
namespace OOP_MineExam.AnimalProject
{
    public class Zoo
    {
        public static void Test()
        {
            Custom.ProgramStart("Animal Project");
            Custom.MakeFreeLines(2);

            var dogSharo = new Dog("Sharo",1);
            var catDjingul = new Cat("Djingul", 1);
            var meduza = new Meduza("Fibi", 400);


            List<Animal> animals = new List<Animal>();
            animals.Add(dogSharo);
            animals.Add(catDjingul);
            animals.Add(meduza);

            foreach (var animal in animals)
            {
                animal.SayHello();               
            }
            Custom.MakeFreeLines(2);
            Custom.ProgramEnd("Animal Project");
            Custom.End();

        }
    }
}
