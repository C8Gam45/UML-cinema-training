using System;
using System.Collections.Generic;

// Exercise 5 - Plusieurs relations
// Un film appartient à un studio
// Une playlist contient plusieurs films

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
        Console.WriteLine($"  - {Title} ({Duration} minutes) - Studio: {Studio.Name}");
    }
}

class Playlist
{
    public string Name { get; set; }
    public List<Movie> Movies { get; set; }

    public Playlist(string name)
    {
        Name = name;
        Movies = new List<Movie>();
    }

    public void AddMovie(Movie movie)
    {
        Movies.Add(movie);
    }

    public void DisplayMovies()
    {
        Console.WriteLine($"Playlist: {Name}");
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
        // Create a studio
        Studio studio = new Studio("Warner Bros", "Los Angeles");

        // Create two films linked to this studio
        Movie movie1 = new Movie("Inception", 148, studio);
        Movie movie2 = new Movie("The Dark Knight", 152, studio);

        // Create a playlist
        Playlist playlist = new Playlist("My Favorites");

        // Add films to playlist
        playlist.AddMovie(movie1);
        playlist.AddMovie(movie2);

        // Display films (with studio name for each)
        playlist.DisplayMovies();
    }
}
