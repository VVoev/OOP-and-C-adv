using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.VirtualMethods
{
    internal class Circle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("I am a circkle");
            Console.WriteLine(" --- ");
            Console.WriteLine("|   | ");
            Console.WriteLine(" --- ");
        }
    }
}
