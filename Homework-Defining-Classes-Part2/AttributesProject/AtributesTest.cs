
namespace Homework_Defining_Classes_Part2.AttributesProject
{
    using Homework_Defining_Classes_Part2.PointProject;
    using System;
    using System.Diagnostics;
    [Version ("1","04")]
    class AtributesTest
    {
        public static void Test()
        {
            //Start 
            NewLine.ProgramStart("Attributes");
            Stopwatch watch = NewLine.StartProgram();

            Type type = typeof(AtributesTest);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }

            //Finish
            NewLine.ProgramFinish("Attributes");
            NewLine.EndProgram(watch);
            NewLine.MakeThreeNewLines();
        }
    }
}
