﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UoWDemo.Repository
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        T FindById(int id);
        IEnumerable<T> GetAll();
        T Edit(T entity);
        void DeleteById(int id);
        void Delete(T entity);
    }
}
