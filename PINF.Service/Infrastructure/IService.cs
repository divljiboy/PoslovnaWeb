using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Service.Infrastructure
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetForPage(int page, int size);
        T Get(int id);
        void Create(T entity);
        void Save();
        void Delete(int id);
        void Delete(T entity);
        void Update(T entity);
        void Detach(T entity);
        void Attach(T entity);
        void Update(T entity, T newEntity);
    }
}
