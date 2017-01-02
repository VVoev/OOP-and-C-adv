using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2_Live.Structuresss
{
    class Structuree
    {
        public static void TestStructure()
        {
            Square square = new Square(
                            new Point() { X = 5, Y = 10 }, 7,
                            new Color() { RedValue = 100, GreenValue = 180, BlueValue = 200 },
                            new Color() { RedValue = 50, GreenValue = 100, BlueValue = 150 },
                            Edges.Rounded);
            //First Square
            Console.WriteLine(square);
            square.Edges = Edges.Straight;
            square.BorderColor = new Color() { GreenValue = 44, BlueValue = 88, RedValue = 122 };
            Point location = square.Location;
            location.X += 10;
            square.Location = location;
            //Second Square
            Console.WriteLine(square);
        }
    }
}
