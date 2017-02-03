using System;
using System.Text;

namespace SofiaUniversity.Data
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }
        public int FacultyNumber { get; set; }

        public Student()
        {

        }
        public Student(string firstname,string lastname,Faculty faculty,Specialty specialty,int facultyNumber)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.FacultyNumber = facultyNumber;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Ime:{0}\nFamiliq:{1}\nFakultet={2}\nSpecialnost={3}\nFakultete Nomer:{4}", this.FirstName,this.LastName,this.Faculty.Name,this.Specialty,this.FacultyNumber));
            return sb.ToString();
        }
    }

}