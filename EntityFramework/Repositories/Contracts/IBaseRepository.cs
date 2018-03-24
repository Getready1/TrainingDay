using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework.Repositories.Contracts
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        void Add(T entity);
        void DeleteById(Guid id);
        void DeleteById(int id);
        void Delete(T entity);
        T GetById(Guid id);
        T GetById(int id);
    }
}
