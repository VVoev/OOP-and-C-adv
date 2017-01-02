using _04.OOP_Principles_Part_1.Interface_And_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles_Part_1.Interface_And_Implementation
{
    class PlayWithInterfaces
    {
        public static void Go()
        {
            Square square = new Square(0, 0, 10);
            Rectangle rect = new Rectangle(0, 0, 10, 12);
            Circle circle = new Circle(0, 0, 5);

            if(square is IShape)
                Console.WriteLine($@"{square.GetType().Name} is Ishape");
            if(rect is IResizable)
                Console.WriteLine("{0} is IResizable",rect.GetType().Name);

            //Not entering cause circle is not Resizable
            if(circle is IResizable)
                Console.WriteLine("{0} is IResizable", circle.GetType().Name);

            Console.WriteLine();
            Console.WriteLine();
            //rect.ResizeByX(5);
            //rect.ResizeByY(5);

            IShape[] shapes = { square, rect, circle };
            foreach (var shape in shapes)
            {
                shape.SetPosition(5, 5);
                Console.WriteLine($@"{shape.GetType().Name} with surface {shape.CalculateSurface()}");
            }
        }
    }
}
