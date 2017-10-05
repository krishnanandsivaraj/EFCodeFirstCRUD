using NSMPublisherForConsumer.Models;
using NSMPublisherForConsumer.Logger;
using System;

namespace NSMPublisherForConsumer.Repository
{
    public class TestRepository : IRepository<Publisher>, IExternalLogService
    {

        public int GetValueById(int id)
        {
            return 100;
        }

        public bool LogError()
        {
            return true;
        }

        public bool Publish(Publisher t)
        {
            return true;
        }
    }
}