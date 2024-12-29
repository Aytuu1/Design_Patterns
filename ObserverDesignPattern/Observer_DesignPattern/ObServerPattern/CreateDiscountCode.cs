using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObServerPattern
{
  public class CreateDiscountCode : IObserver
  {
    private readonly IServiceProvider _serviceProvider;
    Context context = new Context();
    public CreateDiscountCode(IServiceProvider serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    public void CreateNewUser(AppUser user)
    {
      context.Discounts.Add(new Discount
      {
        DiscountCode = "DERGIMART",
        DiscountAmount = 35,
        DiscountCodeStatus = true
      });
      context.SaveChanges();
    }

  }
}
