using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tasks.Models;
using Tasks.Repositories.Contacts;

namespace Tasks.Api
{
    public class StatusesController : ApiController
    {
        private ITaskStatusesRepository _repository;

        public StatusesController(ITaskStatusesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Statuses
        public IEnumerable<TaskStatus> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Statuses/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Statuses
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Statuses/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Statuses/5
        public void Delete(int id)
        {
        }
    }
}
