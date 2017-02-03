using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Type_System.Boxing_and_Unboxing
{
    public class BoxingUnboxing
    {
        public static void Go()
        {
            Point p1 = new Point();
            Console.WriteLine(p1);
            IMovable p1mov = (IMovable)p1;// p1 is boxed
            IMovable p2mov = p1mov;
            // p1mov is not boxed second time,
            // because it is already boxed

            Point p2 = (Point)p2mov; // p2mov is unboxed
            p1.Move(-100, -100);
            p2.Move(100, 100);
            Console.WriteLine("p1 is moved to {0}", p1); // p1=(-100,-100)
            Console.WriteLine("p2 is moved to {0}", p2); // p2=(100,100)

            p1mov.Move(5, 5);
            Console.WriteLine("p1mov is moved to {0} ", p1mov); // p1mov=(5,5)
            Console.WriteLine("p2mov is also moved to {0}", p2mov); // p2mov=(5,5)   
            p2mov.Move(3, 3);
            Console.WriteLine("p1mov is moved to {0} ", p1mov); // p1mov=(5,5)
            Console.WriteLine("p2mov is also moved to {0}", p2mov); // p2mov=(5,5)   


        }
    }
    public interface IMovable
    {
        void Move(int x, int y);
    }
    struct  Point : IMovable
    {
        public int x;
        public int y;

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public override string ToString()
        {
            return string.Format($"{x},{y}");
        }
    }
}
