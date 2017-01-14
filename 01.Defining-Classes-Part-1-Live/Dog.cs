using System;

public class Dog
{
    private string breed;
    private string name;

    public Dog()
    {
    }

    public Dog(string name, string breed)
    {
        this.name = name;
        this.breed = breed;
    }
    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public void SayBau()
    {
        Console.WriteLine("{0} said: Bauuuuuu!",this.name ?? "[unnamed dog]");
    }
}