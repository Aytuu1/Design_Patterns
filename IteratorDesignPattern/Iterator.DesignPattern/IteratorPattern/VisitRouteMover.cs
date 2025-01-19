namespace Iterator.DesignPattern.IteratorPattern
{
  public class VisitRouteMover : IMover<VisitRoute>
  {
    public List<VisitRoute> visitRoutes = new List<VisitRoute>();
    public int VisitRouteCount { get => visitRoutes.Count; }
    public void addVisitRoute(VisitRoute visitRoute)
    {
      visitRoutes.Add(visitRoute);

    }

    public IIterator<VisitRoute> CreateIterator()
    {
      return new VisitRouteIterator(this);
    }




  }
}
