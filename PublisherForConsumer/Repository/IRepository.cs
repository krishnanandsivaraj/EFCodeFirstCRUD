using NSMPublisherForConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSMPublisherForConsumer.Repository
{
    public interface IRepository<T> where T:class
    {
        int GetValueById(int id);
        bool Publish(T t);
        bool LogError();
    }
}
