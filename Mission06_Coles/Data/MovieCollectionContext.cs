using Microsoft.EntityFrameworkCore;
using Mission06_Coles.Models;

namespace Mission06_Coles.Data
{
    // DbContext manages the connection between the application
    // and the SQLite database using Entity Framework Core
    public class MovieCollectionContext : DbContext
    {
        // Constructor receives database options from Program.cs
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options)
           : base(options)
        {
        }

        // DbSet represents the Movies table in the database
        public DbSet<Movie> Movies { get; set; }
    }
}
