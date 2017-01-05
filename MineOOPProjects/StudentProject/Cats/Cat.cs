using MineOOPProjects.StudentProject.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.StudentProject.Cats
{
    class Cat : Mammal
    {
        private Breed breed;

        public Breed Breed { get; set; }
        public Cat(int age, int numberOfTeeth, int numberOfLegs, bool isEatingMeat,Breed breed) : base(age, numberOfTeeth, numberOfLegs, isEatingMeat)
        {
            this.Breed = breed;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"I am a :{this.GetType().Name}");
            sb.AppendLine($"Age:   {this.Age}");
            sb.AppendLine($"NumberOfTeeth:   {this.NumberOfTeeth}");
            sb.AppendLine($"NumberOfLegs:   {this.NumberOfLegs}");
            sb.AppendLine($"Breed:   {this.Breed}");
            return sb.ToString();
        }
    }
}
