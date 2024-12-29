using CQRS.DesignPattern.CQRSPattern.Quiries;
using CQRS.DesignPattern.CQRSPattern.Results;
using CQRS.DesignPattern.DAL;

namespace CQRS.DesignPattern.CQRSPattern.Handlers
{
  public class GetProductUpdateByIdQueryHandler
  {
    private readonly Context _context;

    public GetProductUpdateByIdQueryHandler(Context context)
    {
      _context = context;
    }

    public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
    {
      var values = _context.Products.Find(query.Id);
      return new GetProductUpdateQueryResult
      {
        Description = values.Description,
        Name = values.Name,
        Price = values.Price,
        ProductID = values.ProductID,
        Status = values.Status,
        Stock = values.Stock

      };
    }




  }
}
