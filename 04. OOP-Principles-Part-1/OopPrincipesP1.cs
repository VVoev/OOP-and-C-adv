using _04.OOP_Principles_Part_1.EncapsulationDemo;
using MainAbstract;
using OOP_Principles_Part_1.InheritanceAndAcessability;
using Principles_Part_1.Interface_And_Implementation;
using Principles_Part_1.Simple_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles_Part_1
{
    class OOPPrincipes1
    {
        static void Main()
        {
            //1. Abstract Classes Demo
            SeparateDemos("Abstract Classes");
            AbsractClasses.Go();

            //2. Simple Inheritance
            SeparateDemos("Simple Inheritance");
            SimpleInheritance.Go();

            //3. Interface-And-Implementation
            SeparateDemos("Interface-And-Implementation");
            PlayWithInterfaces.Go();

            //4. InheritanceAndAcessability
            SeparateDemos("InheritanceAndAcessability");
            InheritanceAndAccessability.Go();

            //5. Encapsulation
            SeparateDemos("Encapsulation");
            Encapsulation.Go();


        }

        public static void SeparateDemos(string name)
        {
            Console.WriteLine("[]-----------------------------{0}---------------------------------[]",name);
        }
    }
}
