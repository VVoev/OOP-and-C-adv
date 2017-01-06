using System;
using _04.OOP_Principles_Part_1.AbstractClasses;

namespace MainAbstract
{
    public class Kitten : Cat
    {
        public override int Speed
        {
            get
            {
                return 5;
            }
        }

        public override string GetName()
        {
            return $"Djingal";
        }

        public override void SayMiau()
        {
            Console.WriteLine(GetName()+"says Meowwww");
        }
    }
}