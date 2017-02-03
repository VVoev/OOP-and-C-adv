using _05.Homework_OOP_Principles_Part_2.Problem2.BankCustomers;
using _05.Homework_OOP_Principles_Part_2.Problem2.BankInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem2.Bank
{
    public abstract class Account : IAcountable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private decimal interestAmount;

        public Customer Customer { get; }
        public decimal Balance { get; set; }
        protected decimal InterestRate { get; set; }
        protected decimal InterestAmount { get; set; }

        public Account(Customer customer,decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        public abstract decimal CalculateInterest(int months);
        public virtual void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
        public virtual void WithDrawMoney(decimal money)
        {
            if (this.Balance < 0)
            {
                this.Balance = 0;
            }
            this.Balance -= money;
        }
        public virtual int GetMonthToInterest(int numberOfMonths)
        {
            return numberOfMonths;
        }
        public override string ToString()
        {
            return string.Format($"{this.Customer.CustomerName} has balance of {this.Balance} leva");
        }
    }
}
