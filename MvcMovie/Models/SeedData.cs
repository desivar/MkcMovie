using Mvc_Movie.Data;
using Microsoft.EntityFrameworkCore; // Add this using statement

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (Mvc_MovieContext context = new Mvc_MovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Mvc_MovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Cinderella",
                    ReleaseDate = DateTime.Parse("2015-03-13"),
                    Genre = "Romantic",
                    Price = 6.9.00M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "Harry Potter",
                    ReleaseDate = DateTime.Parse("2001-11-16"),
                    Genre = "Fantasy",
                    Price = 7.60M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "Pride and Prejudice",
                    ReleaseDate = DateTime.Parse ("2002-03-01"), 
                    Genre = "Romantic",
                    Price = 7.80M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "The Lord of the Rings",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Adventure",
                    Price = 6.00M,
                    Rating = "A"

                },
                 new Movie
                 {
                     Title = "Kate and Leopold",
                     ReleaseDate = DateTime.Parse("2001-12-25"),
                     Genre = "Romantic",
                     Price = 6.40M,
                     Rating = "A" 
                 }
            );
            context.SaveChanges();
        }
    }
}