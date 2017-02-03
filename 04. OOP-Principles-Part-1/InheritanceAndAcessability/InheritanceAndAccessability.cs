using _04.OOP_Principles_Part_1.InheritanceAndAcessability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_1.InheritanceAndAcessability
{
    class InheritanceAndAccessability
    {
        public static void Go()
        {
            Dog joe = new Dog("Sharo", 6, "Labrador");
            joe.Sleep();//Sleep is public
            Console.WriteLine("Breed is:" + joe.Breed);
            joe.WagTail();
            joe.Walk();
            var mamal = new Mammal("nqkvo", 1);
            joe.Smqtai();


            //joe.Talk();  Talk() is private
            //joe.Walk();   Walk() is protected
            //joe.Name Name is protected
        }
    } 
}
