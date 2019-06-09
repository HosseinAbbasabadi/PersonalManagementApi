using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Framework.Core
{
    public interface IRepository<T>
    {
        void Create(T entity);
        List<T> GetAll();
        T Get(Expression expression);
        T GetById(long id);
        void Delete(T entity);
        void Update(long id, T entity);
    }
}
