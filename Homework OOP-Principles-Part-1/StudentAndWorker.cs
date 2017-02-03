using Homework_OOP_Principles_Part_1._02.StudentAndWorkers.ExtensionMethods;
using Homework_OOP_Principles_Part_1._02.StudentAndWorkers.People;
using StudentAndWorkers.AbstractClass;
using StudentAndWorkers.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles_Part_1
{
    class StudentAndWorker
    {
        public static void Go()
        {
            var student1 = new Student("Petar", "Dilqnov", 6.00m);
            var student2 = new Student("Iliqn", "Bekqrov", 5.98m);
            var student3 = new Student("Simeon", "Todor", 4.50m);
            var student4 = new Student("Mihail", "Gospodinov", 3.00m);
            var student5 = new Student("Kircata", "Madjarov", 3.15m);
            var student6 = new Student("Ulii", "Georgiev", 4.72m);
            var student7 = new Student("Vlado", "Tonev", 5.198m);
            var student8= new Student("Sasho", "Petresku", 5.33332m);
            var student9 = new Student("Georgi", "Uzunov",4.00m);
            var student = new Student("Martin", "Zmeev", 2.13m);
            var student10 = new Student("Petar", "Tudjarov", 4.88m);
            var sortedStudents = new List<Student> { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };

            //students sorted by exam
            var sortedByExam = sortedStudents.OrderByExam().ToList();
            sortedByExam.ForEach(x => Console.WriteLine("-" + x.ToString()));
            Console.WriteLine();
            



            var worker1 = new Worker("Iliqn", "Ivanov", 500, 8);
            var worker2 = new Worker("Xahan", "Xikirqn", 1300, 4);
            var worker3 = new Worker("Mario", "Peev", 11300, 5);
            var worker4 = new Worker("Todor", "Rusharov", 3500, 8);
            var worker5 = new Worker("Vlado", "Ionkov", 3300, 6);
            var worker6 = new Worker("Daniel", "Dulgov", 5500, 8);
            var worker7 = new Worker("Galya", "Programirova", 8500, 8);
            var worker8 = new Worker("Asen", "Ivanov", 1500, 4);
            var worker9 = new Worker("Petar", "Ivanov", 2500, 12);
            var worker10 = new Worker("Georgi", "Ivanov", 3500, 3);
            var sortedWorkers = new List<Worker> { worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10 };

            //workers sorted by moneyPerHour
            var sortedByMoney = sortedWorkers.OrderByMoneyPerHour().ToList();
            sortedByMoney.ForEach(x => Console.WriteLine("-"+x.ToString()));
            Console.WriteLine();

            //merge all humans in one list and sort by first and lastname
            var mergedList = new List<Human>();
            mergedList.AddRange(sortedStudents);
            mergedList.AddRange(sortedWorkers);
            var sortedMergeList = mergedList.OrderBy(x => x.FirstName).ThenBy(y => y.LastName).ToList();
            sortedMergeList.ForEach(x => Console.WriteLine("-" + x.FullName));






        }
    }
}
