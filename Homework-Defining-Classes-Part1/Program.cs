
using Homework_Defining_Classes_Part1.mobileDevice.CallTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Defining_Classes_Part1.NewLines;
using Homework_Defining_Classes_Part1.ZooProject;

namespace Homework_Defining_Classes_Part1

{
    class Program
    {
        static void Main(string[] args)
        {
            
            //add single GSM
            Battery nmh = new Battery("Triple AAA", 8, 3, BatteryType.Alkaline);
            Display largeDisplay = new Display(5.3, 1600000);
            Gsm mygsm = new Gsm("G3", "LG", 500m, "Vlado Voev", nmh, largeDisplay);
            List<Call> mycalls = new List<Call>();
            

            //add firstCall
            Call currentCallForToday = new Call(DateTime.Now.AddHours(15.23), "23293829", 58);
            mygsm.AddCall(currentCallForToday);
            mycalls.Add(currentCallForToday);

            //add secondCall
            currentCallForToday = new Call(DateTime.Now.AddMonths(1), "35998585454", 123);
            mygsm.AddCall(currentCallForToday);
            mycalls.Add(currentCallForToday);

            //add LastCall
            currentCallForToday = new Call(DateTime.Now.AddMonths(1), "359988803737", 600);
            mygsm.AddCall(currentCallForToday);
            mycalls.Add(currentCallForToday);

            Console.WriteLine("CallHistory Information");
            foreach (var call in mycalls)
            {
                Console.WriteLine($@"Date:{call.DateOfCall}");
                Console.WriteLine($@"Phone Number:{call.CallerCellPhone}");
                Console.WriteLine($@"Duration of phone Call:{call.CallDuration}");
                Console.WriteLine("------------------------------------------------------------------");
            }

            // Display my phone information.
            Console.WriteLine("My mobile phone characteristics:");
            Console.WriteLine(mygsm.ToString());

            Console.WriteLine("-----------------------");
            Console.WriteLine("Statistics");
            // Get total duration of calls and calculate total price. Price per minute is set in class GSM to be 0.25 lv.
            int totalDuration = mygsm.CalculateTotalDuration();
            Console.WriteLine("Total Price: " + mygsm.CalculateTotalPrice(totalDuration) + " leva.");

            // Get longest duration of call.
            Console.WriteLine("The longest duration: " + mygsm.MaxDuration() + " seconds.");
            int maxDuration = mygsm.MaxDuration();
            int longestDurationIndex = mygsm.FindIndexOfLongestDuration(maxDuration);
            mygsm.DeleteCallAtIndex(longestDurationIndex);

            totalDuration = mygsm.CalculateTotalDuration();
            Console.WriteLine("Total Price after removing longest call: " + mygsm.CalculateTotalPrice(totalDuration) + " leva.");

            mygsm.ClearAllCalls();
            if (mygsm.CallsCount == 0)
            {
                Console.WriteLine("Your calls have been deleted successfully.");
            }
            NewLine.NewLinez("School");

            //School bestSchool = new School();
            //List<Discipline>disciplines = new List<Discipline>();
            //Teacher mathTeacher = new Teacher("Petar Stoqnov", disciplines);
            //disciplines.Add(new Discipline("Matematika", 4, 4));
            //disciplines.Add(new Discipline("Fizika", 2,2));
            //disciplines.Add(new Discipline("Ximiq", 3,3));

            //string studentName = Console.ReadLine();
            //Student petar = new Student("Petar", 23);
            //bestSchool.Students.Add(petar);

            NewLine.NewLinez("Library Project");
            var libraryName = "Best Bulgarian Library";
            var bestSeller = new List<Book>();
            var nationalLibrary = new Library(libraryName, bestSeller);
            DateTime dateOfPublishing = new DateTime(2000, 12, 05);

            //Create some books
            var firstBook = new Book("Charlie Angels", "Steven Min", "Ciela", dateOfPublishing, "597845643");
            var secondBook = new Book("The Catedral", "CunKai", "Bard", new DateTime(2005,4,4), "4123146");
            var thirdBook = new Book("Code Better", "Vlado", "Vlado", new DateTime(1999,8,8), "484416");
            var fourhtBook = new Book("LifeIshard", "Can be harder", "Llifetime", new DateTime(1998, 4, 4), "59874");

            //add Books in current test Library
            nationalLibrary.AddBook(firstBook);
            nationalLibrary.AddBook(secondBook);
            nationalLibrary.AddBook(thirdBook);

            
            // Print all books in current library.
            Console.WriteLine("Books in " + nationalLibrary.LibraryName);
            Console.WriteLine(string.Join(Environment.NewLine, nationalLibrary.BookStore));

            // Sort book by author name and clear them from current library.
            var sortedBooks = nationalLibrary.SearchBookByAuthor("Vlado");
            foreach (Book book in sortedBooks)
            {
                nationalLibrary.DeleteBook(book);
            }

            // Print all stayed books in library.
            Console.WriteLine("Current books left in " + nationalLibrary.LibraryName);
            Console.WriteLine(string.Join(Environment.NewLine, nationalLibrary.BookStore));

            NewLine.NewLinez("School Project");

            NewLine.NewLinez("Zoo Project");
            ZooTest.TestPets();











        }
    }
}
