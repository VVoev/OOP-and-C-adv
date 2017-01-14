using MineOOPProjects.PolymorhpZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.PolymorhpZoo.WildAnimals
{
    public abstract class Animal : IAnimal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName,string animalType,double animalWeight,int foodEaten)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
            this.foodEaten = foodEaten;
        }
        public string AnimalType { get;  protected set; }
        public string AnimalName { get;  protected set; }
        public double AnimalWeight { get;  protected set; }
        public int FoodEaten { get;  protected set; }

        public abstract void MakeSound();
        public abstract void Eat();

        public override string ToString()
        {
            return string.Format($"{this.animalType} [{this.animalName},{this.animalWeight},{this.foodEaten}]");
        }
    }
}
