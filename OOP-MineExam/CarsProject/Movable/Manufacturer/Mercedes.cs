using System;

namespace OOP_MineExam.CarsProject
{
    public class Mercedes : Car
    {

        public int NumberOfSeats { get; set; }
        public bool HasLeather { get; set; }

        public Mercedes(double engineSize, int numberOfTyres, bool hasTurbo, bool tuningMode,int numberOfSeats,bool hasLeather,double timeToSixty)
                     : base(engineSize, numberOfTyres, hasTurbo, tuningMode,timeToSixty)
        {
            this.NumberOfSeats = numberOfSeats;
            this.HasLeather = hasLeather;
        }

        public override void GetEngineSize()
        {
            base.GetEngineSize();
        }

        public override void MakeDonuts()
        {
            Console.WriteLine("Mercedes loves Driftinggggggggggg");
        }

        public override string ToString()
        {
            return string.Format($"Technical data for Mercedes \n Engine:{this.EngineSize}\n NumberOfTyres:{this.NumberOfTyres}\n Turbo:{HasTurbo}\n Tuning:{this.AllowForTunning}\n Number of Seat(s):{this.NumberOfSeats} 0-62mph for :{this.TimeToSixty} seconds");
        }
    }
}