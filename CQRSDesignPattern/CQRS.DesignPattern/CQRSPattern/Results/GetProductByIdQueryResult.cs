﻿namespace CQRS.DesignPattern.CQRSPattern.Results
{
  public class GetProductByIdQueryResult
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    
  }
}
