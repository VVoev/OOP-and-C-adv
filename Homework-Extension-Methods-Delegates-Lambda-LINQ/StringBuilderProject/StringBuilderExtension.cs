using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Homework_Extension_Methods_Delegates_Lambda_LINQ.StringBuilderProject
{
   public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder text,int startPosition,int additionalText)
        {
            var sb = new StringBuilder();
            if(startPosition<0 || startPosition > text.Length)
            {
                throw new ArgumentException("Index is out of the text");
            }
            else if (startPosition + additionalText > text.Length)
            {
                throw new ArgumentOutOfRangeException("Lenght of the substring is bigger than the text");
            }
            else
            {
                for (int i = startPosition; i < startPosition+additionalText; i++)
                {
                    sb.Append(text[i]);
                }
            }
            return sb;
        }
    }
}
