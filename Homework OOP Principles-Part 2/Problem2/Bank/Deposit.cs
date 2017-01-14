using _05.Homework_OOP_Principles_Part_2.Problem2.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.Homework_OOP_Principles_Part_2.Problem2.BankCustomers;

namespace _05.Homework_OOP_Principles_Part_2.Problem2.bank
{
    class Deposit : Account
    {
        public Deposit(Customer customer, decimal interestRate) : base(customer, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interestAmmount = 0;
            if (this.Balance >= 1000)
            {
                interestAmmount = months * this.InterestRate;
            }
            return interestAmmount;

        }
    }
}
