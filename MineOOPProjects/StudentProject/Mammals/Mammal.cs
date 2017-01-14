using MineOOPProjects.StudentProject.Person.Creature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineOOPProjects.StudentProject.Mammals
{
    public class Mammal : Creature
    {
        private int numberOfTeeth;
        private int numberOfLegs;
        private bool isEatingMeat;

        public int NumberOfTeeth
        {
            get { return this.numberOfTeeth; }
            set { this.numberOfTeeth = value; }
        }
        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            set { this.numberOfLegs = value; }
        }
        public bool IsEatingMeat
        {
            get { return this.isEatingMeat; }
            set { this.isEatingMeat = value; }
        }



        public Mammal(int age,int numberOfTeeth,int numberOfLegs,bool isEatingMeat) : base(age)
        {
            this.NumberOfTeeth = numberOfTeeth;
            this.NumberOfLegs = numberOfLegs;
            this.IsEatingMeat = isEatingMeat;
        }
    }
}
