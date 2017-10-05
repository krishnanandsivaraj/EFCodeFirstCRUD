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
    [RoutePrefix("Publisher")]
    public class PublisherController : ApiController
    {
        private IRepository<Publisher> _publisherRepo = null;
        public PublisherController() : this(new Repository.Repository()) { }
        public PublisherController(IRepository<Publisher> repo) {
            this._publisherRepo = repo;
        }

        [Route("Publish/{value}")]
        [HttpGet]
        public string Publish(int value) {
            try
            {
                Publisher pub = new Publisher() { publishValue = value };
                bool status=_publisherRepo.Publish(pub);
                return status ? "success" : "failure";
            }
            catch (Exception ex)
            {

                return "failure";
            }
        }
    }
}
