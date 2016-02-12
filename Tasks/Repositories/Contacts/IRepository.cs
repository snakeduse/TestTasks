using System;
using System.Collections.Generic;

namespace Tasks.Repositories.Contacts
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class 
    {
        // все методы реализовывать не стал, потому что нет надобности

        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void SaveChanges();
    }
}
