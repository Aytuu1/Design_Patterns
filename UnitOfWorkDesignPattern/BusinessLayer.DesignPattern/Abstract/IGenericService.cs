﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DesignPattern.Abstract
{
  public interface IGenericService<T> where T : class
  {
    void TInsert(T t);
    void TDelete(T t);
    void TUpdate(T t);
    List<T> TGetAll();
    T TGetById(int id);
    void TMultiUpdate(List<T> t);
  }
}
