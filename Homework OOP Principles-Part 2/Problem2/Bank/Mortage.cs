using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.Homework_OOP_Principles_Part_2.Problem2.BankCustomers;

namespace _05.Homework_OOP_Principles_Part_2.Problem2.Bank
{
    class Mortage : Account
    {
        public Mortage(Customer customer, decimal interestRate) : base(customer, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interestAmount = 0;
            if (this.Customer.GetType().Equals(typeof(Company)))
            {
                interestAmount = months <= 12 ? (this.InterestRate / 2) * months : this.InterestRate * months;
            }
            else if (this.Customer.GetType().Equals(typeof(Individual)))
            {
                int interestMonths = GetMonthToInterest(months);
                interestAmount = interestMonths * this.InterestRate;
            }
            return InterestRate;
        }
    }
}
