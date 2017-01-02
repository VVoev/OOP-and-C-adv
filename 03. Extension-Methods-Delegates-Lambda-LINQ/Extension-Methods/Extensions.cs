using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ.Extension_Methods
{
  public static class  Extensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in enumeration)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        public static void IncreaseWith(this IList<int> list,int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
    }
  
    

}
