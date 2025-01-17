namespace DesignPattern.Composite.CompositePattern
{
  public class ProductComponent : IComponent
  {
    public ProductComponent(int id, string name)
    {
      Id = id;
      Name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }

    public string Display()
    {
      return $"<li class='group-item'>{Name}</li>";
    }

    public int totalCount()
    {
      return 1;
    }









  }
}
