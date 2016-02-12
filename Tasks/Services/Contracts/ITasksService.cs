using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasks.Models;

namespace Tasks.Services.Contracts
{
    public interface ITasksService
    {
        IEnumerable<Task> GetAll();
    }
}
