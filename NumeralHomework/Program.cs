using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralHomework
{
    class Program
    {
        static void Main()
        {

            //01.Decimal to binary
            //long number = long.Parse(Console.ReadLine());
            //Console.WriteLine(NumberToBinary(number));

            //02.Binary to decimal
            //string number = Console.ReadLine();
            //Console.WriteLine(BinaryToDecimal(number));

            //03. Decimal to hexadecimal
            //long number = long.Parse(Console.ReadLine());
            //Console.WriteLine(DecimalToHex(number));

            //04. Hexadecimal to decimal
            //string number = Console.ReadLine().ToLower();
            //Console.WriteLine(HexToDec(number));

            //05. Hexadecimal to binary
            //string number = Console.ReadLine().ToLower();
            //Console.WriteLine(HexToBinary(number));

            //06. Binary to hexadecimal
            //string number = Console.ReadLine();
            //long decimalNumber = BinaryToDecimal(number);
            //Console.WriteLine(DecimalToHex(decimalNumber));

            //07.One system to any other
            // The numeral systems must be between 2 and 16.
            int firstNumeralSystem = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int secondNumeralSystem = int.Parse(Console.ReadLine());

            // Conversion from first numeral system to decimal number.
            long decNum = FirstToDecimal(firstNumeralSystem, n);
            // Convert from decimal number to second numeral system.
            string secondBaseNumber = DecimalToSecond(decNum, secondNumeralSystem);

            // Put string in char array. Print final result in reverse order.
            char[] result = secondBaseNumber.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);

            //08.Binary short/
            //long number = long.Parse(Console.ReadLine());
            //var sb = new StringBuilder();
            //sb.Append((NumberToBinary(number)));
            //Console.WriteLine(ConvertToBinaryShort(ref sb, number));



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

        private static string  ConvertToBinaryShort( ref StringBuilder sb,long number)
        {

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '-')
                {
                    sb.Remove(i, 1);
                }
            }
            while (sb.Length < 16 && number >= 0)
            {
                sb.Insert(0, 0);
            }

            while (sb.Length < 16 && number < 0)
            {
                sb.Insert(0, 1);
            }
            return sb.ToString();
        }

        public static string HexToBinary(string number)
        {
            var sb = new StringBuilder();
            long chislo = (long)HexToDec(number);
            sb.Append(NumberToBinary(chislo));
            return sb.ToString();
        }

        static decimal HexToDec(string hex)
        {
            decimal result = 0;
            hex = hex.ToLower();

            for (int i = 0; i < hex.Length; i++)
            {
                string valAt = hex[hex.Length - 1 - i].ToString();
                result += convertHexToDecimal[valAt] * (long)Math.Pow(16, i);
            }

            return result;
        }

        public static string DecimalToHex(long number)
        {

            var sb = new StringBuilder();
            do
            {
                long remainder = number % 16;
                number /= 16;
                sb.Insert(0, convertDecimalToHex[remainder]);
            }   while (number > 0);

            return sb.ToString();
        }

        public static long BinaryToDecimal(string number)
        {
            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[number.Length - i - 1] == '0')
                    continue;
                else
                    result += (long)(Math.Pow(2, i));
            }
            return result;
        }

        public static string NumberToBinary(long number)
        {
            var sb = new StringBuilder();
            while (number != 0)
            {
                long remainder = number % 2;
                sb.Insert(0, remainder);
                number /= 2;
            }
            return sb.ToString();
        }

        public static Dictionary<string, long> convertHexToDecimal = new Dictionary<string, long>{
        {  "0", 0   },
        {  "1", 1   },
        {  "2", 2   },
        {  "3", 3   },
        {  "4", 4   },
        {  "5", 5   },
        {  "6", 6   },
        {  "7", 7   },
        {  "8", 8   },
        {  "9", 9   },
        {  "a", 10  },
        {  "b", 11  },
        {  "c", 12  },
        {  "d", 13  },
        {  "e", 14  },
        {  "f", 15  },
      };
        public static Dictionary<long, string> convertDecimalToHex = new Dictionary<long, string>{
        {0 ,  "0"  },
        {1 ,  "1"  },
        {2 ,  "2"  },
        {3 ,  "3"  },
        {4 ,  "4"  },
        {5 ,  "5"  },
        {6 ,  "6"  },
        {7 ,  "7"  },
        {8 ,  "8"  },
        {9 ,  "9"  },
        {10,  "A"  },
        {11,  "B"  },
        {12,  "C"  },
        {13,  "D"  },
        {14,  "E"  },
        {15,  "F"  },
      };
    }
}
