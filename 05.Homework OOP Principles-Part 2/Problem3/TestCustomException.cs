using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem3
{
    class TestCustomException
    {
        public static void Go()
        {
            GetValueInt();
            GetValueDateTime();
        }

        private static void GetValueDateTime()
        {
            try
            {
                DateTime start = new DateTime(1985, 7, 17);
                DateTime end = DateTime.Now;
                DateTime x = new DateTime(2018, 1, 1);
                if(x<start || x > end)
                {
                    throw new InvalidRangeException<DateTime>(start, end);
                }
            }
            catch (InvalidRangeException<DateTime>dex)
            {

                Console.WriteLine(string.Format($"{dex.Message} ({dex.Start},{dex.End})"));

            }
        }

        private static void GetValueInt()
        {
            try
            {
                int start = 1;
                int end = 50;
                int x = 150;
                if(x<start || x > end)
                {
                    throw new InvalidRangeException<int>(start, end);
                }
            }
            catch (InvalidRangeException<int>exse)
            {

                Console.WriteLine(string.Format($"{exse.Message} ({exse.Start},{exse.End})"));
            }
        }
    }
}
