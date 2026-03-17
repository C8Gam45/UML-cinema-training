using System;
using System.Collections.Generic;

// Exercise 4 - Multiplicité
// Une playlist contient plusieurs films

class Movie
{
    public string Title { get; set; }
    public int Duration { get; set; }

    public Movie(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }

    public void Display()
    {
        Console.WriteLine($"  - {Title} ({Duration} minutes)");
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
        // Create 2 films
        Movie movie1 = new Movie("Inception", 148);
        Movie movie2 = new Movie("The Dark Knight", 152);

        // Create 1 playlist
        Playlist playlist = new Playlist("My Favorites");

        // Add films to playlist
        playlist.AddMovie(movie1);
        playlist.AddMovie(movie2);

        // Display films
        playlist.DisplayMovies();
    }
}
