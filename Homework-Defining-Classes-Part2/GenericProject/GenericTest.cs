using Homework_Defining_Classes_Part2.PointProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part2.GenericProject
{
    class GenericTest
    {
        public static void TestGeneric()
        {
            //Start 
            NewLine.ProgramStart("GenericList");
            Stopwatch watch = NewLine.StartProgram();

            //Add 10 items into the List
            var list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i*10+10);
            }

            //Insert Item at some Position
            list.InsertAt(5,455);

            //Get Index of the Elementh
            int index = list.IndexAt(80);
            Console.WriteLine($@"Index of the list for the selected element is {index}");
            NewLine.MakeOneLine();

            //Get Value of the Elementh  in the list
            Console.WriteLine("This is the value");
            int value = list.IndexOf(5);
            Console.WriteLine(value);

            //Deleting item from a spefic position
            Console.WriteLine("You succesfully Remove elementh from position 5");
            //455 has been removed
            list.RemoveAt(5);

            //Get Min Value of your List
            Console.WriteLine("The smallest elementh in the list is ");
            list.Min();



            //Get Max Value of your List
            Console.WriteLine("The biggest elementh in the list is ");
            list.Max();



            //Override to String
            //Testing the list
            Console.WriteLine("Those are all elements in your list");
            Console.WriteLine(list.ToString());
            NewLine.MakeOneLine();

            //Clear The list
            list.Clear();
            Console.WriteLine($@"Elemements after clear the list are {list.Count}");




            //Finish
            NewLine.ProgramFinish("GenericList");
            NewLine.EndProgram(watch);
            NewLine.MakeThreeNewLines();
        }
    }
}
