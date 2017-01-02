using Homework_OOP_Principles_Part_1._02.StudentAndWorkers.People;
using StudentAndWorkers.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1._02.StudentAndWorkers.ExtensionMethods
{
    public static class ExtensionMethod
    {
        public static IEnumerable<Student>OrderByExam(this IEnumerable<Student> unorderStudents)
        {
            var orderStudents = unorderStudents.OrderBy(x => x.Grade).ThenBy(y => y.FirstName);
            return orderStudents;
        }

        public static IEnumerable<Worker> OrderByMoneyPerHour(this IEnumerable<Worker> underorderedWorkers)
        {
            var orderStudents = underorderedWorkers.OrderBy(x => x.MoneyPerHour()).ThenBy(y => y.FirstName);
            return orderStudents;
        }
    }
}
