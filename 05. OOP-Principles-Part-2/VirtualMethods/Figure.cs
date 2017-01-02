using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.VirtualMethods
{
    public abstract class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a figure from unknown kind:");
            Console.WriteLine(this.GetType().Name);
        }
    }
}
