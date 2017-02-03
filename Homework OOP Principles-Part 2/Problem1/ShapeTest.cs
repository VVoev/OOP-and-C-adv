using _05.Homework_OOP_Principles_Part_2.Problem1.Abstract;
using _05.Homework_OOP_Principles_Part_2.Problem1.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_ShapeTest
{
    class ShapeTest
    {
        public static void Go()
        {
            var randomNumber = new Random();
            double width, height;
            var randomNumberOfFigures = randomNumber.Next(0, 100);
            var figures = new List<Shape>();

            for (int i = 0; i <= randomNumberOfFigures; i++)
            {
                width = randomNumber.Next(1, 70);
                height = randomNumber.Next(1, 50);
                if (i <= randomNumberOfFigures / 3)
                {
                    var triangle = new Triangle(width, height);
                    figures.Add(triangle);
                }
                else if (i > randomNumberOfFigures/3 && i <randomNumberOfFigures-randomNumberOfFigures/3)
                {
                    var rect = new Rectangle(width, height);
                    figures.Add(rect);
                }
                else
                {
                    var side = width;
                    var square = new Square(side);
                    figures.Add(square);
                }
            }
            var sortedFigures = figures.OrderBy(x => x.CalculateSurface());
            Console.WriteLine(string.Join(Environment.NewLine,sortedFigures));

        }
    }
}
