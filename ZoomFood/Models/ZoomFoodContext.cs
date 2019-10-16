using Microsoft.EntityFrameworkCore;

namespace ZoomFood.Models
{
    public class ZoomFoodContext : DbContext
    {
        public virtual DbSet<Cuisine> Cuisines { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        public ZoomFoodContext(DbContextOptions options) : base(options) { }
    }
}


















