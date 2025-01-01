using DataAccessLayer.DesignPattern.Abstract;
using DataAccessLayer.DesignPattern.Concrete;
using DataAccessLayer.DesignPattern.Repositories;
using EntityLayer.DesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DesignPattern.EntityFrameWork
{
  public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
  {
    public EfCustomerDal(Context context) : base(context)
    {

    }



  }
}
