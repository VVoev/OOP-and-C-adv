using System;

namespace SofiaUniversity.Data
{
    public class Professor
    {
        public Professor(string firstname,string lastname,Faculty fakulty,string subject)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Faculty = fakulty;
            this.Subject = subject;
        }
        public Professor()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Faculty Faculty { get; set; }
        public string Subject { get; set; }
    }
   
}