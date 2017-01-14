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
            var cat = new Cat(2, "Katq");
            Action<int> multiPlyTwoAndHalf = (number) => Console.WriteLine(number*2.5);
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


        }
    }
}
