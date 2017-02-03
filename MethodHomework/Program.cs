using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MethodHomeWork
{
    static void Main()
    {

        string input = "Az se kazvam Vladimir i sam na 31 godini i sam ot sofia";
        //char x = char.Parse(Console.ReadLine());
        //Console.WriteLine(CountLetter(input, x));
        //Console.WriteLine(SayInReverseOrder(input));
        char m = char.Parse(Console.ReadLine());
        char v = char.Parse(Console.ReadLine());

        VladovMetod(input,m,v );



        /* 1.Say Hello
           string name = Console.ReadLine();
           Hello(name);
        */

        /* 2.Get Max Elementh
        var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(Max(arr));
        */

        /* 3.Number As Text
        int number = int.Parse(Console.ReadLine()) % 10;
        Console.WriteLine(NumberAsText(number));
        */

        /*04. Appearance count
        int number = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int numberToLook = int.Parse(Console.ReadLine());
        Console.WriteLine(FindOccurence(ref arr,numberToLook));
        */

        /* 05. Larger than neighbours
        int number = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(LargerThenNeigh(ref arr));
        */

        /* 06. First larger than neighbours
        int number = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(FirstLargerThenNeigh(ref arr));
        */

        /*07. Reverse number
        var number = Console.ReadLine();
        Console.WriteLine(Reverse(number));
        */

        /*09. Sorting array
        int number = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var nov = Sorted(ref arr);
        Console.WriteLine(string.Join(" ",nov));
        */

        /*10. N Factorial
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        Faktoriel(number);
        */

        /*14.Integer calculations
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Minimum(ref arr);
        Maximum(ref arr);
        Average(ref arr);
        Sum(ref arr);
        Product(ref arr);
        */
        



        


        




    }

    private static void VladovMetod(string input, char m, char v)
    {
        int counter1 = 0;
        int counter2 = 0;
        for (int i = 0; i < input.Length; i++)
        {
            
            if (input[i] == m)
            {
                counter1++;
            }
            else if (input[i] == v)
            {
                counter2++;
            }
        }
        if (counter1 > counter2)
        {
            Console.WriteLine($@"Po chesto se sreshta{m}, ima q {counter1}, ostanalata sushtestvuvashta bukva v tova unikalnoooo izrechenie e {v} i neq q ima unikalnite {counter2} puti");
        }
        else if (counter2 > counter1)
        {
            Console.WriteLine($@"Po chesto se sreshta{v}, ima q {counter2}, ostanalata sushtestvuvashta bukva v tova unikalnoooo izrechenie e {m} i neq q ima unikalnite {counter1} puti");
        }
        else
        {
            Console.WriteLine($@"Te sa munichko suvsem munichko ravnichki, no vse pak trqbva da raboti :)");
        }
    
}

    private static string SayInReverseOrder(string mimoza)
    {
        string vrushtanotoOtVladi = string.Empty;
        for (int i = mimoza.Length - 1; i >= 0; i--)
        {
            vrushtanotoOtVladi += mimoza[i];
        }
        return vrushtanotoOtVladi;
    }

    private static int CountLetter(string mimi,char x)
    {
        int counter = 0;
        for (int i = 0; i < mimi.Length; i++)
        {
            if (mimi[i] == x)
            {
                counter++;
            }
        }
        return counter;
    }

    private static void PrintWithV(string[] arr)
    {
        foreach (var word in arr)
        {
            if (word.Contains('M'))
            {
                Console.WriteLine(word);
            }
        }
    }

    static void Product(ref int[] arr)
    {
        int sum = 1;
        foreach (var item in arr)
        {
            sum *= item;
        }
        Console.WriteLine("Product is {0}",sum);
    }

    static void Sum(ref int[] arr)
    {
        double sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }
        Console.WriteLine("Sum is {0}",sum);
    }
    static void Average(ref int[] arr)
    {
        double sum = 0;
        int counter = 0;
        foreach (var item in arr)
        {
            sum += item;
            counter++;
        }
        sum /= counter;
        Console.WriteLine("Average is {0:f2}",sum);
    }

    static void Maximum(ref int[] arr)
    {
        int sum = int.MinValue;
        foreach (var item in arr)
        {
            if (item > sum)
            {
                sum = item;
            }
        }
        Console.WriteLine("Maximum is {0}", sum);
    }

    static void Minimum(ref int[] arr)
    {
        int sum = int.MaxValue;
        foreach (var item in arr)
        {
            if (item < sum)
            {
                sum = item;
            }
        }
        Console.WriteLine("Minimum is {0}", sum);
    }

    static void Faktoriel(BigInteger number)
    {
        BigInteger suma = 1;
        for (BigInteger i = number ; i > 0; i--)
        {
            suma *= i;
        }
        Console.WriteLine(suma);
    }

    private static int[] Sorted(ref int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[j + 1] < arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }

    private static string Reverse(string number)
    {
        var sb = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            sb.Append(number[i]);
        }
        return sb.ToString();
    }

    private static int FirstLargerThenNeigh(ref int[] arr)
    {
        int counter = -1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                counter = i;
                break;
            }
        }
        return counter;
    }

    private static int LargerThenNeigh(ref int[] arr)
    {
        int counter = 0;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                counter++;
            }
        }
        return counter;
    }

    private static int FindOccurence(ref int[] arr, int numberToLook)
    {
        int counter = 0;
        foreach (var item in arr)
        {
            if (item == numberToLook)
            {
                counter++;
            }
        }
        return counter;
    }

    private static string NumberAsText(int number)
    {
        string chislo = string.Empty;
        switch (number)
        {
            case 1: chislo = "one"; break;
            case 2: chislo = "two"; break;
            case 3: chislo = "three"; break;
            case 4: chislo = "four"; break;
            case 5: chislo = "five"; break;
            case 6: chislo = "six"; break;
            case 7: chislo = "seven"; break;
            case 8: chislo = "eight"; break;
            case 9: chislo = "nine"; break;
            default: chislo = "zero"; break;
        }
        return chislo;
    }

    private static int Max(int[] arr)
    {
        int biggest = int.MinValue;

        foreach (var item in arr)
        {
            if (biggest < item)
            {
                biggest = item;
            }
        }
        return biggest;
    }

    static void Hello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

}
