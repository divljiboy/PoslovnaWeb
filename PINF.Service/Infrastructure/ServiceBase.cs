using PINF.Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace PINF.Service.Infrastructure
{
    public abstract class ServiceBase<T> : IService<T> where T : class
    {
        private readonly IRepository<T> repository;
        private readonly IUnitOfWork unitOfWork;

        public ServiceBase(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public virtual IEnumerable<T> GetAll()
        {
            var result = repository.GetAll().ToList();
            return result;
        }

        public virtual IEnumerable<T> GetForPage(int page,int size)
        {
            var result = repository.GetForPage(page, size);
            return result;
        }

        public virtual T Get(int id)
        {
            var result = repository.GetById(id);
            return result;
        }

        //public virtual T GetSingle(Expression<Func<T, bool>> where)
        //{
        //    var result = repository.Get(where);
        //    return result;
        //}

        //public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        //{
        //    var result = repository.GetMany(where);
        //    return result;
        //}

        //public virtual void Delete(Expression<Func<T, bool>> where)
        //{
        //    repository.Delete(where);
        //}

        public virtual void Create(T entity)
        {
            repository.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual void Update(T entity)
        {
            repository.Update(entity);
        }

        public void Update(T entity, T newEntity)
        {
            repository.Update(entity, newEntity);
        }

        public virtual void Detach(T entity)
        {
            repository.Detach(entity);
        }

        public virtual void Attach(T entity)
        {
            repository.Attach(entity);
        }

        public virtual void Delete(int id)
        {
            repository.Delete(repository.GetById(id));
        }

        public virtual void Save()
        {
            unitOfWork.Commit();
        }
        #endregion

    }
}
