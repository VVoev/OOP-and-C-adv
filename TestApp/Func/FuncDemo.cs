using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Func
{
    class FuncDemo
    {
        public static void Start()
        {
            Func<string, string> convertor = s => s.ToUpper();
            Console.WriteLine(convertor("BrAzIlIa"));

            Func<string, string, string> fullname = (a, b) => a +" "+ b;
            var x= fullname("vlado", "voev");
            Console.WriteLine(x);

            Func<int, int, int> Sumator = (a, b) => a + b;
            Func<int, int, int> Multi = (a, b) => a * b;
            Func<string, char, bool> IsContainig = (a, b) => a.Contains(b);
            var res = IsContainig("Petar", 'e');
            Console.WriteLine(res);

            Func<int, int, int, int, int> Biggest = (a, b, c, d) => Math.Max(a, Math.Max(b, Math.Max(c, d)));
            var poGolqmo = Biggest(10, 20, 30, 40);
            Console.WriteLine(poGolqmo);
            
        }
    }
}
