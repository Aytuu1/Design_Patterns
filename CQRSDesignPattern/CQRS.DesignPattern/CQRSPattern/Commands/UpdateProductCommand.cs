﻿namespace CQRS.DesignPattern.CQRSPattern.Commands
{
  public class UpdateProductCommand
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

  }
}
