using _05.Homework_OOP_Principles_Part_2.Problem1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem1.Figures
{
    class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double CalculateSurface()
        {
            return this.side * this.side;
        }
        public override string ToString()
        {
            return string.Format($"I am {GetType().Name} and my surcafe is {CalculateSurface():f2}");
        }
    }
}
