﻿namespace DesignPattern.Composite.CompositePattern
{
  public interface IComponent
  {
    public int Id { get; set; }
    public string Name { get; set; }
    int totalCount();
    string Display();








  }
}
