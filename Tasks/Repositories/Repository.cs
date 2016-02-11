using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tasks.Repositories.Contacts;

namespace Tasks.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext DatabaseContext;

        public Repository(DbContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public void Add(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DatabaseContext.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}