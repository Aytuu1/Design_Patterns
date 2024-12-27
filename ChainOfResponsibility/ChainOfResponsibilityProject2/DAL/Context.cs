using ChainOfResponsibilityProject2.Models;
using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibilityProject2.DAL
{
  public class Context:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU;initial Catalog=ChainOfResponsibility;integrated security=true;");
    }
        public DbSet<PackageViewModel> packageViewModels  { get; set; }
    }
}
