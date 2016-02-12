using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tasks.Models;
using Tasks.Repositories.Contacts;
using Tasks.Services.Contracts;

namespace Tasks.Services
{
    public class TasksService : ITasksService
    {
        public IEnumerable<Task> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}