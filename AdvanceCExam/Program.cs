using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static Dictionary<string, long> alfabet = new Dictionary<string, long>{
        {  "ocaml", 0   },
        {  "haskell", 1   },
        {  "scala", 2   },
        {  "f#", 3   },
        {  "lisp", 4   },
        {  "rust", 5   },
        {  "ml", 6   },
        {  "clojure", 7   },
        {  "erlang", 8   },
        {  "standardml", 9   },
        {  "racket", 10  },
        {  "elm", 11  },
        {  "mercury", 12  },
        {  "commonlisp", 13  },
        {  "scheme", 14  },
        {  "curry", 15  },
      };
    static void Main()
    {


        var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var hint = new string[]
{
    "200", "303", "315", "52", "301", "241", "302", "321", "52", "244", "253", "251",
    "253", "312", "311", "52", "244", "303", "245", "311", "52", "312", "252", "253",
    "311", "52", "302", "313", "301", "245", "310", "241", "300", "52", "311", "321",
    "311", "312", "245", "301", "52", "252", "241", "314", "245", "143", "52", "201",
    "311", "52", "312", "252", "245", "310", "245", "52", "241", "302", "52", "241",
    "304", "304", "310", "303", "304", "310", "253", "241", "312", "245", "52", "242",
    "313", "253", "300", "312", "113", "253", "302", "52", "250", "313", "302", "243",
    "312", "253", "303", "302", "241", "300", "253", "312", "321", "143", "21", "14",
    "215", "312", "310", "253", "302", "251", "114", "214", "245", "304", "300", "241",
    "243", "245", "52", "243", "241", "302", "52", "311", "253","301", "304", "300",
    "253", "250", "321", "52", "312", "252", "253", "302", "251", "311", "52", "241",
    "52", "300", "303", "312", "112", "52", "254", "313", "311", "312", "52", "242",
    "245", "52", "243", "241", "310", "245", "250", "313", "300", "52", "253", "302",
    "52", "315", "252", "241", "312", "52", "303", "310","244", "245", "310", "52",
    "321", "303", "313", "52", "310", "245", "304", "300", "241", "243", "245", "21",
    "14", "220", "252", "253", "302", "255", "52", "241", "242", "303", "313", "312",
    "52", "312", "252", "245", "52", "244", "241", "312", "241", "52", "312", "321",
    "304", "245", "311", "52", "303", "250", "52", "312", "252", "245", "52", "312",
    "252", "310", "245", "245", "52", "302", "313", "301", "242", "245", "310", "311",
    "52", "241", "302", "244", "52", "312", "252", "245", "52", "310", "245", "311",
    "313", "300", "312", "52", "113", "52", "252", "303", "315", "52", "301", "313",
    "243", "252", "52", "253", "311", "52", "122", "234", "130", "120", "52", "110",
    "52", "122", "234", "130", "120", "52", "110", "52", "122", "234", "130", "120", "143"
};
        var Bonus = new List<char>();
        int firstNumeralSystem = 6;
        int secondNumeralSystem = 10;
        var magic = new string[3];
        foreach (var item in hint)
        {
            string n = item;
            long decNum = FirstToDecimal(firstNumeralSystem, n);
            string secondBaseNumber = DecimalToSecond(decNum, secondNumeralSystem);
            char[] result = secondBaseNumber.ToCharArray();
            //Array.Reverse(result);
            //Console.WriteLine(result);
            Bonus.Add((char)decNum);
        }

        foreach (var item in Bonus)
        {
      //      Console.Write(item);
        }
        // Console.WriteLine();
        //rust, standardml, haskellscala 	
        //5,9, 12
        //rust, elm, haskellscala
        //990
        //5 11 12
        //5 11 21
        //Console.WriteLine(5*6*6);
       // Console.WriteLine(9*6);
       // Console.WriteLine(1*6);
       // Console.WriteLine(2);
        long total = 1;
        long number = 0;
        int counter = 0;

        var sb1 = new StringBuilder();
        foreach (var item in input)
        {
            string chislo = "";
            var sb = new StringBuilder();
            for (int i = 0; i < item.Length; i++)
            {

                sb.Append(item[i]);
                if (alfabet.ContainsKey(sb.ToString()))
                {
                    chislo += alfabet[sb.ToString()];
                    number = alfabet[sb.ToString()];

                    //Console.WriteLine(sb+"="+number);
                    total *= number;
                    sb.Clear();
                }
            }

            magic[counter] = chislo;
            counter++;
        }
        //Console.WriteLine(total);
        long smqx = 1;
        int mnogosmqx = 0;
        foreach (var item in magic)
        {
            smqx *= long.Parse(item);
            mnogosmqx++;
        }
        long res = FirstToDecimal(6, "810");
        //Console.WriteLine(res);
        //Console.WriteLine(sb1.ToString());



        // Conversion from first numeral system to decimal number.

        // Convert from decimal number to second numeral system.


        // Put string in char array. Print final result in reverse order.





        GiveMeHint(hint);
    }
    static long FirstToDecimal(int firstNumeralSystem, string n)
    {
        long decNum = 0;
        int index = 0;
        long baseCount = 1;
        int currentDigit = 0;
        while (index < n.Length)
        {
            if (char.IsDigit(n[n.Length - 1 - index]))
            {
                currentDigit = n[n.Length - 1 - index] - '0';
            }
            else
            {
                currentDigit = n[n.Length - 1 - index] - '7';
            }
            decNum += (long)(currentDigit * baseCount);
            baseCount *= firstNumeralSystem;
            index++;
        }

        return decNum;
    }

    static string DecimalToSecond(long firstBaseNumber, int step)
    {
        string secondBase = "";
        string[] hexa = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        while (firstBaseNumber > 0)
        {
            int digit = (int)(firstBaseNumber % step);
            firstBaseNumber /= step;
            secondBase += hexa[digit];
        }
        return secondBase;
    }
   
    private static void GiveMeHint(string[] hint)
    {
        long number = 0;
        foreach (var item in hint)
        {
            int couter = item.Length;
            for (int i = 0; i < item.Length; i++)
            {
                while (couter > i)
                {
                    number += item[i] * 10;
                    couter--;
                }
            }
        }
    }
}
