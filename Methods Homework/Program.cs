using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MethodsLive
    {
    static void Main()
    {
        PrintLogo();
        PrintSign(4);
        PrintMax(10, 20);
        PrintMax(10, 5);
        for (int i = 1; i <= 12; i++)
        {
            SayMonth(i);
            Console.WriteLine();
        }
        int n = 5;
        for (int line = 1; line <= n; line++)
            PrintLine(1, line);
        for (int line = n - 1; line >= 1; line--)
            PrintLine(1, line);

        PrintNumbers(10, 20);
        Console.WriteLine(Multiply(5,10));
        Console.WriteLine(FahrenheitToCelsius(104));
        int[] arr = new int[] { 5, 10, 20 };
        var suma = CalcSum(arr);
        var iStrue = ArePositive(arr);
        Console.WriteLine(iStrue);
        Console.WriteLine("Sumata e "+suma);
        Console.WriteLine("What time is it?");

        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Minutes: ");
        int minutes = int.Parse(Console.ReadLine());
        bool isValidTime = ValidateHours(hours) &&
                      ValidateMinutes(minutes);

        if (isValidTime)
            Console.WriteLine("It is {0}:{1}", hours, minutes);
        else
            Console.WriteLine("Incorrect time!");

        Print(13);
        Print("IVAN");
        Print("IVAN", 13);
    }
    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (int element in elements)
            sum += element;
        return sum;
    }
    static void Print(string text)
    {
        Console.WriteLine(text);
    }

    static void Print(int number)
    {
        Console.WriteLine(number);
    }

    static void Print(string text, int number)
    {
        Console.WriteLine(text + ' ' + number);
    }
    static bool ValidateMinutes(int minutes)
    {
        bool result = (minutes >= 0) && (minutes <= 59);
        return result;
    }
    static bool ValidateHours(int hours)
    {
        bool result = (hours >= 0) && (hours <= 24);
        return result;
    }
    static bool ArePositive(int[] sequence)
    {
        foreach (int number in sequence)
        {
            if (number <= 0)
            {
                return false;
            }
        }
        return true;
    }
    static double FahrenheitToCelsius(double degrees)
    {
        double celsius = (degrees - 32) * 5 / 9;
        return celsius;
    }


    static int Multiply(int firstNum, int secondNum)
    {
        return firstNum * secondNum;
    }
    static void PrintNumbers(int start,int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(" {0}", i);
        }
        Console.WriteLine();
    }
    static void PrintLogo() // PrintLogo is the method's name
    {
        Console.WriteLine("Telerik Corp.");
        Console.WriteLine("www.telerik.com");
    }
    static void PrintSign(int number)
    {
        if (number > 0)
        { Console.WriteLine("Positive"); }
        else if (number < 0)
        { Console.WriteLine("Negative"); }
        else
        { Console.WriteLine("Zero"); }
    }
    static void PrintMax(float number1, float number2)
    {
        Console.WriteLine((number1 > number2) ? "Number1 is bigger" : "Number2 is bigger");
    }
    static void SayMonth(int month)
    {
        string[] monthNames = new string[] {
        "January", "February", "March",
        "April", "May", "June", "July",
        "August", "September", "October",
        "November", "December" };

        Console.Write(monthNames[month - 1]);
    }
}


