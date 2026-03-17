using System;

// Exercise 1

class Movie
{
    private string title;
    private int duration;
    public string GetTitle()
    {
        return title;
    }
    public int GetDuration()
    {
        return duration;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void SetDuration(int duration)
    {
        this.duration = duration;
    }
    public Movie(string title, int duration)
    {
        this.title = title;
        this.duration = duration;
    } 
    public void Display()
    {
        Console.WriteLine($"Movie: {GetTitle()}");
        Console.WriteLine($"Duration: {GetDuration()} minutes");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Director director = new Director("Steven", "Spielberg", "United States");

        director.Display();

        Console.WriteLine();

        Movie movie = new Movie("Inception", 148);

        movie.Display();
    }
}
