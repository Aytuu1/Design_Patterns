using DataAccessLayer.DesignPattern.Abstract;
using DataAccessLayer.DesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DesignPattern.Repositories
{
  public class GenericRepository<T> : IGenericDal<T> where T : class
  {
    private readonly Context _context;

    public GenericRepository(Context context)
    {
      _context = context;
    }

    public void Delete(T t)
    {
      _context.Remove(t);
    }

    public List<T> GetAll()
    {
      return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
      return _context.Set<T>().Find(id);
    }

    public void Insert(T t)
    {
      _context.Add(t);
    }

    public void MultiUpdate(List<T> t)
    {
      _context.UpdateRange(t);
    }

    public void Update(T t)
    {
      _context.Update(t);
    }
  }
}
