using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

// generic constraint
// class : reference type
// IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
// new() : new'lenebilir olmalı (interface new'lenemez)
namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
