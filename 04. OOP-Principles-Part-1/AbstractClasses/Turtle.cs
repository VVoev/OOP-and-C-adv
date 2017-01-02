using System;
using _04.OOP_Principles_Part_1.AbstractClasses;

namespace MainAbstract
{
    public class Turtle : Animal
    {

        public override int Speed
        {
            get
            {
                return 1;
            }
        }

        public override string GetName()
        {
            return "turtle";
        }
    }
}