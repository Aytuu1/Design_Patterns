using CQRS.DesignPattern.CQRSPattern.Commands;
using CQRS.DesignPattern.DAL;

namespace CQRS.DesignPattern.CQRSPattern.Handlers
{
  public class UpdateProductCommandHandler
  {
    private readonly Context _context;

    public UpdateProductCommandHandler(Context context)
    {
      _context = context;
    }

    public void Handler(UpdateProductCommand command)
    {
      var values = _context.Products.Find(command.ProductID);
      values.Name= command.Name;
      values.Description= command.Description;
      values.Price= command.Price;
      values.Stock= command.Stock;
      values.Status = true;
      _context.SaveChanges();
      }
    }
  }

