using Microsoft.EntityFrameworkCore;

namespace crudelicious.Models
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options) {}
        public  DbSet<Dish> Dishes { get; set;}
    }
}