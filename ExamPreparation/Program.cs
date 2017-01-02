using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
    public static Dictionary<string, int> alfabet = new Dictionary<string, int>
    {
        {  "CHU",0},
        {  "TEL",1},
        {  "OFT",2},
        {  "IVA",3},
        {  "EMY",4},
        {  "VNB",5},
        {  "POQ",6},
        {  "ERI",7},
        {  "CAD",8},
        {  "K-A",9},
        {  "IIA",10},
        {  "YLO",11},
        {  "PLA",12}
    };
    public static Dictionary<long, string> tresAlfabet = new Dictionary<long, string>
    {
        {0 ,"LON+"  },
        {1 ,"VK-"   },
        {2 ,"*ACAD"},
        {3 ,"^MIM"  },
        {4 ,"ERIK|"},
        {5 ,"SEY&" },
        {6 ,"EMY>>" },
        {7 ,"/TEL" },
        {8 ,"<<DON"}
 
    };
    static void Main()
    {

        //1.De-cat coding
        //var text = Console.ReadLine().Split(' ').ToList();
        //var input = TextTransfor(text);
        //Console.WriteLine(string.Join(" ", input));




        //1. Multiverse Communication
        //string text = Console.ReadLine();
        //Console.WriteLine(DecimalRepresentation(text));

        //1. TRES4 Numbers
        //ulong number = ulong.Parse(Console.ReadLine());
        //Console.WriteLine(PrintAsText(number));

        //1. StrangeLand Numbers
        //string input = Console.ReadLine();
        //Calculate(input);

        //Problem 1 – Calculation Problem
        //List<string> input = Console.ReadLine().Split(' ').ToList();
        //ulong total = CalculateSum(input);
        //string result = MakeNewWorld(total);
        //Console.WriteLine("{0} = {1}",result,total);
        

        //Problem 2 – Magic Words
        //int number = int.Parse(Console.ReadLine());
        // List <string> list = ReadInput(number);
        //Reorder
        //Reoder(list,number);
        //Print
        //Console.WriteLine(Print(list));

    }

    private static List<string> TextTransfor(List<string> text)
    {
        var sb = new StringBuilder();
        var print = new List<string>();

        foreach (var miniText in text)
        {
            long result = 0;
            for (int i = 0; i < miniText.Length; i++)
            {
                long currentChar = miniText[i] - 'a';
                int stepen = i;
                while (stepen < miniText.Length-1)
                {
                    currentChar *= 21;
                    stepen++;
                }
                result += currentChar;
            }
            while (result>0)
            {
                long ostatak = result % 26;
                char bukva = (char)(ostatak + 'a');
                sb.Insert(0, bukva);
                result /= 26;
            }
            print.Add(sb.ToString());
            sb.Clear();

        }
        return print;

    }

    private static string MakeNewWorld(ulong total)
    {

        var sb = new StringBuilder();
        while (total > 0)
        {
            ulong ostatak = total % 23;
            total /= 23;
            char letter = (char)(ostatak + 'a');
            sb.Append(letter);
        }
        List<char> reverse = new List<char>();
        foreach (var item in sb.ToString())
        {
            reverse.Add(item);
        }
        reverse.Reverse();
        sb.Clear();
        foreach (var word in reverse)
        {
            sb.Append(word);
        }
        return sb.ToString();
    }

    private static ulong CalculateSum(List<string> input)
    {
        ulong totalSum = 0;
        List<string> words = new List<string>();
        foreach (var duma in input)
        {
            words.Add(duma);
            for (int i = 0; i < duma.Length; i++)
            {
                int number = duma[i] - 'a';
                int counter = 0;
                while (counter < duma.Length - i - 1)
                {
                    number *= 23;
                    counter++;
                }
                totalSum += (ulong)number;
            }
        }
        return totalSum;
    }

    private static void Calculate(string input)
    {
        List<string> numbers = new List<string> { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
        var sb = new StringBuilder();
        ulong res = 0;
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(input[i]);
            if (numbers.Contains(sb.ToString()))
            {
                if (count == 0)
                {
                    res += (ulong)numbers.IndexOf(sb.ToString());
                }
                else
                {
                    int x = count;
                    while (x > 0)
                    {

                    }
                }

                sb.Clear();
            }
        }
        Console.WriteLine(res);
    }

    private static string PrintAsText(ulong number)
    {
        var sb = new StringBuilder();
        do
        {
            long ostatak = (long) number % 9;
            number /= 9;
            sb.Insert(0, tresAlfabet[ostatak]);
        } while (number>0);
        return sb.ToString();
    }

    private static string Print(List<string> list)
    {
        int maxLen = 0;
        foreach (var word in list)
        {
            maxLen = Math.Max(maxLen, word.Length);
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < maxLen; i++)
        {
            foreach (var word in list)
            {
                if (word.Length > i)
                {
                    result.Append(word[i]);
                }
            }
        }
        return result.ToString();
    }

    private static void Reoder(List<string> list,int number)
    {
        for (int i = 0; i < number; i++)
        {
            var word = list[i];
            var newIndex = word.Length % (number + 1);
            list.Insert(newIndex, word);
            if (newIndex < i)
            {
                list.RemoveAt(i + 1);
            }
            else
            {
                list.RemoveAt(i);
            }
        }
    }

    private static List<string> ReadInput(int number)
    {
        List<string> words = new List<string>();
        for (int i = 0; i < number; i++)
        {
            string word = Console.ReadLine();
            words.Add(word);
        }
        return words;
    }

    private static long DecimalRepresentation(string text)
    {
        long number = 0;
        var sb = new StringBuilder();
        for (int i = 0; i < text.Length; i += 3)
        {
            sb.Append(text[i]);
            sb.Append(text[i + 1]);
            sb.Append(text[i + 2]);
            number *= 13;
            long res = alfabet[sb.ToString()];
            number += res;
            sb.Clear();
        }
        
        
        


        return number;
    }
}

