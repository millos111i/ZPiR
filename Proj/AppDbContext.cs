using Microsoft.EntityFrameworkCore;
using Proj.Entities;

namespace Proj
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> tm) : base(tm)
        {

        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
