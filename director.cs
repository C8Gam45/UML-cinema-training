using System;
// Exercise 2 

class Director
{
    private string firstName;
    private string lastName;
    private string country;

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public string GetCountry()
    {
        return country;
    }

    public Director(string firstName, string lastName, string country)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.country = country;
    }

    public void Display()
    {
        Console.WriteLine($"Director: {GetFirstName()} {GetLastName()}");
        Console.WriteLine($"Country: {GetCountry()}");
    }
}