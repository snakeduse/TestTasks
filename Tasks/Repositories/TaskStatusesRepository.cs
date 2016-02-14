using System.Data.Entity;
using Tasks.Models;
using Tasks.Repositories.Contacts;

namespace Tasks.Repositories
{
    public class TaskStatusesRepository : Repository<TaskStatus>, ITaskStatusesRepository
    {
        public TaskStatusesRepository(DbContext dbContext):base(dbContext)
        {

        }
    }
}