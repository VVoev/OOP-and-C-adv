using _05.OOP_Principles_Part_2.PolymorphismDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.PolymorphismDemo
{
    class Polymorphism
    {
        public static void Go()
        {
            Figure[] figures =
            {
                new Square {Size=3 },
                new Circkle {Radius=2 },
                new Rectangle {Width=2,Height=4 },
                new Circkle {Radius=4 },
                new Square {Size=6 },
                new Square {Size=8 }
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Figure = {figure.GetType().Name.PadRight(13,' ')}\nsurface = {figure.CalculateSurface():f2}.");
            }
        }
    }
}
