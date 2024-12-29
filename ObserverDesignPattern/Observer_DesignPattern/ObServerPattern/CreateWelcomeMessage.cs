using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObServerPattern
{
  public class CreateWelcomeMessage : IObserver
  {
    private readonly IServiceProvider _serviceProvider;

    public CreateWelcomeMessage(IServiceProvider serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    Context context = new Context();
    public void CreateNewUser(AppUser user)
    {
      context.welcomeMessages.Add(new WelcomeMessage
      {
        Content = "Dergi Bültenimize Kayıt olduğunuz için teşekkür ederiz,Dergilerimize web sitemizden ulaşabilirsiniz.",
        NameSurname = user.Name + " " + user.Surname

      });
      context.SaveChanges();
    }
  }
}
