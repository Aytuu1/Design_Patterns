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
  public class EfProcessDal : GenericRepository<Process>, IProcessDal
  {
    public EfProcessDal(Context context) : base(context)
    {

    }
  }
}
