using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.PolymorphismDemo
{
    public class Circkle : Figure
    {
        public double Radius { get; set; }
        public override double CalculateSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
