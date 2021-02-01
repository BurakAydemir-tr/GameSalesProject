using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
