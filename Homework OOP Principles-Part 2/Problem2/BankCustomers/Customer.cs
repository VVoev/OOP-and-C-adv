using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem2.BankCustomers
{
    public abstract class Customer
    {
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You should enter a name");
                }
                this.customerName = value;
            }
        }

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

    }
}
