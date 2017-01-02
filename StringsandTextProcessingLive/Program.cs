using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
class Program
    {
        static void Main()
        {
        string fileName = @"C:\Pics\Rila2005.jpg";
        Console.WriteLine("Full file name: {0}", fileName);

        string pathOnly = ExtractPath(fileName);
        Console.WriteLine("Path: {0}", pathOnly);

        string fileNameOnly = ExtractFileName(fileName);
        Console.WriteLine("File name only: {0}", fileNameOnly);

        string extension = ExtractExtension(fileName);
        Console.WriteLine("File extenson: {0}", extension);

        Console.WriteLine("----------------------------------------------------------------------------------------------------");

        string[] towns = {"Sofia", "Varna", "Plovdiv",
                          "Pleven", "Bourgas", "Rousse", "Stara Zagora",
                          "Veliko Tarnovo", "Yambol", "Sliven"};
        string firstTown = towns[0];
        for (int i = 1; i < towns.Length; i++)
        {
            string currentTown = towns[i];
            if (String.Compare(currentTown, firstTown) < 0)
            {
                firstTown = currentTown;
            }
        }
        Console.WriteLine("First town: {0}", firstTown);

        Console.WriteLine("----------------------------------------------------------------------------------------------------");

        string s = "Stand up, stand up, Balkan superman.";
        Console.WriteLine("s = \"{0}\"", s);
        Console.WriteLine("s.Length = {0}", s.Length);
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("s[{0}] = {1}", i, s[i]);
        }

        foreach (var ch in s)
        {
            Console.Write(ch);
        }
        Console.WriteLine();


        Console.WriteLine("----------------------------------------------------------------------------------------------------");

        Console.Write("The current culture is: ");
        Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture);

        int number = 42;
        s = number.ToString("D5"); // 00042
        Console.WriteLine(s);

        s = number.ToString("X"); // 2A
        Console.WriteLine(s);

        s = number.ToString("x4"); // 002a
        Console.WriteLine(s);

        // Chenge the default culture to Bulgarian
        System.Threading.Thread.CurrentThread.CurrentCulture =
            new CultureInfo("bg-BG");
        Console.WriteLine("Bulgarian price: {0:C}", number); // 42,00 ëâ.

        // Print the currency as Canadian dollars
        CultureInfo culture = new CultureInfo("fr-CA");
        s = number.ToString("C", culture); // 42,00 $
        Console.WriteLine("Price for Canada: " + s);

        double d = 0.375;
        s = d.ToString("F2"); // 0,38
        Console.WriteLine(s);

        s = d.ToString("F10"); // 0,3750000000
        Console.WriteLine(s);

        s = d.ToString("P2"); // 37,50 %
        Console.WriteLine(s);

        string template = "If I were {0}, I would {1}.";
        string sentence1 = String.Format(
            template, "developer", "know C#");
        Console.WriteLine(sentence1);
        // If I were developer, I would know C#.

        string sentence2 = String.Format(
            template, "elephant", "weigh 4500 kg");
        Console.WriteLine(sentence2);
        // If I were elephant, I would weigh 4500 kg.

        s = String.Format("{0,10:D}", number); // "        42"
        Console.WriteLine(s);

        s = String.Format("{0,10:F5}", d); // "   0,37500"
        Console.WriteLine(s);

        Console.WriteLine("Dec {0:D} = Hex {1:X}", number, number);
        // "Dec 42 = Hex 2A"

        DateTime now = DateTime.Now;
        Console.WriteLine("Now is {0:d.MM.yyyy HH:mm:ss}.", now);
        // Now is 31.03.2006 08:30:32

        // Print the date and time in English (Canada)
        System.Threading.Thread.CurrentThread.CurrentCulture =
            new CultureInfo("en-CA");
        Console.WriteLine(now.ToString("dddd, MMMM dd, yyyy h:mm:ss tt"));

        // Print the date and time in Russian (Russia)
        System.Threading.Thread.CurrentThread.CurrentCulture =
            new CultureInfo("ru-RU");
        Console.WriteLine(now.ToString("dd MMMM yyyy (dddd), H:mm:ss"));

        Console.WriteLine(1.25); // 1.25 -> the separator will be "," (Russia)

        System.Threading.Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;
        Console.WriteLine(1.25); // 1.25 -> the separator will be "." (Invariant)

        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        // String.Replace() example
        string cocktail = "Vodka + Martini + Cherry";
        string replaced = cocktail.Replace("+", "and");
        Console.WriteLine(replaced);

        // String.Remove() example
        string price = "$ 1234567";
        string lowPrice = price.Remove(2, 3);
        Console.WriteLine(lowPrice);

        // Uppercase and lowercase conversion examples
        string alpha = "aBcDeFg";
        string lowerAlpha = alpha.ToLower();
        Console.WriteLine(lowerAlpha);
        string upperAlpha = alpha.ToUpper();
        Console.WriteLine(upperAlpha);

        // Trim() example
         s = "  example of white space ";
        string clean = s.Trim();
        Console.WriteLine(clean);

        // Trim(chars) example
        s = " \t\nHello!!! \n";
        clean = s.Trim(' ', ',', '!', '\n', '\t');
        Console.WriteLine(clean);

        // TrimStart() example
        s = "   C#   ";
        clean = s.TrimStart();
        Console.WriteLine(clean);

        // TrimEnd() example
        s = "   C#   ";
        clean = s.TrimEnd();
        Console.WriteLine(clean);

        Console.WriteLine("---------------------------------------------------------------------");
        string str = "C# Programming Course";

        int index = str.IndexOf("C#"); // index = 0
        Console.WriteLine(index);

        index = str.IndexOf("Course"); // index = 15
        Console.WriteLine(index);

        // IndexOf is case-sensetive. -1 means not found
        index = str.IndexOf("COURSE"); // index = -1
        Console.WriteLine(index);

        // Case-insensitive IndexOf
        index = str.ToLower().IndexOf("COURSE".ToLower()); // 18

        index = str.IndexOf("ram"); // index = 7
        Console.WriteLine(index);

        index = str.IndexOf("r"); // index = 4
        Console.WriteLine(index);

        index = str.IndexOf("r", 5); // index = 7
        Console.WriteLine(index);

        index = str.IndexOf("r", 8); // index = 18
        Console.WriteLine(index);

        Console.WriteLine("----------------------------------------------");

        DateTime startTime = DateTime.Now;
        Console.WriteLine("Concatenation 50 000 chars...");
        DupChar('a', 50000);
        DateTime endTime = DateTime.Now;
        Console.WriteLine("... done in {0} seconds", endTime - startTime);

        //startTime = DateTime.Now;
        //Console.WriteLine("Concatenation 200 000 chars...");
        //DupChar('a', 200000);
        //endTime = DateTime.Now;
        //Console.WriteLine("... done in {0} seconds", endTime - startTime);

        startTime = DateTime.Now;
        Console.WriteLine("Concatenation 5 000 000 chars...");
        var sb = new StringBuilder();
        FillStringBulder('a',5000000,sb);
        endTime = DateTime.Now;
        Console.WriteLine("... done in {0} seconds", endTime - startTime);


        Console.WriteLine("----------------------------------------------------");

        string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
        string[] beers = listOfBeers.Split(' ', ',', '.');
        //string[] beers = listOfBeers.Split(
        //    new char[] {' ', ',', '.'}, 
        //    StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Available beers are:");
        foreach (string beer in beers)
        {
            // Two sequential separators in the input cause
            // presence of empty element in the result
            if (beer != "")
            {
                Console.WriteLine(beer);
            }
        }

    }

    private static StringBuilder FillStringBulder(char v1, int v2,StringBuilder sb)
    {
        for (int i = 0; i < v2; i++)
        {
            sb.Append(v1);
        }
        return sb;
    }

    public static string DupChar(char ch, int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += ch;
        }
        return result;
    }

    static string ExtractExtension(string fileName)
    {
        string extension = "";
        int dotIndex = fileName.LastIndexOf('.');
        if (dotIndex != -1)
        {
            extension = fileName.Substring(dotIndex + 1);
        }
        return extension;
    }

    static string ExtractFileName(string path)
    {
        char dirSlash = Path.PathSeparator;
        int slashIndex = path.LastIndexOf(dirSlash);
        string fileName = path.Substring(slashIndex + 1);
        return fileName;
    }

    static string ExtractPath(string fullFileName)
    {
        char dirSlash = Path.DirectorySeparatorChar;
        int slashIndex = fullFileName.LastIndexOf(dirSlash);
        string path = "";
        if (slashIndex != -1)
        {
            path = fullFileName.Substring(0, slashIndex);
        }
        return path;
    }
}