using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public interface ITransportType
    {
        IEnumerable<TransportType> GetAll();
        TransportType GetById(int id);
        void Add(TransportType transportType);
        TransportType Update(int id, TransportType newTransporttype);
        void Delete(int id);
    }
}
