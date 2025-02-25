﻿using DesignPattern.Composite.MediatorPattern.Queries;
using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
  public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
  {
    private readonly Context _context;

    public GetAllProductQueryHandler(Context context)
    {
      _context = context;
    }

    public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
      return await _context.Products.Select(x => new GetAllProductQueryResult
      {
        ProductCategory = x.ProductCategory,
        ProductName = x.ProductName,
        ProductID = x.ProductID,
        ProductPrice = x.ProductPrice,
        ProductStock = x.ProductStock,
        ProductStockType = x.ProductStockType,
      }).AsNoTracking().ToListAsync();
    }
  }
}
