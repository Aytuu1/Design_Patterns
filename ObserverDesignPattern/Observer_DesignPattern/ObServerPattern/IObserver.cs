using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObServerPattern
{
  public interface IObserver
  {
    void CreateNewUser(AppUser user);
  }
}
