using GameSaleDemo.Abstract;
using GameSaleDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        
        public virtual void Add(TEntity entity)
        {
            Console.WriteLine(entity.GetType()+"Eklendi");
        }

        public void Delete(TEntity entity)
        {
            Console.WriteLine(entity.GetType() + "Silindi");
        }

        public void Update(TEntity entity)
        {
            Console.WriteLine(entity.GetType() + "Güncellendi");
        }
    }
}
