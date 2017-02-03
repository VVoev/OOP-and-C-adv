using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part_1.InheritanceAndAcessability
{
   public class Creature
    {
        protected string Name { get; private set; }

        public Creature(string name)
        {
            this.Name = name;
        }

        private void Talk()
        {
            Console.WriteLine("I am a creature....");
        }

        internal void Walk()
        {
            Console.WriteLine($@"{this.Name}Walking Walking walkinggg");
        }

    }
}
