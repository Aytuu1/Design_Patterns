using CQRS.DesignPattern.CQRSPattern.Results;
using CQRS.DesignPattern.DAL;

namespace CQRS.DesignPattern.CQRSPattern.Handlers
{
  public class GetProductQueryHandler
  {
    private readonly Context _context;
    public GetProductQueryHandler(Context context)
    {
      _context = context;
    }
    public List<GetProductQueryResult> Handle()
    {
      var values = _context.Products.Select(x => new GetProductQueryResult
      {
        Price = x.Price,
        ProductID = x.ProductID,
        ProductName = x.Name,
        Stock = x.Stock,
      }).ToList();
      return values;
    }

  }
}
