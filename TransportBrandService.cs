using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public class TransportBrandService : ITrasnportBrand
    {
        private readonly AppDbContext _conetxt;
        public TransportBrandService(AppDbContext conetxt)
        {
            _conetxt = conetxt;
        }
        public void Add(Transport transportBrand)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransportBrand> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransportBrand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TransportBrand Update(int id, TransportBrand newTransportBrand)
        {
            throw new NotImplementedException();
        }
    }
}
