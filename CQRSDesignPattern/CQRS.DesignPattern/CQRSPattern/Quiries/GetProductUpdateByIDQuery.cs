namespace CQRS.DesignPattern.CQRSPattern.Quiries
{
  public class GetProductUpdateByIDQuery
  {
    public int Id { get; set; }

    public GetProductUpdateByIDQuery(int id)
    {
      Id = id;
    }
  }
}
