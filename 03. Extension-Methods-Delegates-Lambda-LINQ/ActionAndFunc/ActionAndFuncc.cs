namespace Action_And_Func
{
    using OOP_MineExam.CustomSettings;
    using System;
    using System.Collections.Generic;

    public static class ActionAndFunc
    {
        public static void Go()
        {
            var x = Custom.StartProgram();
            Custom.ProgramStart("ActionAndFunc");
            // Action<int> logNumber = Console.WriteLine;
            Action<int> logNumber = (number) => Console.WriteLine(number);
            logNumber(5);

            Action<string, int> logNameAge = (name, age) =>
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            };
            logNameAge("Pesho", 5);

            // Func<string> magic = () => "Magic";
            Func<string> magic = () =>
            {
                return "Magic";
            };
            Console.WriteLine(magic());

            Func<string, int> parser = int.Parse;
            int someNumber = parser("50");
            Console.WriteLine(someNumber);

            string[] someStrings = { "Pesho", "Ivaylo", "Gosho", "Niki" };
            someStrings.Each(Console.WriteLine);
            someStrings.Each(str =>
            {
                Console.Write(str + " ");
            });
            Console.WriteLine();
            //// Array.ForEach(someStrings, Console.WriteLine);
            Custom.ProgramEnd("ActionAndFunc");
            Custom.EndProgram(x);
            Custom.End();
        }

        public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}