using Microsoft.EntityFrameworkCore;
using studentportral.Models.Entities;

namespace studentportral.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; } 
    }
}
