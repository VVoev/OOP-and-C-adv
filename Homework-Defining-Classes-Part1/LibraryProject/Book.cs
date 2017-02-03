using System;
using System.Text;

namespace Homework_Defining_Classes_Part1
{
    public class Book
    {
        private DateTime dateOfPublishing;
        private string author;
        private string press;
        private string isbnNumber;
        private string nameOfBook;

        public DateTime DateOfPublishing
        {
            get { return this.dateOfPublishing; }
            set { this.dateOfPublishing = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Press
        {
            get { return this.press; }
            set { this.press = value; }
        }

        public string IsbnNumber
        {
            get { return this.isbnNumber; }
            set { this.isbnNumber = value; }
        }

        public string NameOfBook
        {
            get { return this.nameOfBook; }
            set { this.nameOfBook = value; }
        }

        public Book(string name, string author, string press, DateTime year, string number)
        {
            this.NameOfBook = name;
            this.Author = author;
            this.Press = press;
            this.DateOfPublishing = year;
            this.IsbnNumber = number;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (this.NameOfBook != null)
            {
                sb.AppendLine("-Name of book:" + this.NameOfBook);
            }
            if (this.Author != null)
            {
                sb.AppendLine("-Author of book:" + this.Author);
            }
            if (this.Press != null)
            {
                sb.AppendLine("-Press of book:" + this.Press);
            }
            if (this.DateOfPublishing != null)
            {
                sb.AppendLine("-Year of book publishing:" + this.DateOfPublishing);
            }
            if (this.IsbnNumber != null)
            {
                sb.AppendLine("-Id of book:" + this.IsbnNumber);
            }
            return sb.ToString();
        }
    }
}