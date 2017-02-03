using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Action
{
    class ActionDemo
    {
        public static void Start()
        {
            Action<int, int> square = (first, second) =>
            {
                Console.WriteLine($"square is {Math.Sqrt(first + second)}");
            };
            square(4, 12);

            Action<int> multiPlyTwoAndHalf = (number) => Console.WriteLine(number * 2.5);
            multiPlyTwoAndHalf(40);

            Action<int, string,string> introduceYourself = (age, firstname,lastname) =>
             {
                 Console.WriteLine($"I am {firstname+" "+lastname} {age} years old");
             };
            introduceYourself(31, "Vlado", "Voev");


            Action<int, int, string> Sumator = (first, second, result) =>
              {
                  int res = first + second;
                  result = res > 0 ? "Positive" : "Negative";
              };
            Sumator(10, 20, string.Empty);

            var cat = new Cat(2, "Katq");
            Action<string, Cat> ChangeName = (name, kotka) =>
            {
                kotka.Name = "Petya";   
            };
            ChangeName("someText", cat);
            Console.WriteLine(cat.Name +" is a  "+ typeof(Cat).Name);


            Action<string, string> fullname = (first, last) =>
            {
                string full = first + " " + last;
                Console.WriteLine(full);
            };
            fullname("Petar", "Danov");

            Action<int, int, int, int, int> BetterMathMax = (first, second, third, fourth, fifth) =>
                {            
                    Console.WriteLine(Math.Max(first, Math.Max(second, Math.Max(third, Math.Max(fourth, fifth)))));   
                };
            Console.WriteLine($"Biggest Number is ");
            BetterMathMax(5,10,15,20,25);


            Action<int, Cat> changeCatYears = (years, catYears) =>
              {
                  catYears.Age = years;
              };
            var myCat = new Cat(15, "Djingal");
            changeCatYears(3, myCat);
            Console.WriteLine($"My name is {myCat.Name} and i am {myCat.Age}years old and i am {typeof(Cat).Name}");




        }
    }
}
