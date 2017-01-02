using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.AbstractClasses
{
    public abstract class Cat : Animal
    {
        public string Breed { get; set; }
        public abstract void SayMiau();
    }
}
