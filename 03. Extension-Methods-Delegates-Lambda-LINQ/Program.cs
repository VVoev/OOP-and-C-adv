using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Extension_Methods_Delegates_Lambda_LINQ.Extension_Methods;
using _03.Extension_Methods_Delegates_Lambda_LINQ.Delegates_Example;
using _03.Extension_Methods_Delegates_Lambda_LINQ.Annonymous_Types;
using Action_And_Func;
using DynamicIsHere;
using EventsAreHere;
using _03.Extension_Methods_Delegates_Lambda_LINQ.Linq_Extensions_Methods;
using _03.Extension_Methods_Delegates_Lambda_LINQ.LambaExpressions;
using _03.Extension_Methods_Delegates_Lambda_LINQ.MultiCast_Delegate;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ
{
    class Program
    {
        public static int PrintString(string str)
        {
            Console.WriteLine($@"Str: {str}");
            return 1;
        }

        public int PrintStringLenght(string value)
        {
            Console.WriteLine($@"Lenght: {value.Length}");
            return 2;
        }

        static void Main(string[] args)
        {
            //1.Extension
            ExtensionTest.Go();

            //2.Delegates
            DelegateTest.Go();

            //3.Annonymous
            AnnonymousTest.Go();

            //4.ActionAndFunc
            ActionAndFunc.Go();

            //5.Dynamic
            Dynamic.Go();

            //6.Events
            Event.Go();

            //7.Linq Extension Methods
            Linq.Go();

            //8.Lambda Expressions
            Lambda.Go();

            //9.MultiCast Delegate
            MDelegate.Go();
        }
    }
}
