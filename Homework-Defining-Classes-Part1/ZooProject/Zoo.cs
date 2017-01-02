using System.Collections.Generic;

namespace Homework_Defining_Classes_Part1.ZooProject
{
    public class Zoo
    {
        private IList<Zoo> animals;
        private Cat cats;
        private Dog dogs;
        private Rabbit rabbits;

        public IList<Zoo> Animals
        {
            get
            {
                return this.animals;
            }
            set
            {
                this.animals = value;
            }
        }
        public Zoo(Cat cat,Dog dog,Rabbit rabbit)
        {

        }
        public static void addAnimal(Zoo animal)
        {

        }


    }
}