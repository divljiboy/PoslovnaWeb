using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PINF.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        void Detach(T entity);

        T GetById(int id);
        T Get(Expression<Func<T, bool>> where);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IEnumerable<T> GetForPage(int page, int size);

        bool Any(Expression<Func<T, bool>> where);
        void Attach(T entity);
        void Update(T entity, T newEntity);
    }
}
