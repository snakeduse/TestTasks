using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Repositories.Contacts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // все методы реализовывать не стал, потому что нет надобности

        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}
