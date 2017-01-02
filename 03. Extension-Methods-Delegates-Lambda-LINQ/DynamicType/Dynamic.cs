using _03.Extension_Methods_Delegates_Lambda_LINQ.DynamicType;
using OOP_MineExam.CustomSettings;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicIsHere
{
    class Dynamic
    {
        public static void Go()
        {
            var x = Custom.StartProgram();
            Custom.ProgramStart("Dynamic");
            UsingDynamicDemo();
            ExpandObjectDemo();
            Custom.ProgramEnd("Dynamic");
            Custom.EndProgram(x);
            Custom.End();

        }

        private static void ExpandObjectDemo()
        {
            dynamic expObject = new ExpandoObject();
            expObject.Result = 5;
            Console.WriteLine($@"Result is {expObject.Result}");

            expObject.Firstname = "Vladko";
            expObject.Lastname = "Tarikatko";
            expObject.SayHello = new Func<string>(() => { return "I am " + expObject.Firstname + " " + expObject.Lastname; });
            Console.WriteLine(expObject.SayHello());
            Custom.MakeFreeLines(2);

            var properties = (IDictionary<string,object>)expObject;
            properties.Add("Age", 24);
            properties.Add("SayAge", new Func<string>(() => { return "My Age is " + properties["Age"]; }));
            Console.WriteLine(expObject.SayAge());Custom.MakeFreeLines(1);

            Console.WriteLine("Age has been changed to ");Custom.MakeFreeLines(1);
            properties.Add("ChangeAge", new Action<int>((age) => { properties["Age"] = age; }));
            expObject.ChangeAge(18);
            Console.WriteLine(expObject.SayAge());

            Custom.MakeFreeLines(3);
            foreach (var pair in properties)
            {
                Console.WriteLine(pair.Key+ " "+pair.Value);
            }

        }

        private static void UsingDynamicDemo()
        {
            dynamic student = new Student();
            student.Name = "Vlado";
            student.ID = 200300400;
            Console.WriteLine(student.Name);
            Console.WriteLine(student.ID);
            Custom.MakeFreeLines(1);

            int result = Sum<int>(5, 6);
            decimal decimalResult = Sum<decimal>(12.15m, 15.83m);
            string text = Sum<string>("Mariq", "Vlado");

            Console.WriteLine(result);
            Console.WriteLine(decimalResult);
            Console.WriteLine(text);
            Custom.MakeFreeLines(1);

            int comparing = Comparer<int>(5, 5);
            double compare = Comparer<double>(5.12, 5.13);
            long compareL = Comparer<long>(5.12, 5.11);

            Console.WriteLine(compare);
            Console.WriteLine(comparing);
            Console.WriteLine(compareL);
            Custom.MakeFreeLines(1);


        }

        private static int Comparer<T>(dynamic v1, dynamic v2)
        {
            if (v1 == v2)
            {
                return 0;
            }
            else
            {
                if (v1 < v2)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        private static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }
    }
}
