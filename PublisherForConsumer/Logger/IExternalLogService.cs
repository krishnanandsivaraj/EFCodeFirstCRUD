using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSMPublisherForConsumer.Logger
{
    public interface IExternalLogService
    {
        bool LogError();
    }
}
