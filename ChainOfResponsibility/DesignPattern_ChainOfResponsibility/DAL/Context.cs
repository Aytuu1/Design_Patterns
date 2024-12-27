using Microsoft.EntityFrameworkCore;

namespace DesignPattern_ChainOfResponsibility.DAL
{
  public class Context:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU;initial Catalog=DesignPattern1;integrated security=true;");
    }
        public DbSet<CustomerProcess> customerProcesses  { get; set; }


    }
}
