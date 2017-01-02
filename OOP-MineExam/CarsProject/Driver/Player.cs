using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CarsProject.Driver
{
    public class Player : Credits
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }


        public Player(string name,int age,Car car)
        {
            this.Name = name;
            this.Age = age;
            this.Car = car;
        }
        public Player()
        {

        }
        public override string ToString()
        {
            return "I am " + this.Name;
        }
    }
}
