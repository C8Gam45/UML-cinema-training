using System;
using System.Collections.Generic;

class Viewer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public Viewer(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public void Display()
    {
        Console.WriteLine($"Viewer: {FirstName} {LastName} ({Email})");
    }
}

class Studio
{
    public string Name { get; set; }
    public string City { get; set; }

    public Studio(string name, string city)
    {
        Name = name;
        City = city;
    }

    public void Display()
    {
        Console.WriteLine($"Studio: {Name} ({City})");
    }
}

class Movie
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public Studio Studio { get; set; }

    public Movie(string title, int duration, Studio studio)
    {
        Title = title;
        Duration = duration;
        Studio = studio;
    }

    public void Display()
    {
        Console.WriteLine($"Movie: {Title} ({Duration} minutes)");
        Studio.Display();
    }
}

class WatchList
{
    public string Name { get; set; }
    public Viewer Viewer { get; set; }
    public List<Movie> Movies { get; set; }

    public WatchList(string name, Viewer viewer)
    {
        Name = name;
        Viewer = viewer;
        Movies = new List<Movie>();
    }

    public void AddMovie(Movie movie)
    {
        Movies.Add(movie);
    }

    public void DisplayMovies()
    {
        Console.WriteLine($"WatchList: {Name}");
        Viewer.Display();
        Console.WriteLine("Movies:");
        foreach (var movie in Movies)
        {
            movie.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Viewer viewer = new Viewer("John", "Doe", "john.doe@example.com");

        Studio studio = new Studio("Warner Bros", "Los Angeles");

        Movie movie1 = new Movie("Inception", 148, studio);
        Movie movie2 = new Movie("The Dark Knight", 152, studio);

        WatchList watchList = new WatchList("My Favorites", viewer);

        watchList.AddMovie(movie1);
        watchList.AddMovie(movie2);

        watchList.DisplayMovies();
    }
}
