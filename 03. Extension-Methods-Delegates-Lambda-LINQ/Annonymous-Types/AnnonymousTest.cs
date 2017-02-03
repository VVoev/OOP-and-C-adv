using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Annonymous_Types
{
    class AnnonymousTest
    {
        public static void Go()
        {
            var watch = Custom.StartProgram();
            Custom.ProgramStart("Annonymous");
            Custom.MakeFreeLines(2);

            var myCar = new { Color = "Black", Brand = "Opel", MaxSpeed = 255 };
            Console.WriteLine($@"My car is {myCar.Color} {myCar.Brand} and can reach up to {myCar.MaxSpeed} km/h");
            Console.WriteLine($@"Maximum speed is {myCar.MaxSpeed} km/h");

            Custom.MakeFreeLines(2);
            var p = new { X = 3, Y = 5, Z = 8 };
            var q = new { X = 3, Y = 5, Z = 8 };
            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(p==q);
            Console.WriteLine(p.Equals(q));
            Custom.MakeFreeLines(2);

            var combined = new { P = p, Q = q };
            Console.WriteLine(combined);
            Custom.MakeFreeLines(3);

            var arr = new[]
                             {
                                 new {X = 5, Y = 10 },
                                 new {X = 15,Y = 20 },
                                 new {X = 25,Y = 30 }
                             };

            foreach (var item in arr)
            {
                Console.WriteLine($@"{item.X},{item.Y}");
            }



            Custom.EndProgram(watch);
            Custom.ProgramEnd("Annonymous");
            Custom.End();
        }
    }
}
