using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tasks.Models;
using Tasks.Repositories.Contacts;

namespace Tasks.Repositories
{
    /// <summary>
    /// Хранилище задач
    /// </summary>
    public class TasksRepository : Repository<Task>, ITasksRepository
    {
        public TasksRepository(DbContext dbContext):base(dbContext)
        {

        }
    }
}