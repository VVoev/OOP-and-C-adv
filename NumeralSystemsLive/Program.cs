namespace BinaryToDecimalAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static StringBuilder builder = new StringBuilder();

        static void Main(string[] args)
        {
            var number = 500;

            var numberInBinaryDOTNET = DecimalToBinaryDOTNET(number);
            var numberInBinaryCUSTOM = DecimalToBinary(number);

            var numberInDecimalDOTNET = BinaryToDecimalDOTNET(numberInBinaryDOTNET);
            var numberInDecimalCUSTOM = BinaryToDecimal(numberInBinaryCUSTOM);

            Console.WriteLine($"Original number in Decimal System: {number}");

            Console.WriteLine();
            Console.WriteLine($"Decimal to Binary (.NET Implementation): {numberInBinaryDOTNET}");
            Console.WriteLine($"Decimal to Binary (Custom Implementation): {numberInBinaryCUSTOM}");

            Console.WriteLine();
            Console.WriteLine($"Binary to Decimal (.NET Implementation): {numberInDecimalDOTNET}");
            Console.WriteLine($"Binary to Decimal (Custom Implementation): {numberInDecimalCUSTOM}");

            var timeWithDotNetImplementation = Benchmark(DecimalToBinaryDOTNET);
            var timeWithCustomImplementation = Benchmark(DecimalToBinary);
            Console.WriteLine();
            Console.WriteLine($"Time with .NET Implementation: {timeWithDotNetImplementation.ToString()}");
            Console.WriteLine($"Time with Custom Implementation: {timeWithCustomImplementation.ToString()}");

            var numberInHex = "1F4";
            var numberInBinary = HexadecimalToBinary(numberInHex);

            Console.WriteLine($"Original number: {numberInHex}");

            Console.WriteLine($"Hex to binary: {HexadecimalToBinary(numberInHex)}");
            Console.WriteLine($"Hex to binary (.NET): {HexadecimalToBinaryDOTNET(numberInHex)}");

            Console.WriteLine($"Binary to hex: {BinaryToHexadecimal(numberInBinary)}");
            Console.WriteLine($"Binary to hex (.NET): {BinaryToHexadecimalDOTNET(numberInBinary)}");
        }
        public static string HexadecimalToBinary(string number)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                var key = number[i];
                var value = HexBinaryTable[key];
                builder.Append(value);
            }

            return builder.ToString().PadLeft(32, '0');
        }

        public static string HexadecimalToBinaryDOTNET(string number)
        {
            // Hex to decimal
            var numberInDecimal = Convert.ToInt32(number, 16);

            // Decimal to binary
            var numberInBinary = Convert.ToString(numberInDecimal, 2);

            return numberInBinary.PadLeft(32, '0');
        }

        public static string BinaryToHexadecimal(string number)
        {
            var result = new StringBuilder();

            for (int i = 0; i < number.Length; i += 4)
            {
                var key = number.Substring(i, 4);
                var value = BinaryToHexTable[key];
                result.Append(value);
            }

            // Remove leading zeros and return number in hexadecimal form
            return result.ToString().TrimStart(new Char[] { '0' });
        }

        public static string BinaryToHexadecimalDOTNET(string number)
        {
            // Binary to decimal
            var numberInDecimal = Convert.ToInt32(number, 2);

            // Decimal to hex
            var numberInHex = Convert.ToString(numberInDecimal, 16);

            return numberInHex;
        }

        public static string DecimalToBinary(int decimalNumber)
        {
            var builder = new StringBuilder();
            var remainder = default(int);

            while (decimalNumber != 0)
            {
                remainder = decimalNumber % 2;
                builder.Insert(0, remainder);
                decimalNumber = decimalNumber / 2;
            }

            return builder.ToString();
        }

        public static string DecimalToBinaryDOTNET(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        public static int BinaryToDecimalDOTNET(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            var numberInDecimal = 0;
            var fromBase = 2;
            var position = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] != '0')
                {
                    position = binaryNumber.Length - i - 1;
                    numberInDecimal += (int)Math.Pow(fromBase, position);
                }
            }

            return numberInDecimal;
        }
        public static Dictionary<char, string> HexBinaryTable = new Dictionary<char, string>()
        {
            {'0',"0000" },
            {'1',"0001" },
            {'2',"0010" },
            {'3',"0011" },
            {'4',"0100" },
            {'5',"0101" },
            {'6',"0110" },
            {'7',"0111" },
            {'8',"1000" },
            {'9',"1001" },
            {'A',"1010" },
            {'B',"1011" },
            {'C',"1100" },
            {'D',"1101" },
            {'E',"1110" },
            {'F',"1111" }
        };

        public static Dictionary<string, char> BinaryToHexTable = new Dictionary<string, char>()
        {
            {"0000", '0' },
            {"0001", '1' },
            {"0010", '2' },
            {"0011", '3' },
            {"0100", '4' },
            {"0101", '5' },
            {"0110", '6' },
            {"0111", '7' },
            {"1000", '8' },
            {"1001", '9' },
            {"1010", 'A' },
            {"1011", 'B' },
            {"1100", 'C' },
            {"1101", 'D' },
            {"1110", 'E' },
            {"1111", 'F' }
        };

        public static string Reverse(string sequence)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = sequence.Length - 1; i >= 0; i--)
            {
                builder.Append(sequence[i]);
            }

            return builder.ToString();
        }

        public static TimeSpan Benchmark(Func<int, string> methodToBeTested)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                methodToBeTested.Invoke(i);
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}