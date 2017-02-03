using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.LambaExpressions
{
    class Lambda
    {
        public static void Go()
        {
            var watch=Custom.StartProgram();
            Custom.ProgramStart("Lambda Expressions");
            var listNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = listNumbers.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", evenNumbers));
            Custom.Separate();

            listNumbers.RemoveAll(x => x > 3);
            Console.WriteLine(string.Join(" ", listNumbers));
            Custom.Separate();

            List<Pet> petList = new List<Pet>();
            petList.Add(new Pet{ Name = "Sharo", Age = 1 });
            petList.Add(new Pet{ Name = "Djafar", Age = 2 });
            petList.Add(new Pet{ Name = "Bingo", Age = 12 });
            petList.Add(new Pet{ Name = "Reks", Age = 21 });
            petList.Add(new Pet{ Name = "Alex", Age = 18});

            var sortedPets = petList.OrderBy(x => x.Age);
            Console.WriteLine(string.Join("", petList));
            Custom.Separate();

            //Predicate
            listNumbers = new List<int> { 11, 20, 33, 40, 55, 60, 77, 80, 99, 100, 111 };
            evenNumbers = listNumbers.FindAll(
                (i) =>
                {
                    Console.WriteLine($@"Value of i is {i}");
                    return (i % 2 == 0);
                });
            Console.WriteLine(string.Join(" ",evenNumbers));
            Custom.Separate();

            Func<bool> func = () => true;
            int number = 2;
            Func<int, bool> intfunc = (x) => x < 10;
            if(func() && intfunc(number))
            {
                Console.WriteLine($@"{number}<10");
            }

            var towns = new List<string> { "Sozopol", "Stara Zagora", "Plovdiv", "Sofia", "Burgas", "Ruse", "Varna" };
            var townWithS = towns.FindAll(
                delegate (string town)
                                        {
                                            return town.StartsWith("S");
                                        });
            //Shortform of the same
            var newTowns=towns.FindAll(x => x.StartsWith("S"));

            Console.WriteLine(string.Join(", ",townWithS));
            Console.WriteLine(string.Join(", ",newTowns));
            Custom.Separate();

            Custom.ProgramEnd("Lambda Expressions");
            Custom.EndProgram(watch);
            Custom.End();
        }
    }
}
