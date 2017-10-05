using NSMPublisherForConsumer.Models;
using NSMPublisherForConsumer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NSMPublisherForConsumer.Controllers
{
    [RoutePrefix("Consumer")]
    public class ConsumerController : ApiController
    {
        private IRepository<Publisher> _publisherRepo = null;
        public ConsumerController() : this(new Repository.Repository()) { }
        public ConsumerController(IRepository<Publisher> repo)
        {
            this._publisherRepo = repo;
        }
        [Route("GetValue/{value}")]
        public int GetValue(int value) {

           return _publisherRepo.GetValueById(value);
        }
    }
}
