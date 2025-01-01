using EntityLayer.DesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DesignPattern.Abstract
{
  public interface ICustomerDal:IGenericDal<Customer>
  {
  }
}
