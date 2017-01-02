using System;
using _04.OOP_Principles_Part_1.Interface_And_Implementation;

namespace Principles_Part_1.Interface_And_Implementation
{
    public class Rectangle : IShape,IMovable,IResizable
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void SetPosition(int x, int y)//From IShape
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()//From IShape
        {
            return width * height;
        }

        public void Move(int deltaX, int deltaY)//From IMovable
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public void Resize(int weightX, int weightY)//From IResizable
        {
            width = width * weightX;
            height = height * weightY;
        }

        public void ResizeByX(int weightX)//From IResizable
        {
            width = width * weightX;
        }

        public void ResizeByY(int weightY)//From IResizable
        {
            height = height * weightY;
        }
    }
}