using _05.Homework_OOP_Principles_Part_2.Problem2;
using _05.Homework_OOP_Principles_ShapeTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2
{
    class Startup
    {
        static void Main()
        {
            //.1 Problem Shapes
            Separate("Problem Shapes");
            ShapeTest.Go();

            //2. BankAccountTest
            Separate("BankAccountTest");
            BankAccountTest.Go();


        }

        private static void Separate(string name)
        {
            Console.WriteLine($"Your project {name.PadLeft(9,' ')} starts here");
            Console.WriteLine();
        }
    }
}
