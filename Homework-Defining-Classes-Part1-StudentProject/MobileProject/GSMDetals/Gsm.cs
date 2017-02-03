
namespace Homework_Defining_Classes_Part1_StudentProject.MobileProject.GSMDetals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //Inherit the whole class
     class GSM : MobileDevice
    {
        //Fields in class GSM
        private static GSM Iphone = new GSM("Iphone 7", "Apple",1900);
        private static readonly decimal pricePerMinutes = 0.33m;
        private List<Call> myTotalCalls = new List<Call>();

        //Properties in class GSM

        public int CallsCount
        {
            get { return myTotalCalls.Count; }
        }

        public decimal PricePerminute
        {
            get { return pricePerMinutes; }
        }
        public GSM Iphone7
        {
            get { return Iphone; }
        }
        //Constructor in class GSM
        public GSM(string model, string manufacturer)
            :this(model,manufacturer,0,null,null,null)
        {

        }
        public GSM(string model, string manufacturer,decimal price)
          : this(model, manufacturer, price, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }



        public GSM()
            :this(null,null)
        {
        }

        //Methods in class GSM
        public void AddCall(Call call)
        {
            myTotalCalls.Add(call);
        }
        public void RemoveCall(Call call)
        {
            myTotalCalls.Remove(call);
        }
        public void RemoveCall(int index)
        {
            myTotalCalls.RemoveAt(index);
        }
        public void ClearallCalls()
        {
            myTotalCalls.Clear();
        }
        public int CalculateTotalDuration()
        {
            int totalDuration = 0;
            foreach (var call in myTotalCalls)
            {
                totalDuration += call.CallDuration;
            }
            return totalDuration;
        }
        public int MaxDuration()
        {
            int maxDuration = 0;
            foreach (var call in myTotalCalls)
            {
                if (maxDuration < call.CallDuration)
                {
                    maxDuration = call.CallDuration;
                }
            }
            return maxDuration;
        }
        public decimal CalculateTotalPrice(int totalDuration)
        {
            decimal totalPrice = (totalDuration / 60) * pricePerMinutes;
            return totalPrice;
        }
    }
}
