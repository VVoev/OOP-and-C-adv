using System;
using _04.OOP_Principles_Part_1.AbstractClasses;

namespace MainAbstract
{
    public class Cheetah : Animal
    {
        public Cheetah()
        {
        }

        public override int Speed
        {
            get
            {
                return 100;
            }
        }

        public override string GetName()
        {
            return "Cheetah";
        }
    }
}