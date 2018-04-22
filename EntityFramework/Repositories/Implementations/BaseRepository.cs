using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataModels;
using EntityFramework.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Repositories.Implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDataContext context;
        private readonly DbSet<T> dbSet;

        public BaseRepository(AppDataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public IQueryable<T> GetAll() => dbSet;
        public void Add(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }
        public void DeleteById(Guid id)
        {
            var toDelete = dbSet.Find(id);
            dbSet.Remove(toDelete);
            context.SaveChanges();
        }
        public void DeleteById(int id)
        {
            var toDelete = dbSet.Find(id);
            dbSet.Remove(toDelete);
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }
        public T GetById(Guid id) => dbSet.Find(id);
        public T GetById(int id) => dbSet.Find(id);
    }
}
