using NSMPublisherForConsumer.Data;
using NSMPublisherForConsumer.Logger;
using NSMPublisherForConsumer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace NSMPublisherForConsumer.Repository
{
    public class Repository : IRepository<Publisher>,IExternalLogService
    {
        public Repository() { }
        private IExternalLogService addService;
        public Repository(IExternalLogService service)
        {
            this.addService = service;
        }
        public int GetValueById(int id)
        {
            int value = 0;
            using (var publishContext = new PublisherContext())
            {
                try
                {
                    return publishContext.publisher.Find(id).publishValue;
                }
                catch (Exception)
                {
                    return value;
                }


            }

        }

        public virtual bool LogError()
        {
            return true;
        }

        public bool Publish(Publisher t)
        {
            using (var publishContext = new PublisherContext())
            {
                try
                {
                    publishContext.publisher.Add(t);
                    publishContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }


            }
        }
    }
}