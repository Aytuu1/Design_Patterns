namespace CQRS.DesignPattern.CQRSPattern.Quiries
{
  public class GetProductByIdQuery
  {
    public int Id { get; set; }

    public GetProductByIdQuery(int ıd)
    {
      Id = ıd;
    }
  }
}
