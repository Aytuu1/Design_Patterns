using Microsoft.EntityFrameworkCore;

namespace CQRS.DesignPattern.DAL
{
  public class Context : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU;initial Catalog=CQRSDesignPattern; integrated security=true;");
    }
    public DbSet<Product> Products { get; set; }
  }
}
