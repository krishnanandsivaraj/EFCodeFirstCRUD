using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NSMPublisherForConsumer.Models;

namespace NSMPublisherForConsumer.Data
{
    public class PublisherContext :DbContext
    {
        public PublisherContext() : base("ConnectionString") { }
        public DbSet<Publisher> publisher { get; set; }
    }
}