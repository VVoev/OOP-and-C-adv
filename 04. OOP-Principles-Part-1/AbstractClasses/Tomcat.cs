using System;
using _04.OOP_Principles_Part_1.AbstractClasses;

namespace MainAbstract
{
    public class Tomcat : Animal
    {
        public Tomcat()
        {
        }

        public override int Speed
        {
            get
            {
                return 50;
            }
        }

        public override string GetName()
        {
            return "Tom";
        }
        public void SayMiau()
        {
            Console.WriteLine(GetName() + " says Meowwwwwwwwww");
        }
    }
}