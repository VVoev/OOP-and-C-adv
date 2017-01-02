using Homework_Defining_Classes_Part1.mobileDevice.CallTest;
using System.Collections.Generic;
using System.Text;

namespace Homework_Defining_Classes_Part1
{
    public class Gsm : MobilePhone //Inherit all properties from class MobilePhone
    {
        //Fields in class Gsm
        private static readonly Gsm iphone7 = new Gsm("Iphone7", "Apple", 1300.25m, "Mimi");
        private static readonly decimal pricePerMinute = 0.25m;
        private List<Call>myTodaYcalls = new List<Call>();

        //Properties in class GSM
        public int CallsCount
        {
            get
            {
                return myTodaYcalls.Count;
            }
        }

        public decimal PricePerMinute
        {
            get
            {
                return pricePerMinute;
            }
        }
        //Constructor in class GSM

        public Gsm Iphone7
        {
            get
            {
                return Iphone7;
            }
        }

        public Gsm(string model=null,string manufacturer =null,decimal price = 0 ,string owner = null,Battery type =null,Display size = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = type;
            this.Display = size;
        }
        //Methods in class GSM
        public void Iphone7Info()
        {
            iphone7.ToString();
        }
        public void AddCall(Call call)
        {
            myTodaYcalls.Add(call);
        }
        public void DeleteCall(Call call)
        {
            myTodaYcalls.Remove(call);
        }
        public void DeleteCallAtIndex(int index)
        {
            myTodaYcalls.RemoveAt(index);
        }
        public void ClearAllCalls()
        {
            myTodaYcalls.Clear();
        }
        public int FindIndexOfLongestDuration(int maxDuration)
        {
            int index = 0;
            for (int i = 0; i < myTodaYcalls.Count; i++)
            {
                if (myTodaYcalls[i].CallDuration == maxDuration)
                {
                    index = i;
                }
            }
            return index;
        }
        public int CalculateTotalDuration()
        {
            int total = 0;
            foreach (var call in myTodaYcalls)
            {
                total += call.CallDuration;
            }
            return total;
        }
        public int MaxDuration()
        {
            int maxDuration = 0;
            foreach (var call in myTodaYcalls)
            {
                if (call.CallDuration > maxDuration)
                {
                    maxDuration = call.CallDuration;
                }
            }
            return maxDuration;
        }
        public decimal CalculateTotalPrice(int totalDuration)
        {
            decimal totalPrice = totalDuration / 60 * pricePerMinute;
            return totalPrice;
        }
        public override string ToString()
        {
            var phoneInformation = new StringBuilder();
            if (this.Model != null)
            {
                phoneInformation.AppendLine("Model: " + this.Model);
            }
            if (this.Manufacturer != null)
            {
                phoneInformation.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (this.Price > 0)
            {
                phoneInformation.AppendLine("Price: " + this.Price + " lv.");
            }
            if (this.Owner != null)
            {
                phoneInformation.AppendLine("Owner " + this.Owner);
            }
            if (this.Battery != null)
            {
                phoneInformation.AppendLine("Battery info:");
                phoneInformation.AppendLine("BatteryModel-" + Battery.BatteryModel);
                phoneInformation.AppendLine("BatteryHoursIdle-" + Battery.BatteryHoursIdle+"h");
                phoneInformation.AppendLine("BatteryHourTalk-" + Battery.BatteryHourTalk + "h");
                phoneInformation.AppendLine("BatteryType-" + Battery.BatteryType);
            }
            if (this.Display != null)
            {
                phoneInformation.AppendLine("Display info:");
                phoneInformation.AppendLine("DispaySize- " + Display.DisplaySize+" Inches");
                phoneInformation.AppendLine("DisplayNumberOfColors- " + Display.NumberOfColours);
            }
            return phoneInformation.ToString();
        }
    }
}