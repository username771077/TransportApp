using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public interface ITrasnportBrand
    {
        IEnumerable<TransportBrand> GetAll();
        TransportBrand GetById(int id);
        void Add(Transport transportBrand);
        TransportBrand Update(int id, TransportBrand newTransportBrand);
        void Delete(int id);
    }
}
