using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tasks.Models;
using Tasks.Repositories;
using Tasks.Repositories.Contacts;

namespace Tasks.Api
{
    public class TasksController : ApiController
    {
        private ITasksRepository _repository;

        public TasksController(ITasksRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Tasks
        public IEnumerable<Task> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Tasks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tasks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tasks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tasks/5
        public void Delete(int id)
        {
        }
    }
}
