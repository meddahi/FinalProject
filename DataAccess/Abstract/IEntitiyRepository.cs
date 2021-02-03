using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    // IEntity : 
    //new() : new lenebilir olmalı
    public interface IEntitiyRepository<T> where T:class,IEntity,new()
    { 
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

      
    }
}
