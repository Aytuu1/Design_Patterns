using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
  public class Context : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU; initial Catalog=MediatRDesignPattern; integrated security=true; TrustServerCertificate=True;");
    }
    public DbSet<Product> Products { get; set; }
  }
}
