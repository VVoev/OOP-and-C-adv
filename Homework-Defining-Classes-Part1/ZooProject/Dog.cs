
namespace Homework_Defining_Classes_Part1.ZooProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Animal
    {
        private class DogInfo
        {
            
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
          protected set { this.name = value; }
        }

        public Dog(int legs, int paws, string eyes)
            : base(legs, paws, eyes)
        {
        }

        public Dog(int legs, int paws, string eyes, string name) : this(legs, paws, eyes)
        {
            this.Name = name;
        }

        public  void SayBauuuu(string name)
        {
            Console.WriteLine("{0} say Bauuuuuuuuuuuuuuuuuu",this.name);
        }
        public static void SayBauuuuu(string name)
        {
            Console.WriteLine("{0} say Bauuuuuuuuuuuuuuuuuu", name);
        }
        public override void SayHello()
        {
            Console.WriteLine("Bauuuuuuuuuuuu");
        }
    }
}
