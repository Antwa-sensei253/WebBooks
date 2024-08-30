using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        
    }
}
