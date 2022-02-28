using SampleGQL.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleGQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        
    }
}