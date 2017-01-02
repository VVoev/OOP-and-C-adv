using System;
using _04.OOP_Principles_Part_1.Interface_And_Implementation;

namespace Principles_Part_1.Interface_And_Implementation
{
    public class Circle : IShape,IMovable
    {
        private int x;
        private int y;
        private int radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        //From Ishape
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //From Ishape
        public double CalculateSurface()
        {
            return Math.PI * radius * radius;
        }
        //From IMovable
        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }
    }
}