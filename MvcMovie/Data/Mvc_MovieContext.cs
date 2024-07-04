using MvcMovie.Models;

namespace Mvc_Movie.Data
{
    public class Mvc_MovieContext : DbContext
    {
        public Mvc_MovieContext(DbContextOptions<Mvc_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }

    public class DbContext
    {
        private DbContextOptions<Mvc_MovieContext> options;

        public DbContext(DbContextOptions<Mvc_MovieContext> options)
        {
            this.options = options;
        }
    }

    public class DbContextOptions<T>
    {
    }

    public class DbSet<T>
    {
        internal async Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}