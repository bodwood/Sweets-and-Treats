using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
  public class StoreContext : DbContext
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }

    public StoreContext(DbContextOptions options) : base(options) { }
  }
}