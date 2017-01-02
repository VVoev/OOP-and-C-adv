using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.User_Defined_Exception
{
   public static  class SumOfLines
    {
       public static void Go()
        {
            long sumOfLines = CalculateSumOfLines(@"C:\Users\Vlado\Documents\visual studio 2015\Projects\ConsoleApplication2\05. OOP-Principles-Part-2\User-Defined-Exception\TextIsHere\lines.txt");
            Console.WriteLine($"Sum of lines are {sumOfLines}");
        }

        private static long CalculateSumOfLines(string fileName)
        {
            StreamReader inFile;
            try
            {
                inFile = File.OpenText(fileName);
            }
            catch (Exception ioe)
            {

                string msg = string.Format($"Cannot open the file {fileName} for reading");
                throw new ParseFileException(msg, fileName, ioe);
            }
            using (inFile)
            {
                long sum = 0;
                long lineNumber = 0;
                while (true)
                {
                    lineNumber++;
                    string line;
                    try
                    {
                        line = inFile.ReadLine();
                    }
                    catch (IOException ioe)
                    {

                        throw new ParseFileException("Error Reading from file", fileName, ioe);
                    }
                    if (line == null)
                    {
                        break;// end of file has been reached
                    }

                    try
                    {
                        sum += int.Parse(line);
                    }
                    catch (SystemException se)
                    {

                        var msg = $"Error parsing line {line}";
                        throw new ParseFileException(msg, fileName, lineNumber, se);
                    }
                }
                return sum;
            }
        }
    }
}
