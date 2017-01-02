using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
    private const int MinCapitalLetters = 2;
    private const int MinSmallLetters = 2;
    private const int MinDigits = 1;
    private const int MinSpecialChars = 3;
    private const int MaxPasswordLength = 15;
    private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string Digits = "0123456789";
    private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
    private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;
    private static readonly Random rnd = new Random();

    static void Main()
        {
        Day day = Day.Monday;
        Console.WriteLine(day);

        // This will not compile
        //Day first = 1;

        Day nextDay = day + 1;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(nextDay);

        Day thirdDay = (Day)3;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(thirdDay);

        string sundayStr = "Sunday";
        Day sunday = (Day)Enum.Parse(typeof(Day), sundayStr);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(sunday);

        Console.ResetColor();
        Console.WriteLine("------------------------------------------------------------------------------------------------");

        DateTime halloween = new DateTime(2011, 10, 31);
            Console.WriteLine(halloween);

            DateTime julyMorning = new DateTime(2011, 7, 1, 5, 52, 0);
            Console.WriteLine(julyMorning);

            DateTime dayAfterHalloween = halloween.AddDays(1);
            DateTime dayAfterJulyMorning = julyMorning.AddDays(1);
            Console.WriteLine($@"One day after haloween is {dayAfterHalloween}");
            Console.WriteLine($@"One day after July Morning is {dayAfterJulyMorning}");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

        String sampleLower = new String('a', 5);
        String sampleUpper = sampleLower.ToUpper();

        Console.WriteLine(sampleLower); // aaaaa
        Console.WriteLine(sampleUpper); // AAAAA

        DateTime now = DateTime.Now;
        DateTime later = now.AddHours(8);

        Console.WriteLine("Now: {0}", now);
        Console.WriteLine("8 hours later: {0}", later);

        Console.WriteLine("------------------------------------------------------------------------------------------------");

       

        StringBuilder password = new StringBuilder();
        for (int i = 1; i <= MinCapitalLetters; i++)
        {
            char capitalLetter = GenerateChar(CapitalLetters);
            InsertAtRandomPosition(password, capitalLetter);
        }
        for (int i = 1; i <= MinSmallLetters; i++)
        {
            char smallLetter = GenerateChar(SmallLetters);
            InsertAtRandomPosition(password, smallLetter);
        }
        for (int i = 1; i <= MinDigits; i++)
        {
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);
        }
        for (int i = 1; i <= MinSpecialChars; i++)
        {
            char specialChar = GenerateChar(SpecialChars);
            InsertAtRandomPosition(password, specialChar);
        }
        int maxAdditionalChars = MaxPasswordLength - password.Length;
        int additionalCharsCount = rnd.Next(maxAdditionalChars + 1);
        for (int i = 1; i <= additionalCharsCount; i++)
        {
            char specialChar = GenerateChar(AllChars);
            InsertAtRandomPosition(password, specialChar);
        }
        Console.WriteLine(password);

        Console.WriteLine("------------------------------------------------------------------------------------------------");

        DateTime christmas = new DateTime(2011, 12, 25);

        int den = christmas.Day;
        int month = christmas.Month;
        int year = christmas.Year;
        Console.WriteLine(
            "Christmas day: {0}, month: {1}, year: {2}", den, month, year);

        Console.WriteLine("Day of year: {0}", christmas.DayOfYear);

        Console.WriteLine(
            "Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));

        DateTime asd = new DateTime(day: 15, month: 1, year: 2015);
        Console.WriteLine(asd);

        Console.WriteLine("------------------------------------------------------------------------------------------------");


        // This random generator is initialized with random seed
        Random randomGenerator = new Random();
        Console.WriteLine(randomGenerator.Next());

        // This random generator is initialized with the same seed
        // bacause is initialized in the same moment in the time
        Random anotherRandomGenerator = new Random();

        // This will print the same value
        Console.WriteLine(anotherRandomGenerator.Next());

        // This random generator has fixed initial seed
        Random randomGenerator1 = new Random(123);
        Console.WriteLine(randomGenerator1.Next());

        // This random generator has fixed initial seed
        Random randomGenerator2 = new Random(456);
        Console.WriteLine(randomGenerator2.Next(50));
        Console.WriteLine("------------------------------------------------------------------------------------------------");

        double radius = 2.9;
        Console.WriteLine("Circle radius: {0}", radius);
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Circle area: {0}", area);
        Console.WriteLine();

        double precise = 8.7654321;
        double round3 = Math.Round(precise, 3);
        double round1 = Math.Round(precise, 1);
        Console.WriteLine("Precise: {0}", precise);
        Console.WriteLine("Rounded to 0.1: {0}", round1);
        Console.WriteLine("Rounded to 0.001: {0}", round3);









    }
    private static void InsertAtRandomPosition(StringBuilder password, char character)
    {
        int randomPosition = rnd.Next(password.Length + 1);
        password.Insert(randomPosition, character);
    }

    private static char GenerateChar(string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        return randomChar;
    }
}
