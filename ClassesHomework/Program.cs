using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
    {
        /*
        01.Leap year
        int year = int.Parse(Console.ReadLine());
        CheckIsLeapOrCommon(year);
        */

        /*
        04. Triangle surface by side and altitude
        Triangle triangle = ReadTriangleTwoSides();
        Console.WriteLine("{0:f2}",triangle.Area);
        */

        /*
        05.Triangle surface by three sides
        Triangle triangle = ReadTriangleThreeSides();
        Console.WriteLine("{0:f2}",triangle.AreaWithThreeSides);
        */

        /*
        06. Triangle surface by two sides and an angle       
        Triangle triangle = ReadTwoSidesAndAngle();
        Console.WriteLine("{0:f2}",triangle.SurfaceWithTwoSidesAndAngle);
        */

        /*
         08. Sum integers
         */
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(MakeCalculations(input));

    }

    private static long MakeCalculations(int[] inputs)
    {
        long sum = 0;
        foreach (var input in inputs)
        {
            sum += input;
        }
        return sum;
    }

    private static Triangle ReadTwoSidesAndAngle()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        Triangle side = new Triangle(first, second, angle);
        return side;
    }

    private static Triangle ReadTriangleThreeSides()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());
        Triangle side = new Triangle() { triangleSideA = sideA, triangleSideB = sideB, triangleSideC = sideC };
        return side;
    }

    private static Triangle ReadTriangleTwoSides()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        Triangle side = new Triangle(){ triangleSideA = sideA, triangleSideB = sideB};
        return side;
    }

    private static void CheckIsLeapOrCommon(int year)
    {
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine(isLeap ? "Leap" : "Common");
    }
}

public class Triangle
{
    private double first;
    private double second;
    private double angle;

    public Triangle(double first, double second, double angle)
    {
        this.first = first;
        this.second = second;
        this.angle = angle;
    }
    public Triangle()
    {

    }

    public double triangleSideA { get; set; }
        public double triangleSideB { get; set; }
        public double triangleSideC { get; set; }

    public double AreaWithTwoSides
    {
        get
        {
            return triangleSideA * triangleSideB / 2;
        }
    }
    public double AreaWithThreeSides
    {
        get
        {
            return Math.Sqrt(Perimeter *
                            (Perimeter - triangleSideA) *
                            (Perimeter - triangleSideB) *
                            (Perimeter - triangleSideC));
        }
    }
    public double SurfaceWithTwoSidesAndAngle
    {
        get
        {
            return  (first* second * Math.Sin(Math.PI * angle / 180)) / 2;
        }
    }
    public double Perimeter
    {
        get
        {
            return (triangleSideA + triangleSideB+triangleSideC) / 2;
        }
    }




}