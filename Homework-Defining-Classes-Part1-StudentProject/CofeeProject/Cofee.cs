using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes_Part1_StudentProject.CofeeProject
{
    public class Cofee
    {

        //fields in Class Cofee
        private int clientCall;
        private int milk;
        private int sugar;
        private CofeeType type;
        private int water;

        //Properties in Class Cofee
        public int ClientCall
        {
            get { return this.clientCall; }
            set { this.clientCall = value; }
        }
        public int Milk 
        {
            get { return this.milk; }
            set { this.milk = value; }
        }
        public int Sugar
        {
            get { return this.sugar; }
            set { this.sugar = value; }
        }

        public CofeeType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int Water
        {
            get { return this.water; }
            set { this.water = value; }
        }

        //Constructor in class Cofee
        public Cofee(int clientCall,int milk,int sugar,int water,CofeeType type)
        {
            this.ClientCall = clientCall;
            this.Milk = milk;
            this.Sugar = sugar;
            this.Water = water;
            this.Type = type;
        }

        //Methods in class Coffee
        public static string CofeeInfo(int clientCall, int milk, int sugar, int water, CofeeType type)
        {
            var giveMeInfo = new StringBuilder();
            giveMeInfo.AppendLine("Client number is: "+clientCall.ToString());
            giveMeInfo.AppendLine("Milk in ml: "+milk.ToString());
            giveMeInfo.AppendLine("Sugar in grams: " + sugar.ToString());
            giveMeInfo.AppendLine("Water in ml: " + water.ToString());
            giveMeInfo.AppendLine("You selected: " + type.ToString()+" Coffee");
            return giveMeInfo.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (this.ClientCall != 0)
            {
                sb.AppendLine("Client number is: " + this.ClientCall);
            }
            if (this.Milk != 0)
            {
                sb.AppendLine("Milk in ml: " + this.Milk);
            }
            if (this.Sugar != 0)
            {
                sb.AppendLine("Sugar in grams " + this.Sugar);
            }
            if (this.Water != 0)
            {
                sb.AppendLine("Water in ml: " + this.Water);
            }
            if (this.Type >=0)
            {
                sb.AppendLine("You selected: " + this.Type+" Cofee");
            }
            return sb.ToString();
        }
    }
}
