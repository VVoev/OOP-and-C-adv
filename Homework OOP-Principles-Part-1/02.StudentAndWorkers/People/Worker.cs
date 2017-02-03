using StudentAndWorkers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1._02.StudentAndWorkers.People
{
    public class Worker : Human
    {
        //const
        private const int workdays = 5;
        private const int numberOfWeeksInMonth = 4;
        //fields
        private decimal weekSalary;
        private decimal workHoursPerDay;

        //properties
        public decimal WeekSalary { get { return this.weekSalary; }set { this.weekSalary = value; } }
        public decimal WorkHoursPerDay { get { return this.workHoursPerDay; }set { this.workHoursPerDay = value; } }

        //Constructor
        public Worker(string firstname, string lastName,decimal weekSalary,decimal workHoursPerDay)
            : base(firstname, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal perHour = this.WeekSalary / ((workHoursPerDay * workdays)*numberOfWeeksInMonth);
            return perHour;
        }

        public override string ToString()
        {
            return string.Format($"{base.FullName}  Amount per hour {this.MoneyPerHour():f2} usd");
        }
    }
}
