using OOP_MineExam.CarsProject.Movable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CarsProject
{
    public abstract class Car : Vehicle,ICar
    {
        public List<Car>Cars { get; set; }
        public Car(double engineSize, int numberOfTyres, bool hasTurbo, bool tuningMode,double timeToSixty)
                : base(engineSize, numberOfTyres, hasTurbo, tuningMode,timeToSixty)
        {
            this.Cars = new List<Car>();
        }

        public virtual void GetEngineSize()
        {
            Console.WriteLine("My engine is {0}l",this.EngineSize);
        }

        public virtual void MakeDonuts()
        {
            Console.WriteLine("Tyres Squezeeeeeeeeeeee");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
