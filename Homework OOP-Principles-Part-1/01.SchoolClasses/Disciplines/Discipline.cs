using SchoolClasses.Disciplines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Disciplines
{
    public class Discipline
    {
        //fields
        private DisciplineType type;
        private int numberOfLessons;
        private int numberOfExams;

        //properties
        public DisciplineType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int NumberOfLessons
        {
            get
            {
                return this.numberOfLessons;
            }
            set
            {
                CheckForZero(value);
                this.numberOfLessons = value;
            }
        }
        public int NumberOfExams
        {
            get
            {
                return this.numberOfExams;
            }
            set
            {
                CheckForZero(value);
                this.numberOfExams = value;
            }
        }

        //Constructor
        public Discipline(DisciplineType type,int lessons,int exercises)
        {
            this.Type = type;
            this.NumberOfLessons = lessons;
            this.NumberOfExams = exercises;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Type} ==> [Lessons: {this.NumberOfLessons}] [Exercises: {this.NumberOfExams}]");
            return sb.ToString();
        }

        private void CheckForZero(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("You cannot pass a course with 0 Exams");
            }
        }
    }
}
