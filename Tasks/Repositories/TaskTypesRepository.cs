using System.Data.Entity;
using Tasks.Models;
using Tasks.Repositories.Contacts;

namespace Tasks.Repositories
{
    public class TaskTypesRepository : Repository<TaskType>, ITaskTypesRepository
    {
        public TaskTypesRepository(DbContext dbContext):base(dbContext)
        {

        }
    }
}