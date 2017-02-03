using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dgroup
{
    
    public class Group
    {
        //fields
        int groupNumber;
        string departmentName;

        //properties

        public int GroupNumbers
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (this.groupNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Group number cannot be negative");
                }
                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get { return this.departmentName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Department should be assigned");
                }
                this.departmentName = value;
            }
        }

        //Constructor

        public Group(string departmentName,int groupNumber)
        {
            this.GroupNumbers = groupNumber;
            this.DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return string.Format($@"[CourseName:{this.DepartmentName}][Number:{this.GroupNumbers}]");
        }
    }
}
