using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.AbstractClasses
{
    public abstract class Animal : IComparable<Animal>
    {
        public abstract string GetName();
        public abstract int Speed { get; }

        public override string ToString()
        {
            return "I am " + this.GetName();
        }

        public int CompareTo(Animal other)
        {
            return this.Speed.CompareTo(other.Speed);
        }
    }
}
