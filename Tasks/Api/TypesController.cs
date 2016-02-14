﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tasks.Models;
using Tasks.Repositories.Contacts;

namespace Tasks.Api
{
    public class TypesController : ApiController
    {
        private ITaskTypesRepository _repository;

        public TypesController(ITaskTypesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Types
        public IEnumerable<TaskType> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Types/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Types
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Types/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Types/5
        public void Delete(int id)
        {
        }
    }
}
