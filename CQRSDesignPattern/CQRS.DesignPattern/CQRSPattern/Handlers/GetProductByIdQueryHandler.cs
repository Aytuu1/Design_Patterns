using CQRS.DesignPattern.CQRSPattern.Quiries;
using CQRS.DesignPattern.CQRSPattern.Results;
using CQRS.DesignPattern.DAL;

namespace CQRS.DesignPattern.CQRSPattern.Handlers
{
  public class GetProductByIdQueryHandler
  {
    private readonly Context _context;
    public GetProductByIdQueryHandler(Context context)
    {
      _context = context;
    }
    public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
    {
      var values = _context.Set<Product>().Find(query.Id);
      return new GetProductByIdQueryResult
      {
        Name=values.Name,
        Price=values.Price,
        ProductID=values.ProductID,
        Stock = values.Stock
      };
    }
  }
}
