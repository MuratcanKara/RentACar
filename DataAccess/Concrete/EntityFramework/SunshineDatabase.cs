using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccess.Concrete.EntityFramework
{
    public class SunshineContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Sunshine2;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
