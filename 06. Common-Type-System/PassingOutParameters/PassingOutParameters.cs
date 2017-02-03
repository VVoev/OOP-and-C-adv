using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.PassingOutParametersss
{
    public struct Point
    {
        public int x, y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public struct Dimensions
    {
        public int width, height;
        public Dimensions(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    public class Rectangle
    {
        private int x, y, width, height;

        public Rectangle(int x,int y ,int width,int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void GetLocationAndDimension(out Point location, out Dimensions dimension)
        {
            location = new Point(x, y);
            dimension = new Dimensions(width, height);
        }


        public override string  ToString()
        {
            return string.Format($"Rectangle with {x},{y} width:{width} and height:{height}");
        }
    }


    class PassingOutParameters
    {
        public static void Go()
        {
            Rectangle rect = new Rectangle(5, 10, 12, 8);
            Point location = new Point(3, 3);
            Dimensions dimension = new Dimensions(1, 2);
            // Location and dimension are not pre-initialized!
            Console.WriteLine(rect);

            rect.GetLocationAndDimension(out location, out dimension);
            Console.WriteLine($"{location.x}{location.y} {Environment.NewLine}{dimension.height}{dimension.width}");
        }
    }
}
