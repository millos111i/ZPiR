using Microsoft.EntityFrameworkCore;

namespace Proj
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> tm) : base(tm)
        {

        }
    }
}
