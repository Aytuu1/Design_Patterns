using BusinessLayer.DesignPattern.Abstract;
using DataAccessLayer.DesignPattern.Abstract;
using DataAccessLayer.DesignPattern.UnitOfWork;
using EntityLayer.DesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DesignPattern.Concrete
{
  public class CustomerManager : ICustomerService
  {
    private readonly ICustomerDal _customerDal;
    private readonly IUowDal _uowDal;

    public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
    {
      _customerDal = customerDal;
      _uowDal = uowDal;
    }

    public void TDelete(Customer t)
    {
      _customerDal.Delete(t);
      _uowDal.Save();
    }

    public List<Customer> TGetAll()
    {
      return _customerDal.GetAll();
    }

    public Customer TGetById(int id)
    {
      return _customerDal.GetById(id);
    }

    public void TInsert(Customer t)
    {
      _customerDal.Insert(t);
      _uowDal.Save();
    }

    public void TMultiUpdate(List<Customer> t)
    {
      _customerDal.MultiUpdate(t);
      _uowDal.Save();
    }

    public void TUpdate(Customer t)
    {
      _customerDal.Update(t);
      _uowDal.Save();
    }
  }
}
