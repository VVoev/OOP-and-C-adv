using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MineExam.CofeeProject
{
    class Cofee
    {
        private string productChoise;
        private string sugarChoise;

        public Cofee(string productChoise, string sugarChoise)
        {
            this.productChoise = productChoise;
            this.sugarChoise = sugarChoise;
        }

        public override string ToString()
        {
            return string.Format($"You have Ordered {productChoise} Cofee with {sugarChoise} sugar ! {Environment.NewLine}Please welcome back anytime");
        }

        private CofeeType GetCofeeType(string choise)
        {
            switch (choise.ToLower())
            {
                case "cappuchino": return CofeeType.Cappuchino;
                case "blackcofee": return CofeeType.BlackCofee;
                case "white": return CofeeType.White;
                case "double":return CofeeType.Double;
                default:throw new ArgumentException("Invalid Choise");
            }
        }
        private SugarType GetSugarType(string choise)
        {
            switch (choise.ToLower())
            {
                case "sugarfree":return SugarType.SugarFree;
                case "normal":return SugarType.Normal;
                case "double":return SugarType.Double;
                default: throw new ArgumentException("Invalid Choise");
            }
        }

        public static void Go()
        {
            Console.WriteLine("Please select what do you want");
            Console.WriteLine("Cappuchino/BlackCofee/White Cofee/Double");
            var productChoise = Console.ReadLine();
            Console.WriteLine("Please select amount of sugar you want in your product");
            Console.WriteLine("SugarFree/Normal/Double");
            var sugarChoise = Console.ReadLine();

            var coffe = new Cofee(productChoise, sugarChoise);
            Console.WriteLine(coffe);
        }
    }
    public enum CofeeType
    {
        Cappuchino,
        BlackCofee,
        White,
        Double
    }
    public enum SugarType
    {
        SugarFree,
        Normal,
        Double
    }
}
