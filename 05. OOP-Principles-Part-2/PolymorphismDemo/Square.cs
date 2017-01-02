using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.PolymorphismDemo
{
    public class Square : Figure
    {
        public double Size { get; set; }

        public override double CalculateSurface()
        {
            return this.Size * this.Size;
        }
    }
}
