using System.Collections.Generic;

namespace E_Commerce_System.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Example DbSet
        public DbSet<User> Users { get; set; }
    }
}
