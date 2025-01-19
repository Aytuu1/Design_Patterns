namespace Iterator.DesignPattern.IteratorPattern
{
  public interface IIterator<T>
  {
    T CurrentItem { get; }
    bool NextLocation();




  }
}
