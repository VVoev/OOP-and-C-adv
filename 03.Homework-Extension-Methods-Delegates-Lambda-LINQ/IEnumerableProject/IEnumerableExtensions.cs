using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Homework_Extension_Methods_Delegates_Lambda_LINQ.IEnumerableProject
{
    public static class IEnumerableExtensions
    {
        public static T CalculateSum<T>(this IEnumerable<T> collection)
            where T:IComparable<T>
        {
            T sumValue = (dynamic)0;
            foreach (var item in collection)
            {
                sumValue +=(dynamic) item;
            }
            return sumValue;
        }
        public static T CalculateProduct<T>(this IEnumerable<T> collection)
            where T:IComparable<T>
        {
            T sum = (dynamic)1;
            foreach (var item in collection)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }
        public static T MinNumber<T>(this IEnumerable<T> collection)
            where T:IComparable<T>
        {
            T sum = collection.First();
            foreach (var item in collection)
            {
                if (sum.CompareTo(item)>0)
                {
                    sum = item;
                }
            }
            return sum;
        }
        public static T MaxNumber<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T sum = collection.First();
            foreach (var item in collection)
            {
                if (sum.CompareTo(item) < 0)
                {
                    sum = item;
                }
            }
            return sum;
        }
        public static T AverageOfAll<T>(this IEnumerable<T> collection)
        {
            T value = default(T);
            int index = 0;
            foreach (var item in collection)
            {
                index++;
                value += (dynamic)item;
            }
            return (dynamic)value/index;
        }
    }
}
