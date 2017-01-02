using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Linq_Extensions_Methods
{
    class Linq
    {
        public static void Go()
        {
            var x = Custom.StartProgram();
            Custom.ProgramStart("Linq Extensions Methods");

            LinqKeywordsExample();
            LinqExtensionsMethodsExample();





            Custom.ProgramEnd("Linq Extensions Methods");
            Custom.EndProgram(x);
            Custom.End();
        }

        private static void LinqExtensionsMethodsExample()
        {
            var studentRepo = new StudentRepository();
            var students = studentRepo.GetAllStudents();

            //Where
            var someStudents = students.Where(x => x.Name == "Vlado" || x.Name == "Spas");
            Console.WriteLine(string.Join("",someStudents));
            Custom.Separate();
            //First
            Student first = students.FirstOrDefault(x => x.Courses.Count == 3);
            Console.WriteLine(first);
            Custom.Separate();

            //Select
            var projectedItems = students.Select(x => new Student { Name = x.Id.ToString(), Courses = new List<Course>() });
            Console.WriteLine(string.Join(" ",projectedItems));
            Custom.Separate();

            //Select to annonymous
            var annStudents = students.Select(x => new { Name = x.Name, ID = x.Id, TotalCouces = x.Courses.Count });
            Console.WriteLine(string.Join(Environment.NewLine,annStudents));
            Custom.Separate();

            //Orderb by
            var ordered = students.OrderBy(x => x.Courses.Count).ThenBy(x => x.Name);
            Console.WriteLine(string.Join(Environment.NewLine, ordered));
            Custom.Separate();

            //Any
            bool checkAny = students.All(x => x.Name != string.Empty);
            Console.WriteLine(checkAny);
            Custom.Separate();

            //All
            bool checkAll = students.All(x => x.Name != string.Empty);
            Console.WriteLine(checkAll);
            checkAll = students.All(x => x.Id > 2);
            Console.WriteLine(checkAll);
            Custom.Separate();

            //ToList and ToArray
            Student[] arrayOfStudents = students.ToArray();
            Print(arrayOfStudents);
            Custom.Separate();
            List<Student> listOfstudents = arrayOfStudents.ToList();
            Print(listOfstudents);
            Custom.Separate();

            //Reading string of numbers separate by a space
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Print(numbers);

            //reverse
            Print(students.Reverse());
            Custom.Separate();

            //average
            double averageCourses = students.Average(x => x.Courses.Count());
            Console.WriteLine(averageCourses);
            Custom.Separate();

            //max
            int max = students.Max(x => x.Courses.Count);
            Console.WriteLine(max);
            Custom.Separate();

            //min
            int min = students.Min(x => x.Courses.Count);
            Console.WriteLine(min);
            Custom.Separate();

            //count
            int count = students.Count(x => x.Name.Length > 4);
            Console.WriteLine(count);
            Custom.Separate();

            //sum
            int sum = students.Sum(x => x.Courses.Count);
            Console.WriteLine(sum);
            Custom.Separate();

            //extension Methods

            var collection = students.Where(x => x.Id > 1)
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Courses.Count)
                .Select(x => new { Name = x.Name, Courses = x.Courses.Count })
                .ToArray();
            Print(collection);
            Custom.Separate();

            //nesting
            var someOtherStudents = students.Where(x => x.Courses.Any(c => c.Name == "OOP")).OrderBy(v => v.Name);
            Console.WriteLine(string.Join(Environment.NewLine,someOtherStudents));
            Custom.Separate();
            someOtherStudents = students.Where(x => x.Courses.Any(c => c.Name == "JavaScript")).OrderBy(v => v.Id);
            Console.WriteLine(string.Join(Environment.NewLine, someOtherStudents));
            Custom.Separate();
        }

        private static void LinqKeywordsExample()
        {
            int[] numbers = { 5, 3, 4, 5, 6, 10, 20, 30, 12, 3, 4, 5, 6, 83 };
            var querySmallNumbers =
                                   from num in numbers
                                   where num > 10
                                   select num;
            Print(querySmallNumbers);

            string[] towns = { "London", "Moscow", "Berlin", "New York" };
            var townPairs = from town1 in towns
                            from town2 in towns
                            select new { t1 = town1, t2 = town2 };


            foreach (var pair in townPairs)
                Console.WriteLine(pair);

            string[] fruits = { "Cherry", "PineApple", "Apple", "Orange", "Grape","Avocado" };
            var sortFruitsInAscending = from fruit in fruits
                                        orderby fruit
                                        select fruit;
            Print(sortFruitsInAscending);
            Custom.Separate();
        }

        private static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var query in collection)
            {
                Console.Write(query.ToString()+" ");
            }
            Console.WriteLine();
        }
        }
    }
