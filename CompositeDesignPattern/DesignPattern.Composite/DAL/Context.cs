using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DAL
{
  public class Context : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU; initial Catalog=CompositeDesignPattern; integrated security=true; trustServerCertificate=true;");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }









  }
}
