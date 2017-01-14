using _05.Homework_OOP_Principles_Part_2.Problem2.bank;
using _05.Homework_OOP_Principles_Part_2.Problem2.Bank;
using _05.Homework_OOP_Principles_Part_2.Problem2.BankCustomers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Homework_OOP_Principles_Part_2.Problem2
{
    public class BankAccountTest
    {
        public static void Go()
        {
            // Create customer Deposit account.
            var companyCustomer = new Company("IBM");
            var companyDeposit = new Deposit(companyCustomer, 1.5m);
            companyDeposit.DepositMoney(10000m);
            companyDeposit.WithDrawMoney(1500m);
            decimal amount = companyDeposit.CalculateInterest(6);
            companyDeposit.Balance -= amount;
            Console.WriteLine(companyDeposit);

            // Create individual Loan account.
            var individualCustomer = new Individual("Ivan Ivanov");
            var individualLoan = new Loan(individualCustomer, 5m);
            individualLoan.Balance = 15000;
            decimal yearAmount = individualLoan.CalculateInterest(12);
            individualLoan.Balance -= yearAmount;
            Console.WriteLine(individualLoan);

            // Create individual Mortgage account.
            var mortgageCustomer = new Individual("Angel Angelov");
            var individualMortgage = new Mortage(mortgageCustomer, 4.5m);
            individualMortgage.Balance = 45000m;
            decimal mortgageAmount = individualMortgage.CalculateInterest(12);
            individualMortgage.Balance -= mortgageAmount;
            Console.WriteLine(individualMortgage);

            // Create list of Accounts.
            Console.WriteLine("-------------------------------");
            var listOfAccounts = new List<Account>() { companyDeposit, individualLoan, individualMortgage };
            listOfAccounts.ForEach(x => Console.WriteLine(x.Customer.CustomerName + " " + x.Balance + " leva."));

        }
    }
}
