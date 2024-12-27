using DesignPattern_ChainOfResponsibilityProje2.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern_ChainOfResponsibilityProje2.DAL
{
  public class Context : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU;initial Catalog=ChainOfResponsibility;integrated security=true;");
    }

    public DbSet<PackageProcessViewModel> packageProcessViewModels { get; set; }







  }
}
