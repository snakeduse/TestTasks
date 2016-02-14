using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
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