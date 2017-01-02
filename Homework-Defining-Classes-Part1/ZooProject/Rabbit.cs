
namespace Homework_Defining_Classes_Part1.ZooProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rabbit : Animal
    {
        public Rabbit(int legs, int paws, string eyes)
            : base(legs, paws, eyes)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("I cannot speak because I`am rabbit");
        }
    }
}
