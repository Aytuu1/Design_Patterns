using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObServerPattern
{
  public class CreateMagazineAnnouncement : IObserver
  {
    private readonly IServiceProvider _serviceProvider;
    Context context = new Context();

    public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    public void CreateNewUser(AppUser user)
    {
      context.userProcesses.Add(new UserProcess
      {
        NameSurname = user.Name+" "+user.Surname,
        Magazine="Bilim Dergisi",
        Content="Bilim dergimizin mart sayısı 1 mart'da evinize ulaştırılacaktır.Konular Jupiter gezegeni ve Mars olacaktır."
      });
      context.SaveChanges();
    }
  }
}
