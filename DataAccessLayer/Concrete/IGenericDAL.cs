﻿using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public interface IGenericDAL<TEntity> where TEntity: class,ITable, new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> Get();
        TEntity GetById(int id); 
    }
}

