using OOP_MineExam.CarsProject.Movable;
using System;

namespace OOP_MineExam.CarsProject
{
    public class Audi:Car,ICar
    {
        public bool IsQuatro { get; set; }
        public bool IsDoubleClutch { get; set; }

        public Audi(double engineSize, int numberOfTyres, bool hasTurbo, bool tuningMode,bool isQuatro,bool isDoubleCluch,double timeToSixty) : base(engineSize, numberOfTyres, hasTurbo, tuningMode,timeToSixty)
        {
            this.IsQuatro = isQuatro;
            this.IsDoubleClutch = isDoubleCluch;
        }

        public override void GetEngineSize()
        {
            base.GetEngineSize();
        }

        public override void MakeDonuts()
        {
            if (!IsQuatro)
            {
                throw new ArgumentException("Your car is four wheel drive");
            }
            Console.WriteLine("Tyreeeeeeeeeeeeeee Squeeeezeeeeeeeee");
        }

        public override string ToString()
        {
            return string.Format($"Technical data for Audi \n Engine:{this.EngineSize}\n NumberOfTyres:{this.NumberOfTyres}\n Turbo:{HasTurbo}\n Tuning:{this.AllowForTunning}\n Quatro:{this.IsQuatro}\n Automatic:{this.IsDoubleClutch}\n 0-62mph for :{this.TimeToSixty} seconds");
        }
    }
}