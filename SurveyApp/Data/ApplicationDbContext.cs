
using Microsoft.EntityFrameworkCore;

namespace SurveyApp.Data  // kendi namespace'ini yaz
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Buraya tabloları ekleyeceksin
        // public DbSet<Product> Products { get; set; }
    }
}
