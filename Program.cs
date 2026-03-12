using System;

class Movie
{
    public string Title { get; set; }
    public int Duration { get; set; } // in minutes

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Duration: {Duration} minutes");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Movie movie = new Movie();
        movie.Title = "Inception";
        movie.Duration = 148;
        movie.Display();
    }
}
