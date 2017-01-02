using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringAndTextHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               02. Reverse string
               string text = Console.ReadLine();
               Console.WriteLine(Reverse(text)); 
           */

            /*
             03. Correct brackets
             string brackets = Console.ReadLine();
             Console.WriteLine(CheckIfBracketsAreCorrect(brackets));
             */

            /*04. Sub-string in text
            string searchText = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(Count(searchText, text));
            */

            /*
            05.Parse tags
            string text = Console.ReadLine();
            Console.WriteLine(ParsedText(text));
            */

            /*
            06. String length
            string  text = Console.ReadLine();
            Console.WriteLine(FormatedText(text));
            */

            /*
            10. Unicode characters
            string text = Console.ReadLine();
            Unicode(text);
            */

            /*
            12. Parse URL
            string url = Console.ReadLine();
            Parse(url);
            */


            /*
            15. Replace tags
            string htmlText = Console.ReadLine();
            Replace(htmlText);
            */

            //23. Series of letters
            string text = Console.ReadLine();
            Console.WriteLine(RemoveDublicateText(ref text));




        }

        private static string RemoveDublicateText(ref string text)
        {
            string pattern = @"([a-zA-z])\1+";
            string replacement = "$1";
            Regex rgx = new Regex(pattern);
            string replacedText = Regex.Replace(text, pattern, replacement);
            return replacedText;
        }

        private static void Replace(string htmlText)
        {
            StringBuilder result = new StringBuilder();

            string pattern = @"<a href=(""|')([a-zA-Z0-9/\:\. \#]+)\1>([a-zA-Z0-9 \#]+)<\/a>";
            string replacement = @"[$3]($2)";

            Regex rgx = new Regex(pattern);
            result.AppendLine(Regex.Replace(htmlText, pattern, replacement)
                                   .TrimStart('"')
                                   .TrimEnd('"'));

            Console.Write(result);
        }

        private static void Parse(string url)
        {

            int protokolIndex = url.IndexOf(':');
            int serverIndex = url.IndexOf('/', protokolIndex + 3);
            string protocol = url.Substring(0, protokolIndex);
            string server = url.Substring(protokolIndex + 3, serverIndex - protokolIndex - 3);
            string resource = url.Substring(serverIndex);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }

        private static void CheckForHttp(ref string input, ref string protocol)
        {
            if (input.Contains("http"))
            {
                protocol = "http";
            }
            if (input.Contains("https"))
            {
                protocol = "https";
            }
        }

        private static void Unicode(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)text[i]);
            }
            Console.WriteLine();
        }

        private static string FormatedText(string text)
        {
            var sb = new StringBuilder();
            if (text.Length > 20)
            {
                for (int i = 0; i < 20; i++)
                    sb.Append(text[i]);
                return sb.ToString();
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                    sb.Append(text[i]);
                while (sb.Length<20)
                    sb.Append('*');
                return sb.ToString();
            }
        }

        private static string ParsedText(string text)
        {
            string fUpcase = "<upcase>";
            string bUpcase = "</upcase>";
            bool finish = false;

            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; )
            {
                int found = text.IndexOf(fUpcase,i);
                int bfound = text.IndexOf(bUpcase,i);
                while (i < found)
                {
                    sb.Append(text[i]);
                    i++;
                }
                while(found==-1 && bfound == -1 && i<text.Length)
                {
                    sb.Append(text[i]);
                    i++;
                    finish = true;
                }

                if (finish)
                    return sb.ToString();

                i += fUpcase.Length;
                string upper = text.Substring(i, bfound - i).ToUpper();
                i += bfound - i + bUpcase.Length;
                sb.Append(upper);
            }
            return sb.ToString();
        }

        private static int Count(string searchText, string text)
        {
            int found = 0;
            for (int i = 0; i < text.Length;)
            {
                int x = text.IndexOf(searchText, i);
                i = x;
                if (i == -1)
                    break;
                i += searchText.Length;
                found++;
            }
            return found;
        }

        private static string CheckIfBracketsAreCorrect(string brackets)
         {
             string correct = "Incorrect";
             int forwardBracket = 0;int backwardBracket = 0;
             foreach (char elem in brackets)
             {
                 if (elem == '(')
                     forwardBracket++;
                 if (elem == ')')
                     backwardBracket++;
             }
             if (forwardBracket == backwardBracket)
             {
                 correct = "Correct";
             }

             return correct;
         }

         private static string Reverse(string text)
         {
             var sb = new StringBuilder();
             for (int i = text.Length - 1; i >= 0; i--)
             {
                 sb.Append(text[i]);
             }
             return sb.ToString();
         }
     }
 }
