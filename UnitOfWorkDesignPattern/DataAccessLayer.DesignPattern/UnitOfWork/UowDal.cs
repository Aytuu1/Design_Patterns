﻿using DataAccessLayer.DesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DesignPattern.UnitOfWork
{
  public class UowDal : IUowDal
  {
    private readonly Context _context;

    public UowDal(Context context)
    {
      _context = context;
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}
