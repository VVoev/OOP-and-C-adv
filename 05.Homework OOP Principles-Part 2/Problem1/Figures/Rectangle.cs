using _05.Homework_OOP_Principles_Part_2.Problem1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem1.Figures
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            return this.height * this.width;
        }

        public override string ToString()
        {
            return string.Format($"I am {GetType().Name} and my surcafe is {CalculateSurface():f2}");
        }
    }
}
