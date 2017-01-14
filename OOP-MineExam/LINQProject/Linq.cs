using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_MineExam.CustomSettings;

namespace OOP_MineExam.LINQProject
{
    class Linq
    {
        public static void Go()
        {
            Custom.ProgramStart("LINQ Project");

            var arrayNames = new string[] { "Mimi", "Vlado", "Djingal", "Pepi", "Alexander", "Misho", "Ivan" };
            var arrayNumbers = new int[] { 5, 2, 3, 4, 5, 7, 8, 10, 12, 100, 200, 400, 800, 302 };
            var arrayStudents = new StudentProject.University.Student[] { new StudentProject.University.Student("mimi", "Ivanova"),
                                                                          new StudentProject.University.Student("miro", "Qnkof"),
                                                                          new StudentProject.University.Student("Petar", "Petrov"),
                                                                          new StudentProject.University.Student("Spas", "Uzunov") };
            var townDictionary = new Dictionary<string, long>();
            townDictionary.Add("London", 2000000);
            townDictionary.Add("Sofia", 100000);
            townDictionary.Add("Sinsinati", 3000000);
            townDictionary.Add("Smqdovo", 2000);
            townDictionary.Add("Moscow", 2000000);

            var sortedNames = arrayNames.Where(x => x.Length > 2 && x.Length<=4);
            var sortedNumbers = arrayNumbers.Where(x => x > 10 && x % 3 == 0);
            var numbersInAsceding = arrayNumbers.OrderBy(x => x);
            var sortedStudents = arrayStudents.Where(x => x.Lastname.StartsWith("I")); ;
            var sortedDictionary = townDictionary.Where(x => x.Value > 50000).Where(x => x.Key.Contains("S"));

            




            Console.WriteLine("Sorted Names");
            Console.WriteLine(string.Join(" ",sortedNames));
            Custom.MakeFreeLines(2);

            Console.WriteLine("Sorted Numbers");
            Console.WriteLine(string.Join(" ", sortedNumbers));
            Custom.MakeFreeLines(2);

            Console.WriteLine("Sorted Numbers In Asceding Order");
            Console.WriteLine(string.Join(" ", numbersInAsceding));
            Custom.MakeFreeLines(2);

            Console.WriteLine("Sorted Students");
            Console.WriteLine(string.Join(" ",sortedStudents));
            Custom.MakeFreeLines(2);

            Console.WriteLine("Sorted Towns");
            Console.WriteLine(string.Join(" "+Environment.NewLine,sortedDictionary));
            Custom.MakeFreeLines(2);

            Custom.ProgramEnd("Linq Project");
            Custom.End();

        }
    }
}
