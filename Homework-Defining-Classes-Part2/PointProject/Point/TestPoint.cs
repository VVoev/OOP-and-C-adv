using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Homework_Defining_Classes_Part2.Point;
using Homework_Defining_Classes_Part2.PathData;
using Homework_Defining_Classes_Part2.PointProject;

namespace Homework_Defining_Classes_Part2.Point
{
    class TestPoint
    {
        public static void TestExam()
        {
            //Start Program
            NewLine.ProgramStart("Point");
            Stopwatch watch= NewLine.StartProgram();

            //Add 3 Points
            Point3D first = new Point3D(10, 10, 10);
            Point3D second = new Point3D(15.5, 22.2, 44.8);
            Point3D third = new Point3D(488, 20890.4734683, 106434378);

            //Add Point With a Default Value
            Point3D entryPoint = Point3D.DefaultStartingPoint;

            //Test CallculateDistance
            double distance = Distance.CalculateDistance(first, second);

            //Test
            Path path = new Path();
            path.AddPoint(first);
            path.AddPoint(second);
            path.AddPoint(third);
            path.AddPoint(entryPoint);
            Console.WriteLine("3D Points:");
            Console.WriteLine("You have in Total {0} Points",path.Count);
            Console.WriteLine(string.Join(Environment.NewLine, path.Points));
            NewLine.MakeThreeNewLines();

            //Test Reading from file
            string input = @"C:\Users\Vlado\Documents\Visual Studio 2015\Projects\ConsoleApplication2\Homework-Defining-Classes-Part2\PointProject\IOFiles\input.txt";
            Path pathFromFile = PathStorage.LoadPath(input);
            Console.WriteLine("3D Points read from file.");
            Console.WriteLine(string.Join(Environment.NewLine, pathFromFile.ToString()));
            NewLine.MakeThreeNewLines();


            //Remove Last Point
            path.RemovePooint(entryPoint);

            //Remove Point at specific position
            path.RemovePointAt(0);

            Console.WriteLine("3D Points:");
            Console.WriteLine("You have in Total {0} Points", path.Count);
            Console.WriteLine(string.Join(Environment.NewLine, path.Points));
            NewLine.MakeThreeNewLines();

            //Changes values for the remaining points
            for (int i = 0; i < path.Count; i++)
            {
                path[i] = new Point3D(i + 10, (i+10)*2, i + Math.Pow(16,i));
            }
            Console.WriteLine("3D Points has been changed to:");
            Console.WriteLine("You have in Total {0} Points", path.Count);
            Console.WriteLine(string.Join(Environment.NewLine, path.Points));
            NewLine.MakeThreeNewLines();

            //Write To File
            string outputFile = @"C:\Users\Vlado\Documents\Visual Studio 2015\Projects\ConsoleApplication2\Homework-Defining-Classes-Part2\PointProject\IOFiles\output.txt";
            PathStorage.SavePath(outputFile, path);
            Console.WriteLine("3D Points written to file:");
            Console.WriteLine(path.ToString());
            NewLine.MakeThreeNewLines();

            //Finish
            NewLine.ProgramFinish("Point");
            NewLine.EndProgram(watch);
            NewLine.MakeThreeNewLines();








        }

    }
}
