using GenericConstraints;
using System;
using System.Runtime.InteropServices;
using Defining_Classes___Part_2_Live;
using SofiaUniversity.Data;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface,
  AllowMultiple = true)]
public class AuthorAttribute : System.Attribute
{
    public string Name { get; private set; }

    public AuthorAttribute(string name)
    {
        this.Name = name;
    }
}

[Author("Nikolay Kostov")]
[Author("Doncho Minkov")]
[Author("Ivaylo Kenov")]
[Author("Evlogi Hristov")]
class CustomAttributesDemo
{
    static void Main(string[] args)
    {
        Type type = typeof(CustomAttributesDemo);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (AuthorAttribute authorAttribute in allAttributes)
        {
            Console.WriteLine("This class is written by {0}. ",
                authorAttribute.Name);
        }

        PrintLines("Generic List INT");

        GenericList<int> intList = new GenericList<int>();
        GenericList<int> intList2 = new GenericList<int>(2);
        intList.Add(100);
        intList.Add(200);
        intList.Add(300);
        intList2.Add(44);
        Console.WriteLine("Number of elements are {0}",intList.Count);
        Console.WriteLine("Number of elements are {0}",intList2.Count);
        PrintLines(1);
        for (int i = 0; i < intList.Count; i++)
        {
            int elem = intList[i];
            Console.WriteLine(elem);
        }

        PrintLines("Generic List String");

        GenericList<string> stringList = new GenericList<string>();
        stringList.Add("C#");
        stringList.Add("JAVA");
        stringList.Add("C++");
        stringList.Add("Python");
        Console.WriteLine("Number of elements are {0}", stringList.Count);
        PrintLines(1);
        for (int i = 0; i < stringList.Count; i++)
        {
            string elem = stringList[i];
            Console.WriteLine(elem);
        }

        PrintLines(1);
        GenericConstraintClass<TestClass1> test1 = new GenericConstraintClass<TestClass1>();
        Console.Write("GENERIC class and construktor");
        PrintLines(1);
        PrintLines("Generic Methods");

        long x = 10;
        long y = 20;
        long min = Min<long>(x, y);
        Console.WriteLine("Min({0}, {1}) = {2}", x, y, min);

        string firstString = "Vodka";
        string secondString = "Beer";
        string minString = Min<string>(firstString, secondString);
        Console.WriteLine("Min({0}, {1}) = {2}", firstString, secondString, minString);

        //Point p1 = new Point();
        //Point p2 = new Point();
        //Point minPoint = Min(p1, p2); 
        // This will not compile
        PrintLines("Sofia University");
        Faculty fakultet = new Faculty();
        fakultet.Name = "Economics";
        Faculty profesorF = new Faculty();
        profesorF.Name = "Vsichkologiq";
        Student mimi = new Student("Mariq", "Kumanova",fakultet, Specialty.QdrenaFizika, 25554);
        Student vavaKote = new Student("Valq", "Koteto", fakultet, Specialty.ComputerScience, 38791);
        Professor vladi = new Professor("Vlado", "Voev", profesorF, "BashVsichko");
        List<Student> students = new List<Student>();
        students.Add(mimi);
        students.Add(vavaKote);
        foreach (var student in students)
        {
            Console.WriteLine(student);
            Console.WriteLine();
        }
        PrintLines("Overloading Operators");
        Fraction f1 = (double)1/10;
        Console.WriteLine("f1 = {0}", f1);
        Fraction f2 = (double)1 / 10;
        Console.WriteLine("--f1 = {0}", --f1);
        Console.WriteLine("f2 = {0}", f2);
        Console.WriteLine("f2 = {0}", f2);
        Console.WriteLine("-f1 = {0}", -f1);
        Console.WriteLine("f1 + f2 = {0}", f1 + f2);
        Console.WriteLine("f1 - f2 = {0}", f1 - f2);
        Console.WriteLine("f1 * f2 = {0}", f1 * f2);
        Console.WriteLine("f1 / f2 = {0}", f1 / f2);
        Console.WriteLine("f1 / f2 as double = {0}", (double)(f1 / f2));
        Console.WriteLine("-(f1+f2)*(f1-f2/f1) = {0}", -(f1 + f2) * (f1 - f2 / f1));
        Console.WriteLine("++f1 = {0}", ++f1);

        PrintLines("Static Members");
        Console.WriteLine(SqrtPrecalculated.GetSqrt(81));
        PrintLines("Structure");

        Square square = new Square(
             new Point() { X = 5, Y = -3 },
             7,
             new Color() { Redvalue = 73, Greenvalue = 158, Bluevalue = 76 },
             new Color() { Redvalue = 0, Greenvalue = 255, Bluevalue = 133 },
             Edges.Rounded
 );
        Console.WriteLine(square);






    }
  

    public static T Min<T>(T first, T second)
             where T : IComparable<T>
    {
        if (first.CompareTo(second) <= 0)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    public static void PrintLines(string name)
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------NEXT ONE IS BELOW---------------{0}-------------------",name);
        Console.WriteLine();
    }

    public static void PrintLines(int numberOfLines)
    {
        for (int i = 0; i < numberOfLines; i++)
        {
            Console.WriteLine();
        }
    }

    public static void EndProgram()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------Your Program End Here------------------------------------------------------");
        Console.WriteLine();
    }
}