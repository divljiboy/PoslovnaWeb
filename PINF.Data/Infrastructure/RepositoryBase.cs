using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PINF.Model.Model;
using System.Data.Entity;
using System.Linq;

namespace PINF.Data.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IModelBase
    {
        #region Properties
        private PINFContext dataContext;
        protected readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected PINFContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            T local = dbSet.Local.SingleOrDefault(x => x.Id == entity.Id);
            if (local == null)
            {
                dbSet.Attach(entity);
                dataContext.Entry(entity).State = EntityState.Unchanged;
            }
            else
            {
                dataContext.Entry(local).State = EntityState.Unchanged;
            }
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Update(T entity, T newEntity)
        {
            dataContext.Entry(entity).CurrentValues.SetValues(newEntity);
        }

        public virtual void Detach(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Detached;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where);
        }

        public virtual IEnumerable<T> GetForPage(int page, int size)
        {
            return dbSet.OrderBy(x => x.Id).Skip((page-1) * size).Take(size);
        }

        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        public virtual bool Any(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).Any();
        }

        public virtual void Attach(T entity)
        {
            T local = dbSet.Local.SingleOrDefault(x => x.Id == entity.Id);
            if (local == null)
            {
                dbSet.Attach(entity);
                dataContext.Entry(entity).State = EntityState.Unchanged;
            }
            else
            {
                dataContext.Entry(local).State = EntityState.Unchanged;
            }
        }

        #endregion
    }
}
