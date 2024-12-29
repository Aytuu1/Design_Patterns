using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Observer_DesignPattern.DAL
{
  public class Context : IdentityDbContext<AppUser, AppRole, int>
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-EGM53VS\\SQLAYTU;initial catalog=ObServerDesignPattern; integrated security=true;");
    }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<WelcomeMessage> welcomeMessages { get; set; }
    public DbSet<UserProcess> userProcesses { get; set; }

  }
}
