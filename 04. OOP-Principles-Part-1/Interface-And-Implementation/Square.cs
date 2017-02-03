using System;
using _04.OOP_Principles_Part_1.Interface_And_Implementation;

namespace Principles_Part_1.Interface_And_Implementation
{
    public class Square : IShape
    {
        private int x;
        private int y;
        private int size;

        public Square(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void SetPosition(int x, int y)//From Ishape
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()//From Ishape
        {
            return size * size;
        }
    }
}