
using StudentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionForStudentsss
{
    public static class ExtensionStudent
    {
        public static IEnumerable<Student> OrderByGroup(this IEnumerable<Student> unorderedStudents, int groupNumber)
        {
            var orderedStudents = unorderedStudents.Where(x => x.GroupNumber.GroupNumbers == groupNumber)
                                                   .ToList();
            return orderedStudents;
        }

        public static IEnumerable<Student> ThenByFirstName(this IEnumerable<Student> unorderedStudents)
        {
            var orderedStudents = unorderedStudents.OrderBy(x => x.FirstName)
                                                   .ToList();
            return orderedStudents;
        }
        public static IEnumerable<Student> ExtractByEmail(this IEnumerable<Student> unorderedStudents,string email)
        {
            var orderedStudents = unorderedStudents.Where(x => x.Email.Contains(email))
                                                  .ToList();
            return orderedStudents;
        }
        public static IEnumerable<Student> FromTown(this IEnumerable<Student> unorderedStudents, string town)
        {
            var orderedStudents = unorderedStudents.Where(x => x.Tel.StartsWith(town))
                                                  .ToList();
            return orderedStudents;
        }
        public static IEnumerable<Student> ByMarkLenght(this IEnumerable<Student> unorderedStudents, int numberOfMarks)
        {
            var orderedStudents = unorderedStudents.Where(x => x.Marks.Count==numberOfMarks)
                                                  .ToList();
            return orderedStudents;
        }
        public static IEnumerable<Student> ExtractByYear(this IEnumerable<Student> unorderedStudents, string year)
        {
            var orderedStudents = unorderedStudents.Where(x => x.Fn.Substring(4, 2).CompareTo(year) == 0);
            return orderedStudents;
        }

        public static IEnumerable<Student> GroupByNameLenght(this IEnumerable<Student> unorderedStudents)
        {
            var orderedStudents = unorderedStudents.OrderBy(x => x.GroupNumber.DepartmentName.Length);
            return orderedStudents;
        }
    }
}
