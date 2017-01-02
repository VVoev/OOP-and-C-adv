using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CarsProject
{
    public abstract class Vehicle
    {
        public double EngineSize { get; set; }
        public int NumberOfTyres { get; set; }
        public bool HasTurbo { get; set; }
        public bool AllowForTunning { get; set; }
        public double TimeToSixty { get; set; }

        public Vehicle(double engineSize,int numberOfTyres,bool hasTurbo,bool tuningMode,double timeToSixty)
        {
            this.EngineSize = engineSize;
            this.NumberOfTyres = numberOfTyres;
            this.HasTurbo = hasTurbo;
            this.AllowForTunning = tuningMode;
            this.TimeToSixty = timeToSixty;
        }

    }
}
