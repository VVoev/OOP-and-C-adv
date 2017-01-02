
namespace Homework_Defining_Classes_Part1.ZooProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Animal
    {
        private int legs;
        private int paws;
        private string eyes;

        public int Legs
        {
            get { return this.legs; }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Your pet is handicapped");
                }
                else if (value > 2)
                {
                    throw new ArgumentException("Your pet is superPet");
                }
                else
                {
                    this.legs = value;
                }
            }
        }
        public int Paws
        {
            get { return this.paws; }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Your pet is handicapped");
                }
                else if (value > 2)
                {
                    throw new ArgumentException("Your pet is superPet");
                }
                else
                {
                    this.legs = value;
                }
            }
        }
        public string Eyes
        {
            get { return this.eyes; }
            set { this.eyes = value; }
        }

        public Animal(int legs,int paws,string eyes)
        {
            this.Legs = legs;
            this.Paws = paws;
            this.Eyes = eyes;
        }


        public abstract void SayHello();
    }
}
