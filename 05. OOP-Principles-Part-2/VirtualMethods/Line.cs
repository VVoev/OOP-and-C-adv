using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.VirtualMethods
{
    class Line : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am a line");
            Console.WriteLine("-----");
        }
    }
}
