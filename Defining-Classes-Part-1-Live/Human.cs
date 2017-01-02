using System;

public class Human
{
    private int age;
    private string name;

    public Human(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if(value<0 || value > 120)
            {
                throw new ArgumentException("Invalid Age,Age should be in the range [0-120].");
            }
            this.age = value;
        }
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            if (value.Length < 2)
            {
                throw new ArgumentException("Name is too short,Should be at least 2 chars");
            }
            if (value.Length > 50)
            {
                throw new ArgumentException("Name is too long,Should be less than 50 chars");
            }
            foreach (var ch in value)
            {
                if (!AllowedLetter(ch))
                {
                    throw new ArgumentException("Invalid name,Use only letters,space and hyphen");
                }
            }
            this.name = value;
        }
    }

    private bool AllowedLetter(char ch)
    {
        bool isAllowed = char.IsLetter(ch) || ch == '-' || ch == ' ';
        return isAllowed;
    }
}