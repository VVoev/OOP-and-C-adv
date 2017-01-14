using _05.Homework_OOP_Principles_Part_2.Problem1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem1.Abstract
{
    public abstract class Shape 
    {
        protected double width;
        protected double height;
        public abstract double CalculateSurface();

    }
}
