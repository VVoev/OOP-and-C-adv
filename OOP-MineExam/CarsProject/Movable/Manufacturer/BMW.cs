using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CarsProject.Movable.Manufacturer
{
    class BMW : Car
    {
        public int NumberOfTurbo { get; set; }
        public BMW(double engineSize, int numberOfTyres, bool hasTurbo, bool tuningMode,int numberOfTurbo,double timeToSixty)
            : base(engineSize, numberOfTyres, hasTurbo, tuningMode,timeToSixty)
        {
            this.NumberOfTurbo = numberOfTurbo;
        }

        public override void GetEngineSize()
        {
            base.GetEngineSize();
        }

        public override void MakeDonuts()
        {
            Console.WriteLine("BMW loves Driftinggggggggggg");
        }

        public override string ToString()
        {
            return string.Format($"Technical data for BMW \n Engine:{this.EngineSize}\n NumberOfTyres:{this.NumberOfTyres}\n Turbo:{HasTurbo}\n Tuning:{this.AllowForTunning}\n Number of Turbo(s):{this.NumberOfTurbo} 0-62mph for :{this.TimeToSixty} seconds");
        }
    }
}
