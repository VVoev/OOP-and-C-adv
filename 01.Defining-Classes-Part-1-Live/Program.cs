using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Cofee normalCofee = new Cofee(CoffeeSize.Normal);
        Cofee doubleCofee = new Cofee(CoffeeSize.Double);

        Console.WriteLine("The {0} coffee is {1} ml.",
              normalCofee.Size, (int)normalCofee.Size);
        Console.WriteLine("The {0} coffee is {1} ml.",
              doubleCofee.Size, (int)doubleCofee.Size);
        PrintLines();

        Console.WriteLine(Constants.PI);
        Constants c = new Constants(5);
        Console.WriteLine(c.Size);
        //c.Size = 10; // Compilation error: readonly field
        //Console.WriteLine(Constants.Size); // compile error
        PrintLines();

        Person anonymous = new Person();
        Console.WriteLine("Person 1: name: {0}, age: {1}",anonymous.Name ?? "[unnamed]", anonymous.Age);
        Person peter = new Person("Peter", 19);
        Console.WriteLine("Person 2: name: {0}, age: {1}",peter.Name, peter.Age);
        PrintLines(1);

        AlarmClock defaultAlarm = new AlarmClock();
        Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock.",defaultAlarm.Hours, defaultAlarm.Minutes);
        AlarmClock earlyAlarm = new AlarmClock(5, 15);
        Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock.", earlyAlarm.Hours, earlyAlarm.Minutes);
        PrintLines(1);

        Point centrePoint = new Point();
        centrePoint.Name = "Center of the coordinate system";
        Console.WriteLine("First point: ({0},{1}) has name '{2}'", centrePoint.XCord, centrePoint.Ycord, centrePoint.Name);
        Point point77 = new Point(7, 7);
        Console.WriteLine("First point: ({0},{1}) has name '{2}'", point77.XCord, point77.Ycord, point77.Name);
        PrintLines(1);
        PrintLines();

        Rectangle firstRect = new Rectangle(5.5f, 2.3f);
        Console.WriteLine("Rectangle is {0}x{1} and has area of {2}",firstRect.Width,firstRect.Height,firstRect.Area);
        Rectangle secondRect2 = new Rectangle(3.0f, 4.0f);
        Console.WriteLine("Rectangle 2 is {0}x{1} and has area {2}",secondRect2.Height, secondRect2.Width, secondRect2.Area);
        PrintLines(1);

        UserProfile profile = new UserProfile(91112, "Steven", "King");
        Console.WriteLine(profile);
        PrintLines();

        Console.WriteLine("Enter firstdog Name: ");
        string dogName = "Sharo";
        Console.WriteLine("Enter firstdog Breed: ");
        string dogBreed = "Shokolad";
        Dog firstDog = new Dog(dogName, dogBreed);

        Dog secondDog = new Dog();
        Console.WriteLine("Enter second dog's name: ");
        secondDog.Name = "Mimi";
        Console.WriteLine("Enter second dog's breed: ");
        secondDog.Breed = "Pokemonska Prevazhodna";

        Dog thirdDog = new Dog();
        // Save the dogs in an array
        Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
        // Ask each of the dogs to bark
        foreach (Dog dog in dogs)
            dog.SayBau();
        PrintLines();

        Hour hour = Hour.Five;
        Console.WriteLine(hour);
        hour--;
        Console.WriteLine(hour);
        hour = (Hour)Enum.Parse(typeof(Hour), "Three");
        Console.WriteLine(hour); // Three
        PrintLines();

        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());

        try
        {
            Human human = new Human(name, age);
            Console.WriteLine("Hello, {0}!", human.Name);
            Console.WriteLine("Your age is {0}.", human.Age);
        }
        catch (Exception ex)
        {

            Console.WriteLine("Cannot create human object: " + ex);
        }
        PrintLines();

        Dot p1 = new Dot(2, 3);
        Dot p2 = new Dot(4, 7);
        Console.WriteLine($@"The first dot is in {p1}");
        Console.WriteLine($@"The second dot is in {p2}");
        Console.WriteLine($@"The distance between P1 and P2 is  {p1.CalculateDistance(p2)}");




        EndProgram();

        
    }

    public static void PrintLines()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------NEXT ONE IS BELOW----------------------------------------------------------");
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
